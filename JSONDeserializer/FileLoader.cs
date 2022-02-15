using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JSONDeserializer
{
    public class FileLoader
    {
        private WebClient wc;
        public void Load()
        {
            var path = @"./Currencies.json";
            var exist = File.Exists(path);
            if (exist) File.Delete(path);
            wc = new WebClient();
            var url = "https://www.cbr-xml-daily.ru/daily_json.js";
            var save_path = "./";
            var name = "Currencies.json";
            wc.DownloadFile(url, save_path + name);
        }
    }
}
