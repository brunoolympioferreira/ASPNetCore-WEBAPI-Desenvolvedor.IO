using DevIo.Api.Controllers;
using DevIO.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace DevIo.Api.V2.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/teste")]
    public class TesteController : MainController

    {
        public TesteController(INotificador notificador, IUser appUser) : base(notificador, appUser)
        {
        }

        [HttpGet]
        public string Valor()
        {

            //throw new Exception("Error");

            //try
            //{
            //    var i = 0;
            //    var result = 42 / i;
            //}
            //catch (DivideByZeroException e)
            //{
            //    e.Ship(HttpContext);
            //}

            //_logger.LogTrace("Log de Trace");
            //_logger.LogDebug("Log de Debug");
            //_logger.LogInformation("Log de Informação");
            //_logger.LogWarning("Log de Aviso");
            //_logger.LogError("Log de Erro");
            //_logger.LogCritical("Log de Problema Critico");

            return "Sou a V2";
        }
    }
}
