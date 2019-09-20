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
            ViewBag.CategoryList = productService.GetCategories();

            ViewBag.SubCategoryList = productService.GetSubCategories();

            return View(productService.GetProducts());
        }


        [HttpGet]
        public JsonResult GetSubCategorieList(int categoryid)
        {
            var oup = productService.GetSubCategories()
                .Select(x => new { id = x.SubcategoryId, text = x.SubcategoryName });
            return Json(oup, JsonRequestBehavior.AllowGet);
        }

    }
}