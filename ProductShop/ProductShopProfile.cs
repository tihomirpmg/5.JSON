namespace ProductShop
{
    using AutoMapper;
    using Models;
    using ProductShop.App.Dto.Import;

    public class ProductShopProfile : Profile
    {
        public ProductShopProfile()
        {
            this.CreateMap<UserDto, User>();

            this.CreateMap<ProductDto, Product>();

            this.CreateMap<CategoryDto, Category>();
        }
    }
}