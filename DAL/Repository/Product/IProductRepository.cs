using Microsoft.Xrm.Sdk;
using System;

namespace DAL.Repository.Product
{
    public interface IProductRepository
    {
        DataCollection<Entity> GetProductList();

        Entity GetProductById(Guid id);

         bool AddProduct(Entity product);

    }
}
