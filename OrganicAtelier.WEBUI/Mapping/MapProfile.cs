using AutoMapper;
using OrganicAtelier.BLL.DTOs.AboutDTO;
using OrganicAtelier.BLL.DTOs.BlogDTO;
using OrganicAtelier.BLL.DTOs.ClientDTO;
using OrganicAtelier.BLL.DTOs.ContactDTO;
using OrganicAtelier.BLL.DTOs.FeatureDTO;
using OrganicAtelier.BLL.DTOs.MailDTO;
using OrganicAtelier.BLL.DTOs.ProductDetailDTO;
using OrganicAtelier.BLL.DTOs.ProductDTO;
using OrganicAtelier.BLL.DTOs.ProductTypeDTO;
using OrganicAtelier.BLL.DTOs.SliderDTO;
using OrganicAtelier.Entity;

namespace OrganicAtelier.WEBUI.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<ProductDetail, ResultProductDetailDTO>().ReverseMap();

            CreateMap<Product, ResultProductDTO>().ReverseMap();
            CreateMap<Product, CreateProductDTO>().ReverseMap();
            CreateMap<Product, UpdateProductDTO>().ReverseMap();

            CreateMap<ProductType, ResultProductTypeDTO>().ReverseMap();
            CreateMap<ProductType, CreateProductTypeDTO>().ReverseMap();
            CreateMap<ProductType, UpdateProductTypeDTO>().ReverseMap();

            CreateMap<Slider, ResultSliderDTO>().ReverseMap();
            CreateMap<Slider, UpdateSliderDTO>().ReverseMap();
            CreateMap<Slider, CreateSliderDTO>().ReverseMap();

            CreateMap<About, ResultAboutDTO>().ReverseMap();
            CreateMap<About, UpdateAboutDTO>().ReverseMap();

            CreateMap<Client, ResultClientDTO>().ReverseMap();
            CreateMap<Client, UpdateClientDTO>().ReverseMap();

            CreateMap<Feature, ResultFeatureDTO>().ReverseMap();
            CreateMap<Blog, ResultBlogDTO>().ReverseMap();
            CreateMap<Contact, ResultContactDTO>().ReverseMap();
            CreateMap<Mail, ResultMailDTO>().ReverseMap();


        }
    }
}
