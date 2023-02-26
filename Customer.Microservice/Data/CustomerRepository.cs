using Customer.Microservice.Entities;
using System.Xml.Linq;

namespace Customer.Microservice.Data
{
    public class CustomerRepository
    {
        public readonly List<CustomerModel> Customers;
        public CustomerRepository()
        {
           Customers= new List<CustomerModel>
            {
                new CustomerModel { Id = 1, Name = "John Mayer", City = "Toronto", Contact = "john.mayer@example.com", Email = "john.mayer@example.com"  },
                new CustomerModel { Id = 2, Name = "Mary Johnson", City = "New York", Contact = "mary.johnson@example.com", Email = "mary.johnson@example.com" },
                new CustomerModel { Id = 3, Name = "William Lee", City = "London", Contact = "william.lee@example.com", Email = "william.lee@example.com" },
                new CustomerModel { Id = 4, Name = "Emily Nguyen", City = "Sydney", Contact = "emily.nguyen@example.com", Email = "emily.nguyen@example.com" },
                new CustomerModel { Id = 5, Name = "Robert Chen", City = "Shanghai", Contact = "robert.chen@example.com", Email = "robert.chen@example.com" },
                new CustomerModel { Id = 6, Name = "Julia Kim", City = "Seoul", Contact = "julia.kim@example.com", Email = "julia.kim@example.com" },
                new CustomerModel { Id = 7, Name = "Michael Brown", City = "Los Angeles", Contact = "michael.brown@example.com", Email = "michael.brown@example.com" },
                new CustomerModel { Id = 8, Name = "Lily Wong", City = "Hong Kong", Contact = "lily.wong@example.com", Email = "lily.wong@example.com" },
                new CustomerModel { Id = 9, Name = "David Patel", City = "Mumbai", Contact = "david.patel@example.com", Email = "david.patel@example.com" },
                new CustomerModel { Id = 10, Name = "Sophia Martinez", City = "Mexico City", Contact = "sophia.martinez@example.com", Email = "sophia.martinez@example.com" }
            };
        }

        public void Add(CustomerModel customer)
        {
            Customers.Add(customer);
        }

        public CustomerModel? FindById(int id)
        {
            return Customers.FirstOrDefault(x => x.Id == id);
        }

        public void Delete(CustomerModel customer)
        {
            Customers.Remove(customer);
        }

        public IEnumerable<CustomerModel> GetAll()
        {
            return Customers;
        }

        public void Update(CustomerModel customer,int id)
        {

            var customerToDelete = Customers.FirstOrDefault(customer => customer.Id == id);
            if (customerToDelete is null)
                return;
            customer.Id = id;
            Customers.Remove(customerToDelete);
            Customers.Add(customer);
        }
    }
}
