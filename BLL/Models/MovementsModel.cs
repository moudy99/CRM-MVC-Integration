using DLL.Models;
using System;

namespace BLL.Models
{
    public class MovementsModel
    {
        public int MovedQuntity { get; set; }
        public string MovedName { get; set; }

        public Guid MovedProductId { get; set; }

        //public Enums.MovementType Type { get; set; }
        public int MovmentType { get; set; }

        public ProductModel Product { get; set; }
    }
}
