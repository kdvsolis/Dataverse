using Dataverse.Backend.Models;

namespace Dataverse.Backend.DataRepository
{
    public class ProductRepository
    {
        private readonly List<Product> _products = new List<Product>();

        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public void AddProduct(Product product)
        {
            product.Id = _products.Count + 1;
            _products.Add(product);
        }

        public void UpdateProduct(int id, Product updatedProduct)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == id);
            if (existingProduct != null)
            {
                existingProduct.Name = updatedProduct.Name;
                existingProduct.Description = updatedProduct.Description;
                existingProduct.Price = updatedProduct.Price;
            }
        }

        public void DeleteProduct(int id)
        {
            var productToDelete = _products.FirstOrDefault(p => p.Id == id);
            if (productToDelete != null)
            {
                _products.Remove(productToDelete);
            }
        }
    }
}
