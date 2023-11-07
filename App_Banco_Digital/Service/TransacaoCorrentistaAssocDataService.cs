using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using App_Banco_Digital.Model;

namespace App_Banco_Digital.Service
{
    public class TransacaoCorrentistaAssocDataService : DataService
    {
        public static async Task<bool?> SaveAsyncTransacaoCorrentistaAssoc(TransacaoCorrentistaAssoc transacaoCorrentista)
        {
            var json_enviar = JsonConvert.SerializeObject(transacaoCorrentista);

            string json = await DataService.PostData(json_enviar, "/transacaoCorrentistaAssoc/save");


            return JsonConvert.DeserializeObject<bool?>(json);
        }
    }
}