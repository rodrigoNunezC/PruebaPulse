using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Usuario = PruebaPulse.BE.Usuario;

namespace PruebaPulse.UI
{
    public partial class Evento : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
                string url = "http://localhost:51999/usuario/all";
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = "GET";
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);

                    JArray JsonResponse = JArray.Parse(reader.ReadToEnd());
                    List<PruebaPulse.BE.Usuario> usuarios = new List<PruebaPulse.BE.Usuario>();

                    foreach (var usuarioJSON in JsonResponse)
                    {
                        PruebaPulse.BE.Usuario usuario = new PruebaPulse.BE.Usuario();
                        usuarios.Add(JsonConvert.DeserializeObject<PruebaPulse.BE.Usuario>(usuarioJSON.ToString()));
                    }

                    foreach (var usuario in usuarios)
                    {
                        dropDownUsuarios.Items.Add(new ListItem(usuario.Nombres.ToString(), usuario.Id.ToString()));
                    }
                    reader.Close();
                    dataStream.Close();

                
            }
        }

        protected void BtnGuardarEvento_Click(object sender, EventArgs e)
        {


        }
    }
}