using BusinessObjects.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Repository.Interfaces
{
    public interface IRootRepository
    {
         Root GetRoot();

         Currency GetCurrency(string Ticket);
        
    }
}
