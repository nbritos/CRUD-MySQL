using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CapaEntidades;
using System.Data;

namespace CapaDatos
{
    public class CDAfiliados
    {
        
        string connString = "Server=localhost;User=root;Password=;Port=3306;database=bd_tpintegrador";

        public void Create(CEAfiliados paramAfiliado) 
        {
            string query = "INSERT INTO afiliados (nombre,apellido,idPlan,falta,observaciones) VALUES" +
                " (@nombre,@apellido,@idPlan,@falta,@observaciones);";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("nombre", paramAfiliado.nombre);
                command.Parameters.AddWithValue("apellido", paramAfiliado.apellido);
                command.Parameters.AddWithValue("idPlan", paramAfiliado.idPLan);
                command.Parameters.AddWithValue("falta", paramAfiliado.fAlta);
                command.Parameters.AddWithValue("observaciones", paramAfiliado.observaciones);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }finally { conn.Close(); }  

        }

        public void Update(CEAfiliados paramAfiliado)
        {
            string query = @"UPDATE afiliados SET nombre = @nombre, apellido = @apellido, idPlan = @idPlan, observaciones = @observaciones WHERE idAfiliado = @idAfiliado";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("nombre", paramAfiliado.nombre);
                command.Parameters.AddWithValue("apellido", paramAfiliado.apellido);
                command.Parameters.AddWithValue("idPlan", paramAfiliado.idPLan);
                command.Parameters.AddWithValue("observaciones", paramAfiliado.observaciones);
                command.Parameters.AddWithValue("idAfiliado", paramAfiliado.idAfiliado);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }finally { conn.Close(); }
        }

        public DataSet LeerAfiliados()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            string query = "SELECT * from afiliados";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataSet ds=new DataSet();

            try
            {
                conn.Open();
                adapter.Fill(ds,"tablaAfiliados");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }

        public DataSet LeerAfiliadosInactivos()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            string query = "SELECT * from afiliados WHERE fbaja IS NOT NULL";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataSet ds = new DataSet();

            try
            {
                conn.Open();
                adapter.Fill(ds, "tablaAfiliados");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }




        public int TraerPlanAfiliados (string paramID)
        {
            int value=0;
            string query = "SELECT idPlan FROM planes WHERE descripcion LIKE '" + paramID + "'";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    value = reader.GetInt32(0);
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            return value;
        }

        public void BajaAfiliado(CEAfiliados paramAfiliado)
        {
            string query = @"UPDATE afiliados SET fbaja = @fbaja WHERE idAfiliado = @idAfiliado";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("fbaja", paramAfiliado.fBaja);
                command.Parameters.AddWithValue("idAfiliado", paramAfiliado.idAfiliado);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        public void Habilitar(CEAfiliados paramAfiliado)
        {
            string query = @"UPDATE afiliados SET fbaja = null WHERE idAfiliado = @idAfiliado";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("idAfiliado", paramAfiliado.idAfiliado);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }
    }
}
