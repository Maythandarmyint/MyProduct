using MyProduct.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProduct.Controllers
{
    public class HomeController : Controller
    {

        private IProductService productService;

        public HomeController(IProductService productService)
        {
            this.productService = productService;
        }

        public ActionResult Index()
        {            

            return View(productService.GetProducts());
        }

    }
}