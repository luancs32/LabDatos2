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
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(80, 20);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 27);
            txtId.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(80, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(80, 100);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(150, 27);
            txtEdad.TabIndex = 2;
            // 
            // txtPosicion
            // 
            txtPosicion.Location = new Point(80, 140);
            txtPosicion.Name = "txtPosicion";
            txtPosicion.Size = new Size(150, 27);
            txtPosicion.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(80, 180);
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
            lblTiempoSecuencial.Location = new Point(575, 70);
            lblTiempoSecuencial.Name = "lblTiempoSecuencial";
            lblTiempoSecuencial.Size = new Size(108, 20);
            lblTiempoSecuencial.TabIndex = 8;
            lblTiempoSecuencial.Text = "Tiempo: 0 ticks";
            // 
            // lblTiempoIndexado
            // 
            lblTiempoIndexado.AutoSize = true;
            lblTiempoIndexado.Location = new Point(575, 110);
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
            label1.Location = new Point(10, 23);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 4;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 63);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 103);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Edad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 143);
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
            // Form1
            // 
            ClientSize = new Size(749, 250);
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
            ResumeLayout(false);
            PerformLayout();
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
    }
}