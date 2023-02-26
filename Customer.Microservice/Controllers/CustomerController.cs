using Customer.Microservice.Data;
using Customer.Microservice.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Customer.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerRepository _repository;

        public CustomerController(CustomerRepository repository)
        {
            _repository = repository;
        }
        [HttpPost]
        public IActionResult Create(CustomerModel customer)
        {
            _repository.Add(customer);
            return Ok(customer.Id);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var customers = _repository.GetAll();
            if (customers == null) return NotFound();
            return Ok(customers);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var customer = _repository.FindById(id);
            if (customer == null) return NotFound();
            return Ok(customer);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var customer = _repository.FindById(id);
            if (customer == null) return NotFound();
            _repository.Delete(customer);
            return Ok(customer.Id);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, CustomerModel customerData)
        {
            var customer = _repository.FindById(id);

            if (customer == null) return NotFound();
            else
            {
                _repository.Update(customerData, id);
                return Ok(customer.Id);
            }
        }
    }
}
