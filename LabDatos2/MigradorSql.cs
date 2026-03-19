using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace LabDatos2
{
    public class MigradorSql
    {
        private readonly string _connectionString;

        public MigradorSql(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task MigrarDesdeArchivo(string archivoPath)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                if (!File.Exists(archivoPath)) throw new FileNotFoundException("El archivo binario no existe.");

                using (FileStream fs = new FileStream(archivoPath, FileMode.Open, FileAccess.Read))
                using (BinaryReader reader = new BinaryReader(fs, Encoding.UTF8))
                {
                    while (fs.Position < fs.Length)
                    {
                        int id = reader.ReadInt32();
                        string nombre = new string(reader.ReadChars(50)).TrimEnd('\0', ' ');
                        int edad = reader.ReadInt32();

                        string query = "INSERT INTO Ciudadano (Id, Nombre, Edad) VALUES (@Id, @Nombre, @Edad)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Id", id);
                            command.Parameters.AddWithValue("@Nombre", nombre);
                            command.Parameters.AddWithValue("@Edad", edad);

                            try
                            {
                                await command.ExecuteNonQueryAsync();
                            }
                            catch (SqlException)
                            {
                                // Ignoramos errores si la llave primaria ya existe
                            }
                        }
                    }
                }
            }
        }
    }
}