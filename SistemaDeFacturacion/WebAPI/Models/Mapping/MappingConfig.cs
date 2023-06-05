using AutoMapper;
using WebAPI.Models.Clases;
using WebAPI.Models.Dto.Base;
using WebAPI.Models.Dto.Create;
using WebAPI.Models.Dto.Update;

namespace WebAPI.Models.Mapping
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            CreateMap<Waiters, WaitersDto>().ReverseMap();
            CreateMap<Waiters, WaitersCreateDto>().ReverseMap();
            CreateMap<Waiters, WaitersUpdateDto>().ReverseMap();

            CreateMap<Tables, TablesDto>().ReverseMap();
            CreateMap<Tables, TablesCreateDto>().ReverseMap();
            CreateMap<Tables, TablesUpdateDto>().ReverseMap();

        }
    }
}
