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

namespace App_Banco_Digital.Service
{
    public class DataService
    {
        private static readonly string servidor = "http://10.0.2.2:8000";

        protected static async Task<string> PostData(string json_object, string rota)
        {
            string uri = servidor + rota;
            string json_response = "";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(
                    uri,
                    new StringContent(json_object, Encoding.UTF8, "application/json")
                );

                if (response.IsSuccessStatusCode == true)
                {
                    json_response = response.Content.ReadAsStringAsync().Result;
                }
            }

            return json_response;
        }
    }
}