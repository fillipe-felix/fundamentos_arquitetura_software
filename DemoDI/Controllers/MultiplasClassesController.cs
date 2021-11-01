using System;
using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class MultiplasClassesController : Controller
    {
        private readonly Func<string, IService> _serviceAcessor;

        public MultiplasClassesController(Func<string, IService> serviceAcessor)
        {
            _serviceAcessor = serviceAcessor;
        }

        public string Index()
        {
            return _serviceAcessor("A").Retorno();
            //return _serviceAcessor("B").Retorno();
            //return _serviceAcessor("C").Retorno();
        }
    }
}