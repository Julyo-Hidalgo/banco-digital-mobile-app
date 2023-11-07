using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using App_Banco_Digital.Model;
using Newtonsoft.Json;
using Xamarin.Essentials;

namespace App_Banco_Digital.Service
{
    public class DataService
    {
        private static readonly string servidor = "http://10.0.2.2:8000";

        protected static async Task<string> PostData(string json_object, string rota)
        {
            string json_response = "";

            string uri = servidor + rota;

            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                throw new Exception("Por favor, conecte-se à Internet.");
            }

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(
                    uri,
                    new StringContent(json_object, Encoding.UTF8, "application/json")
                );

                Console.WriteLine("_______________________________");
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.WriteLine("_______________________________");

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("_______________________________");
                    Console.WriteLine(response.StatusCode);
                    Console.WriteLine("_______________________________");

                    string conteudo = response.Content.ReadAsStringAsync().Result;

                    json_response = conteudo;
                }
            }
            return json_response;

        }

    }
}