namespace ProductShop.DTOs.Export
{
    public class UserAllDto
    {
        public int UserCount { get; set; }

        public UserProductDto[] Users { get; set; }
    }
}