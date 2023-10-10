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
        public static async Task<ChavePix> SaveAsyncChavePix(ChavePix pix)
        { 
            var json_enviar = JsonConvert.SerializeObject(pix);

            string json = await DataService.PostData(json_enviar, "/conta/pix/save");


            return JsonConvert.DeserializeObject<ChavePix>(json);
        }
    }
}
