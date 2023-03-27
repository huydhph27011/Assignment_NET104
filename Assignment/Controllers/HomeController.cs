using _1.DAL.Models;
using Assignment.IServices;
using Assignment.Models;
using Assignment.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
    
namespace Assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMaterialService _materialService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _materialService = new MaterialService();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult ShowSanPham()
        {
            List<Material> materials = _materialService.GetAllMaterials();
            return View(materials);
        }
        public IActionResult ShowSanPham5()
        {
            List<Material> materials = _materialService.GetMaterial5s();
            return View(materials);
        }
        public IActionResult CreateSP()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSP(Material m)
        {
            if (_materialService.CreateMaterial(m))
            {
                return RedirectToAction("ShowSanPham");
            }
            return BadRequest();
        }
        public IActionResult DeleteSP(Guid id)
        {
            if (_materialService.DeleteMaterial(id))
            {
                return RedirectToAction("ShowSanPham");
            }
            return BadRequest();
        }
        public IActionResult Details(Guid id)
        {
            var materials = _materialService.GetMaterialById(id);
            return View(materials);
        }
        [HttpGet]
        public IActionResult EditSP(Guid id)
        {
            var materials = _materialService.GetMaterialById(id);
            return View(materials);
        }
        [HttpPost]
        public IActionResult EditSP(Material m)
        {
            if (m.Price <= 1)
            {
                return Content("Giá bịp");
            }
            else if(m.SoLuongTon <=1)
            {
                return Content("Giá bịp");
            }
            else
            {
                _materialService.UpdateMaterial(m);
                return RedirectToAction("ShowSanPham");
            }
            return BadRequest();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}