using BLL.Service.Movements;
using BLL.Service.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class MovementController : Controller
    {
        private readonly IProductService productService;
        private readonly IMovementsService movementsService;

        public MovementController(IProductService productService, IMovementsService movementsService)
        {
            this.productService = productService;
            this.movementsService = movementsService;
        }
        // GET: Movement
        public ActionResult Index()
        {

            var result = movementsService.Movements();

            return View(result);
        }
    }
}