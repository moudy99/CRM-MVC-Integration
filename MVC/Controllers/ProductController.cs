using BLL.Service.Movements;
using BLL.Service.Product;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly IMovementsService movementsService;

        public ProductController(IProductService productService, IMovementsService movementsService)
        {
            this.productService = productService;
            this.movementsService = movementsService;
        }
        
        public ActionResult Index()
        {
            var products = productService.GetProductList();
            return View(products);
        }

        [HttpPost]
        public ActionResult AddProduct(ProductModel productModel)
        {
            if (ModelState.IsValid)
            {
            productService.AddProdcut(productModel); 
                return Json(new { success = true, message = "Product added successfully!" });
            }
            return Json(new { success = false, message = "Failed to add product." });
        }
    }
}