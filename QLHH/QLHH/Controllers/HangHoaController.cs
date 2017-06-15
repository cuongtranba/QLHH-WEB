using System.Collections.Generic;
using System.Linq;
using Cross.Enums;
using Microsoft.AspNetCore.Mvc;
using QLHH.BUS.Interfaces;
using QLHH.DAL.Model;

namespace QLHH.Controllers
{
    public class HangHoaController : Controller
    {
        private IHangHoaService _hangHoaService;

        public HangHoaController(IHangHoaService hangHoaService)
        {
            _hangHoaService = hangHoaService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PhieuNhap()
        {
            var getattributeForPhieunhap = _hangHoaService.GetAttributeByType(EntityTypes.PhieuNhap);
            var entity = new Entity()
            {
                EntityTypeId = (int)EntityTypes.PhieuNhap,
                EntityAttributes = getattributeForPhieunhap
            };
            return View(entity);
        }
        [HttpPost]
        public IActionResult PhieuNhap(Entity entity)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}