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
    [RoutePrefix("usuario")]
    public class UsuarioController : ApiController
    {
        [HttpGet]
        [Route("all")]
        public List<Usuario> All()
        {
            return new UsuarioBLL().All();
        }
    }
}
