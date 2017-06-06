using Microsoft.AspNetCore.Mvc;

namespace QLHH.Controllers
{
    public class DataSourceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}