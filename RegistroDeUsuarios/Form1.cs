using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroDeUsuarios.Entidad;

namespace RegistroDeUsuarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            User objUsuario = new User();
            objUsuario.login = txtLogin.Text;
            objUsuario.Nombre = txtNombre.Text;
            objUsuario.Apellido = txtApellido.Text;
            objUsuario.Correo = txtCorreo.Text;
            objUsuario.Genero = rdMasculino.Checked ? "M" : (rdFemenino.Checked ? "F" : "");
            objUsuario.Telefono = txtTelefono.Text;
            objUsuario.Celular = txtCelular.Text;
            objUsuario.Direccion = txtDireccion.Text;
            objUsuario.WebSite = txtWebSite.Text;
            objUsuario.Fecha_Nac = dateTimePicker1.Value;
            objUsuario.url_Imagen = txtWebSite.Text;
            objUsuario.password_actual = txtPassActual.Text;
            objUsuario.password = txtNewPass.Text;

            String mirespuesta = objUsuario.Guardar(objUsuario);
            MessageBox.Show(mirespuesta);
        }
    }
}
