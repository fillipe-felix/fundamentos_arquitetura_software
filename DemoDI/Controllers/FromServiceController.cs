using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class FromServiceController : Controller
    {
        public void Index([FromServices] IClienteService clienteService)
        {
            clienteService.AdicionarCliente(new Cliente());
        }
    }
}