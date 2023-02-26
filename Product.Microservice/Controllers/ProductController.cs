using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.Microservice.Data;
using Product.Microservice.Entities;

namespace Product.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _repository;

        public ProductController(ProductRepository repository)
        {
            _repository = repository;
        }
        [HttpPost]
        public IActionResult Create(ProductModel product)
        {
            _repository.Add(product);
            return Ok(product.Id);
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
            var product = _repository.FindById(id);
            if (product == null) return NotFound();
            return Ok(product);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = _repository.FindById(id);
            if (product == null) return NotFound();
            _repository.Delete(product);
            return Ok(product.Id);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, ProductModel productData)
        {
            var product = _repository.FindById(id);
            if (product == null) return NotFound();
            else
            {
                _repository.Update(product, id);
                return Ok(product.Id);
            }
        }
    }
}
