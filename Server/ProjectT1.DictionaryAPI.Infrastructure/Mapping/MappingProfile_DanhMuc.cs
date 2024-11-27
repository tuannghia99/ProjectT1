using AutoMapper;
using GenerateModelSQLServerEFCore.Models;
using ProjectT1.DictionaryAPI.Infrastructure.DTOs;

namespace ProjectT1.DictionaryAPI.Infrastructure.Mappings {

    public class MappingProfile_DanhMuc : Profile {
        public MappingProfile_DanhMuc() {
            CreateMapping();
        }

        public void CreateMapping() {
            // 001. LinhVuc
            CreateMap<LinhVucDTO, Dm0002>()
            .ForMember(dest => dest.Oid, opts => opts.MapFrom(src => src.Oid))
            .ForMember(dest => dest.LinkGuid20, opts => opts.MapFrom(src => src.IdDonViSuDungChuongTrinh))
            .ForMember(dest => dest.Mscode, opts => opts.MapFrom(src => src.MaSo))
            .ForMember(dest => dest.Msname, opts => opts.MapFrom(src => src.Ten))
            .ReverseMap();
        }
    }
}