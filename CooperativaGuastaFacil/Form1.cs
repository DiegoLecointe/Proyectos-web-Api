using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CooperativaGuastaFacil.Entidad;

namespace CooperativaGuastaFacil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
{
            User Usuario = new User();

            Usuario.Id_Cliente = txtId_Cliente.Text;
            Usuario.Nombre = txtNombre.Text;
            Usuario.Apellido = txtApellido.Text;
            Usuario.Direccion = txtDireccion.Text;
            Usuario.Telefono = txtTelefono.Text;
            Usuario.Fecha_Nac = txtFecha_Nac.Value;
            Usuario.Id_Cuenta = txtId_Cuenta.Text;
            Usuario.Saldo = txtSaldo.Text;
            Usuario.Id_Tipo_C = rdBttnCuentaAhorro.Checked ? "1" : (rdBttnCuentaMonetaria.Checked ? "2" : "");

            String Respuesta = Usuario.Guardar(Usuario);
            MessageBox.Show(Respuesta);

        }
    }
}
