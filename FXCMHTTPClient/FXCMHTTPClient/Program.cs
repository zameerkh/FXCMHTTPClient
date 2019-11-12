using FXCMRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace FXCMHTTPClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Stored!");
            GetFXCMAPI();
            Console.ReadKey();
        }

        public static void GetFXCMAPI()
        {
            // Login info for FXCM

            string url = "https://api-demo.fxcm.com";
            string url2 = "https://api-demo.fxcm.com/trading/get_instruments";
            string api_token = "0ee751f0af135d3da90378756f8129bb4a586490";

            Session session = new Session(api_token, url);
            session.Connect();
            Console.WriteLine(session.State);

            /*IList<Instrument> inst = session.GetInstruments();
            Dictionary<string, string> currencylist = new Dictionary<string, string>();
            for (int i = 0; i < inst.Count(); i++)
            {
                currencylist.Add(inst[i].Symbol, inst[i].Symbol);
            }

            
            Console.WriteLine(currencylist);
            Console.WriteLine(inst[0].Symbol);*/




            /*HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", api_token);
            HttpResponseMessage response = await client.GetAsync();
            HttpContent content = response.Content;
            string mycontent = await content.ReadAsStringAsync();*/
        }
    }
}
