using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PruebaPulse.BE;
using PruebaPulse.BLL;

namespace API.Controllers
{
    [RoutePrefix("evento")]
    public class EventoController : ApiController
    {

        [HttpGet]
        [Route("all")]
        public List<Evento> All()
        {
            return new EventoBLL().All();
        }

        //[HttpPost]
        //[Route("create")]
        ////[Authorize]
        //public void Create(Evento entity)
        //{
        //    new EventoBLL().Create(ref entity);
        //}


    }
}
