using System.IO;
using System.Text;

namespace LabDatos2
{
    public class GestorArchivos
    {
        private readonly string _path = "datos_ciudadanos.dat";

        public void GuardarCiudadano(Ciudadano c, int posicion)
        {
            using (FileStream fs = new FileStream(_path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                long offset = (long)posicion * Ciudadano.Size;
                fs.Seek(offset, SeekOrigin.Begin);

                using (BinaryWriter writer = new BinaryWriter(fs, Encoding.UTF8))
                {
                    writer.Write(c.Id);
                    writer.Write(c.Nombre.PadRight(50).ToCharArray());
                    writer.Write(c.Edad);
                }
            }
        }
        public List<Ciudadano> LeerTodos()
        {
            List<Ciudadano> lista = new List<Ciudadano>();
            string rutaDatos = "datos_ciudadanos.dat";

            // Si el archivo no existe (porque lo borraste o es la primera vez), 
            // regresamos la lista vacía para que no marque error.
            if (!File.Exists(rutaDatos))
            {
                return lista;
            }

            using (FileStream fs = new FileStream(rutaDatos, FileMode.Open, FileAccess.Read))
            using (BinaryReader br = new BinaryReader(fs))
            {
                // Recorremos el archivo mientras no lleguemos al final
                while (fs.Position < fs.Length)
                {
                    Ciudadano ciudadano = new Ciudadano();

                    // ⚠️ IMPORTANTE: El orden de lectura DEBE ser exactamente el mismo 
                    // en el que los guardas. Asumo que es Id, Nombre y Edad.
                    ciudadano.Id = br.ReadInt32();
                    //ciudadano.Nombre = br.ReadString();
                    ciudadano.Nombre = new string(br.ReadChars(50)).TrimEnd('\0', ' ');
                    ciudadano.Edad = br.ReadInt32();

                    lista.Add(ciudadano);

                    // Nota: Si en tu método GuardarCiudadano usas un tamaño de registro fijo 
                    // (por ejemplo, rellenas con espacios o saltas bytes para que todos midan lo mismo),
                    // la lógica de avance iría aquí. Si usas guardado continuo, este código es perfecto.
                }
            }

            return lista;
        }

        public Ciudadano? LeerCiudadano(int posicion)
        {
            if (!File.Exists(_path)) return null;

            using (FileStream fs = new FileStream(_path, FileMode.Open, FileAccess.Read))
            {
                long offset = (long)posicion * Ciudadano.Size;
                if (offset >= fs.Length) return null;
                fs.Seek(offset, SeekOrigin.Begin);

                using (BinaryReader reader = new BinaryReader(fs, Encoding.UTF8))
                {
                    int id = reader.ReadInt32();
                    string nombre = new string(reader.ReadChars(50)).TrimEnd('\0', ' ');
                    int edad = reader.ReadInt32();

                    Ciudadano c = new Ciudadano();
                    c.Id = id;
                    c.Nombre = nombre;
                    c.Edad = edad;
                    return c;
                }
            }
        }

        public Ciudadano? BuscarSecuencialmente(int idABuscar)
        {
            if (!File.Exists(_path)) return null;

            using (FileStream fs = new FileStream(_path, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs, Encoding.UTF8))
            {
                while (fs.Position < fs.Length)
                {
                    int id = reader.ReadInt32();
                    string nombre = new string(reader.ReadChars(50)).TrimEnd('\0', ' ');
                    int edad = reader.ReadInt32();

                    if (id == idABuscar)
                    {
                        Ciudadano c = new Ciudadano();
                        c.Id = id;
                        c.Nombre = nombre;
                        c.Edad = edad;
                        return c;
                    }
                }
            }
            return null;
        }
    }
}