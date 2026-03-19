using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LabDatos2
{
    public partial class Form1 : Form
    {
        private GestorArchivos _gestorArchivos;
        private GestorIndice _gestorIndice;
        private MigradorSql _migradorSql;

        public Form1()
        {
            InitializeComponent();
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

                _gestorArchivos.GuardarCiudadano(ciudadano, posicion);
                _gestorIndice.GuardarEnIndice(id, posicion);

                MessageBox.Show("Ciudadano guardado correctamente.");
                // --- Nuevas líneas para limpiar la interfaz ---
                txtId.Clear();
                txtNombre.Clear();
                txtEdad.Clear();
                txtPosicion.Clear();

                
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
    }
}