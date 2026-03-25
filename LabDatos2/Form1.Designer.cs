
using System.Drawing;
using System.Windows.Forms;

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
            pnlHeader = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            pnlAccent = new Panel();
            pnlLeft = new Panel();
            lblSeccionRegistro = new Label();
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtEdad = new TextBox();
            label4 = new Label();
            txtPosicion = new TextBox();
            divReg = new Panel();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnCargar = new Button();
            btnVaciar = new Button();
            divLote = new Panel();
            lblLote = new Label();
            txtTamañoLote = new TextBox();
            pnlCenter = new Panel();
            lblSeccionBusqueda = new Label();
            label5 = new Label();
            txtBuscarId = new TextBox();
            btnBuscarSecuencial = new Button();
            btnBuscarIndexado = new Button();
            divRes = new Panel();
            lblResultado = new Label();
            lblTimingTitle = new Label();
            lblTiempoSecuencial = new Label();
            lblTiempoIndexado = new Label();
            divOps = new Panel();
            lblSeccionOps = new Label();
            btnMigrarSql = new Button();
            pnlRight = new Panel();
            label6 = new Label();
            btnMostrarDatos = new Button();
            dgvCiudadanos = new DataGridView();
            sepLC = new Panel();
            sepCR = new Panel();
            pnlHeader.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlCenter.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCiudadanos).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(80, 50, 70);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Controls.Add(pnlAccent);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1270, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(271, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "El Arquitecto de Datos";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 8.5F);
            lblSubtitulo.ForeColor = Color.FromArgb(200, 175, 190);
            lblSubtitulo.Location = new Point(22, 42);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(240, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Gestión y búsqueda de ciudadanos";
            // 
            // pnlAccent
            // 
            pnlAccent.BackColor = Color.FromArgb(188, 100, 130);
            pnlAccent.Dock = DockStyle.Bottom;
            pnlAccent.Location = new Point(0, 67);
            pnlAccent.Name = "pnlAccent";
            pnlAccent.Size = new Size(1270, 3);
            pnlAccent.TabIndex = 2;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.White;
            pnlLeft.Controls.Add(lblSeccionRegistro);
            pnlLeft.Controls.Add(label1);
            pnlLeft.Controls.Add(txtId);
            pnlLeft.Controls.Add(label2);
            pnlLeft.Controls.Add(txtNombre);
            pnlLeft.Controls.Add(label3);
            pnlLeft.Controls.Add(txtEdad);
            pnlLeft.Controls.Add(label4);
            pnlLeft.Controls.Add(txtPosicion);
            pnlLeft.Controls.Add(divReg);
            pnlLeft.Controls.Add(btnGuardar);
            pnlLeft.Controls.Add(btnEditar);
            pnlLeft.Controls.Add(btnEliminar);
            pnlLeft.Controls.Add(btnCargar);
            pnlLeft.Controls.Add(btnVaciar);
            pnlLeft.Controls.Add(divLote);
            pnlLeft.Location = new Point(12, 82);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(258, 500);
            pnlLeft.TabIndex = 1;
            // 
            // lblSeccionRegistro
            // 
            lblSeccionRegistro.AutoSize = true;
            lblSeccionRegistro.BackColor = Color.Transparent;
            lblSeccionRegistro.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblSeccionRegistro.ForeColor = Color.FromArgb(148, 85, 112);
            lblSeccionRegistro.Location = new Point(16, 18);
            lblSeccionRegistro.Name = "lblSeccionRegistro";
            lblSeccionRegistro.Size = new Size(75, 19);
            lblSeccionRegistro.TabIndex = 0;
            lblSeccionRegistro.Text = "REGISTRO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(90, 55, 72);
            label1.Location = new Point(16, 46);
            label1.Name = "label1";
            label1.Size = new Size(23, 19);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(245, 241, 244);
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.ForeColor = Color.FromArgb(148, 85, 112);
            txtId.Location = new Point(16, 62);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(224, 30);
            txtId.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(90, 55, 72);
            label2.Location = new Point(16, 100);
            label2.Name = "label2";
            label2.Size = new Size(69, 19);
            label2.TabIndex = 3;
            label2.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(253, 250, 252);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.ForeColor = Color.FromArgb(60, 45, 55);
            txtNombre.Location = new Point(16, 116);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(224, 30);
            txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(90, 55, 72);
            label3.Location = new Point(16, 154);
            label3.Name = "label3";
            label3.Size = new Size(46, 19);
            label3.TabIndex = 2;
            label3.Text = "EDAD";
            // 
            // txtEdad
            // 
            txtEdad.BackColor = Color.FromArgb(253, 250, 252);
            txtEdad.BorderStyle = BorderStyle.FixedSingle;
            txtEdad.Font = new Font("Segoe UI", 10F);
            txtEdad.ForeColor = Color.FromArgb(60, 45, 55);
            txtEdad.Location = new Point(16, 170);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(224, 30);
            txtEdad.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(90, 55, 72);
            label4.Location = new Point(16, 208);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 1;
            label4.Text = "POSICIÓN";
            // 
            // txtPosicion
            // 
            txtPosicion.BackColor = Color.FromArgb(253, 250, 252);
            txtPosicion.BorderStyle = BorderStyle.FixedSingle;
            txtPosicion.Font = new Font("Segoe UI", 10F);
            txtPosicion.ForeColor = Color.FromArgb(60, 45, 55);
            txtPosicion.Location = new Point(16, 224);
            txtPosicion.Name = "txtPosicion";
            txtPosicion.Size = new Size(224, 30);
            txtPosicion.TabIndex = 3;
            // 
            // divReg
            // 
            divReg.BackColor = Color.FromArgb(228, 210, 220);
            divReg.Location = new Point(16, 264);
            divReg.Name = "divReg";
            divReg.Size = new Size(224, 1);
            divReg.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(188, 100, 130);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(16, 276);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(224, 34);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar Registro";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(160, 120, 155);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnEditar.ForeColor = Color.FromArgb(160, 120, 155);
            btnEditar.Location = new Point(16, 320);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(108, 30);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(155, 70, 100);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.FromArgb(155, 70, 100);
            btnEliminar.Location = new Point(132, 320);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(108, 30);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.White;
            btnCargar.Cursor = Cursors.Hand;
            btnCargar.FlatAppearance.BorderColor = Color.FromArgb(148, 85, 112);
            btnCargar.FlatStyle = FlatStyle.Flat;
            btnCargar.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnCargar.ForeColor = Color.FromArgb(148, 85, 112);
            btnCargar.Location = new Point(16, 360);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(108, 30);
            btnCargar.TabIndex = 17;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnVaciar
            // 
            btnVaciar.BackColor = Color.White;
            btnVaciar.Cursor = Cursors.Hand;
            btnVaciar.FlatAppearance.BorderColor = Color.FromArgb(148, 85, 112);
            btnVaciar.FlatStyle = FlatStyle.Flat;
            btnVaciar.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnVaciar.ForeColor = Color.FromArgb(148, 85, 112);
            btnVaciar.Location = new Point(132, 360);
            btnVaciar.Name = "btnVaciar";
            btnVaciar.Size = new Size(108, 30);
            btnVaciar.TabIndex = 19;
            btnVaciar.Text = "Vaciar";
            btnVaciar.UseVisualStyleBackColor = false;
            btnVaciar.Click += btnVaciar_Click;
            // 
            // divLote
            // 
            divLote.BackColor = Color.FromArgb(228, 210, 220);
            divLote.Location = new Point(16, 404);
            divLote.Name = "divLote";
            divLote.Size = new Size(224, 1);
            divLote.TabIndex = 20;
            // 
            // lblLote
            // 
            lblLote.AutoSize = true;
            lblLote.BackColor = Color.Transparent;
            lblLote.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblLote.ForeColor = Color.FromArgb(90, 55, 72);
            lblLote.Location = new Point(16, 371);
            lblLote.Name = "lblLote";
            lblLote.Size = new Size(128, 19);
            lblLote.TabIndex = 21;
            lblLote.Text = "TAMAÑO DE LOTE";
            // 
            // txtTamañoLote
            // 
            txtTamañoLote.BackColor = Color.FromArgb(253, 250, 252);
            txtTamañoLote.BorderStyle = BorderStyle.FixedSingle;
            txtTamañoLote.Font = new Font("Segoe UI", 12F);
            txtTamañoLote.ForeColor = Color.FromArgb(60, 45, 55);
            txtTamañoLote.Location = new Point(16, 393);
            txtTamañoLote.Multiline = true;
            txtTamañoLote.Name = "txtTamañoLote";
            txtTamañoLote.Size = new Size(224, 40);
            txtTamañoLote.TabIndex = 18;
            // 
            // pnlCenter
            // 
            pnlCenter.BackColor = Color.White;
            pnlCenter.Controls.Add(lblSeccionBusqueda);
            pnlCenter.Controls.Add(label5);
            pnlCenter.Controls.Add(txtBuscarId);
            pnlCenter.Controls.Add(btnBuscarSecuencial);
            pnlCenter.Controls.Add(btnBuscarIndexado);
            pnlCenter.Controls.Add(divRes);
            pnlCenter.Controls.Add(lblResultado);
            pnlCenter.Controls.Add(lblTimingTitle);
            pnlCenter.Controls.Add(lblTiempoSecuencial);
            pnlCenter.Controls.Add(lblTiempoIndexado);
            pnlCenter.Controls.Add(divOps);
            pnlCenter.Controls.Add(lblSeccionOps);
            pnlCenter.Controls.Add(btnMigrarSql);
            pnlCenter.Controls.Add(lblLote);
            pnlCenter.Controls.Add(txtTamañoLote);
            pnlCenter.Location = new Point(282, 82);
            pnlCenter.Name = "pnlCenter";
            pnlCenter.Size = new Size(258, 500);
            pnlCenter.TabIndex = 3;
            // 
            // lblSeccionBusqueda
            // 
            lblSeccionBusqueda.AutoSize = true;
            lblSeccionBusqueda.BackColor = Color.Transparent;
            lblSeccionBusqueda.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblSeccionBusqueda.ForeColor = Color.FromArgb(148, 85, 112);
            lblSeccionBusqueda.Location = new Point(16, 18);
            lblSeccionBusqueda.Name = "lblSeccionBusqueda";
            lblSeccionBusqueda.Size = new Size(84, 19);
            lblSeccionBusqueda.TabIndex = 0;
            lblSeccionBusqueda.Text = "BÚSQUEDA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(90, 55, 72);
            label5.Location = new Point(16, 46);
            label5.Name = "label5";
            label5.Size = new Size(96, 19);
            label5.TabIndex = 0;
            label5.Text = "ID A BUSCAR";
            // 
            // txtBuscarId
            // 
            txtBuscarId.BackColor = Color.FromArgb(253, 250, 252);
            txtBuscarId.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarId.Font = new Font("Segoe UI", 10F);
            txtBuscarId.ForeColor = Color.FromArgb(60, 45, 55);
            txtBuscarId.Location = new Point(16, 62);
            txtBuscarId.Name = "txtBuscarId";
            txtBuscarId.Size = new Size(224, 30);
            txtBuscarId.TabIndex = 5;
            // 
            // btnBuscarSecuencial
            // 
            btnBuscarSecuencial.BackColor = Color.White;
            btnBuscarSecuencial.Cursor = Cursors.Hand;
            btnBuscarSecuencial.FlatAppearance.BorderColor = Color.FromArgb(160, 120, 155);
            btnBuscarSecuencial.FlatStyle = FlatStyle.Flat;
            btnBuscarSecuencial.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnBuscarSecuencial.ForeColor = Color.FromArgb(160, 120, 155);
            btnBuscarSecuencial.Location = new Point(16, 104);
            btnBuscarSecuencial.Name = "btnBuscarSecuencial";
            btnBuscarSecuencial.Size = new Size(224, 32);
            btnBuscarSecuencial.TabIndex = 6;
            btnBuscarSecuencial.Text = "Búsqueda Secuencial";
            btnBuscarSecuencial.UseVisualStyleBackColor = false;
            btnBuscarSecuencial.Click += btnBuscarSecuencial_Click;
            // 
            // btnBuscarIndexado
            // 
            btnBuscarIndexado.BackColor = Color.FromArgb(110, 155, 135);
            btnBuscarIndexado.Cursor = Cursors.Hand;
            btnBuscarIndexado.FlatAppearance.BorderSize = 0;
            btnBuscarIndexado.FlatStyle = FlatStyle.Flat;
            btnBuscarIndexado.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnBuscarIndexado.ForeColor = Color.White;
            btnBuscarIndexado.Location = new Point(16, 146);
            btnBuscarIndexado.Name = "btnBuscarIndexado";
            btnBuscarIndexado.Size = new Size(224, 32);
            btnBuscarIndexado.TabIndex = 7;
            btnBuscarIndexado.Text = "Búsqueda Indexada";
            btnBuscarIndexado.UseVisualStyleBackColor = false;
            btnBuscarIndexado.Click += btnBuscarIndexado_Click;
            // 
            // divRes
            // 
            divRes.BackColor = Color.FromArgb(228, 210, 220);
            divRes.Location = new Point(16, 194);
            divRes.Name = "divRes";
            divRes.Size = new Size(224, 1);
            divRes.TabIndex = 8;
            // 
            // lblResultado
            // 
            lblResultado.BackColor = Color.Transparent;
            lblResultado.Font = new Font("Segoe UI", 8.5F);
            lblResultado.ForeColor = Color.FromArgb(148, 85, 112);
            lblResultado.Location = new Point(16, 200);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(224, 42);
            lblResultado.TabIndex = 10;
            lblResultado.Text = "Esperando búsqueda...";
            // 
            // lblTimingTitle
            // 
            lblTimingTitle.AutoSize = true;
            lblTimingTitle.BackColor = Color.Transparent;
            lblTimingTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTimingTitle.ForeColor = Color.FromArgb(148, 85, 112);
            lblTimingTitle.Location = new Point(16, 252);
            lblTimingTitle.Name = "lblTimingTitle";
            lblTimingTitle.Size = new Size(168, 19);
            lblTimingTitle.TabIndex = 11;
            lblTimingTitle.Text = "TIEMPOS DE EJECUCIÓN";
            // 
            // lblTiempoSecuencial
            // 
            lblTiempoSecuencial.AutoSize = true;
            lblTiempoSecuencial.BackColor = Color.Transparent;
            lblTiempoSecuencial.Font = new Font("Segoe UI", 8.5F);
            lblTiempoSecuencial.ForeColor = Color.FromArgb(90, 55, 72);
            lblTiempoSecuencial.Location = new Point(16, 274);
            lblTiempoSecuencial.Name = "lblTiempoSecuencial";
            lblTiempoSecuencial.Size = new Size(131, 20);
            lblTiempoSecuencial.TabIndex = 8;
            lblTiempoSecuencial.Text = "Secuencial:  0 ticks";
            // 
            // lblTiempoIndexado
            // 
            lblTiempoIndexado.AutoSize = true;
            lblTiempoIndexado.BackColor = Color.Transparent;
            lblTiempoIndexado.Font = new Font("Segoe UI", 8.5F);
            lblTiempoIndexado.ForeColor = Color.FromArgb(110, 155, 135);
            lblTiempoIndexado.Location = new Point(16, 296);
            lblTiempoIndexado.Name = "lblTiempoIndexado";
            lblTiempoIndexado.Size = new Size(130, 20);
            lblTiempoIndexado.TabIndex = 9;
            lblTiempoIndexado.Text = "Indexada:    0 ticks";
            // 
            // divOps
            // 
            divOps.BackColor = Color.FromArgb(228, 210, 220);
            divOps.Location = new Point(16, 328);
            divOps.Name = "divOps";
            divOps.Size = new Size(224, 1);
            divOps.TabIndex = 12;
            // 
            // lblSeccionOps
            // 
            lblSeccionOps.AutoSize = true;
            lblSeccionOps.BackColor = Color.Transparent;
            lblSeccionOps.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblSeccionOps.ForeColor = Color.FromArgb(148, 85, 112);
            lblSeccionOps.Location = new Point(16, 340);
            lblSeccionOps.Name = "lblSeccionOps";
            lblSeccionOps.Size = new Size(105, 19);
            lblSeccionOps.TabIndex = 13;
            lblSeccionOps.Text = "OPERACIONES";
            // 
            // btnMigrarSql
            // 
            btnMigrarSql.BackColor = Color.FromArgb(100, 110, 140);
            btnMigrarSql.Cursor = Cursors.Hand;
            btnMigrarSql.FlatAppearance.BorderSize = 0;
            btnMigrarSql.FlatStyle = FlatStyle.Flat;
            btnMigrarSql.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnMigrarSql.ForeColor = Color.White;
            btnMigrarSql.Location = new Point(16, 449);
            btnMigrarSql.Name = "btnMigrarSql";
            btnMigrarSql.Size = new Size(224, 32);
            btnMigrarSql.TabIndex = 11;
            btnMigrarSql.Text = "Migrar a SQL Server";
            btnMigrarSql.UseVisualStyleBackColor = false;
            btnMigrarSql.Click += btnMigrarSql_Click;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(label6);
            pnlRight.Controls.Add(btnMostrarDatos);
            pnlRight.Controls.Add(dgvCiudadanos);
            pnlRight.Location = new Point(552, 82);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(706, 500);
            pnlRight.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(148, 85, 112);
            label6.Location = new Point(16, 20);
            label6.Name = "label6";
            label6.Size = new Size(172, 19);
            label6.TabIndex = 13;
            label6.Text = "DATOS DE CIUDADANOS";
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.BackColor = Color.FromArgb(188, 100, 130);
            btnMostrarDatos.Cursor = Cursors.Hand;
            btnMostrarDatos.FlatAppearance.BorderSize = 0;
            btnMostrarDatos.FlatStyle = FlatStyle.Flat;
            btnMostrarDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMostrarDatos.ForeColor = Color.White;
            btnMostrarDatos.Location = new Point(558, 12);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(130, 32);
            btnMostrarDatos.TabIndex = 14;
            btnMostrarDatos.Text = "Mostrar Datos";
            btnMostrarDatos.UseVisualStyleBackColor = false;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // dgvCiudadanos
            // 
            dgvCiudadanos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCiudadanos.Location = new Point(16, 52);
            dgvCiudadanos.Name = "dgvCiudadanos";
            dgvCiudadanos.RowHeadersWidth = 51;
            dgvCiudadanos.Size = new Size(672, 436);
            dgvCiudadanos.TabIndex = 12;
            dgvCiudadanos.CellDoubleClick += dgvCiudadanos_CellDoubleClick;
            // 
            // sepLC
            // 
            sepLC.BackColor = Color.FromArgb(235, 225, 230);
            sepLC.Location = new Point(270, 82);
            sepLC.Name = "sepLC";
            sepLC.Size = new Size(12, 500);
            sepLC.TabIndex = 2;
            // 
            // sepCR
            // 
            sepCR.BackColor = Color.FromArgb(235, 225, 230);
            sepCR.Location = new Point(540, 82);
            sepCR.Name = "sepCR";
            sepCR.Size = new Size(12, 500);
            sepCR.TabIndex = 4;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(250, 246, 248);
            ClientSize = new Size(1270, 594);
            Controls.Add(pnlHeader);
            Controls.Add(pnlLeft);
            Controls.Add(sepLC);
            Controls.Add(pnlCenter);
            Controls.Add(sepCR);
            Controls.Add(pnlRight);
            Font = new Font("Segoe UI", 9.5F);
            Name = "Form1";
            Text = "El Arquitecto de Datos";
            Load += Form1_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlCenter.ResumeLayout(false);
            pnlCenter.PerformLayout();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCiudadanos).EndInit();
            ResumeLayout(false);
        }

        // ══════════════════════════════════════════════════════════════
        //  TABLA  —  ConfigurarDisenoTabla (llamado desde Form1.cs)
        // ══════════════════════════════════════════════════════════════
        private void ConfigurarDisenoTabla()
        {
            dgvCiudadanos.AutoGenerateColumns = false;
            dgvCiudadanos.Columns.Clear();

            dgvCiudadanos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IdProp",
                HeaderText = "ID",
                Width = 65,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dgvCiudadanos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreProp",
                HeaderText = "Nombre Completo",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvCiudadanos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EdadProp",
                HeaderText = "Edad",
                Width = 80,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dgvCiudadanos.AllowUserToAddRows = false;
            dgvCiudadanos.ReadOnly = true;
            dgvCiudadanos.RowHeadersVisible = false;
            dgvCiudadanos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCiudadanos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCiudadanos.BackgroundColor = Color.White;
            dgvCiudadanos.GridColor = Color.FromArgb(228, 210, 220);

            dgvCiudadanos.DefaultCellStyle.BackColor = Color.White;
            dgvCiudadanos.DefaultCellStyle.ForeColor = Color.FromArgb(60, 45, 55);
            dgvCiudadanos.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvCiudadanos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(188, 100, 130);
            dgvCiudadanos.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvCiudadanos.EnableHeadersVisualStyles = false;
            dgvCiudadanos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(80, 50, 70);
            dgvCiudadanos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCiudadanos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvCiudadanos.ColumnHeadersHeight = 36;

            dgvCiudadanos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(253, 247, 250);
            dgvCiudadanos.RowTemplate.Height = 30;
        }

        // ── Campos privados ──────────────────────────────────────────
        private Panel pnlHeader;
        private Panel pnlLeft;
        private Panel pnlCenter;
        private Panel pnlRight;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblSeccionRegistro;
        private Label lblSeccionBusqueda;
        private Label lblSeccionOps;
        private Label lblLote;

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
        private Button btnVaciar;
        private Panel pnlAccent;
        private Panel divReg;
        private Panel divLote;
        private Panel divRes;
        private Label lblTimingTitle;
        private Panel divOps;
        private Panel sepLC;
        private Panel sepCR;
    }
}
