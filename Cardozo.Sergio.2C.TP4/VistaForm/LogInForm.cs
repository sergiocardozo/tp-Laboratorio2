using LogicApp.Entidades;
using LogicApp.PersistenciaDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaForm
{
    public partial class LogInForm : Form
    {        
        public LogInForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Al presionar el boton accede a la base de datos para verificar que el usuario es correcto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "NombreDeUsuario" && txtUsuario.TextLength > 2)
            {
                if (txtContraseña.Text != "Contraseña")
                {
                    SistemaDAO user = new SistemaDAO();
                    bool validarLogin = user.Login(txtUsuario.Text, txtContraseña.Text);
                    if (validarLogin == true)
                    {
                        PrincipalForm frmPrincipal = new PrincipalForm();
                        frmPrincipal.Show();                       
                        frmPrincipal.FormClosed += LogOut;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Nombre de Usuario o Contraseña Incorrecta. Vuelva a Ingresar");
                        txtContraseña.Text = "";
                        txtContraseña.UseSystemPasswordChar = false;
                        txtUsuario.Focus();
                    }
                }
                else
                    msgError("Por Favor, Ingresar Contraseña");
            }
            else
                msgError("Por Favor, Ingresar Usuario");
        }
        /// <summary>
        /// Va a imprimir en el label el mensaje de error
        /// </summary>
        /// <param name="mensaje"></param>
        private void msgError(string mensaje)
        {
            lblMensajeError.Text = "     " + mensaje;

        }
        /// <summary>
        /// Metodo para asociar el evento Closed del formulario principal al LogOut
        /// Limpia los textbox y muestra este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogOut(object sender, FormClosedEventArgs e)
        {
            lblMensajeError.Visible = true;
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtContraseña.UseSystemPasswordChar = false;
            this.Show();
        }
    }
}
