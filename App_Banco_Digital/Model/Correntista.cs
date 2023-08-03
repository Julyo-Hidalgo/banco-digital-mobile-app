using System;
using System.Collections.Generic;
using System.Text;

namespace App_Banco_Digital.Model
{
    public class Correntista
    {
        public string id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public DateTime? data_nasc { get; set; }
        public string senha { get; set; }
    }
}