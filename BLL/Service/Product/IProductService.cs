using DLL.Models;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.Product
{
    public interface IProductService
    {
            List<ProductModel> GetProductList();
        bool AddProdcut(ProductModel model);
    }
}
