using BLL.Service.Movements;
using BLL.Service.Product;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;
        private readonly IMovementsService movementsService;

        public HomeController(IProductService productService, IMovementsService movementsService)
        {
            this.productService = productService;
            this.movementsService = movementsService;
        }

        public ActionResult Index()
        {

            var products = productService.GetProductList();
            return View(products);

        }

        public ActionResult About()
        {

            var result = movementsService.Movements();

            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}