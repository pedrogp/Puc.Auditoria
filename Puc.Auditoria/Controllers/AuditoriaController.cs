using Puc.Auditoria.Entidades;
using Puc.Auditoria.Entidades.Contratos;
using Puc.Auditoria.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Puc.Auditoria.Controllers
{
    [Route("api/Auditorias")]
    public class AuditoriaController : ApiController
    {
        AuditoriaBll _auditoriaBll = new AuditoriaBll();

        //Método criado apenas para efeitos de testes. Estes dados não seriam expostos em uma aplicação real.
        public IEnumerable<DadosCliente> Get()
        {
            return _auditoriaBll.ListarDadosClientes();
        }

        public bool Post(AuditoriaInput input)
        {
            return _auditoriaBll.VerificarAtividadeCliente(input.IdCliente, input.NumeroCartao);
        }
    }
}
