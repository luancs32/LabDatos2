using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace LabDatos2
{
    public partial class Form1 : Form
    {
        private GestorArchivos _gestorArchivos;
        private GestorIndice _gestorIndice;
        private MigradorSql _migradorSql;
        private BindingList<Ciudadano> _listaCiudadanos;

        public Form1()
        {
            InitializeComponent();
            _listaCiudadanos = new BindingList<Ciudadano>();
            dgvCiudadanos.DataSource = _listaCiudadanos;
            _listaCiudadanos = new BindingList<Ciudadano>();
            dgvCiudadanos.DataSource = _listaCiudadanos;

            // ¡Aquí! Para que el primer ID (0) aparezca en cuanto abras el programa
            ActualizarSiguienteRegistro();
            ConfigurarDisenoTabla();
            _gestorArchivos = new GestorArchivos();
            _gestorIndice = new GestorIndice();


            // Recuerda cambiar "TuBaseDeDatos" por el nombre de tu BD en Management Studio
            //_migradorSql = new MigradorSql("Server=10.12.13.143\SQLEXPRESS;Database=LabDatosDB;User Id=sa;Password=123;TrustServerCertificate=True;");
            _migradorSql = new MigradorSql("Server=10.12.13.143,1433;Database=LabDatos2;User Id=sa;Password=123;TrustServerCertificate=True;");
            _gestorIndice.CargarIndice();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                string nombre = txtNombre.Text;
                int edad = int.Parse(txtEdad.Text);
                int posicion = int.Parse(txtPosicion.Text);

                Ciudadano ciudadano = new Ciudadano();
                ciudadano.Id = id;
                ciudadano.Nombre = nombre;
                ciudadano.Edad = edad;
                // Guardar en los archivos locales
                _gestorArchivos.GuardarCiudadano(ciudadano, posicion);
                _gestorIndice.GuardarEnIndice(id, posicion);

                // 3. ¡Agrega el ciudadano a la lista visual del DataGridView!
                _listaCiudadanos.Add(ciudadano);

                _gestorArchivos.GuardarCiudadano(ciudadano, posicion);
                _gestorIndice.GuardarEnIndice(id, posicion);

                MessageBox.Show("Ciudadano guardado correctamente.");
                // --- Nuevas líneas para limpiar la interfaz ---

                txtNombre.Clear();
                txtEdad.Clear();
                txtPosicion.Clear();

                // ¡Actualizamos para el siguiente registro!
                ActualizarSiguienteRegistro();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnBuscarSecuencial_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscarId.Text, out int idABuscar))
            {
                Stopwatch sw = Stopwatch.StartNew();
                var resultado = _gestorArchivos.BuscarSecuencialmente(idABuscar);
                sw.Stop();

                MostrarResultado(resultado, lblTiempoSecuencial, sw.ElapsedTicks);
            }
        }

        private void btnBuscarIndexado_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscarId.Text, out int idABuscar))
            {
                Stopwatch sw = Stopwatch.StartNew();

                int? posicion = _gestorIndice.ObtenerPosicion(idABuscar);
                Ciudadano? resultado = null;

                if (posicion.HasValue)
                {
                    resultado = _gestorArchivos.LeerCiudadano(posicion.Value);
                }

                sw.Stop();
                MostrarResultado(resultado, lblTiempoIndexado, sw.ElapsedTicks);
            }
        }

        private void MostrarResultado(Ciudadano? c, Label labelTiempo, long ticks)
        {
            labelTiempo.Text = $"Tiempo: {ticks} ticks";
            if (c.HasValue)
                lblResultado.Text = $"Encontrado: {c.Value.Nombre}, Edad: {c.Value.Edad}";
            else
                lblResultado.Text = "Registro no encontrado.";
        }

        private async void btnMigrarSql_Click(object sender, EventArgs e)
        {
            try
            {
                btnMigrarSql.Enabled = false;
                await _migradorSql.MigrarDesdeArchivo("datos_ciudadanos.dat");
                MessageBox.Show("Migración a SQL Server EXPRESS completada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en migración: " + ex.Message);
            }
            finally
            {
                btnMigrarSql.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Limpiamos la lista visual para evitar duplicados en pantalla
                _listaCiudadanos.Clear();

                // 2. Le pedimos al gestor que nos traiga todos los datos del archivo local .dat
                // (Asegúrate de tener un método similar a este en tu clase GestorArchivos)
                List<Ciudadano> registros = _gestorArchivos.LeerTodos();

                // 3. Recorremos los registros y los agregamos a la tabla
                foreach (Ciudadano ciudadano in registros)
                {
                    // Opcional: Filtramos el registro "fantasma" de la posición 0 que vimos antes
                    if (ciudadano.Id != 0)
                    {
                        _listaCiudadanos.Add(ciudadano);
                    }
                }
                ActualizarSiguienteRegistro();
                MessageBox.Show("Datos cargados exitosamente en la tabla.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos: " + ex.Message);
            }
        }
        private void ActualizarSiguienteRegistro()
        {
            // Buscamos el ID más alto que exista en la tabla visual
            int maxId = -1;

            foreach (var c in _listaCiudadanos)
            {
                if (c.IdProp > maxId) maxId = c.IdProp;
            }

            // El siguiente será el más alto + 1, o 0 si no hay ninguno
            int siguiente = maxId + 1;

            txtId.Text = siguiente.ToString();
            txtPosicion.Text = siguiente.ToString();
        }

        private void dgvCiudadanos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que no hayan dado clic en los encabezados
            if (e.RowIndex >= 0)
            {
                // Obtenemos al ciudadano de la fila seleccionada
                Ciudadano seleccionado = (Ciudadano)dgvCiudadanos.CurrentRow.DataBoundItem;

                // Pasamos sus datos a las cajas de texto para editarlos
                txtId.Text = seleccionado.IdProp.ToString();
                txtPosicion.Text = seleccionado.IdProp.ToString(); // Asumiendo que tu ID y Posición van a la par
                txtNombre.Text = seleccionado.NombreProp;
                txtEdad.Text = seleccionado.EdadProp.ToString();
            }
        }
        private void ActualizarEnSqlServer(Ciudadano ciudadanoEditado)
        {
            // Usa la misma cadena de conexión que tienes en tu botón de migrar
            string connectionString = "Server=10.12.13.143,1433;Database=LabDatos2;User Id=sa;Password=123;TrustServerCertificate=True;";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                // El comando UPDATE busca por ID y cambia el Nombre y la Edad
                string query = "UPDATE Ciudadanos SET Nombre = @Nombre, Edad = @Edad WHERE Id = @Id";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", ciudadanoEditado.NombreProp);
                    comando.Parameters.AddWithValue("@Edad", ciudadanoEditado.EdadProp);
                    comando.Parameters.AddWithValue("@Id", ciudadanoEditado.IdProp);

                    conexion.Open();
                    comando.ExecuteNonQuery(); // Ejecutamos el cambio
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Recogemos los datos modificados de las cajas de texto
                int id = int.Parse(txtId.Text);
                string nuevoNombre = txtNombre.Text;
                int nuevaEdad = int.Parse(txtEdad.Text);
                int posicion = int.Parse(txtPosicion.Text);

                // 2. Creamos el ciudadano con los nuevos datos
                Ciudadano ciudadanoEditado = new Ciudadano();
                ciudadanoEditado.Id = id;
                ciudadanoEditado.Nombre = nuevoNombre;
                ciudadanoEditado.Edad = nuevaEdad;

                // 3. ACTUALIZAR ARCHIVO LOCAL (.dat)
                // Como usamos fs.Seek en tu método GuardarCiudadano, si le pasamos
                // una posición que ya existe, ¡simplemente la sobrescribe!
                _gestorArchivos.GuardarCiudadano(ciudadanoEditado, posicion);

                // 4. ACTUALIZAR SQL SERVER
                ActualizarEnSqlServer(ciudadanoEditado);

                // 5. ACTUALIZAR LA TABLA VISUAL (DataGridView)
                for (int i = 0; i < _listaCiudadanos.Count; i++)
                {
                    if (_listaCiudadanos[i].IdProp == id)
                    {
                        _listaCiudadanos[i] = ciudadanoEditado;
                        break; // Lo encontramos y lo reemplazamos
                    }
                }

                // Refrescamos la tabla para ver los cambios
                dgvCiudadanos.Refresh();

                MessageBox.Show("Registro editado correctamente en el archivo local y en SQL Server.");

                // Limpiamos y preparamos para el siguiente nuevo registro
                txtNombre.Clear();
                txtEdad.Clear();
                ActualizarSiguienteRegistro(); // Regresa el ID al siguiente disponible
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
            }
        }
    }
}