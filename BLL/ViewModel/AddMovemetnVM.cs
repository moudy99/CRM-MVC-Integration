    using DLL.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace BLL.ViewModel
    {
        public class AddMovemetnVM
        {
            public int MovedQuntity { get; set; }
            public string MovedName { get; set; }

            public Guid MovedProductId { get; set; }

            public int MovmentType { get; set; }
        }
    }
