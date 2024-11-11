using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DLL.Models
{
    public class ProductModel
    {
        public string Name { get; set; }
        public int CurrentStock { get; set; }

        public Guid ProductId { get; set; }
    }
}