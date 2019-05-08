using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaPulse.DAL;
using Usuario = PruebaPulse.BE.Usuario;
using UsuarioEF = PruebaPulse.DAL.Usuario;

namespace PruebaPulse.BLL
{
   public class UsuarioBLL
    {
        private Usuario MapFromDataSourceToEntity(UsuarioEF source)
        {
            var usuario = new Usuario();

            usuario.Id = source.Id;
            usuario.ApellidPaterno = source.ApellidoPaterno;
            usuario.Correo = source.Correo;
            usuario.Nombres = source.Nombres;



            return usuario;
        }

        private UsuarioEF MapFromEntityToDataSource(Usuario entity)
        {
            var usuarioEF = new UsuarioEF();

            usuarioEF.Id = entity.Id;
            usuarioEF.Correo = entity.Correo;
            usuarioEF.Nombres = entity.Nombres;
            usuarioEF.ApellidoPaterno = entity.ApellidPaterno;

            return usuarioEF;
        }


        public List<Usuario> All()
        {
            try
            {
                using (var ctx = new PruebaPulseEntities())
                {

                    var usuarios = new List<Usuario>();
                    ctx.Usuario.ToList().ForEach(c => usuarios.Add(MapFromDataSourceToEntity(c)));

                    return usuarios;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
