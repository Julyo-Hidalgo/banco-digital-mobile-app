using App_Banco_Digital.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App_Banco_Digital.Service
{
    public class TransacaoDataService : DataService
    {
        public static async Task<bool?> SaveAsyncTransacao(Transacao transacao)
        {
            var json_enviar = JsonConvert.SerializeObject(transacao);

            string json = await DataService.PostData(json_enviar, "/transacao/save");


            return JsonConvert.DeserializeObject<bool?>(json);
        }
    }
}
