using Puc.Auditoria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puc.Auditoria.Negocio.Mock
{
    public static class DadosClientesMock
    {
        public static List<DadosCliente> DadosClientes = new List<DadosCliente>()
        {
            new DadosCliente
            {
                ClienteSuspeito = false,
                IdCliente = 1,
                NumeroCartao = "1111222233334444",
            },
            new DadosCliente
            {
                ClienteSuspeito = true,
                IdCliente = 2,
                NumeroCartao = "1111222233335555",
            }
        };
    }
}
