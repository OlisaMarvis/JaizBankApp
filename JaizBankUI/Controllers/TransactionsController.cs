using JaizBank.Application.JaizBank.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JaizBankUI.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly ITransactionService _service;

        public TransactionsController(ITransactionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _service.GetAllTransactions();
            return View(result);
        }
    }
}
