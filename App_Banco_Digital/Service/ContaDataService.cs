using App_Banco_Digital.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App_Banco_Digital.Service
{
    public class ContaDataService : DataService
    {
        public static async Task<List<Conta>> searchAsyncByChavePix(string chavePix)
        {
            var json_enviar = JsonConvert.SerializeObject(chavePix);

            string json = await DataService.PostData(json_enviar, "/conta/searchByChavePix");


            return JsonConvert.DeserializeObject<List<Conta>>(json);
        }
    }
}
