using Dataverse.Backend.DataRepository;
using Dataverse.Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dataverse.Backend.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductRepository _repository;

        public ProductsController(ProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _repository.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _repository.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest();
            }
            _repository.AddProduct(product);
            return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product updatedProduct)
        {
            if (updatedProduct == null)
            {
                return BadRequest();
            }
            _repository.UpdateProduct(id, updatedProduct);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            _repository.DeleteProduct(id);
            return NoContent();
        }
    }

}
