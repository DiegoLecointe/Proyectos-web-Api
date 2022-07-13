using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;

namespace RegistroDeUsuarios.Entidad
{
    class User
    {
        public string login { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public string WebSite { get; set; }
        public DateTime Fecha_Nac { get; set; }
        public string url_Imagen { get; set; }
        public string password_actual { get; set; }
        public string password { get; set; }

        public string Guardar(User objUsuario) {

            string respuesta;

            var request = (HttpWebRequest)WebRequest.Create("http://svr-moria.azurewebsites.net/api/usuario/InsertUser");

            try
            {
                request.ContentType = "application/json";
                request.Method = "POST";

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(objUsuario);
                    streamWriter.Write(json);
                }

                var reponse = (HttpWebResponse)request.GetResponse();

                using (var streamReader = new StreamReader(reponse.GetResponseStream())) 
                {
                    var result = streamReader.ReadToEnd();
                    respuesta = result.ToString();
                }

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            return respuesta;
        }

    }
}
