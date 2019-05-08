using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPulse.BE
{
  public class Usuario
    {

        public Guid Id { get; set; }
        public string Nombres { get; set; }
        public string ApellidPaterno { get; set; }
        public string Correo { get; set; }

        public Usuario()
        {

          
        }

    }
}
