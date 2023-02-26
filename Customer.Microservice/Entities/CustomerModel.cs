namespace Customer.Microservice.Entities
{
    public class CustomerModel : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
