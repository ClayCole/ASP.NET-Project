using System;
using System.Collections.Generic;

namespace Testing.Models
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        public void UpdateProduct(Product product);

        public void InsertProduct(Product productToInsert); // AssignCategory()
        public IEnumerable<Category> GetCategories(); // GetCategories()
        public Product AssignCategory(); // InsertProduct()

        public void DeleteProduct(Product product);

    }
}

