using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaForm
{
    public partial class PrincipalForm : Form
    {
        Thread thread;
        
        public PrincipalForm()
        {
            SplashForm form = new SplashForm();
            form.ShowDialog();
            InitializeComponent();            
        }
        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            InicializarFechaHora();
        }

        /// <summary>
        /// Inicializa el hilo que mantiene actualizada la fecha y la hora.
        /// </summary>
        private void InicializarFechaHora()
        {
            thread = new Thread(ActualizarFechaHora);
            thread.Start();
        }
        /// <summary>
        /// Actualiza el label lblFechaHora con la fecha y hora actual cada 1 segundo.
        /// </summary>
        private void ActualizarFechaHora()
        {
            while (true)
            {
                if (this.lblFechayHora.InvokeRequired)
                {
                    this.lblFechayHora.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.lblFechayHora.Text = DateTime.Now.ToString();
                    });
                }
                else
                {
                    this.lblFechayHora.Text = DateTime.Now.ToString();
                }

                Thread.Sleep(1000);
            }
        }
        private void tsBtnCliente_Click(object sender, EventArgs e)
        {
            ClientesForm formClientes = new ClientesForm();
            formClientes.ShowDialog();
            
        }

        private void tsBtn_VideoJuegos_Click(object sender, EventArgs e)
        {
            ListaVideoJuegoForm frm = new ListaVideoJuegoForm();
            frm.ShowDialog();
        }

        private void tsBtnVentas_Click(object sender, EventArgs e)
        {
            VentasForm frm = new VentasForm();
            frm.ShowDialog();
        }        

        private void tsBtnHistorialVentas_Click(object sender, EventArgs e)
        {
            HistorialVentasForm form = new HistorialVentasForm();
            form.ShowDialog();
        }

        private void tsBtnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread.ThreadState != ThreadState.Aborted)
                thread.Abort();
        }

        
    }
}
