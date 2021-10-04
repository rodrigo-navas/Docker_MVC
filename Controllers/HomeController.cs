using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using mvc1.Models;
using System.Diagnostics;

namespace mvc1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository _repository;
        private string message;

        public HomeController(ILogger<HomeController> logger, IRepository repository, IConfiguration configuration)
        {
            _logger = logger;
            _repository = repository;
            message = $"Docker - ({configuration["HOSTNAME"]})";
        }

        public IActionResult Index()
        {
            ViewBag.Message = message;
            return View(_repository.Produtos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
