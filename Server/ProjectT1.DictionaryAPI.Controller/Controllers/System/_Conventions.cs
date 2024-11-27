// ***********************************************************************
// Assembly         : ProjectX1.DictionaryAPI.Controller
// Author           : Admin
// Created          : 09-02-2023
//
// Last Modified By : Admin
// Last Modified On : 12-03-2023
// ***********************************************************************
// <copyright file="_Conventions.cs" company="ProjectX1.DictionaryAPI.Controller">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
/*

[Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatch(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Prefix)]
[Microsoft.AspNetCore.Mvc.ProducesDefaultResponseType]
[Microsoft.AspNetCore.Mvc.ProducesResponseType(200)] -- Ok
[Microsoft.AspNetCore.Mvc.ProducesResponseType(404)] -- Not found
public static void Find (object id);
public static void Get (object id);

[Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatch(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Prefix)]
[Microsoft.AspNetCore.Mvc.ProducesDefaultResponseType]
[Microsoft.AspNetCore.Mvc.ProducesResponseType(201)] -- Created
[Microsoft.AspNetCore.Mvc.ProducesResponseType(400)] -- Bad request   
public static void Create(object model);
public static void Post (object model);

[Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatch(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Prefix)]
[Microsoft.AspNetCore.Mvc.ProducesDefaultResponseType]
[Microsoft.AspNetCore.Mvc.ProducesResponseType(204)]
[Microsoft.AspNetCore.Mvc.ProducesResponseType(404)]  -- Not found
[Microsoft.AspNetCore.Mvc.ProducesResponseType(400)]  -- Bad request
public static void Edit (object id, object model);
public static void Put (object id, object model);
public static void Update (object id, object model);

[Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatch(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiConventionNameMatchBehavior.Prefix)]
[Microsoft.AspNetCore.Mvc.ProducesDefaultResponseType]
[Microsoft.AspNetCore.Mvc.ProducesResponseType(200)] -- Ok
[Microsoft.AspNetCore.Mvc.ProducesResponseType(404)] -- Not found
[Microsoft.AspNetCore.Mvc.ProducesResponseType(400)] -- Bad request
public static void Delete (object id);

*/