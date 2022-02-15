using BusinessObjects.Model;
using Microsoft.AspNetCore.Mvc;
using ServiceLibrary.Interfaces;
using System.Collections;
using ValutesWebApp.Models;

namespace ValutesWebApp.Controllers
{
    public class RootController : Controller
    {
        private readonly IRootService _rootService;
        public RootController(IRootService rootService)
        {
            _rootService = rootService;
        }
        public IActionResult Currencies(int page = 1)
        {
            int pageSize = 10;

            var count = _rootService.GetRoot().Currency.Count;
            var items = _rootService.GetRoot().Currency.Values.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            CurrencyViewModel viewModel = new CurrencyViewModel
            {
                PageViewModel = pageViewModel,
                Currencies = items,
                Root = _rootService.GetRoot(),
            };
            return View(viewModel);
        }
        public IActionResult Currency(string ticket, int page = 1)
        {
            return View(_rootService.GetCurrency(ticket));
        }
    }
}
