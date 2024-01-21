namespace MicroService.Models.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public uint Cost { get; set; }
        public decimal Price { get; set; }
    }
}
