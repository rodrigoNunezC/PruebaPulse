using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPulse.BE
{
   public class Invitado
    {
        public Guid Id { get; set; }
        public string Correo { get; set; }
        public int? EstadoId { get; set; }
        public Guid? EventoId { get; set; }

        public Invitado()
        {

        }
    }

   
}
