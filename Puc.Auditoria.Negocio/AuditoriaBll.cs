using Puc.Auditoria.Entidades;
using Puc.Auditoria.Negocio.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puc.Auditoria.Negocio
{
    public class AuditoriaBll
    {
        public IEnumerable<Auditoria.Entidades.DadosCliente> ListarDadosClientes()
        {
            return DadosClientesMock.DadosClientes;
        }

        public bool VerificarAtividadeCliente(int idCliente, string cartao)
        {
            var dadosCliente = DadosClientesMock.DadosClientes.FirstOrDefault(dados => dados.IdCliente == idCliente);

            if (dadosCliente.ClienteSuspeito || dadosCliente.NumeroCartao != cartao)
            {
                return false;
            }

            return true;
        }
    }
}
