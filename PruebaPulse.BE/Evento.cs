using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPulse.BE
{
    public class Evento
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public Usuario  CreadoPor { get; set; }

        public List<Invitado> Invitados { get; set; }

        public Evento()
        {
            Invitados = new List<Invitado>();
            CreadoPor = new Usuario();
        }

    }
}
