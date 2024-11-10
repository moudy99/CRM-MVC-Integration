using DAL.Repository.Product;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.Product
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public List<ProductModel> GetProductList()
        {
            var result = productRepository.GetProductList();

            List<ProductModel> products = new List<ProductModel>();
            foreach (var entity in result)
            {
                products.Add(new ProductModel
                {
                    Name = entity.GetAttributeValue<string>("m99_name"),
                    CurrentStock = entity.GetAttributeValue<int>("m99_quntity")
                });
            }
            return products;
        }
    }
}
