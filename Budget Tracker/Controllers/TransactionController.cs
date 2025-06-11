using Microsoft.AspNetCore.Mvc;
using BudgetApp.Models;
using BudgetApp.Services;

namespace BudgetApp.Controllers
{
    public class TransactionController : Controller
    {
        private readonly TransactionService _service;

        public TransactionController(TransactionService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _service.GetAllAsync();
            return View(list);
        }

        public IActionResult Add() => View();

        [HttpPost]
        public async Task<IActionResult> Add(Transaction t)
        {
            await _service.AddAsync(t);
            return RedirectToAction("Index");
        }
    }
}
