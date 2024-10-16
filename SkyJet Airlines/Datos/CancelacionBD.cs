using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CancelacionBD : Conexion
    {
        public CancelacionBD() { }

        public bool ExisteCancelacion(int id)
        {
            bool exists = false;

            try
            {
                Open();

                string query = "SELECT COUNT(*) FROM [Cancelaciones] WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@id", id);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                        exists = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un Error en la Consulta: " + ex.Message);
            }
            finally
            {
                Close();
            }

            return exists;
        }

        public void InsertarCancelacion(Cancelacion cancelacion)
        {
            try
            {
                Open();

                string query = "INSERT INTO [Cancelaciones] (id, id_ticket, cod_vuelo, fecha) VALUES (@id, @ticket, @vuelo, @fecha)";
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@id", cancelacion.Id);
                    command.Parameters.AddWithValue("@ticket", cancelacion.IdTicket);
                    command.Parameters.AddWithValue("@vuelo", cancelacion.CodVuelo);
                    command.Parameters.AddWithValue("@fecha", cancelacion.Fecha);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un Error en la Consulta: " + ex.Message);
            }
            finally
            {
                Close();
            }
        }

        public List<Cancelacion> ListaCancelaciones()
        {
            List<Cancelacion> cancelaciones = new List<Cancelacion>();

            try
            {
                Open();

                string query = "SELECT id, id_ticket, cod_vuelo, fecha FROM [Cancelaciones]";
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cancelacion cancelacion = new Cancelacion();
                            cancelacion.Id = Convert.ToInt32(reader["id"].ToString());
                            cancelacion.IdTicket = Convert.ToInt32(reader["id_ticket"].ToString());
                            cancelacion.CodVuelo = reader["cod_vuelo"].ToString();
                            cancelacion.Fecha = Convert.ToDateTime(reader["fecha"].ToString());

                            cancelaciones.Add(cancelacion);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un Error en la Consulta: " + ex.Message);
            }
            finally
            {
                Close();
            }

            return cancelaciones;
        }
    }
}
