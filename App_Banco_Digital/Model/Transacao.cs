using System;
using System.Collections.Generic;
using System.Text;

namespace App_Banco_Digital.Model
{
    public class Transacao
    {
        public int id {  get; set; }
        public double valor {  get; set; }
        public DateTime data_transacao { get; set; }
    }
}
