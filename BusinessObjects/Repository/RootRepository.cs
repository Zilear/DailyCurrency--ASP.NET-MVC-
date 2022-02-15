using BusinessObjects.Model;
using BusinessObjects.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Repository
{
    public class RootRepository : IRootRepository
    {
       
        public Root GetRoot()
        {
            var jsonFile = File.ReadAllText("./Currencies.json");
            return JsonConvert.DeserializeObject<Root>(jsonFile, JSONDeserializer.JsonToClass.Converter.Settings);
        }
        public Currency GetCurrency(string Ticket)
        {
            Root root = GetRoot();
            foreach (var currency in root.Currency.Values)
            {
                if (currency.CharCode == Ticket) return currency;
            }
            return null;
        }

        
    }
}
