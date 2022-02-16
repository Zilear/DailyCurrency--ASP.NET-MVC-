using BusinessObjects.Model;
using BusinessObjects.Repository;
using BusinessObjects.Repository.Interfaces;
using ServiceLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public class CurrenciesDataService : ICurrenciesDataService
    {
        private readonly ICurrenciesDataRepository _rootRepository;
        public CurrenciesDataService(ICurrenciesDataRepository rootRepository)
        {
            _rootRepository = rootRepository;
        }
        public CurrenciesData GetCurrenciesData()
        {
            return _rootRepository.GetCurrenciesData();
        }

        public Currency GetCurrency(string Ticket)
        {
            return _rootRepository.GetCurrency(Ticket);
        }
    }
}
