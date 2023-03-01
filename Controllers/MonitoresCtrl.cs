using Microsoft.AspNetCore.Mvc;
using Monitores_WebApp.Entities;

namespace Monitores_WebApp.Controllers
{
    [ApiController]
    [Route("api/monitores")]
    public class MonitoresCtrl:ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Monitors>> Get()
        {
            return new List<Monitors>()
            {
                new Monitors() {Id = 1, Marca = "LB", Frecuencia = "60hz", Pulgadas = "9", Resolución = "4K", Precio = 789},

                new Monitors() {Id = 2, Marca = "FF", Frecuencia = "50hz", Pulgadas = "10", Resolución = "1080p", Precio = 900}
            };
        }
    }
}
