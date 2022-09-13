using JaizBank.Application.JaizBank.Interfaces;
using JaizBankUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JaizBankUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITransactionService _service;

        public HomeController(ILogger<HomeController> logger, ITransactionService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _service.GetAllTransactions();
            return View(result);
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