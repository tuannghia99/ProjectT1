using app.Common;
using app.StdCommon;
using CASAuthServiceClient;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using ProjectX.Abstract;
using ProjectX.Abstract.Bus;
using ProjectX1.Client.ServerBusiness.Infrastructure.Contracts;
using ProjectY4c.Client.ServerBusiness;

namespace ProjectX.Client.Winform.LookUp {
    public static class LookUpCommon {
        public static readonly Dictionary<string, string> g_dicDonViQuanLy = new Dictionary<string, string>()
        {
            {"E34E8135-C304-49CA-BE20-D3D20D367486", "Công ty cổ phần công nghệ VCS Việt Nam" },
        };
        public static List<OrganizationEntity> OrderOrganization(Guid parentId, List<OrganizationEntity> list, bool resetMS = false, int level = 0) {
            if (!resetMS) {
                var ordList = list.Where(s => (parentId == Guid.Empty || parentId == s.ParentOrganizationID) && s.Level == level).OrderBy(s => s.OrganizationName);
                if (!ordList.Any()) return new();
                var res = new List<OrganizationEntity>();
                foreach (var l in ordList) {
                    res.Add(l);
                    res.AddRange(OrderOrganization(l.OrganizationID, list, resetMS, level + 1));
                }
                return res;
            }
            else {
                var ordList = OrderOrganization(parentId, list, false, level);
                var prevLevel = -1;
                var prevMS = string.Empty;
                var currMS = 1;
                foreach (var l in ordList) {
                    if (prevLevel < l.Level) {
                        prevLevel = l.Level;
                        var index = ordList.IndexOf(l);
                        if (index > 0) {
                            prevMS += (currMS - 1).SafeToString().PadLeft(2, '0');
                            currMS = 1;
                        }
                    }
                    else if (prevLevel > l.Level) {
                        prevLevel = l.Level;
                        var index = ordList.IndexOf(l);
                        if (index > 0) {
                            var last = prevMS.Substring(prevMS.Length - 2 > 0 ? prevMS.Length - 2 : 0).TrimStart('0').ConvertToInt();
                            currMS = last + 1;
                            prevMS = prevMS.Remove(prevMS.Length - 2 > 0 ? prevMS.Length - 2 : 0);
                        }
                    }
                    l.OrganizationCode = prevMS + currMS.SafeToString().PadLeft(2, '0');
                    currMS++;
                }
                return ordList;
            }
        }
        public static int XtraInput2(string prompt) {
            XtraInputBoxArgs args = new XtraInputBoxArgs();
            args.DefaultButtonIndex = 0;
            args.Prompt = prompt;
            RadioGroup editor = new RadioGroup();

            object[] itemValues = new object[] { 1, 2 };
            string[] itemDescriptions = new string[] { "Từng cấp NS", "Tất cả cấp NS" };
            for (int i = 0; i < itemValues.Length; i++) {
                editor.Properties.Items.Add(new RadioGroupItem(itemValues[i], itemDescriptions[i]));
            }
            args.Editor = editor;
            if (editor.Properties != null) {
                editor.Properties.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
                editor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                editor.Properties.Appearance.Options.UseBackColor = true;
                editor.Properties.Appearance.Options.UseBorderColor = true;
                editor.Properties.Appearance.Options.UseFont = true;
                editor.Properties.Appearance.Options.UseTextOptions = true;
                editor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                editor.Properties.ItemHorzAlignment = RadioItemHorzAlignment.Center;
                editor.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Column;
            }
            var result = XtraInputBox.Show(args).ConvertToNullableInt();
            if (result == null) {
                return 0;
            }
            else
                return result.ConvertToInt();
        }

        /// <summary>
        /// Thay thế hàm LoadFromObjec trực tiếp
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objBus">IBusinessObject của loại đối tượng được load cho repo</param>
        /// <param name="editControl">Repo được load dữ liệu</param>
        /// <param name="inputParams">InputParam được áp dụng - nếu là null thì thì mặc định không cần truyền vào</param>
        /// <param name="valueMember">ValueMemmber của repo - nếu là Oid thì mặc định không cần truyền vào, nếu không phải Oid thì phải truyền vào</param>
        /// <param name="displayMember">DisplayMember của repo - nếu là Ten thì mặc định không cần truyền vào, nếu không phải Ten thì phải truyền vào</param>
        /// <param name="parameter">Giá trị trường của đối tượng cần lọc theo dữ liệu DTO
        /// <returns></returns>
        public static async Task FillDataLookUpControl<T>(this ISimpleBusinessObject<T> objBus, object editControl, InputParams? inputParams = null, string valueMember = "Oid", string displayMember = "Ten", bool parentChildTree = true, bool forceDetail = true, Func<T, bool>? parameter = null, bool primNow = false) where T : class {
            var dataSource = await LookupData(objBus, primNow, inputParams, valueMember, displayMember, "MaSo", parameter);
            var viewCols = new List<Tuple<string, string>>();
            var props = typeof(T).GetProperties().Select(x => x.Name);

            if (props.Contains("MaSo")) {
                dataSource = dataSource.OrderBy(x => x.GetType().GetProperty("MaSo").GetValue(x, null)).ToList();
                if (parentChildTree) {
                    ConfigureParentChildTree(dataSource, displayMember);
                }
            }

            if (props.Contains("MaSo") && props.Contains("Ten")) {
                viewCols = new List<Tuple<string, string>>() {
                    //new Tuple<string, string>("MaSo","Mã số"),
                    new Tuple<string, string>("Ten","Tên")
                };
            }
            else {
                viewCols = new List<Tuple<string, string>>() {
                    new Tuple<string, string>(displayMember,"Tên")
                };
            }
            CreateLookUpConrol(editControl, dataSource, viewCols, valueMember, displayMember, parentChildTree, forceDetail, props);
        }

        /// <summary>
        /// Thay thế hàm LoadFromObjec trực tiếp
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objBus">IBusinessObject của loại đối tượng được load cho repo</param>
        /// <param name="editControls">Repo được load dữ liệu</param>
        /// <param name="inputParams">InputParam được áp dụng - nếu là null thì thì mặc định không cần truyền vào</param>
        /// <param name="valueMember">ValueMemmber của repo - nếu là Oid thì mặc định không cần truyền vào, nếu không phải Oid thì phải truyền vào</param>
        /// <param name="displayMember">DisplayMember của repo - nếu là Ten thì mặc định không cần truyền vào, nếu không phải Ten thì phải truyền vào</param>
        /// <param name="parameter">Giá trị trường của đối tượng cần lọc theo dữ liệu DTO
        /// <returns></returns>
        public static async Task FillDataLookUpControl<T>(this ISimpleBusinessObject<T> objBus, List<object> editControls, InputParams? inputParams = null, string valueMember = "Oid", string displayMember = "Ten", bool parentChildTree = false, bool forceDetail = true, Func<T, bool>? parameter = null, bool primNow = false) where T : class {
            var dataSource = await LookupData(objBus, primNow, inputParams, valueMember, displayMember, "MaSo", parameter);
            var viewCols = new List<Tuple<string, string>>();
            var props = typeof(T).GetProperties().Select(x => x.Name);

            if (props.Contains("MaSo")) {
                dataSource = dataSource.OrderBy(x => x.GetType().GetProperty("MaSo").GetValue(x, null)).ToList();
                if (parentChildTree) {
                    ConfigureParentChildTree(dataSource, displayMember);
                }
            }

            if (props.Contains("MaSo") && props.Contains("Ten")) {
                viewCols = new List<Tuple<string, string>>() {
                    //new Tuple<string, string>("MaSo","Mã số"),
                    new Tuple<string, string>("Ten","Tên")
                };
            }
            else {
                viewCols = new List<Tuple<string, string>>() {
                    new Tuple<string, string>(displayMember,"Tên")
                };
            }
            foreach (var editControl in editControls) {
                CreateLookUpConrol(editControl, dataSource, viewCols, valueMember, displayMember, parentChildTree, forceDetail, props);
            }
        }

        private static async Task<List<T>?> LookupData<T>(ISimpleBusinessObject<T> objBus, bool primNow, InputParams? inputParams, string valueMember, string displayMember, string maSoMember, Func<T, bool>? parameter) where T : class {
            List<T>? dataSource = null;
            if (objBus is ISimpleBusinessObjectPrim<T> objPrim && primNow) {
                dataSource = (await objPrim.GetListItemPrim(true, inputParams)).LstObjData?.Select(s => {
                    s.DisplayText = $"{s.MaSo} - {s.Ten}";
                    var t = (T)typeof(T).GetNewInstance();
                    var v = t.GetType().GetProperty(valueMember);
                    var m = t.GetType().GetProperty(maSoMember);
                    var d = t.GetType().GetProperty(displayMember);
                    v?.SetValue(t, s.Id);
                    m?.SetValue(t, s.MaSo);
                    d?.SetValue(t, s.DisplayText);
                    return t;
                }).ToList();
            }
            else {
                dataSource = (await objBus.GetListItem(true, inputParams)).LstObjData?.Where(x => parameter?.Invoke(x) ?? true).ToList();
            }
            return dataSource;
        }

        private static void CreateLookUpConrol<T>(object? editControl, List<T>? dataSource, List<Tuple<string, string>> viewCols, string valueMember, string displayMember, bool parentChildTree, bool forceDetail, IEnumerable<string> props) where T : class {
            if (editControl != null) {
                if (editControl is LookUpEditBase lookUpControl) {
                    if(lookUpControl?.Properties != null) {
                        lookUpControl.Properties.DataSource = dataSource;
                        lookUpControl.CreateColumns(viewCols);
                        lookUpControl.Properties.DisplayMember = displayMember;
                        lookUpControl.Properties.ValueMember = valueMember;
                    }

                    if (lookUpControl is LookUpEdit lookUp && lookUp != null) { lookUp.Properties.SearchMode = SearchMode.AutoSuggest; lookUp.Properties.ShowHeader = true; }
                    else if (lookUpControl is GridLookUpEdit gridLookUp && gridLookUp != null) gridLookUp.Properties.SearchMode = GridLookUpSearchMode.AutoSuggest;
                    else if (lookUpControl is SearchLookUpEdit searchLookUp && searchLookUp != null) ;
                    else if (lookUpControl is TreeListLookUpEdit treeListLookUp && treeListLookUp != null) ;

                    if (parentChildTree && lookUpControl != null) {
                        lookUpControl.CustomDisplayText -= customDisplayText;
                        lookUpControl.CustomDisplayText += customDisplayText;
                        if (forceDetail && props.Contains("MaSo") && dataSource?.Count > 1 &&
                                !new List<string> { typeof(DonViSuDungChuongTrinhDTO).Name,
                                                        typeof(DiaBanDTO).Name }.Contains(typeof(T).Name)) {
                            lookUpControl.Validating -= CheckTheMostDetail;
                            lookUpControl.Validating += CheckTheMostDetail;
                        }
                    }
                }
                else if (editControl is RepositoryItemLookUpEditBase repoLookUpControl) {
                    if (repoLookUpControl != null) {
                        repoLookUpControl.DataSource = dataSource;
                        repoLookUpControl.CreateColumns(viewCols);
                        repoLookUpControl.DisplayMember = displayMember;
                        repoLookUpControl.ValueMember = valueMember;
                    }

                    if (repoLookUpControl is RepositoryItemLookUpEdit lookUp && lookUp != null) lookUp.SearchMode = SearchMode.AutoSuggest;
                    else if (repoLookUpControl is RepositoryItemGridLookUpEdit gridLookUp && gridLookUp != null) gridLookUp.SearchMode = GridLookUpSearchMode.AutoSuggest;
                    else if (repoLookUpControl is RepositoryItemSearchLookUpEdit searchLookUp && searchLookUp != null) ;
                    else if (repoLookUpControl is RepositoryItemTreeListLookUpEdit treeListLookUp && treeListLookUp != null) ;

                    if (parentChildTree && repoLookUpControl != null) {
                        // NOTE: Các form nên để LoadDataRepo lên trước LoadDataToControl để sự kiện này được kích hoạt khi mở form
                        repoLookUpControl.CustomDisplayText -= customDisplayText;
                        repoLookUpControl.CustomDisplayText += customDisplayText;
                    }
                }
            }
        }

        /// <summary>
        /// Viết lại cấu trúc cây cha - con cho dataSource
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataSource"></param>
        /// <param name="displayMember">Tên hiển thị</param>
        /// <param name="configMember">Mã số</param>
        public static List<T>? ConfigureParentChildTree<T>(this List<T>? dataSource, string displayMember = "Ten", string configMember = "MaSo") where T : class {
            if (dataSource?.Count > 1) {
                var minLevel = 999;
                var multi = 2;
                for (var index = 0; index < dataSource.Count; ++index) {
                    var currentValue = dataSource[index].GetType().GetProperty(configMember)?.GetValue(dataSource[index]).SafeToString() ?? string.Empty;
                    minLevel = minLevel <= currentValue.Length ? minLevel : currentValue.Length;
                }
                for (var index = 0; index < dataSource.Count; ++index) {
                    var currentValue = dataSource[index].GetType().GetProperty(configMember)?.GetValue(dataSource[index]).SafeToString() ?? string.Empty;
                    var nameProp = dataSource[index].GetType().GetProperty(displayMember);
                    if (nameProp != null) {
                        var name = nameProp.GetValue(dataSource[index]).SafeToString().Trim();
                        nameProp.SetValue(dataSource[index], name.PadLeft(multi * (currentValue.Length > minLevel ? (currentValue.Length - minLevel) : 0) + name.Length));
                    }
                }
            }
            return dataSource;
        }


        /// <summary>
        /// Event Handler for Validating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void CheckTheMostDetail(object? sender, System.ComponentModel.CancelEventArgs e) {
            if (sender != null) {
                if (sender is LookUpEditBase lookUp) {
                    if (!CheckTheMostDetail(lookUp))
                        e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Kiểm tra chi tiết nhất cho các lookup editor, đối với chọn nhiều bắt buộc phải có thuộc tính Data và CheckBox
        /// </summary>
        /// <param name="lookups">Các lookup editor cần kiểm tra</param>
        /// <returns></returns>
        public static bool CheckTheMostDetail(params LookUpEditBase[] lookups) {
            var noError = true;
            foreach (var lookup in lookups) {
                var multi = false;
                if (lookup is SearchLookUpEdit se) {
                    multi = se.Properties.View.IsMultiSelect;
                }
                var dataSource = (lookup.Properties.DataSource as IEnumerable<object>)?.Cast<object>().ToList();
                var vals = new List<Guid>();
                if (!multi) {
                    vals.Add(lookup.EditValue.ConvertToGuid());
                }
                else {
                    vals.AddRange(lookup.EditValue.SafeToString().Split(',').Select(s => s.Trim().ConvertToGuid()).ToList());
                }
                var errorText = string.Empty;
                foreach (var val in vals) {
                    if (val != Guid.Empty && dataSource?.Count > 1) {
                        var hasData = false;
                        var hasCheckBox = false;
                        foreach (var prop in dataSource[0].GetType().GetProperties().ToList()) {
                            if (prop.Name.StartsWith("Data")) {
                                hasData = true;
                            }
                            if (prop.Name.StartsWith("CheckBox")) {
                                hasCheckBox = true;
                            }
                        }
                        List<object>? data = dataSource;
                        if (hasData && hasCheckBox) {
                            data = dataSource.Select(s => s.GetType().GetProperty("Data")?.GetValue(s) ?? new object()).ToList();

                        }

                        var ms = data.Where(s => s.GetType().GetProperty("Oid")?.GetValue(s).ConvertToGuid() == val).FirstOrDefault();
                        if (ms != null) {
                            var maSo = ms.GetType().GetProperty("MaSo")?.GetValue(ms).SafeToString() ?? string.Empty;
                            var idParent = ms.GetType().GetProperty("IdDuAnThuocChuongTrinh")?.GetValue(ms).SafeToString() ?? string.Empty;
                            if (!maSo.IsNullOrEmpty()) {
                                var listSubMaSo = data.Where(s => (s.GetType().GetProperty("MaSo")?.GetValue(s).SafeToString() ?? string.Empty).StartsWith(maSo)
                                && (s.GetType().GetProperty("MaSo")?.GetValue(s).SafeToString() ?? string.Empty).Length > maSo.Length
                                ).ToList();
                                if (listSubMaSo.Count > 0) {
                                    errorText = "Yêu cầu chọn thông tin có mã số chi tiết nhất";
                                    noError = false;
                                }
                            }
                        }
                    }
                }
                lookup.ErrorText = errorText;
            }
            return noError;
        }

        /// <summary>
        /// Kiểm tra chi tiết nhất cho các in-place repository lookup editor, đối với chọn nhiều bắt buộc phải có thuộc tính Data và CheckBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="repoLookups">Các in-place repository lookup editor cần kiểm tra</param>
        public static void CheckTheMostDetail(object sender, BaseContainerValidateEditorEventArgs e, params RepositoryItemLookUpEditBase[] repoLookups) {
            var grid = (GridView)sender;
            var repo = grid?.FocusedColumn.ColumnEdit;
            if (repo != null && repo is RepositoryItemLookUpEditBase repoLookup && repoLookups.Contains(repoLookup)) {
                var valid = true;
                var errorText = string.Empty;
                var multi = false;
                if (repoLookup is RepositoryItemSearchLookUpEdit se) {
                    multi = se.View.IsMultiSelect;
                }
                var dataSource = (repoLookup.DataSource as IEnumerable<object>)?.Cast<object>().ToList();
                var vals = new List<Guid>();
                if (!multi) {
                    vals.Add(e.Value.ConvertToGuid());
                }
                else {
                    vals.AddRange(e.Value.SafeToString().Split(',').Select(s => s.Trim().ConvertToGuid()).ToList());
                }
                foreach (var val in vals) {
                    if (val != Guid.Empty && dataSource?.Count > 1) {
                        var hasData = false;
                        var hasCheckBox = false;
                        foreach (var prop in dataSource[0].GetType().GetProperties().ToList()) {
                            if (prop.Name == "Data") {
                                hasData = true;
                            }
                            if (prop.Name.StartsWith("CheckBox")) {
                                hasCheckBox = true;
                            }
                        }
                        List<object>? data = dataSource;
                        if (hasData && hasCheckBox) {
                            data = dataSource.Select(s => s.GetType().GetProperty("Data")?.GetValue(s) ?? new object()).ToList();
                        }
                        var ms = data.Where(s => s.GetType().GetProperty("Oid")?.GetValue(s).ConvertToGuid() == val).FirstOrDefault();
                        if (ms != null) {
                            var maSo = ms.GetType().GetProperty("MaSo")?.GetValue(ms).SafeToString() ?? string.Empty;
                            if (!maSo.IsNullOrEmpty()) {
                                var listSubMaSo = data.Where(s => (s.GetType().GetProperty("MaSo")?.GetValue(s).SafeToString() ?? string.Empty).StartsWith(maSo) && (s.GetType().GetProperty("MaSo")?.GetValue(s).SafeToString() ?? string.Empty).Length > maSo.Length).ToList();
                                if (listSubMaSo.Count > 0) {
                                    valid = false;
                                    errorText = "Yêu cầu chọn thông tin có mã số chi tiết nhất";
                                }
                            }
                        }
                    }
                }
                e.Valid = valid;
                e.ErrorText = errorText;
            }
        }

        public static void customDisplayText(object sender, CustomDisplayTextEventArgs e) {
            e.DisplayText = e.DisplayText.SafeToString().Trim();
        }


        /// <summary>
        /// Thay thế hàm LoadFromObjec trực tiếp
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objBus">IBusinessObject của loại đối tượng được load cho repo</param>
        /// <param name="editControls">Repo được load dữ liệu</param>
        /// <param name="inputParams">InputParam được áp dụng - nếu là null thì thì mặc định không cần truyền vào</param>
        /// <param name="valueMember">ValueMemmber của repo - nếu là Oid thì mặc định không cần truyền vào, nếu không phải Oid thì phải truyền vào</param>
        /// <param name="displayMember">DisplayMember của repo - nếu là Ten thì mặc định không cần truyền vào, nếu không phải Ten thì phải truyền vào</param>
        /// <param name="parameter">Giá trị trường của đối tượng cần lọc theo dữ liệu DTO
        /// <returns></returns>
        public static async Task FillDataLookUpControlChild<T>(this ISimpleBusinessObject<T> objBus, List<object> editControls, InputParams? inputParams = null, string valueMember = "Oid", string displayMember = "Ten", bool parentChildTree = true, string nameParent = "", bool forceDetail = true, Func<T, bool>? parameter = null, bool primNow = false) where T : class {
            var dataSource = await LookupDataChild(objBus, primNow, inputParams, valueMember, displayMember, "MaSo", parameter);
            var viewCols = new List<Tuple<string, string>>();
            var props = typeof(T).GetProperties().Select(x => x.Name);

            if (props.Contains("MaSo")) {
                dataSource = dataSource.OrderBy(x => x.GetType().GetProperty("MaSo").GetValue(x, null)).ToList();
                if (parentChildTree) {
                    ConfigureParentChildTreeChild(dataSource, displayMember);
                }
            }

            if (props.Contains("MaSo") && props.Contains("Ten")) {
                viewCols = new List<Tuple<string, string>>() {
                    //new Tuple<string, string>("MaSo","Mã số"),
                    new Tuple<string, string>("Ten","Tên")
                };
            }
            else {
                viewCols = new List<Tuple<string, string>>() {
                    new Tuple<string, string>(displayMember,"Tên")
                };
            }
            foreach (var editControl in editControls) {
                CreateLookUpConrolChild(editControl, dataSource, viewCols, valueMember, displayMember, parentChildTree, nameParent, forceDetail, props);
            }
        }

        private static async Task<List<T>?> LookupDataChild<T>(ISimpleBusinessObject<T> objBus, bool primNow, InputParams? inputParams, string valueMember, string displayMember, string maSoMember, Func<T, bool>? parameter) where T : class {
            List<T>? dataSource = null;
            if (objBus is ISimpleBusinessObjectPrim<T> objPrim && primNow) {
                //dataSource = (await objPrim.GetListItemPrim(true, inputParams)).LstObjData?.Select(s => {
                //    T t = (T)typeof(T).GetNewInstance();
                //    var v = t.GetType().GetProperty(valueMember);
                //    var m = t.GetType().GetProperty(maSoMember);
                //    var d = t.GetType().GetProperty(displayMember);
                //    if (v != null) v.SetValue(t, s.Id);
                //    if (m != null) m.SetValue(t, s.MaSo);
                //    if (d != null) d.SetValue(t, s.Ten);
                //    return t;
                //}).ToList();
            }
            else {
                dataSource = (await objBus.GetListItem(true, inputParams)).LstObjData?.Where(x => parameter?.Invoke(x) ?? true).ToList();
            }
            return dataSource;
        }

        private static void CreateLookUpConrolChild<T>(object? editControl, List<T>? dataSource, List<Tuple<string, string>> viewCols, string valueMember, string displayMember, bool parentChildTree, string nameParent, bool forceDetail, IEnumerable<string> props) where T : class {
            if (editControl != null) {
                if (editControl is LookUpEditBase lookUpControl) {
                    if (lookUpControl?.Properties != null) {
                        lookUpControl.Properties.DataSource = dataSource;
                        lookUpControl.CreateColumns(viewCols);
                        lookUpControl.Properties.DisplayMember = displayMember;
                        lookUpControl.Properties.ValueMember = valueMember;
                    }

                    if (lookUpControl is LookUpEdit lookUp && lookUp != null) { lookUp.Properties.SearchMode = SearchMode.AutoSuggest; lookUp.Properties.ShowHeader = true; }
                    else if (lookUpControl is GridLookUpEdit gridLookUp && gridLookUp != null) gridLookUp.Properties.SearchMode = GridLookUpSearchMode.AutoSuggest;
                    else if (lookUpControl is SearchLookUpEdit searchLookUp && searchLookUp != null) ;
                    else if (lookUpControl is TreeListLookUpEdit treeListLookUp && treeListLookUp != null) ;

                    if (parentChildTree && lookUpControl != null) {
                        lookUpControl.CustomDisplayText -= customDisplayText;
                        lookUpControl.CustomDisplayText += customDisplayText;
                        if (forceDetail && props.Contains("MaSo") && dataSource?.Count > 1 &&
                                !new List<string> { typeof(DonViSuDungChuongTrinhDTO).Name,
                                                        typeof(DiaBanDTO).Name }.Contains(typeof(T).Name)) {
                            lookUpControl.Validating -= (sender, e) => CheckTheMostDetailChild(nameParent, sender, e);
                            lookUpControl.Validating += (sender, e) => CheckTheMostDetailChild(nameParent, sender, e);
                        }
                    }
                }
                else if (editControl is RepositoryItemLookUpEditBase repoLookUpControl) {
                    if (repoLookUpControl != null) {
                        repoLookUpControl.DataSource = dataSource;
                        repoLookUpControl.CreateColumns(viewCols);
                        repoLookUpControl.DisplayMember = displayMember;
                        repoLookUpControl.ValueMember = valueMember;
                    }

                    if (repoLookUpControl is RepositoryItemLookUpEdit lookUp && lookUp != null) lookUp.SearchMode = SearchMode.AutoSuggest;
                    else if (repoLookUpControl is RepositoryItemGridLookUpEdit gridLookUp && gridLookUp != null) gridLookUp.SearchMode = GridLookUpSearchMode.AutoSuggest;
                    else if (repoLookUpControl is RepositoryItemSearchLookUpEdit searchLookUp && searchLookUp != null) ;
                    else if (repoLookUpControl is RepositoryItemTreeListLookUpEdit treeListLookUp && treeListLookUp != null) ;

                    if (parentChildTree && repoLookUpControl != null) {
                        // NOTE: Các form nên để LoadDataRepo lên trước LoadDataToControl để sự kiện này được kích hoạt khi mở form
                        repoLookUpControl.CustomDisplayText -= customDisplayText;
                        repoLookUpControl.CustomDisplayText += customDisplayText;
                    }
                }
            }
        }

        /// <summary>
        /// Viết lại cấu trúc cây cha - con cho dataSource
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataSource"></param>
        /// <param name="displayMember">Tên hiển thị</param>
        /// <param name="configMember">Mã số</param>
        public static List<T>? ConfigureParentChildTreeChild<T>(this List<T>? dataSource, string displayMember = "Ten", string configMember = "MaSo") where T : class {
            if (dataSource?.Count > 1) {
                var minLevel = 999;
                var multi = 2;
                for (var index = 0; index < dataSource.Count; ++index) {
                    var currentValue = dataSource[index].GetType().GetProperty(configMember)?.GetValue(dataSource[index]).SafeToString() ?? string.Empty;
                    minLevel = minLevel <= currentValue.Length ? minLevel : currentValue.Length;
                }
                for (var index = 0; index < dataSource.Count; ++index) {
                    var currentValue = dataSource[index].GetType().GetProperty(configMember)?.GetValue(dataSource[index]).SafeToString() ?? string.Empty;
                    var nameProp = dataSource[index].GetType().GetProperty(displayMember);
                    if (nameProp != null) {
                        var name = nameProp.GetValue(dataSource[index]).SafeToString().Trim();
                        nameProp.SetValue(dataSource[index], name.PadLeft(multi * (currentValue.Length > minLevel ? (currentValue.Length - minLevel) : 0) + name.Length));
                    }
                }
            }
            return dataSource;
        }


        /// <summary>
        /// Event Handler for Validating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void CheckTheMostDetailChild(string nameParent, object? sender, System.ComponentModel.CancelEventArgs e) {
            if (sender != null) {
                if (sender is LookUpEditBase lookUp) {
                    if (!CheckTheMostDetailChild(nameParent, lookUp))
                        e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Kiểm tra chi tiết nhất cho các lookup editor, đối với chọn nhiều bắt buộc phải có thuộc tính Data và CheckBox
        /// </summary>
        /// <param name="lookups">Các lookup editor cần kiểm tra</param>
        /// <returns></returns>
        public static bool CheckTheMostDetailChild(string nameParent, params LookUpEditBase[] lookups) {
            var noError = true;
            foreach (var lookup in lookups) {
                var multi = false;
                if (lookup is SearchLookUpEdit se) {
                    multi = se.Properties.View.IsMultiSelect;
                }
                var dataSource = (lookup.Properties.DataSource as IEnumerable<object>)?.Cast<object>().ToList();
                var vals = new List<Guid>();
                if (!multi) {
                    vals.Add(lookup.EditValue.ConvertToGuid());
                }
                else {
                    vals.AddRange(lookup.EditValue.SafeToString().Split(',').Select(s => s.Trim().ConvertToGuid()).ToList());
                }
                var errorText = string.Empty;
                foreach (var val in vals) {
                    if (val != Guid.Empty && dataSource?.Count > 1) {
                        var hasData = false;
                        var hasCheckBox = false;
                        foreach (var prop in dataSource[0].GetType().GetProperties().ToList()) {
                            if (prop.Name.StartsWith("Data")) {
                                hasData = true;
                            }
                            if (prop.Name.StartsWith("CheckBox")) {
                                hasCheckBox = true;
                            }
                        }
                        List<object>? data = dataSource;
                        if (hasData && hasCheckBox) {
                            data = dataSource.Select(s => s.GetType().GetProperty("Data")?.GetValue(s) ?? new object()).ToList();

                        }
                        var ms = data.Where(s => s.GetType().GetProperty("Oid")?.GetValue(s).ConvertToGuid() == val).FirstOrDefault();
                        if (ms != null) {
                            var maSo = ms.GetType().GetProperty("MaSo")?.GetValue(ms).SafeToString() ?? string.Empty;
                            var idCha = ms.GetType().GetProperty(nameParent)?.GetValue(ms).SafeToString() ?? string.Empty;
                            if (!maSo.IsNullOrEmpty() && !idCha.IsNullOrEmpty()) {
                                var listSubMaSo = data.Where(s => (s.GetType().GetProperty(nameParent)?.GetValue(s).SafeToString() ?? string.Empty).Equals(idCha)
                                && (s.GetType().GetProperty("MaSo")?.GetValue(s).SafeToString() ?? string.Empty).StartsWith(maSo)
                                && (s.GetType().GetProperty("MaSo")?.GetValue(s).SafeToString() ?? string.Empty).Length > maSo.Length
                                ).ToList();
                                if (listSubMaSo.Count > 0) {
                                    errorText = "Yêu cầu chọn thông tin có mã số chi tiết nhất";
                                    noError = false;
                                }
                            }
                        }
                    }
                }
                lookup.ErrorText = errorText;
            }
            return noError;
        }

        /// <summary>
        /// Kiểm tra chi tiết nhất cho các in-place repository lookup editor, đối với chọn nhiều bắt buộc phải có thuộc tính Data và CheckBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="repoLookups">Các in-place repository lookup editor cần kiểm tra</param>
        public static void CheckTheMostDetailChild(string nameParent, object sender, BaseContainerValidateEditorEventArgs e, params RepositoryItemLookUpEditBase[] repoLookups) {
            var grid = (GridView)sender;
            var repo = grid?.FocusedColumn.ColumnEdit;
            if (repo != null && repo is RepositoryItemLookUpEditBase repoLookup && repoLookups.Contains(repoLookup)) {
                var valid = true;
                var errorText = string.Empty;
                var multi = false;
                if (repoLookup is RepositoryItemSearchLookUpEdit se) {
                    multi = se.View.IsMultiSelect;
                }
                var dataSource = (repoLookup.DataSource as IEnumerable<object>)?.Cast<object>().ToList();
                var vals = new List<Guid>();
                if (!multi) {
                    vals.Add(e.Value.ConvertToGuid());
                }
                else {
                    vals.AddRange(e.Value.SafeToString().Split(',').Select(s => s.Trim().ConvertToGuid()).ToList());
                }
                foreach (var val in vals) {
                    if (val != Guid.Empty && dataSource?.Count > 1) {
                        var hasData = false;
                        var hasCheckBox = false;
                        foreach (var prop in dataSource[0].GetType().GetProperties().ToList()) {
                            if (prop.Name == "Data") {
                                hasData = true;
                            }
                            if (prop.Name.StartsWith("CheckBox")) {
                                hasCheckBox = true;
                            }
                        }
                        List<object>? data = dataSource;
                        if (hasData && hasCheckBox) {
                            data = dataSource.Select(s => s.GetType().GetProperty("Data")?.GetValue(s) ?? new object()).ToList();
                        }
                        var ms = data.Where(s => s.GetType().GetProperty("Oid")?.GetValue(s).ConvertToGuid() == val).FirstOrDefault();
                        if (ms != null) {
                            var maSo = ms.GetType().GetProperty("MaSo")?.GetValue(ms).SafeToString() ?? string.Empty;
                            var idCha = ms.GetType().GetProperty(nameParent)?.GetValue(ms).SafeToString() ?? string.Empty;
                            if (!maSo.IsNullOrEmpty()) {
                                var listSubMaSo = data.Where(s => (s.GetType().GetProperty(nameParent)?.GetValue(s).SafeToString() ?? string.Empty).Equals(idCha)
                                && (s.GetType().GetProperty("MaSo")?.GetValue(s).SafeToString() ?? string.Empty).StartsWith(maSo)
                                && (s.GetType().GetProperty("MaSo")?.GetValue(s).SafeToString() ?? string.Empty).Length > maSo.Length
                                ).ToList();
                                if (listSubMaSo.Count > 0) {
                                    valid = false;
                                    errorText = "Yêu cầu chọn thông tin có mã số chi tiết nhất";
                                }
                            }
                        }
                    }
                }
                e.Valid = valid;
                e.ErrorText = errorText;
            }
        }

        

        #region Custom - from Y4c
        /// <summary>
        /// Hàm cài đặt hiển thì Mã số - Tên trên repo
        /// </summary>
        /// <param name="repositories"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void SetupRepositoryViewsAndColumns(RepositoryItemSearchLookUpEdit[] repositories) {
            if (repositories == null) {
                throw new ArgumentNullException(nameof(repositories), "The repositories cannot be null.");
            }
            var viewCol = new List<Tuple<string, string>> {
                        new("MaSo", "Mã số"),
                        new("Ten", "Tên")};
            foreach (var repo in repositories) {
                if (repo != null) {
                    repo.CreateColumns(viewCol);
                    repo.PopupView.Columns["MaSo"].MinWidth = 60;
                }
            }
        }
        /// <summary>
        /// Hàm tuỳ chỉnh kiểu thiết kế chữ trên các cột của bandedgrid
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="fontStyle"></param>
        /// <param name="bands"></param>
        public static void SetFontStyleForBandedGridViewHeader(BandedGridView grid, FontStyle fontStyle, params GridBand[] bands) {
            if (grid == null || bands == null)
                return;
            grid.BeginUpdate();
            try {
                foreach (var band in bands) {
                    if (band == null)
                        break;
                    band.AppearanceHeader.Font = new Font(band.AppearanceHeader.Font, fontStyle);
                }
            }
            finally {
                grid.EndUpdate();
            }
        }
        /// <summary>
        /// Hàm tuỳ chỉnh trạng thái các nút khi số lượng bản ghi trên lưới thay đổi
        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="buttons"></param>
        public static void SetButtonStateBasedOnGridRowCount(GridView gridView, params BarButtonItem[] buttons) {
            if (gridView == null || buttons == null || buttons.Length == 0) {
                return;
            }
            UpdateButtonState(gridView.RowCount, buttons);
            gridView.RowCountChanged += (sender, e) => {
                UpdateButtonState(gridView.RowCount, buttons);
            };
        }
        private static void UpdateButtonState(int rowCount, params BarButtonItem[] buttons) {
            bool hasRows = rowCount > 0;
            foreach (var button in buttons) {
                button.Enabled = hasRows;
            }
        }
        public static void ConfigureAdvanceEmbeddedNavigator(GridControl gridControl) {
            gridControl.UseEmbeddedNavigator = true;
            // Ẩn tất cả các nút mặc định của EmbeddedNavigator
            foreach (NavigatorButtonBase button in gridControl.EmbeddedNavigator.Buttons.ButtonCollection) {
                button.Visible = false;
            }
            ImageCollection imageCollection = new ImageCollection();
            imageCollection.AddImage((Bitmap)(new ImageConverter().ConvertFrom(app.StdAppResources.DXIconPack.Copy_16x16)));//0
            imageCollection.AddImage((Bitmap)(new ImageConverter().ConvertFrom(app.StdAppResources.DXIconPack.Paste_16x16)));//1
            imageCollection.AddImage((Bitmap)(new ImageConverter().ConvertFrom(app.StdAppResources.DXIconPack.Delete_16x16)));//2 
            gridControl.EmbeddedNavigator.Buttons.ImageList = imageCollection;
            NavigatorCustomButton btnCopy = gridControl.EmbeddedNavigator.Buttons.CustomButtons.Add();
            btnCopy.Tag = "copy";
            btnCopy.Hint = "Copy to clipboard";
            btnCopy.ImageIndex = 0;
            NavigatorCustomButton btnPaste = gridControl.EmbeddedNavigator.Buttons.CustomButtons.Add();
            btnPaste.Tag = "paste";
            btnPaste.Hint = "Paste from clipboard";
            btnPaste.ImageIndex = 1;
            NavigatorCustomButton btnDelete = gridControl.EmbeddedNavigator.Buttons.CustomButtons.Add();
            btnDelete.Tag = "delete";
            btnDelete.Hint = "Delete record";
            btnDelete.ImageIndex = 2;
            string textFormat = "Bản ghi {0}/{1}";
            gridControl.EmbeddedNavigator.TextLocation = NavigatorButtonsTextLocation.End;
            gridControl.EmbeddedNavigator.TextStringFormat = textFormat;
        }
        #endregion
    }
}