using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaPulse.DAL;


using Evento = PruebaPulse.BE.Evento;
using EventoEF = PruebaPulse.DAL.Evento;

namespace PruebaPulse.BLL
{
    public class EventoBLL
    {

        private Evento MapFromDataSourceToEntity(EventoEF source)
        {
            var evento = new Evento();
            var invitadoBLL = new InvitadoBLL();

            evento.Id = source.Id;
            evento.FechaInicio = source.FechaInicio;
            evento.Descripcion = source.Descripcion;
            evento.Titulo = source.Titulo;

            source.Invitado.ToList().ForEach(c => evento.Invitados.Add(invitadoBLL.MapFromDataSourceToEntity(c)));
           

            return evento;
        }

        private EventoEF MapFromEntityToDataSource(Evento entity)  
        {
            var eventoEF = new EventoEF();

            eventoEF.Id = entity.Id;
            eventoEF.FechaInicio = entity.FechaInicio;
            eventoEF.Descripcion = entity.Descripcion;
            eventoEF.Titulo = entity.Titulo;



            return eventoEF;
        }


        public List<Evento> All()
        {
            try
            {
                using (var ctx = new PruebaPulseEntities()) 
                {

                    var eventos = new List<Evento>();
                    ctx.Evento.ToList().ForEach(c => eventos.Add(MapFromDataSourceToEntity(c)));

                    return eventos;
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }

    }
}
