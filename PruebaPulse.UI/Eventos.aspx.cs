using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

using Evento = PruebaPulse.BE.Evento;

namespace PruebaPulse.UI
{
    public partial class Eventos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string url = "http://localhost:51999/evento/all";
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = "GET";
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    //var test = reader.ReadToEnd();

                    JArray JsonResponse = JArray.Parse(reader.ReadToEnd());
                    List<PruebaPulse.BE.Evento> eventos = new List<PruebaPulse.BE.Evento>();

                    foreach (var eventoJSON in JsonResponse)
                    {
                        eventos.Add(JsonConvert.DeserializeObject<PruebaPulse.BE.Evento>(eventoJSON.ToString()));
                    }

                    GridEventos.DataSource = eventos;
                    GridEventos.DataBind();

                    reader.Close();
                    dataStream.Close();
                }
            }

        
        }

        protected void BtnNuevoEvento_Click(object sender, EventArgs e)
        {
            Response.Redirect("Evento.aspx");
        }
    }
}