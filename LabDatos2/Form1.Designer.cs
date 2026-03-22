namespace LabDatos2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            txtPosicion = new TextBox();
            btnGuardar = new Button();
            txtBuscarId = new TextBox();
            btnBuscarSecuencial = new Button();
            btnBuscarIndexado = new Button();
            lblTiempoSecuencial = new Label();
            lblTiempoIndexado = new Label();
            lblResultado = new Label();
            btnMigrarSql = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dgvCiudadanos = new DataGridView();
            label6 = new Label();
            btnMostrarDatos = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnCargar = new Button();
            txtTamañoLote = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCiudadanos).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(84, 70);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(150, 27);
            txtId.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(84, 110);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(84, 150);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(150, 27);
            txtEdad.TabIndex = 2;
            // 
            // txtPosicion
            // 
            txtPosicion.Location = new Point(84, 190);
            txtPosicion.Name = "txtPosicion";
            txtPosicion.Size = new Size(150, 27);
            txtPosicion.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(54, 244);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 30);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar Registro";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtBuscarId
            // 
            txtBuscarId.Location = new Point(365, 20);
            txtBuscarId.Name = "txtBuscarId";
            txtBuscarId.Size = new Size(150, 27);
            txtBuscarId.TabIndex = 5;
            // 
            // btnBuscarSecuencial
            // 
            btnBuscarSecuencial.Location = new Point(320, 60);
            btnBuscarSecuencial.Name = "btnBuscarSecuencial";
            btnBuscarSecuencial.Size = new Size(150, 30);
            btnBuscarSecuencial.TabIndex = 6;
            btnBuscarSecuencial.Text = "Búsqueda Secuencial";
            btnBuscarSecuencial.UseVisualStyleBackColor = true;
            btnBuscarSecuencial.Click += btnBuscarSecuencial_Click;
            // 
            // btnBuscarIndexado
            // 
            btnBuscarIndexado.Location = new Point(320, 100);
            btnBuscarIndexado.Name = "btnBuscarIndexado";
            btnBuscarIndexado.Size = new Size(150, 30);
            btnBuscarIndexado.TabIndex = 7;
            btnBuscarIndexado.Text = "Búsqueda Indexada";
            btnBuscarIndexado.UseVisualStyleBackColor = true;
            btnBuscarIndexado.Click += btnBuscarIndexado_Click;
            // 
            // lblTiempoSecuencial
            // 
            lblTiempoSecuencial.AutoSize = true;
            lblTiempoSecuencial.Location = new Point(345, 283);
            lblTiempoSecuencial.Name = "lblTiempoSecuencial";
            lblTiempoSecuencial.Size = new Size(108, 20);
            lblTiempoSecuencial.TabIndex = 8;
            lblTiempoSecuencial.Text = "Tiempo: 0 ticks";
            // 
            // lblTiempoIndexado
            // 
            lblTiempoIndexado.AutoSize = true;
            lblTiempoIndexado.Location = new Point(345, 323);
            lblTiempoIndexado.Name = "lblTiempoIndexado";
            lblTiempoIndexado.Size = new Size(108, 20);
            lblTiempoIndexado.TabIndex = 9;
            lblTiempoIndexado.Text = "Tiempo: 0 ticks";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(320, 150);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(157, 20);
            lblResultado.TabIndex = 10;
            lblResultado.Text = "Esperando búsqueda...";
            // 
            // btnMigrarSql
            // 
            btnMigrarSql.Location = new Point(320, 180);
            btnMigrarSql.Name = "btnMigrarSql";
            btnMigrarSql.Size = new Size(150, 30);
            btnMigrarSql.TabIndex = 11;
            btnMigrarSql.Text = "Migrar a SQL Server";
            btnMigrarSql.UseVisualStyleBackColor = true;
            btnMigrarSql.Click += btnMigrarSql_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 73);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 4;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 113);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 153);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Edad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 193);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 1;
            label4.Text = "Posición:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 23);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 0;
            label5.Text = "ID a Buscar:";
            // 
            // dgvCiudadanos
            // 
            dgvCiudadanos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCiudadanos.Location = new Point(586, 70);
            dgvCiudadanos.Name = "dgvCiudadanos";
            dgvCiudadanos.RowHeadersWidth = 51;
            dgvCiudadanos.Size = new Size(596, 381);
            dgvCiudadanos.TabIndex = 12;
            dgvCiudadanos.CellDoubleClick += dgvCiudadanos_CellDoubleClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(833, 23);
            label6.Name = "label6";
            label6.Size = new Size(73, 26);
            label6.TabIndex = 13;
            label6.Text = "Datos";
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(1032, 23);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(150, 30);
            btnMostrarDatos.TabIndex = 14;
            btnMostrarDatos.Text = "Mostrar datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(24, 314);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(140, 314);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(24, 19);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(94, 29);
            btnCargar.TabIndex = 17;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // txtTamañoLote
            // 
            txtTamañoLote.Location = new Point(24, 403);
            txtTamañoLote.Name = "txtTamañoLote";
            txtTamañoLote.Size = new Size(94, 27);
            txtTamañoLote.TabIndex = 18;
            // 
            // Form1
            // 
            ClientSize = new Size(1236, 487);
            Controls.Add(txtTamañoLote);
            Controls.Add(btnCargar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnMostrarDatos);
            Controls.Add(label6);
            Controls.Add(dgvCiudadanos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMigrarSql);
            Controls.Add(lblResultado);
            Controls.Add(lblTiempoIndexado);
            Controls.Add(lblTiempoSecuencial);
            Controls.Add(btnBuscarIndexado);
            Controls.Add(btnBuscarSecuencial);
            Controls.Add(txtBuscarId);
            Controls.Add(btnGuardar);
            Controls.Add(txtPosicion);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Name = "Form1";
            Text = "Lab: El Arquitecto de Datos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCiudadanos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private void ConfigurarDisenoTabla()
        {
       
            // 1. Limpiar y evitar columnas automáticas
            dgvCiudadanos.AutoGenerateColumns = false;
            dgvCiudadanos.Columns.Clear();

            // 2. Crear Columna ID
            dgvCiudadanos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IdProp", // Coincide con tu struct
                HeaderText = "ID",
                Width = 60,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            // 3. Crear Columna Nombre
            dgvCiudadanos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreProp", // Coincide con tu struct
                HeaderText = "Nombre Completo",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // 4. Crear Columna Edad
            dgvCiudadanos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EdadProp", // Coincide con tu struct
                HeaderText = "Edad",
                Width = 80,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            // --- Diseño Visual ---
            dgvCiudadanos.AllowUserToAddRows = false;
            dgvCiudadanos.ReadOnly = true;
            dgvCiudadanos.RowHeadersVisible = false;
            dgvCiudadanos.BackgroundColor = Color.White;
            dgvCiudadanos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Estilo de encabezado azul
            dgvCiudadanos.EnableHeadersVisualStyles = false;
            dgvCiudadanos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgvCiudadanos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCiudadanos.ColumnHeadersHeight = 35;

            // Efecto cebra
            dgvCiudadanos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
        }
        

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtBuscarId;
        private System.Windows.Forms.Button btnBuscarSecuencial;
        private System.Windows.Forms.Button btnBuscarIndexado;
        private System.Windows.Forms.Label lblTiempoSecuencial;
        private System.Windows.Forms.Label lblTiempoIndexado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnMigrarSql;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DataGridView dgvCiudadanos;
        private Label label6;
        private Button btnMostrarDatos;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnCargar;
        private TextBox txtTamañoLote;
    }
}