using LogicApp.Comun;
using LogicApp.Entidades;
using LogicApp.PersistenciaDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaForm
{
    public partial class ClientesForm : Form
    {
        public delegate void LimpiarTextbox();
        public event LimpiarTextbox Limpiar;
        Empresa empresa;
        SistemaDAO sistema;

        public ClientesForm()
        {
            InitializeComponent();
            sistema = new SistemaDAO();
            empresa = new Empresa();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            dataGClientes.DataSource = sistema.MostrarClientes();
            dataGClientes.Columns[0].Visible = false;
            dataGClientes.Columns[1].HeaderText = "ID SOCIO";
            dataGClientes.Columns[2].HeaderText = "NOMBRE";
            dataGClientes.Columns[3].HeaderText = "APELLIDO";
            btnBorrarCliente.Visible = false;
            btnModificarCliente.Visible = false;
            btnBorrarSeleccion.Visible = false;
            btnCancelar.Visible = false;
        }
        /// <summary>
        /// Inserta un elemento en la grilla y en la base de datos si el Cliente cumple las condiciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsBtnGuardar_Click(object sender, EventArgs e)
        {
            int id = 0;

            Cliente cliente = new Cliente(id++, txtIDSocio.Text, txtNombre.Text, txtApellido.Text);

            if (!(txtIDSocio.Text == ""))
            {
                if (!(txtNombre.Text == ""))
                {
                    if (!(txtApellido.Text == ""))
                    {
                        try
                        {
                            this.empresa += cliente;
                            if (dataGClientes.RowCount > 0)
                            {
                                bool existe = false;
                                for (int i = 0; i < dataGClientes.RowCount; i++)
                                {
                                    if (dataGClientes.Rows[i].Cells[1].Value.ToString() == txtIDSocio.Text ||
                                        dataGClientes.Rows[i].Cells[2].Value.ToString() == txtNombre.Text &&
                                        dataGClientes.Rows[i].Cells[3].Value.ToString() == txtApellido.Text)
                                    {
                                        MessageBox.Show("El Cliente ya ha sido ingresado");
                                        existe = true;
                                        break;
                                    }
                                }
                                if (existe == false)
                                {
                                    sistema.InsertarCliente(txtIDSocio.Text, txtNombre.Text, txtApellido.Text);
                                    dataGClientes.DataSource = sistema.MostrarClientes();
                                    MessageBox.Show("Cliente Agregado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        catch (SistemaVentasException ex)
                        {

                            MessageBox.Show(ex.Message);
                        }

                    }
                    else
                        MessageBox.Show("Debe Ingresar Apellido de socio");
                }
                else
                    MessageBox.Show("Debe Ingresar Nombre de socio");
            }
            else
                MessageBox.Show("Debe Ingresar numero de socio");
        }
        /// <summary>
        /// Cierra el formulario al presionar el boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsBtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Evento que al seleccionar una fila de la grilla lo muestra en los textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                txtIDSocio.Text = dataGClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNombre.Text = dataGClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtApellido.Text = dataGClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtIDSocio.Enabled = false;
                btnBorrarSeleccion.Visible = true;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Al presionar el boton modificar de la barra te permite solo modificar un cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsBtnModificar_Click(object sender, EventArgs e)
        {
            btnModificarCliente.Visible = true;
            btnCancelar.Visible = true;
            tsBtnBorrarCliente.Enabled = false;
            tsBtnGuardar.Enabled = false;
        }
        /// <summary>
        /// Modifica el cliente seleccionado de la grilla 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModificarCliente_Click(object sender, EventArgs e)
        {
            tsBtnBorrarCliente.Enabled = false;
            tsBtnGuardar.Enabled = false;


            DialogResult result = MessageBox.Show($"¿Seguro desea modificar el cliente {txtApellido.Text}, {txtNombre.Text}?", "Modificar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                sistema.ModificarCliente(txtIDSocio.Text, txtNombre.Text, txtApellido.Text);
                dataGClientes.DataSource = sistema.MostrarClientes();
            }
            LimpiarSeleccion();


        }
        /// <summary>
        /// Al presionar el boton Borrar solo te permite Borrar un cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsBtnBorrarCliente_Click(object sender, EventArgs e)
        {
            btnBorrarCliente.Visible = true;
            btnCancelar.Visible = true;
            tsBtnGuardar.Enabled = false;
            tsBtnModificar.Enabled = false;
        }
        /// <summary>
        /// Borra un cliente seleccionado de la grilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show($"¿Seguro desea borrar el Cliente {txtApellido.Text}, {txtNombre.Text}?", "Borrar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                sistema.BorrarCliente(txtIDSocio.Text);
                dataGClientes.DataSource = sistema.MostrarClientes();
            }
            LimpiarSeleccion();
        }
        /// <summary>
        /// Al presionar el boton limpia los textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrarSeleccion_Click(object sender, EventArgs e)
        {
            LimpiarSeleccion();
        }
        /// <summary>
        /// Metodo que limpia los datos ingresados en los textbox
        /// </summary>
        private void LimpiarSeleccion()
        {
            txtIDSocio.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtIDSocio.Enabled = true;
            btnBorrarSeleccion.Visible = false;
        }
        /// <summary>
        /// Al presionar el boton deja el formulario para realizar todas las acciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnModificarCliente.Visible = false;
            btnBorrarCliente.Visible = false;
            btnCancelar.Visible = false;
            tsBtnModificar.Enabled = true;
            tsBtnGuardar.Enabled = true;
            tsBtnBorrarCliente.Enabled = true;
            LimpiarSeleccion();
        }
    }
}
