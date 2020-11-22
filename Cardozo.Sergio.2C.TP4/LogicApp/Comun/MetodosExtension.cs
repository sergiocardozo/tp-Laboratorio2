using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicApp.Comun
{
    public static class MetodosExtension
    {
        /// <summary>
        /// Metodo de extension que va a formatear el precio.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static string FormateoPrecio(this Double valor)
        {
            return string.Format($"Ganancias a la fecha: ${valor:0.00}");
        }

        /// <summary>
        /// Metodo de extension que le da estilo a los datagrid
        /// </summary>
        /// <param name="DgView"></param>
        public static void FormatearGrid(this DataGridView DgView)
        {
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            DgView.EnableHeadersVisualStyles = false;

            columnHeaderStyle.BackColor = Color.LightBlue;

            columnHeaderStyle.ForeColor = Color.Black;

            DgView.DefaultCellStyle.BackColor = Color.White;

            DgView.DefaultCellStyle.ForeColor = Color.Black;

            DgView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            DgView.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            DgView.BackgroundColor = Color.White;

            DgView.CellBorderStyle = DataGridViewCellBorderStyle.Raised;

            DgView.RowHeadersVisible = false;

            DgView.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            DgView.MultiSelect = false;
        }
        /// <summary>
        /// Metodo de extension que solo va a permitir caracteres especiales(Letras)
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool EsLetra(this KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                return e.Handled;
            }
            else
            {
                e.Handled = true;
                return e.Handled;
            }
        }
        /// <summary>
        /// Metodo de extension que solo va a permitir numeros.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool EsNumero(this KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)))
            {
                return true;
            }
            else
                return false;
        }
    }
}
