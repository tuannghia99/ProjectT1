using AutoMapper;
using GenerateModelSQLServerEFCore.Models;
using ProjectT1.DictionaryAPI.Infrastructure.DTOs;

namespace ProjectT1.DictionaryAPI.Infrastructure.Mappings {

    public class MappingProfile_DanhMuc : Profile {
        public MappingProfile_DanhMuc() {
            CreateMapping();
        }

        public void CreateMapping() {
            // 001. ChucVu
            CreateMap<ChucVuDTO, CommonCategory>()
            .ForMember(dest => dest.Oid, opts => opts.MapFrom(src => src.Oid))
            .ForMember(dest => dest.Mscode, opts => opts.MapFrom(src => src.MaSo))
            .ForMember(dest => dest.Msname, opts => opts.MapFrom(src => src.Ten))
            .ReverseMap();

            // 002. PhongBan
            CreateMap<PhongBanDTO, CommonCategory>()
            .ForMember(dest => dest.Oid, opts => opts.MapFrom(src => src.Oid))
            .ForMember(dest => dest.Mscode, opts => opts.MapFrom(src => src.MaSo))
            .ForMember(dest => dest.Msname, opts => opts.MapFrom(src => src.Ten))
            .ReverseMap();

            // 003. TrinhDoHocVan
            CreateMap<TrinhDoHocVanDTO, CommonCategory>()
            .ForMember(dest => dest.Oid, opts => opts.MapFrom(src => src.Oid))
            .ForMember(dest => dest.Mscode, opts => opts.MapFrom(src => src.MaSo))
            .ForMember(dest => dest.Msname, opts => opts.MapFrom(src => src.Ten))
            .ReverseMap();
        }
    }
}