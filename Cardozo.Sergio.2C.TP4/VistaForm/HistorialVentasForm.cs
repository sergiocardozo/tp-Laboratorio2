﻿using LogicApp.Comun;
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
    public partial class HistorialVentasForm : Form
    {

        SistemaDAO sistema;
        Empresa empresa;
        public HistorialVentasForm()
        {

            InitializeComponent();

            sistema = new SistemaDAO();
            empresa = new Empresa();
            dataGHistorialVentas.DataSource = sistema.MostrarVentas();
        }

        private void HistorialVentasForm_Load(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < dataGHistorialVentas.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dataGHistorialVentas.Rows[i].Cells[3].Value);
            }
            lblGananciasVentas.Text = sum.FormateoPrecio();
        }

        private void tsBtnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tsBtnGuardarArchivo_Click(object sender, EventArgs e)
        {

            for (int fila = 0; fila < dataGHistorialVentas.Rows.Count; fila++)
            {
                List<Venta> ventas = new List<Venta>();
                Venta ventas1 = new Venta();
                ventas1.CliApellido = dataGHistorialVentas.Rows[fila].Cells[0].Value.ToString();
                ventas1.CliNombre = dataGHistorialVentas.Rows[fila].Cells[1].Value.ToString();
                ventas1.NombreJuego = dataGHistorialVentas.Rows[fila].Cells[2].Value.ToString();
                ventas1.Ganancia = Convert.ToDouble(dataGHistorialVentas.Rows[fila].Cells[3].Value);
                ventas1.FechaVenta = Convert.ToDateTime(dataGHistorialVentas.Rows[fila].Cells[4].Value);


                empresa.ArchivoTextoVentas(ventas1);
            }
        }
    }
}
