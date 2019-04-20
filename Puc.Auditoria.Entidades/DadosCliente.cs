using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puc.Auditoria.Entidades
{
    public class DadosCliente
    {
        public int IdCliente { get; set; }
        public string NumeroCartao { get; set; }
        public bool ClienteSuspeito { get; set; }
    }
}
