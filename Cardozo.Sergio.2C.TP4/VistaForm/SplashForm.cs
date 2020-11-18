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
    public partial class SplashForm : Form
    {
        delegate void CambiarProgresoDelegate(string texto, int valor);

        public delegate void Mensaje(string mensaje);
        public event Mensaje Msg;
        
        Thread thread;
        public SplashForm()
        {
            InitializeComponent();

            timer.Start();
            IniciarConteo();
            
        }
        /// <summary>
        /// Metodo que inicializa el subproceso
        /// </summary>
        private void IniciarConteo()
        {
            thread = new Thread(new ThreadStart(ProgresoBarra));
            thread.Start();

        }
        /// <summary>
        /// Metodo que empieza a hacer el conteo de 0 a 100 y lo va mostrando en el label
        /// </summary>
        private void ProgresoBarra()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(50);
                CambiarProceso(string.Format($"Progreso {i}%"), i);
            }
        }
        /// <summary>
        /// Al aumentar el valor en 1 de la progressbar va a cambiar el texto del label
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="valor"></param>
        private void CambiarProceso(string texto, int valor)
        {
            if (this.pBarraProgreso.InvokeRequired)
            {
                CambiarProgresoDelegate delegado = new CambiarProgresoDelegate(CambiarProceso);
                object[] parametro = new object[] { texto, valor };
                this.Invoke(delegado, parametro);
            }
            else
            {
                pBarraProgreso.Value = valor;
                lblProgreso.Text = texto;
            }
        }
        /// <summary>
        /// Cuando la barra llega a 100 cierra el formulario y detiene la progressbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (pBarraProgreso.Value == 100)
            {
                timer.Stop();
                Msg += MensajeFinalizado;
                this.Close();
            }
        }

        private void MensajeFinalizado(string mensaje)
        {
            mensaje = string.Format($"Bienvenido al sistema de ventas PlayforFun");
            MessageBox.Show(Msg(mensaje));
        }
        private void SplashForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (thread.ThreadState != ThreadState.Aborted)
                thread.Abort();
        }

      
    }
}
