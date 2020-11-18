using LogicApp.Entidades;
using LogicApp.PersistenciaDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaForm
{
    public partial class VentasForm : Form
    {
        SistemaDAO sistema = new SistemaDAO();

        int idCliente;
        public VentasForm()
        {
            InitializeComponent();
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            dataGClientes.DataSource = sistema.MostrarClientes();
            dataGClientes.Columns[0].Visible = false;
            dataGClientes.Columns[1].HeaderText = "ID SOCIO";
            dataGClientes.Columns[2].HeaderText = "NOMBRE";
            dataGClientes.Columns[3].HeaderText = "APELLIDO";

            lvClienteSeleccionado.View = View.Details;
            lvClienteSeleccionado.Columns.Add("ID SOCIO", 100);
            lvClienteSeleccionado.Columns.Add("NOMBRE", 150);
            lvClienteSeleccionado.Columns.Add("APELLIDO", 150);

            lvVideoJuegos.View = View.Details;
            lvVideoJuegos.Columns.Add("ID VIDEO JUEGO", 100);
            lvVideoJuegos.Columns.Add("NOMBRE VIDEO JUEGO", 150);
            lvVideoJuegos.Columns.Add("TIPO VIDEO JUEGO", 150);
            lvVideoJuegos.Columns.Add("PRECIO", 80);
            lvVideoJuegos.Columns.Add("STOCK", 100);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGClientes.CurrentRow != null)
                {
                    ListViewItem item = new ListViewItem(this.dataGClientes.CurrentRow.Cells[0].Value.ToString());
                    item.SubItems.Add(this.dataGClientes.CurrentRow.Cells[2].Value.ToString());
                    item.SubItems.Add(this.dataGClientes.CurrentRow.Cells[3].Value.ToString());

                    lvClienteSeleccionado.Items.Add(item);
                    idCliente = Convert.ToInt32(dataGClientes.CurrentRow.Cells[0].Value.ToString());
                    btnAgregar.Enabled = false;
                    btnCancelar.Enabled = true;


                    List<VideoJuego> videoJuegos = new List<VideoJuego>();
                    videoJuegos = sistema.MostrarVideoJuegos();

                    foreach (VideoJuego videos in videoJuegos)
                    {
                        ListViewItem it = new ListViewItem(videos.Id.ToString());
                        it.SubItems.Add(videos.NombreVideoJuego.ToString());
                        it.SubItems.Add(videos.NombreTipoJuego.ToString());
                        it.SubItems.Add(videos.Precio.ToString());
                        it.SubItems.Add(videos.Stock.ToString());
                        lvVideoJuegos.Items.Add(it);
                    }
                }
                else
                {
                    MessageBox.Show("Debe Seleccionar un cliente", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lvClienteSeleccionado.Clear();
            lvClienteSeleccionado.View = View.Details;
            lvClienteSeleccionado.Columns.Add("ID SOCIO", 100);
            lvClienteSeleccionado.Columns.Add("NOMBRE", 150);
            lvClienteSeleccionado.Columns.Add("APELLIDO", 150);

            lvVideoJuegos.Clear();
            lvVideoJuegos.View = View.Details;
            lvVideoJuegos.Columns.Add("ID VIDEO JUEGO", 100);
            lvVideoJuegos.Columns.Add("NOMBRE VIDEO JUEGO", 150);
            lvVideoJuegos.Columns.Add("TIPO VIDEO JUEGO", 150);
            lvVideoJuegos.Columns.Add("PRECIO", 80);
            lvVideoJuegos.Columns.Add("STOCK", 100);

            btnAgregar.Enabled = true;
            btnCancelar.Enabled = false;
            btnAgregar.Focus();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {

            if (lvClienteSeleccionado.CheckedIndices.Count > 0 && lvVideoJuegos.CheckedIndices.Count > 0)
            {
                DateTime fechaVenta;
                fechaVenta = DateTime.Now;
                double precio;
                int idVideoJuego;
                int stock = 1;
                string nombreJuego;

                for (int i = 0; i <= lvVideoJuegos.CheckedItems.Count - 1; i++)
                {
                    if (Convert.ToInt32(lvVideoJuegos.CheckedItems[i].SubItems[4].Text) > 0)
                    {
                        DialogResult resp = MessageBox.Show("¿Desea vender este juego?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resp == DialogResult.Yes)
                        {
                            idVideoJuego = Convert.ToInt32(lvVideoJuegos.CheckedItems[i].Text);
                            nombreJuego = lvVideoJuegos.CheckedItems[i].SubItems[1].Text;
                            precio = Convert.ToDouble(lvVideoJuegos.CheckedItems[i].SubItems[3].Text);

                            sistema.DescontarStock(stock, nombreJuego);
                            sistema.InsertarVenta(idCliente, idVideoJuego, fechaVenta, precio);
                        }
                        lvClienteSeleccionado.Clear();
                        lvClienteSeleccionado.View = View.Details;
                        lvClienteSeleccionado.Columns.Add("ID SOCIO", 100);
                        lvClienteSeleccionado.Columns.Add("NOMBRE", 150);
                        lvClienteSeleccionado.Columns.Add("APELLIDO", 150);

                        lvVideoJuegos.Clear();
                        lvVideoJuegos.View = View.Details;
                        lvVideoJuegos.Columns.Add("ID VIDEO JUEGO", 100);
                        lvVideoJuegos.Columns.Add("NOMBRE VIDEO JUEGO", 150);
                        lvVideoJuegos.Columns.Add("TIPO VIDEO JUEGO", 150);
                        lvVideoJuegos.Columns.Add("PRECIO", 80);
                        lvVideoJuegos.Columns.Add("STOCK", 100);

                        btnAgregar.Enabled = true;
                        btnCancelar.Enabled = false;
                        btnAgregar.Focus();
                    }
                    else
                        MessageBox.Show("No tenes stock de este juego");
                }
            }
            else
                MessageBox.Show("Debe selecciona un Juego o un cliente", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void txtFiltraPorCodigo_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtFiltraPorCodigo.Text;
            
            dataGClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGClientes.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
                txtFiltraPorCodigo.Clear();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void tsBtnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
