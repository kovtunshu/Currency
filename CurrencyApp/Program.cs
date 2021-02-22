using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using MyLib;
using System.Text.Json;
using System.Text;



namespace CurrencyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string URI = "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json";

            string jsonFromServer = Web.GetWebContent(URI);
            //JsonTextReader reader = new JsonTextReader(new StringReader(jsonFromServer));

            List<CurrencyRate> currRates = JsonConvert.DeserializeObject<List<CurrencyRate>>(jsonFromServer);


            foreach (var item in currRates)
            {
                Console.WriteLine($" { item.cc } { item.rate } { item.exchangedate } ");
            }
            

            _ = Console.ReadLine();

        }

    }
}
