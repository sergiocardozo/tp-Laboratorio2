using LogicApp.Comun;
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
    public partial class ListaVideoJuegoForm : Form
    {
        SistemaDAO sistema = new SistemaDAO();
        Empresa empresa = new Empresa();
        public ListaVideoJuegoForm()
        {
            InitializeComponent();
        }

        private void ListaVideoJuegoForm_Load(object sender, EventArgs e)
        {

            dataGListaJuegos.DataSource = sistema.MostrarVideoJuegos();
            cmbTipoJuegos.DataSource = sistema.ObtenerTiposVideoJuegos();
            cmbTipoJuegos.SelectedItem = cmbTipoJuegos.SelectedValue;
            cmbTipoJuegos.DisplayMember = "NombreTipoJuego";
            cmbTipoJuegos.ValueMember = "IdTipoJuego";

            cmbTipoJuegos.Text = "<--Tipo de Juegos-->";
            dataGListaJuegos.Columns[0].Visible = false;
            dataGListaJuegos.Columns[4].Visible = false;
            dataGListaJuegos.Columns[5].Visible = false;

            dataGListaJuegos.Columns[1].HeaderText = "NOMBRE VIDEOJUEGO";
            dataGListaJuegos.Columns[2].HeaderText = "PRECIO";
            dataGListaJuegos.Columns[3].HeaderText = "STOCK";
            dataGListaJuegos.Columns[4].HeaderText = "TIPO JUEGO";
            btnBorrarSeleccion.Visible = false;
            btnBorrarJuego.Visible = false;
            btnModificarJuego.Visible = false;
            btnCancelar.Visible = false;
        }

        private void dataGListaJuegos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtVideoJuego.Text = dataGListaJuegos.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPrecio.Text = dataGListaJuegos.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtStock.Text = dataGListaJuegos.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbTipoJuegos.Text = dataGListaJuegos.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtVideoJuego.Enabled = false;
                cmbTipoJuegos.Enabled = false;
                btnBorrarSeleccion.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Agrega un VideoJuego a la lista verificando que no este previamente cargado y lo carga en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsBtnGuardar_Click(object sender, EventArgs e)
        {
            int idTipoJuego = Convert.ToInt32(cmbTipoJuegos.SelectedValue);
            string nombreTipoJuego = cmbTipoJuegos.Text;
            int idJuego = 0;
            double precio;
            int stock;
            int.TryParse(txtStock.Text, out stock);
            double.TryParse(txtPrecio.Text, out precio);
            VideoJuego juego = new VideoJuego(idTipoJuego, nombreTipoJuego, idJuego++, txtVideoJuego.Text, precio, stock, idTipoJuego);

            if (!(txtVideoJuego.Text == ""))
            {
                if (!(txtPrecio.Text == ""))
                {
                    if (!(txtStock.Text == ""))
                    {
                        if (!(cmbTipoJuegos.Items == null))
                        {
                            try
                            {
                                empresa += juego;
                                if (dataGListaJuegos.RowCount > 0)
                                {
                                    bool existe = false;
                                    for (int i = 0; i < dataGListaJuegos.RowCount; i++)
                                    {
                                        if (dataGListaJuegos.Rows[i].Cells[1].Value.ToString() == txtVideoJuego.Text)
                                        {
                                            MessageBox.Show("El Juego ya existe");
                                            existe = true;
                                            break;
                                        }
                                    }
                                    if (existe == false)
                                    {
                                        sistema.InsertarVideoJuego(txtVideoJuego.Text, precio, stock, Convert.ToInt32(cmbTipoJuegos.SelectedValue));
                                        dataGListaJuegos.DataSource = sistema.MostrarVideoJuegos();
                                        MessageBox.Show("Juego Agregado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                }
                            }
                            catch (SistemaVentasException ex)
                            {

                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                            MessageBox.Show("Ingresar tipo de juego");
                    }
                    else
                        MessageBox.Show("Ingresar stock del juego");
                }
                else
                    MessageBox.Show("Ingresar Precio de juego");
            }
            else
                MessageBox.Show("Ingresar nombre de juego");
        }

        private void tsBtnModificar_Click(object sender, EventArgs e)
        {
            btnModificarJuego.Visible = true;
            btnCancelar.Visible = true;
            tsBtnGuardar.Enabled = false;
            tsBtnBorrar.Enabled = false;
            txtVideoJuego.Enabled = false;
            cmbTipoJuegos.Enabled = false;
        }

        private void btnModificarJuego_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"¿Seguro desea modificar el juego {txtVideoJuego.Text}?", "Modificar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                sistema.ModificarVideoJuego(txtVideoJuego.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtStock.Text));
                dataGListaJuegos.DataSource = sistema.MostrarVideoJuegos();

            }
            btnModificarJuego.Visible = false;
        }

        private void tsBtnBorrar_Click(object sender, EventArgs e)
        {
            btnBorrarJuego.Visible = true;            
            btnCancelar.Visible = true;
            tsBtnGuardar.Enabled = false;
            tsBtnModificar.Enabled = false;
            txtVideoJuego.Enabled = false;
            cmbTipoJuegos.Enabled = false;
        }

        private void btnBorrarJuego_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro desea borrar el Juego?", "Borrar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                sistema.BorrarJuego(txtVideoJuego.Text);
                dataGListaJuegos.DataSource = sistema.MostrarVideoJuegos();
            }
            btnBorrarJuego.Visible = false;
        }
        private void btnBorrarSeleccion_Click(object sender, EventArgs e)
        {
            txtPrecio.Clear();
            txtStock.Clear();
            txtVideoJuego.Clear();
            cmbTipoJuegos.Text = "<--Tipo de Juegos-->";
            txtVideoJuego.Enabled = true;
            cmbTipoJuegos.Enabled = true;
            btnBorrarSeleccion.Visible = false;

        }
        private void tsBtnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnBorrarJuego.Visible = false;
            btnCancelar.Visible = false;
            txtVideoJuego.Enabled = true;
            cmbTipoJuegos.Enabled = true;
            btnBorrarSeleccion.Visible = false;
            btnModificarJuego.Visible = false;
            tsBtnGuardar.Enabled = true;
            tsBtnModificar.Enabled = true;
            tsBtnBorrar.Enabled = true;
            txtPrecio.Clear();
            txtStock.Clear();
            txtVideoJuego.Clear();
            cmbTipoJuegos.Text = "<--Tipo de Juegos-->";
        }
    }
}
