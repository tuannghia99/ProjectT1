using AutoMapper;
using GenerateModelSQLServerEFCore.Models;
using ProjectT1.DictionaryAPI.Infrastructure.DTOs;

namespace ProjectT1.DictionaryAPI.Infrastructure.Mappings {

    public class MappingProfile_ChucNang : Profile {
        public MappingProfile_ChucNang() {
            CreateMapping();
        }

        public void CreateMapping() {
            // 001. KhenThuong
            CreateMap<KhenThuongDTO, KhenThuong>()
            .ReverseMap();

            // 002. KyLuat
            CreateMap<KyLuatDTO, KyLuat>()
            .ReverseMap();

            // 003. NhanVien
            CreateMap<NhanVienDTO, NhanVien>()
            .ReverseMap();
        }
    }
}