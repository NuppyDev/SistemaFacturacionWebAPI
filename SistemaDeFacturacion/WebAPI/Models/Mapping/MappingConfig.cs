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
            //Meseros
            CreateMap<Waiters, WaitersDto>().ReverseMap();
            CreateMap<Waiters, WaitersCreateDto>().ReverseMap();
            CreateMap<Waiters, WaitersUpdateDto>().ReverseMap();

            //Mesas
            CreateMap<Tables, TablesDto>().ReverseMap();
            CreateMap<Tables, TablesCreateDto>().ReverseMap();
            CreateMap<Tables, TablesUpdateDto>().ReverseMap();

            //Productos
            CreateMap<Products, ProductsDto>().ReverseMap();
            CreateMap<Products, ProductsCreateDto>().ReverseMap();
            CreateMap<Products, ProductsUpdateDto>().ReverseMap();

            //Historico
            CreateMap<Historical, HistoricalDto>().ReverseMap();
            CreateMap<Historical, HistoricalCreateDto>().ReverseMap();
            CreateMap<Historical, HistoricalUpdateDto>().ReverseMap();

            //Categorias
            CreateMap<Categories, CategoriesDto>().ReverseMap();
            CreateMap<Categories, CategoriesCreateDto>().ReverseMap();
            CreateMap<Categories, CategoriesUpdateDto>().ReverseMap();

            //Descripciones
            CreateMap<Description, DescriptionDto>().ReverseMap();
            CreateMap<Description, DescriptionCreateDto>().ReverseMap();
            CreateMap<Description, DescriptionUpdateDto>().ReverseMap();

            //Facturas
            CreateMap<Invoice, InvoiceDto>().ReverseMap();
            CreateMap<Invoice, InvoiceCreateDto>().ReverseMap();
            CreateMap<Invoice, InvoiceUpdateDto>().ReverseMap();

            //Facturas y Descripciones
            CreateMap<InvoiceDescription, InvoiceDescriptionDto>().ReverseMap();
            CreateMap<InvoiceDescription, InvoiceDescriptionCreateDto>().ReverseMap();
            CreateMap<InvoiceDescription, InvoiceDescriptionUpdateDto>().ReverseMap();
        }
    }
}
