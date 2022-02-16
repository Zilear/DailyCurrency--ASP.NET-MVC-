using BusinessObjects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary.Interfaces
{
    public interface ICurrenciesDataService
    {
        CurrenciesData GetCurrenciesData();

        Currency GetCurrency(string Ticket);
    }
}
