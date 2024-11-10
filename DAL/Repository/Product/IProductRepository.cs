using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Product
{
    public interface IProductRepository
    {
        DataCollection<Entity> GetProductList();

    }
}
