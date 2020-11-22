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
        private Empresa empresa;
        private SistemaDAO sistema;

        public ClientesForm()
        {
            InitializeComponent();
            sistema = new SistemaDAO();
            empresa = new Empresa();
        }
        /// <summary>
        /// Se inicializa el formulario y le doy formato a los datagrid extendiendo la clase DataGridView
        /// y muestro los datos que tengo en mi Base de dato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientesForm_Load(object sender, EventArgs e)
        {
            dataGClientes.FormatearGrid();

            dataGClientes.DataSource = sistema.MostrarClientes();

            dataGClientes.Columns[0].Visible = false;
            dataGClientes.Columns[1].HeaderText = "DNI";
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
                                    LimpiarSeleccion();
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
            foreach (DataGridViewRow item in dataGClientes.Rows)
            {
                if (dataGClientes.CurrentRow != null)
                {
                    DialogResult result = MessageBox.Show($"¿Seguro desea modificar el cliente {txtApellido.Text}, {txtNombre.Text}?", "Modificar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        sistema.ModificarCliente(txtIDSocio.Text, txtNombre.Text, txtApellido.Text);
                        dataGClientes.DataSource = sistema.MostrarClientes();
                        LimpiarSeleccion();
                    }
                    break;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Cliente de la grilla", "Atencion", MessageBoxButtons.OK);
                    break;
                }
            }

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
            txtApellido.Enabled = false;
            txtIDSocio.Enabled = false;
            txtNombre.Enabled = false;
        }
        /// <summary>
        /// Borra un cliente seleccionado de la grilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGClientes.Rows)
            {
                if (dataGClientes.CurrentRow.Index > 0)
                {                 
                    DialogResult result = MessageBox.Show($"¿Seguro desea borrar el Cliente {txtApellido.Text}, {txtNombre.Text}?", "Borrar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        sistema.BorrarCliente(txtIDSocio.Text);
                        dataGClientes.DataSource = sistema.MostrarClientes();
                        LimpiarSeleccion();
                    }
                    break;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Cliente de la grilla", "Atencion", MessageBoxButtons.OK);
                    break;                    
                }
            }
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
        /// Metodo que deja el formulario por defecto
        /// </summary>
        private void LimpiarSeleccion()
        {
            txtIDSocio.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            
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
            txtApellido.Enabled = true;
            txtIDSocio.Enabled = true;
            txtNombre.Enabled = true;
            LimpiarSeleccion();
        }
        /// <summary>
        /// Extiendo la clase KeyPressEventArgs para solo se podra ingresar numeros en el txtIdSocio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIDSocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.EsNumero();
        }

        /// <summary>
        /// Extiendo la clase KeyPressEventArgs para solo se podra ingresar Letras en el txtNombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.EsLetra(); 
        }
        /// <summary>
        /// Extiendo la clase KeyPressEventArgs para solo se podra ingresar Letras en el txtApellido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.EsLetra(); // METODO DE EXTENSION
        }


    }
}
