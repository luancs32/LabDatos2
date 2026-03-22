using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
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
            txtTamañoLote.Text = "500";//Lote para migrar a sql
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
            //comenta lo de arriba y checa esto 
            //try
            //{
            //    List<Ciudadano> todosLosRegistros = _gestorArchivos.LeerTodos();
            //    int total = todosLosRegistros.Count;

            //    if (total == 0)
            //    {
            //        MessageBox.Show("No hay datos en el archivo para migrar.");
            //        return;
            //    }

            //    // Leemos el tamaño del lote desde tu nuevo TextBox (por defecto será 500)
            //    int tamañoLote = int.Parse(txtTamañoLote.Text);
            //    string connectionString = "Server=10.12.13.143,1433;Database=LabDatos2;User Id=sa;Password=123;TrustServerCertificate=True;";

            //    //INICIAMOS EL CRONÓMETRO!
            //    Stopwatch cronometro = new Stopwatch();
            //    cronometro.Start();

            //    using (SqlConnection conexion = new SqlConnection(connectionString))
            //    {
            //        conexion.Open();

            //        for (int i = 0; i < total; i += tamañoLote)
            //        {
            //            int cantidadRestante = Math.Min(tamañoLote, total - i);
            //            List<Ciudadano> loteActual = todosLosRegistros.GetRange(i, cantidadRestante);

            //            using (SqlTransaction transaccion = conexion.BeginTransaction())
            //            {
            //                try
            //                {
            //                    foreach (Ciudadano c in loteActual)
            //                    {
            //                        if (c.IdProp == 0 && string.IsNullOrWhiteSpace(c.NombreProp)) continue;

            //                        string query = "INSERT INTO Ciudadanos (Id, Nombre, Edad) VALUES (@Id, @Nombre, @Edad)";
            //                        using (SqlCommand comando = new SqlCommand(query, conexion, transaccion))
            //                        {
            //                            comando.Parameters.AddWithValue("@Id", c.IdProp);
            //                            comando.Parameters.AddWithValue("@Nombre", c.NombreProp);
            //                            comando.Parameters.AddWithValue("@Edad", c.EdadProp);
            //                            comando.ExecuteNonQuery();
            //                        }
            //                    }
            //                    transaccion.Commit();
            //                }
            //                catch (Exception)
            //                {
            //                    transaccion.Rollback();
            //                    throw;
            //                }
            //            }
            //        }
            //    }

            //    // DETENEMOS EL CRONÓMETRO!
            //    cronometro.Stop();

            //    // Mostramos el tiempo exacto para tu reporte
            //    MessageBox.Show($"¡Migración exitosa!\n\n" +
            //                    $"Registros enviados: {total}\n" +
            //                    $"Tamaño de los lotes: {tamañoLote}\n" +
            //                    $"Tiempo total: {cronometro.ElapsedMilliseconds} milisegundos.");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error durante la migración: " + ex.Message);
            //}
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
        private void EliminarEnSqlServer(int id)
        {
            string connectionString = "Server=10.12.13.143,1433;Database=LabDatos2;User Id=sa;Password=123;TrustServerCertificate=True;";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Ciudadanos WHERE Id = @Id";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", id);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validamos que hayas seleccionado a alguien primero
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Por favor, selecciona un registro de la tabla para eliminar.");
                    return;
                }

                // Preguntamos si está segura de borrarlo
                DialogResult respuesta = MessageBox.Show(
                    "¿Estás segura de que deseas eliminar este registro permanentemente?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    int id = int.Parse(txtId.Text);
                    int posicion = int.Parse(txtPosicion.Text);

                    // 1. ELIMINAR EN ARCHIVO LOCAL (Sobrescribimos con un "fantasma")
                    Ciudadano ciudadanoVacio = new Ciudadano();
                    ciudadanoVacio.Id = 0; // ID 0 para que tu lector lo ignore
                    ciudadanoVacio.Nombre = "";
                    ciudadanoVacio.Edad = 0;
                    _gestorArchivos.GuardarCiudadano(ciudadanoVacio, posicion);

                    // 2. ELIMINAR EN SQL SERVER
                    EliminarEnSqlServer(id);

                    // 3. ELIMINAR DE LA TABLA VISUAL
                    for (int i = 0; i < _listaCiudadanos.Count; i++)
                    {
                        if (_listaCiudadanos[i].IdProp == id)
                        {
                            _listaCiudadanos.RemoveAt(i); // Lo quitamos de la lista
                            break;
                        }
                    }

                    MessageBox.Show("Registro eliminado correctamente de ambos sistemas.");

                    // Limpiamos todo y preparamos el siguiente ID automático
                    txtNombre.Clear();
                    txtEdad.Clear();
                    ActualizarSiguienteRegistro();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            // 1. Preparamos las herramientas de generación
            Random rnd = new Random();
            //string[] nombres = { "Carolina", "Jimena", "Cesar", "Natalia", "Luis", "Elena", "Pedro", "Sofia", "Miguel", "Lucia" };
            //string[] apellidos = { "Gomez", "Sanchez", "Perez", "Rodriguez", "Lopez", "Martinez", "Garcia", "Hernandez", "Ruiz", "Diaz" };
            string[] nombres = {
                "Carolina", "Jimena", "Cesar", "Natalia", "Luis",
                "Elena", "Pedro", "Sofia", "Miguel", "Lucia",
                "Andres", "Valentina", "Diego", "Camila", "Fernando",
                "Isabella", "Ricardo", "Gabriela", "Alejandro", "Daniela",
                "Jorge", "Mariana", "Roberto", "Paola", "Eduardo",
                "Fernanda", "Antonio", "Andrea", "Francisco", "Monica",
                "Hector", "Adriana", "Arturo", "Veronica", "Manuel",
                "Stephanie", "Oscar", "Patricia", "Rafael", "Claudia",
                "Sergio", "Vanessa", "Ernesto", "Diana", "Gustavo",
                "Laura", "Raul", "Jessica", "Victor", "Karla"
            };

            string[] apellidos = {
                "Gomez", "Sanchez", "Perez", "Rodriguez", "Lopez",
                "Martinez", "Garcia", "Hernandez", "Ruiz", "Diaz",
                "Morales", "Jimenez", "Torres", "Ramirez", "Flores",
                "Reyes", "Cruz", "Moreno", "Gutierrez", "Ortiz",
                "Chavez", "Ramos", "Vargas", "Castillo", "Romero",
                "Mendoza", "Herrera", "Medina", "Aguilar", "Vega",
                "Delgado", "Soto", "Castro", "Fuentes", "Sandoval",
                "Rios", "Pena", "Miranda", "Lara", "Guerrero",
                "Ibarra", "Campos", "Cervantes", "Salinas", "Espinoza",
                "Contreras", "Nunez", "Pacheco", "Velazquez", "Acosta"
            };

            int inicioId = _listaCiudadanos.Count; // Empezamos desde el ID que siga
            int cantidadAGenerar = 1000;

            try
            {
                // 2. Abrimos SOLO el archivo local .dat
                using (FileStream fs = new FileStream("datos_ciudadanos.dat", FileMode.OpenOrCreate, FileAccess.Write))
                using (BinaryWriter writer = new BinaryWriter(fs, Encoding.UTF8))
                {
                    // 3. Generamos los 1000 registros
                    for (int i = 0; i < cantidadAGenerar; i++)
                    {
                        int idActual = inicioId + i;
                        string nombreAleatorio = nombres[rnd.Next(nombres.Length)] + " " + apellidos[rnd.Next(apellidos.Length)];
                        int edadAleatoria = rnd.Next(10, 81);

                        // --- A. GUARDAR EN ARCHIVO LOCAL (.dat) ---
                        long offset = (long)idActual * Ciudadano.Size;
                        fs.Seek(offset, SeekOrigin.Begin);
                        writer.Write(idActual);
                        writer.Write(nombreAleatorio.PadRight(50).ToCharArray());
                        writer.Write(edadAleatoria);

                        // --- B. AGREGAR A LA TABLA VISUAL (DataGridView) ---
                        Ciudadano c = new Ciudadano();
                        c.Id = idActual;
                        c.Nombre = nombreAleatorio;
                        c.Edad = edadAleatoria;

                        _listaCiudadanos.Add(c);
                    }
                }

                // 4. Actualizamos el cuadrito de texto del ID al terminar
                ActualizarSiguienteRegistro();
                dgvCiudadanos.Refresh();

                MessageBox.Show("¡1000 registros generados en el archivo local!\nRevisa tu tabla y presiona 'Migrar a SQL' cuando estés lista.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la carga masiva: " + ex.Message);
            }
        }

        private void dgvCiudadanos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            //vaciar el archivo local y tambien en sql server y comenzar en 0
            // 1. Pregunta de seguridad (¡Muy importante para no borrar por accidente!)
            DialogResult respuesta = MessageBox.Show(
                "¿Estás ABSOLUTAMENTE SEGURA de que quieres borrar TODOS los registros?\nSe vaciará el archivo local y la base de datos permanentemente.",
                "¡ADVERTENCIA DE BORRADO MASIVO!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    // --- A. VACIAR LA BASE DE DATOS (SQL Server) ---
                    string connectionString = "Server=10.12.13.143,1433;Database=LabDatos2;User Id=sa;Password=123;TrustServerCertificate=True;";
                    using (SqlConnection conexion = new SqlConnection(connectionString))
                    {
                        // Usamos TRUNCATE en lugar de DELETE porque es instantáneo y limpia todo de raíz
                        string query = "TRUNCATE TABLE Ciudadanos";
                        using (SqlCommand comando = new SqlCommand(query, conexion))
                        {
                            conexion.Open();
                            comando.ExecuteNonQuery();
                        }
                    }

                    // --- B. VACIAR EL ARCHIVO LOCAL (.dat) ---
                    // Al usar FileMode.Create, C# aplasta el archivo viejo y crea uno nuevo totalmente vacío (0 bytes)
                    using (FileStream fs = new FileStream("datos_ciudadanos.dat", FileMode.Create, FileAccess.Write))
                    {
                        // No escribimos nada, solo lo dejamos en blanco.
                    }

                    // --- C. LIMPIAR LA INTERFAZ VISUAL ---
                    _listaCiudadanos.Clear(); // Vaciamos la lista en memoria
                    dgvCiudadanos.Refresh();  // Actualizamos la tabla para que se vea vacía

                    // Limpiamos los textos
                    txtNombre.Clear();
                    txtEdad.Clear();

                    // ¡La magia! Como la lista ya tiene 0 elementos, tu método pondrá el ID en 0 automáticamente
                    ActualizarSiguienteRegistro();

                    MessageBox.Show("¡Limpieza total completada!\nTu sistema está como nuevo y listo para empezar desde el ID 0.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar vaciar el sistema: " + ex.Message);
                }
            }

        }
    }
}