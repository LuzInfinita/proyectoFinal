using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDatos2
{
    public class DBConexion
    {
        public String miConexion;
        public SqlConnection sqlConexion;
        
        public DBConexion() // Constructor crea la Conexión
        {
            miConexion = "Data Source=148.225.60.117; Initial Catalog=DS3;"
                            + " User Id=ds3usuario; Password=12345678;";
            //miConexion = "Data Source=localhost; Initial Catalog=NombreBaseDatos;"
            //                + " User Id=usuarioX; Password=contraseñaX;";

            sqlConexion = new SqlConnection(miConexion);
        }

        public SqlConnection ConectaSQL() // Realiza la conexión al servidor
        {
            if (sqlConexion.State == ConnectionState.Closed 
                    || sqlConexion.State == ConnectionState.Broken)
            {
                sqlConexion.Open();
            }

            return sqlConexion;
        }

        public void DesconectaSQL()
        {
            if(sqlConexion.State == ConnectionState.Open)
            {
                sqlConexion.Close();
            }
        }

        public bool ejecutaUpdate(String query, SqlParameter[] parametros)
        {
            bool auxRegreso = false;
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter();
                SqlCommand comando = new SqlCommand(query, ConectaSQL());
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddRange(parametros); // Asigno Parámetros al comando
                int renglones = comando.ExecuteNonQuery(); // Ejecuta contra la BAse de Datos el query
                if (renglones <= 0) // No inserto ningún registro
                {
                    auxRegreso = false;
                }
                else
                {
                    auxRegreso = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema al Actualizar los registros. Error: "
                    + ex.ToString());
            }
            finally
            {
                DesconectaSQL();
            }

            return auxRegreso;
        }



        public bool ejecutaInsert(String query, SqlParameter[] parametros)
        {
            bool auxRegreso = false;
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter();
                SqlCommand comando = new SqlCommand(query, ConectaSQL());
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddRange(parametros); // Asigno Parámetros al comando
                // adaptador.InsertCommand = comando;
                int renglones = comando.ExecuteNonQuery(); // Ejecuta contra la BAse de Datos el query
                if( renglones <= 0) // No inserto ningún registro
                {
                    auxRegreso = false;
                } else
                {
                    auxRegreso = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema al insertar el registro. Error: "
                    + ex.ToString());
            }
            finally
            {
                DesconectaSQL();
            }
            
            return auxRegreso;
        }

        public DataTable ejecutaSelect(String query, SqlParameter[] parametros)
        {
            DataSet ds = new DataSet(); // Conjunto de DataTable
            DataTable auxRegreso = new DataTable(); // Almacenamos los datos recibidos de la Base de datos
            SqlCommand comando = new SqlCommand(); // Recibe propiedas para realizar la conexión a la BD y ejecutar el query 
            SqlDataAdapter adaptador = new SqlDataAdapter(); // Llena información de DataSet y DataTable
            try
            {
                comando.CommandText = query; // Consulta hacia la Base de Datos
                comando.CommandType = CommandType.Text; // Es texto
                comando.Connection = ConectaSQL(); // Conecta a la base de datos por medio del método definido anteriormente                
                comando.Parameters.AddRange(parametros); // Agrega los parámetros
                comando.ExecuteNonQuery(); // Ejecuta el query contra la Base de datos
                adaptador.SelectCommand = comando; // Relaciona el DataAdapter con el SQLCommand
                adaptador.Fill(ds); // Llena el DataSet con información almacenada en el DataAdapter
                if (ds.Tables.Count > 0) // Verifico que exista al menos 1 Tabla en el DataSet
                    auxRegreso = ds.Tables[0]; // Asigno la primer tabla al DataTable
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el ejecutaSelect: " + ex.ToString());
            } finally
            {
                DesconectaSQL(); // Me desconecto de la Base de Datos
            }

            return auxRegreso; // Regreso el DataTable con Información
        }


        public bool ejecutaElimina(String query, SqlParameter[] parametros)
        {
            bool auxRegreso = false;
            try
            {
                SqlCommand comando = new SqlCommand(query, ConectaSQL());
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddRange(parametros); // Asigno Parámetros al comando
                int renglones = comando.ExecuteNonQuery(); // Ejecuta contra la Base de Datos el query
                if (renglones <= 0) // No eliminó ningún registro
                {
                    auxRegreso = false;
                }
                else
                {
                    auxRegreso = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema al Eliminar los registros. Error: "
                    + ex.ToString());
            }
            finally
            {
                DesconectaSQL();
            }

            return auxRegreso;
        }

        public bool EjecutaStoreProcedure(String consulta, SqlParameter[] parametros)
        {
            bool auxRegreso = false;
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter();
                SqlCommand comando = new SqlCommand(consulta, ConectaSQL());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddRange(parametros); // Asigno Parámetros al comando
                comando.ExecuteNonQuery(); // Ejecuta contra la Base de Datos el query

                // Obtiene parámetros de salida (OUTPUT)
                auxRegreso = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema al Actualizar los registros. Error: "
                    + ex.ToString());
            }
            finally
            {
                DesconectaSQL();
            }

            return auxRegreso;
        }

        //Nota: "out" indica regreso
        public void EjecutaStoreProcedureParametros(String consulta, SqlParameter[] parametros, out int IDRegreso, out String Mensaje, out bool Regreso)
        {
           
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter();
                SqlCommand comando = new SqlCommand(consulta, ConectaSQL());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddRange(parametros); // Asigno Parámetros al comando
                comando.ExecuteNonQuery(); // Ejecuta contra la Base de Datos el query

                // Obtiene parámetros de salida (OUTPUT)
                IDRegreso = Int32.Parse(comando.Parameters["@IDRegreso"].Value.ToString());
                Regreso = Boolean.Parse(comando.Parameters["@spRegreso"].Value.ToString());
                Mensaje = comando.Parameters["@spRegreso"].Value.ToString();

            }
            catch (Exception ex)
            {
                IDRegreso = 0;
                Regreso = false;
                Mensaje = "Error: " + ex.ToString();

               /* MessageBox.Show("Problema al Actualizar los registros. Error: "
                    + ex.ToString()); */
            }
            finally
            {
                DesconectaSQL();
            }

            
        }
    }
}
