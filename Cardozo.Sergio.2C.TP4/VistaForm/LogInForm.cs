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
        private void msgError(string mensaje)
        {
            lblMensajeError.Text = "     " + mensaje;

        }
        public void LogOut(object sender, FormClosedEventArgs e)
        {
            
            lblMensajeError.Visible = true;
            txtContraseña.Clear();
            txtUsuario.Clear();
            txtContraseña.UseSystemPasswordChar = false;
            this.Show();
        }
    }
}
