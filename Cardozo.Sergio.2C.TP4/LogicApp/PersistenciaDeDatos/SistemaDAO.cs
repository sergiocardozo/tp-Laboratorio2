using LogicApp.Comun;
using LogicApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicApp.PersistenciaDeDatos
{
    public class SistemaDAO : ConexionSQL
    {

        #region Login
        /// <summary>
        /// Metodo para acceder a los usuarios de la base de datos
        /// </summary>
        /// <param name="user">Usuario</param>
        /// <param name="password">Contrasña</param>
        /// <returns>True si pudo acceder, False caso contrario</returns>
        public bool Login(string user, string password)
        {
            try
            {
                SistemaDAO.Comando.CommandText = "SELECT * FROM USUARIOS WHERE (NombreUsuario=@user AND Contraseña=@password)";
                SistemaDAO.Comando.Parameters.Clear();
                SistemaDAO.Comando.Parameters.AddWithValue("@user", user);
                SistemaDAO.Comando.Parameters.AddWithValue("@password", password);

                SistemaDAO.Conexion.Open();
                SqlDataReader reader = SistemaDAO.Comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Usuarios.ID = reader.GetInt32(0);
                        Usuarios.NombreUsuario = reader.GetString(1);
                        Usuarios.Contraseña = reader.GetString(2);
                        Usuarios.Nombre = reader.GetString(3);
                        Usuarios.Apellido = reader.GetString(4);
                    }
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {

                throw new SistemaVentasException("Ocurrio un error en la base de datos", ex);
            }
            finally
            {
                if (ConexionSQL.Conexion.State == System.Data.ConnectionState.Open)
                    ConexionSQL.Conexion.Close();
            }
        }
        #endregion

        #region Insert
        /// <summary>
        /// Inserta un nuevo Cliente en la Base de Datos
        /// </summary>
        /// <param name="id">id del cliente</param>
        /// <param name="nombre">nombre del cliente</param>
        /// <param name="apellido">apellido del cliente</param>
        public void InsertarCliente(string idSocio, string nombre, string apellido)
        {
            SistemaDAO.Comando.CommandText = "INSERT INTO CLIENTES (idsocio, nombre, apellido) VALUES (@idsocio, @nombre, @apellido);";
            SistemaDAO.Comando.Parameters.Clear();
            SistemaDAO.Comando.Parameters.AddWithValue("@idsocio", idSocio);
            SistemaDAO.Comando.Parameters.AddWithValue("@nombre", nombre);
            SistemaDAO.Comando.Parameters.AddWithValue("@apellido", apellido);
            SistemaDAO.Ejecutar();
        }
        /// <summary>
        /// Inserta un nuevo Juego en la Base de Datos
        /// </summary>
        /// <param name="nombreJuego">nombre del juego</param>
        /// <param name="precio">precio del juego</param>
        /// <param name="stock">Cantidad en stock</param>
        /// <param name="tipoJuego">Tipo de juegos</param>
        public void InsertarVideoJuego(string nombreJuego, double precio, int stock, int tipoJuego)
        {
            SistemaDAO.Comando.CommandText = "INSERT INTO VIDEOJUEGOS (nombrevideojuego, precio, stock, idtipovideojuego)" +
                " VALUES (@nombrevideojuego, @precio, @stock, @idtipovideojuego);";
            SistemaDAO.Comando.Parameters.Clear();

            SistemaDAO.Comando.Parameters.AddWithValue("@nombrevideojuego", nombreJuego);
            SistemaDAO.Comando.Parameters.AddWithValue("@precio", precio);
            SistemaDAO.Comando.Parameters.AddWithValue("@stock", stock);
            SistemaDAO.Comando.Parameters.AddWithValue("@idtipovideojuego", tipoJuego);
            SistemaDAO.Ejecutar();
        }
        /// <summary>
        /// Inserta una nueva Venta en la Base de datos
        /// </summary>
        /// <param name="idCliente">id del cliente</param>
        /// <param name="idVideoJuego">id del video juego</param>
        /// <param name="fechaVenta">fecha de la venta</param>
        /// <param name="precio">precio del juego</param>
        public void InsertarVenta(int idCliente, int idVideoJuego, DateTime fechaVenta, double precio)
        {
            SistemaDAO.Comando.CommandText = "INSERT INTO VENTAS (IDCliente, IDJuego, FechaVenta, GananciaVenta) " +
                "VALUES (@IDCliente, @IDJuego, @FechaVenta, @GananciaVenta);";
            SistemaDAO.Comando.Parameters.Clear();
            SistemaDAO.Comando.Parameters.AddWithValue("@IDCliente", idCliente);
            SistemaDAO.Comando.Parameters.AddWithValue("@IDJuego", idVideoJuego);
            SistemaDAO.Comando.Parameters.AddWithValue("@FechaVenta", fechaVenta);
            SistemaDAO.Comando.Parameters.AddWithValue("@GananciaVenta", precio);
            SistemaDAO.Ejecutar();
        }        
        #endregion

        #region Mostrar Datos
        /// <summary>
        /// Muestra los datos de todos los Clientes
        /// </summary>
        /// <returns>Retorna la lista de clientes con el cliente agregado</returns>
        public List<Cliente> MostrarClientes()
        {
            try
            {
                Comando.Connection = Conexion;
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "SELECT * FROM CLIENTES";
                Conexion.Open();
                SqlDataReader reader = Comando.ExecuteReader();
                List<Cliente> listaclientes = new List<Cliente>();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string idSocio = reader["idsocio"].ToString();
                    string nombre = reader["nombre"].ToString();
                    string apellido = reader["apellido"].ToString();

                    Cliente clientes = new Cliente(id, idSocio, nombre, apellido);
                    listaclientes.Add(clientes);
                }
                return listaclientes;

            }
            catch (Exception ex)
            {

                throw new SistemaVentasException("Error al ingresar a la base de datos", ex);
            }
            finally
            {
                if (ConexionSQL.Conexion.State == System.Data.ConnectionState.Open)
                    ConexionSQL.Conexion.Close();
            }
        }
        /// <summary>
        /// Muestra la lista de todos los VideoJuegos
        /// </summary>
        /// <returns>Retorna la lista con el juego agregado</returns>
        public List<VideoJuego> MostrarVideoJuegos()
        {
            try
            {
                Comando.Connection = Conexion;
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "SELECT * FROM VIDEOJUEGOS inner Join TIPOVIDEOJUEGO " +
                        "on VIDEOJUEGOS.IDTipoVideoJuego = TIPOVIDEOJUEGO.IDTipoJuego;";
                Conexion.Open();
                SqlDataReader reader = Comando.ExecuteReader();
                List<VideoJuego> listaVideoJuegos = new List<VideoJuego>();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["IDVideoJuego"]);
                        string nombreVideoJuego = reader["NombreVideoJuego"].ToString();
                        double precio = Convert.ToDouble(reader["Precio"]);
                        int stock = Convert.ToInt32(reader["Stock"]);
                        int idTipoJuego = Convert.ToInt32(reader["IDTipoVideoJuego"]);
                        int idTipoVideoJuego = Convert.ToInt32(reader["IDTipoJuego"]);
                        string nombreTipoJuego = reader["NombreTipoVideoJuego"].ToString();

                        VideoJuego videoJuego = new VideoJuego(idTipoVideoJuego, nombreTipoJuego, id, nombreVideoJuego, precio, stock, idTipoJuego);
                        listaVideoJuegos.Add(videoJuego);
                    }

                }
                return listaVideoJuegos;

            }
            catch (Exception ex)
            {

                throw new SistemaVentasException("Error al ingresar a la base de datos", ex);
            }
            finally
            {
                if (ConexionSQL.Conexion.State == System.Data.ConnectionState.Open)
                    ConexionSQL.Conexion.Close();
            }
        }
              
        /// <summary>
        /// Metodo para obtener la lista de los tipos de VideoJuegos
        /// </summary>
        /// <returns>Retorna la lista de los tipos de Juegos</returns>
        public List<VideoJuego> ObtenerTiposVideoJuegos()
        {
            try
            {
                Comando.Connection = Conexion;
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "SELECT idtipojuego, nombretipovideojuego FROM TIPOVIDEOJUEGO";
                Conexion.Open();
                SqlDataReader reader = Comando.ExecuteReader();
                List<VideoJuego> listatiposJuegos = new List<VideoJuego>();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["idtipojuego"]);
                    string nombreVideoJuego = reader["nombretipovideojuego"].ToString();


                    VideoJuego videoJuego = new VideoJuego(id, nombreVideoJuego);
                    listatiposJuegos.Add(videoJuego);
                }
                return listatiposJuegos;

            }
            catch (Exception ex)
            {

                throw new SistemaVentasException("Error al ingresar a la base de datos", ex);
            }
            finally
            {
                if (ConexionSQL.Conexion.State == System.Data.ConnectionState.Open)
                    ConexionSQL.Conexion.Close();
            }
        }
        /// <summary>
        /// Metodo que muestra la lista de las ventas
        /// </summary>
        /// <returns>Retorna la lista con las ventas generadas</returns>
        public List<Venta> MostrarVentas()
        {
            try
            {
                Comando.Connection = Conexion;
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "select CLIENTES.apellido, CLIENTES.nombre, VIDEOJUEGOS.NombreVideoJuego, VENTAS.FechaVenta, VENTAS.GananciaVenta " +
                        "From VENTAS " +
                            "inner Join CLIENTES on CLIENTES.id = VENTAS.IDCliente " +
                                "inner Join VIDEOJUEGOS on VIDEOJUEGOS.IDVideoJuego = VENTAS.IDJuego";
                Conexion.Open();
                SqlDataReader reader = Comando.ExecuteReader();
                List<Venta> listaVentas = new List<Venta>();

                while (reader.Read())
                {

                    string cliApellido = reader["apellido"].ToString();
                    string cliNombre = reader["nombre"].ToString();
                    string nombreJuego = reader["NombreVideoJuego"].ToString();
                    DateTime fechaVenta = Convert.ToDateTime(reader["FechaVenta"]);
                    double ganancia = Convert.ToDouble(reader["GananciaVenta"]);




                    Venta ventas = new Venta(cliApellido, cliNombre, nombreJuego, fechaVenta, ganancia);
                    listaVentas.Add(ventas);
                }
                return listaVentas;
            }
            catch (Exception ex)
            {
                throw new SistemaVentasException("Error al ingresar a la base de datos", ex);
            }
            finally
            {
                if (ConexionSQL.Conexion.State == System.Data.ConnectionState.Open)
                    ConexionSQL.Conexion.Close();
            }
        }
        #endregion

        #region Actualizar
        /// <summary>
        /// Metodo para modificar un Cliente de la base de datos
        /// </summary>
        /// <param name="idSocio">id a modificar</param>
        /// <param name="cambioNombre">nuevo nombre del cliente</param>
        /// <param name="cambioApellido">nuevo apellido del cliente</param>
        public void ModificarCliente(string idSocio, string cambioNombre, string cambioApellido)
        {
            Comando.CommandText = "UPDATE CLIENTES SET nombre = @cambioNombre, apellido = @cambioApellido WHERE idSocio = @idSocio";
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@idSocio", idSocio);
            Comando.Parameters.AddWithValue("@cambioNombre", cambioNombre);
            Comando.Parameters.AddWithValue("@cambioApellido", cambioApellido);
            SistemaDAO.Ejecutar();
        }
        /// <summary>
        /// Metodo para modificar un VideoJuego
        /// </summary>
        /// <param name="nombreVideoJuego">nombre de videojuego a modificar</param>
        /// <param name="nuevoPrecio">nuevo precio del juego</param>
        /// <param name="nuevoStock">stock del juego</param>
        public void ModificarVideoJuego(string nombreVideoJuego, double nuevoPrecio, int nuevoStock)
        {
            Comando.CommandText = "UPDATE VIDEOJUEGOS SET precio = @nuevoPrecio, stock = @nuevoStock WHERE nombreVideoJuego = @nombreVideoJuego";
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@nombreVideoJuego", nombreVideoJuego);
            Comando.Parameters.AddWithValue("@nuevoPrecio", nuevoPrecio);
            Comando.Parameters.AddWithValue("@nuevoStock", nuevoStock);
            SistemaDAO.Ejecutar();
        }
        /// <summary>
        /// Metodo que va al generar una venta descuenta del stock la cantidad vendida 
        /// </summary>
        /// <param name="cantidad">cantidad vendida</param>
        /// <param name="nombreVideoJuego">nombre del juego a modificar</param>
        public void DescontarStock(int cantidad, string nombreVideoJuego)
        {
            Comando.CommandText = "UPDATE VIDEOJUEGOS SET stock = stock - @cantidad WHERE nombreVideoJuego = @nombreVideoJuego";
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@cantidad", cantidad);
            Comando.Parameters.AddWithValue("@nombreVideoJuego", nombreVideoJuego);

            SistemaDAO.Ejecutar();
        }
        #endregion

        #region DELETE
        /// <summary>
        /// Metodo que borra un cliente seleccionado de la Base de datos por su id 
        /// </summary>
        /// <param name="idSocio">Id de socio a borrar</param>
        public void BorrarCliente(string idSocio)
        {
            Comando.CommandText = "DELETE FROM CLIENTES WHERE idSocio = @idSocio";
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@idSocio", idSocio);
            SistemaDAO.Ejecutar();
        }
        /// <summary>
        /// Metodo que borra un Juego de la Base de datos por su nombre.
        /// </summary>
        /// <param name="nombreVideoJuego">nombre de juego a borrar</param>
        public void BorrarJuego(string nombreVideoJuego)
        {
            Comando.CommandText = "DELETE FROM VIDEOJUEGOS WHERE nombreVideoJuego = @nombreVideoJuego";
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@nombreVideoJuego", nombreVideoJuego);
            SistemaDAO.Ejecutar();
        }
        #endregion

        public List<Venta> FiltrarVentas(string paramIngresado)
        {
            try
            {
                Comando.CommandText = "select CLIENTES.apellido, CLIENTES.nombre, VIDEOJUEGOS.NombreVideoJuego, VENTAS.FechaVenta, VENTAS.GananciaVenta " +
                    "From VENTAS " +
                        "inner Join CLIENTES on CLIENTES.id = VENTAS.IDCliente " +
                            "inner Join VIDEOJUEGOS on VIDEOJUEGOS.IDVideoJuego = VENTAS.IDJuego " +
                                    "Where CLIENTES.apellido Like '@paramIngresado%'";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@paramIngresado", paramIngresado);
                Conexion.Open();
                SqlDataReader reader = Comando.ExecuteReader();
                List<Venta> listaVentas = new List<Venta>();

                while (reader.Read())
                {

                    string cliApellido = reader["apellido"].ToString();
                    string cliNombre = reader["nombre"].ToString();
                    string nombreJuego = reader["NombreVideoJuego"].ToString();
                    DateTime fechaVenta = Convert.ToDateTime(reader["FechaVenta"]);
                    double ganancia = Convert.ToDouble(reader["GananciaVenta"]);

                    Venta ventas = new Venta(cliApellido, cliNombre, nombreJuego, fechaVenta, ganancia);
                    listaVentas.Add(ventas);
                }
                return listaVentas;
            }
            catch (Exception ex)
            {
                throw new SistemaVentasException("Error al ingresar a la base de datos", ex);
            }
            finally
            {
                if (ConexionSQL.Conexion.State == System.Data.ConnectionState.Open)
                    ConexionSQL.Conexion.Close();
            }
        }
    }
}
