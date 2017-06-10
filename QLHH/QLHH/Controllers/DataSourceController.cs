using Microsoft.AspNetCore.Mvc;

namespace QLHH.Controllers
{
    public class DataSourceController : Controller
    {
        public IActionResult Index(string q)
        {
            var results = new[]
            {
                new { id = 1, text = "user1" },
                new { id = 2, text = "user2" },
                new { id = 3, text = "user3" },
                new { id = 4, text = "user4" },
            };
            return Json(new { results });
        }

        public IActionResult Submit(int key, string value)
        {
            return Json(new { results = true });
        }
    }
}