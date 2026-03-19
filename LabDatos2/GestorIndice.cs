using System.Collections.Generic;
using System.IO;

namespace LabDatos2
{
    public class GestorIndice
    {
        private readonly string _idxPath = "datos_ciudadanos.idx";
        private Dictionary<int, int> _indice = new Dictionary<int, int>();

        public void CargarIndice()
        {
            _indice.Clear();
            if (!File.Exists(_idxPath)) return;

            using (FileStream fs = new FileStream(_idxPath, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                while (fs.Position < fs.Length)
                {
                    int id = reader.ReadInt32();
                    int pos = reader.ReadInt32();
                    _indice[id] = pos;
                }
            }
        }

        public void GuardarEnIndice(int id, int posicion)
        {
            _indice[id] = posicion;
            using (FileStream fs = new FileStream(_idxPath, FileMode.Append, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(id);
                writer.Write(posicion);
            }
        }

        public int? ObtenerPosicion(int id)
        {
            if (_indice.TryGetValue(id, out int pos)) return pos;
            return null;
        }
    }
}