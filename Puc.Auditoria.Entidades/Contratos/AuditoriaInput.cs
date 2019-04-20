using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puc.Auditoria.Entidades.Contratos
{
    public class AuditoriaInput
    {
        public int IdCliente { get; set; }
        public string NumeroCartao { get; set; }
        public bool ClienteSuspeito { get; set; }
    }
}
