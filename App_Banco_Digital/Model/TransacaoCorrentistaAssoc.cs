using System;
using System.Collections.Generic;
using System.Text;

namespace App_Banco_Digital.Model
{
    public class TransacaoCorrentistaAssoc
    {
        public int id_conta_remetente {  get; set; }
        public int id_conta_destinatario {  get; set; }
        public int id_transacao { get; set; }
    }
}
