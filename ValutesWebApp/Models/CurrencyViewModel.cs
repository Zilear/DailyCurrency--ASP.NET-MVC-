using BusinessObjects.Model;

namespace ValutesWebApp.Models
{
    public class CurrencyViewModel
    {
        public CurrenciesData CurrenciesData { get; set; }
        public IEnumerable<Currency> Currencies { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
