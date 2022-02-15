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
    public class RootService : IRootService
    {
        private readonly IRootRepository _rootRepository;
        public RootService(IRootRepository rootRepository)
        {
            _rootRepository = rootRepository;
        }
        public Root GetRoot()
        {
            return _rootRepository.GetRoot();
        }

        public Currency GetCurrency(string Ticket)
        {
            return _rootRepository.GetCurrency(Ticket);
        }
    }
}
