using Microsoft.AspNetCore.Mvc;

namespace bootstrap_demo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.BMI_791 = 0;
            return View();
        }

        public IActionResult Index(BMI.Models.BMImodel_791 model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.BMI_791 = model.CalculateBMI_791();
            }
            else
            {
                ViewBag.BMI_791 = 0;
            }
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}