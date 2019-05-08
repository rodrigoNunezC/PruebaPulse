using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaPulse.DAL;


using Invitado = PruebaPulse.BE.Invitado;
using InvitadoEF = PruebaPulse.DAL.Invitado;


namespace PruebaPulse.BLL
{
   public  class InvitadoBLL
    {

        public Invitado MapFromDataSourceToEntity(InvitadoEF source)
        {
            var invitado = new Invitado();


            invitado.Id = source.Id;
            invitado.Correo = source.Correo;
            invitado.EventoId = source.EventoId;
            invitado.EstadoId = source.EstadoId;
         

            return invitado;
        }

        public InvitadoEF MapFromEntityToDataSource(Invitado entity)
        {
            var invitadoEF = new InvitadoEF();

            invitadoEF.Id = entity.Id;
            invitadoEF.Correo = entity.Correo;
            invitadoEF.EventoId = entity.EventoId;
            invitadoEF.EstadoId = entity.EstadoId;

            return invitadoEF;
        }


        public List<Invitado> All()
        {
            try
            {
                using (var ctx = new PruebaPulseEntities())
                {

                    var invitados = new List<Invitado>();
                    ctx.Invitado.ToList().ForEach(c => invitados.Add(MapFromDataSourceToEntity(c)));

                    return invitados;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
