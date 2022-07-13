using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace CooperativaGuastaFacil.Entidad
{
    class User
    {
        public string Id_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha_Nac { get; set; }
        public string Id_Cuenta { get; set; }
        public string Saldo { get; set; }
        public string Id_Tipo_C { get; set; }

        public String Guardar(User Usuario)
        {
            String Respuesta;

            var Request = (HttpWebRequest)WebRequest.Create("http://webapibanco.azurewebsites.net/api/CliCuenta");
            try
            {
                Request.ContentType = "application/json";
                Request.Method = "POST";

                using (var streamwriter = new StreamWriter(Request.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(Usuario);
                    streamwriter.Write(json);
                }
                var response = (HttpWebResponse)Request.GetResponse();

                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    Respuesta = result.ToString();
                }
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            return Respuesta;
        }
    }

}
