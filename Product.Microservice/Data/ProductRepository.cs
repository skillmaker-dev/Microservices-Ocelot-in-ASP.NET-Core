using Product.Microservice.Entities;

namespace Product.Microservice.Data
{
    public class ProductRepository
    {
        public readonly List<ProductModel> Products;
        public ProductRepository()
        {
            Products = new List<ProductModel>
            {
                new ProductModel { Id = 1, Name = "Samsung galaxy s22", Rate = 200 },
                new ProductModel { Id = 2, Name = "Apple iPhone 13 Pro", Rate = 999 },
                new ProductModel { Id = 3, Name = "Sony Playstation 5", Rate = 499 },
                new ProductModel { Id = 4, Name = "Microsoft Surface Pro 8", Rate = 1299 },
                new ProductModel { Id = 5, Name = "Canon EOS R5", Rate = 3799 },
                new ProductModel { Id = 6, Name = "Bose QuietComfort 45 headphones", Rate = 329 },
                new ProductModel { Id = 7, Name = "DJI Mavic 3 drone", Rate = 2099 },
                new ProductModel { Id = 8, Name = "Tesla Model 3", Rate = 37990 },
                new ProductModel { Id = 9, Name = "Fitbit Charge 5", Rate = 179 },
                new ProductModel { Id = 10, Name = "Amazon Echo Show 10", Rate = 249 }
            };
        }

        public void Add(ProductModel product)
        {
            Products.Add(product);
        }

        public ProductModel? FindById(int id)
        {
            return Products.FirstOrDefault(x => x.Id == id);
        }

        public void Delete(ProductModel product)
        {
            Products.Remove(product);
        }

        public IEnumerable<ProductModel> GetAll()
        {
            return Products;
        }

        public void Update(ProductModel product, int id)
        {

            var productToDelete = Products.FirstOrDefault(p => p.Id == id);
            if (productToDelete is null)
                return;
            product.Id = id;
            Products.Remove(productToDelete);
            Products.Add(product);
        }
    }
}
