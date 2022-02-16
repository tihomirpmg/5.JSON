using ProductShop.DTOs.Export;

namespace ProductShop.DTO.Export
{
    public class ProductSoldDto
    {
        public int Count { get; set; }

        public ProductAllDto[] Products { get; set; }
    }
}