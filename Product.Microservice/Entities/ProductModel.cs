namespace Product.Microservice.Entities
{
    public class ProductModel : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public int Rate { get; set; }
    }
}
