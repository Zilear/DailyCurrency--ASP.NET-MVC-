using BusinessObjects.Model;
using Microsoft.AspNetCore.Mvc;
using ServiceLibrary.Interfaces;
using System.Collections;
using ValutesWebApp.Models;

namespace ValutesWebApp.Controllers
{
    public class CurrenciesDataController : Controller
    {
        private readonly ICurrenciesDataService _currenciesDataService;
        public CurrenciesDataController(ICurrenciesDataService currenciesDataService)
        {
            _currenciesDataService = currenciesDataService;
        }
        public IActionResult Currencies(int page = 1)
        {
            int pageSize = 10;

            var count = _currenciesDataService.GetCurrenciesData().Currency.Count;
            var items = _currenciesDataService.GetCurrenciesData().Currency.Values.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            CurrencyViewModel viewModel = new CurrencyViewModel
            {
                PageViewModel = pageViewModel,
                Currencies = items,
                CurrenciesData = _currenciesDataService.GetCurrenciesData(),
            };
            return View(viewModel);
        }
        public IActionResult Currency(string ticket, int page = 1)
        {
            return View(_currenciesDataService.GetCurrency(ticket));
        }
    }
}
