using App_Banco_Digital.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace App_Banco_Digital.Service
{
    public class ChavePixDataService : DataService
    {
        public static async Task<bool?> SaveAsyncChavePix(ChavePix pix)
        { 
            var json_enviar = JsonConvert.SerializeObject(pix);

            string json = await DataService.PostData(json_enviar, "/pix/save");


            return JsonConvert.DeserializeObject<bool?>(json);
        }
    }
}
