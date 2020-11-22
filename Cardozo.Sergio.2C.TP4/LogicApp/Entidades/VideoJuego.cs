using LogicApp.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicApp.Entidades
{
    public class VideoJuego
    {

        private int id;
        private string nombreVideoJuego;
        private double precio;
        private int stock;
        private int idTipoVideoJuego;
        private int idTipoJuego;
        private string nombreTipoJuego;

        #region Propiedades
        /// <summary>
        /// Propiedad Id
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// Propiedad NombreVideoJuego
        /// </summary>
        public string NombreVideoJuego
        {
            get { return nombreVideoJuego; }
            set { nombreVideoJuego = value; }
        }
        /// <summary>
        /// Propiedad Precio
        /// </summary>
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        /// <summary>
        /// Propiedad Stock
        /// </summary>
        public int Stock
        {
            get { return stock; }
            set
            {
                if (value < 0)
                    throw new SistemaVentasException("Revisa el stock, no tenes mas");
                stock = value;
            }
        }
        /// <summary>
        /// Propiedad IdVideoJuego
        /// </summary>
        public int IDTipoVideoJuego
        {
            get { return idTipoVideoJuego; }
            set { idTipoVideoJuego = value; }
        }
        /// <summary>
        /// Propiedad id Tipo Juego
        /// </summary>
        public int IdTipoJuego
        {
            get { return idTipoJuego; }
            set
            {
                if (value > 0)
                    idTipoJuego = value;
            }
        }
        /// <summary>
        /// Propiedad lectura y escritura nombre del video Juego
        /// </summary>
        public string NombreTipoJuego
        {
            get { return nombreTipoJuego; }
            set { nombreTipoJuego = value; }
        }

        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public VideoJuego()
        {
        }
        /// <summary>
        /// Constructor que inicializa el tipo de videoJuego y el nombre del tipo de juego
        /// </summary>
        /// <param name="idTipoJuego"></param>
        /// <param name="nombreTipoJuego"></param>
        public VideoJuego(int idTipoJuego, string nombreTipoJuego)
        {
            this.idTipoJuego = idTipoJuego;
            this.nombreTipoJuego = nombreTipoJuego;
        }
        /// <summary>
        /// Constructor que inicializa los atributos de la clase
        /// </summary>
        /// <param name="idTipoJuego"></param>
        /// <param name="nombreTipoJuego"></param>
        /// <param name="id"></param>
        /// <param name="nombreVideoJuego"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param>
        /// <param name="idTipoVideoJuego"></param>
        public VideoJuego(int idTipoJuego, string nombreTipoJuego, int id, string nombreVideoJuego, double precio, int stock, int idTipoVideoJuego)
            : this(idTipoJuego, nombreTipoJuego)
        {
            this.id = id;
            this.nombreVideoJuego = nombreVideoJuego;
            this.precio = precio;
            this.stock = stock;
            this.idTipoVideoJuego = idTipoVideoJuego;
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Dos juegos son iguales si tienen el mismo nombre;
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns> 
        public static bool operator ==(VideoJuego j1, VideoJuego j2)
        {
            return j1.NombreVideoJuego == j2.NombreVideoJuego;
        }
        /// <summary>
        /// Dos juegos son distintos si tienen distinto nombre
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        public static bool operator !=(VideoJuego j1, VideoJuego j2)
        {
            return !(j1 == j2);
        } 
        #endregion


    }
}
