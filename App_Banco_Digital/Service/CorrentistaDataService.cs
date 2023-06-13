using App_Banco_Digital.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App_Banco_Digital.Service
{
    public class CorrentistaDataService : DataService
    {
        public static async Task<Correntista> save(Correntista c)
        {
            var json_a_enviar = JsonConvert.SerializeObject(c);

            Console.WriteLine(json_a_enviar);

            string json = await DataService.PostData(json_a_enviar, "/correntista/save");


            return JsonConvert.DeserializeObject<Correntista>(json);
        }
    }
}
