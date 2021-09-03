using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId = 1,CategoryId = 1,ProductName = "Çikolata(500g)", UnitPrice = 15,UnitsInStock = 15},
                new Product{ProductId = 2,CategoryId = 1,ProductName = "çerez", UnitPrice = 500,UnitsInStock = 3},
                new Product{ProductId = 3,CategoryId = 2,ProductName = "batarya", UnitPrice = 1500,UnitsInStock = 2},
                new Product{ProductId = 4,CategoryId = 2,ProductName = "kamera", UnitPrice = 150,UnitsInStock = 65},
                new Product{ProductId = 5,CategoryId = 2,ProductName = "maus", UnitPrice = 85,UnitsInStock = 1}
            };
        }
        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        public void Delete(Product product)
        {

            Product productToDelete = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAllByCategory(int CategoryId)
        {
            return _products.Where(p => p.CategoryId == CategoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}