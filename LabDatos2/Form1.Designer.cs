
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
            // ══════════════════════════════════════════════════════════════
            //  PALETA  —  Rose Executive (variables locales)
            // ══════════════════════════════════════════════════════════════
            Color cBgForm = Color.FromArgb(250, 246, 248);
            Color cBgPanel = Color.White;
            Color cBgInput = Color.FromArgb(253, 250, 252);
            Color cBgInputRO = Color.FromArgb(245, 241, 244);
            Color cRose = Color.FromArgb(188, 100, 130);
            Color cRoseDark = Color.FromArgb(155, 70, 100);
            Color cMauve = Color.FromArgb(160, 120, 155);
            Color cSage = Color.FromArgb(110, 155, 135);
            Color cSlate = Color.FromArgb(100, 110, 140);
            Color cTextDark = Color.FromArgb(60, 45, 55);
            Color cTextMid = Color.FromArgb(90, 55, 72);
            Color cTextLight = Color.FromArgb(148, 85, 112);
            Color cBorder = Color.FromArgb(228, 210, 220);
            Color cHeaderBg = Color.FromArgb(80, 50, 70);
            Color cPanelGap = Color.FromArgb(235, 225, 230);

            Font fontTitle = new Font("Segoe UI", 14F, FontStyle.Bold);
            Font fontSub = new Font("Segoe UI", 8.5F, FontStyle.Regular);
            Font fontSection = new Font("Segoe UI", 8F, FontStyle.Bold);
            Font fontLabel = new Font("Segoe UI", 8F, FontStyle.Bold);
            Font fontInput = new Font("Segoe UI", 10F, FontStyle.Regular);
            Font fontBtn = new Font("Segoe UI", 9F, FontStyle.Bold);
            Font fontBtnSm = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            Font fontSmall = new Font("Segoe UI", 8.5F, FontStyle.Regular);

            // ── Controles ─────────────────────────────────────────────────
            pnlHeader = new Panel();
            pnlLeft = new Panel();
            pnlCenter = new Panel();
            pnlRight = new Panel();

            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblSeccionRegistro = new Label();
            lblSeccionBusqueda = new Label();
            lblSeccionOps = new Label();
            lblLote = new Label();

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
            btnVaciar = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvCiudadanos).BeginInit();
            SuspendLayout();

            // ══════════════════════════════════════════════════════════════
            //  HEADER
            // ══════════════════════════════════════════════════════════════
            Panel pnlAccent = new Panel();
            pnlAccent.BackColor = cRose;
            pnlAccent.Dock = DockStyle.Bottom;
            pnlAccent.Height = 3;

            lblTitulo.Text = "El Arquitecto de Datos";
            lblTitulo.Font = fontTitle;
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 8);
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;

            lblSubtitulo.Text = "Gestión y búsqueda de ciudadanos";
            lblSubtitulo.Font = fontSub;
            lblSubtitulo.ForeColor = Color.FromArgb(200, 175, 190);
            lblSubtitulo.Location = new Point(22, 42);
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;

            pnlHeader.BackColor = cHeaderBg;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 70;
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Controls.Add(pnlAccent);

            // ══════════════════════════════════════════════════════════════
            //  PANEL IZQUIERDO  —  Registro
            // ══════════════════════════════════════════════════════════════
            pnlLeft.BackColor = cBgPanel;
            pnlLeft.Location = new Point(12, 82);
            pnlLeft.Size = new Size(258, 500);
            pnlLeft.Name = "pnlLeft";

            // Sección
            lblSeccionRegistro.Text = "REGISTRO";
            lblSeccionRegistro.Font = fontSection;
            lblSeccionRegistro.ForeColor = cTextLight;
            lblSeccionRegistro.Location = new Point(16, 18);
            lblSeccionRegistro.AutoSize = true;
            lblSeccionRegistro.BackColor = Color.Transparent;

            // ID
            label1.Text = "ID";
            label1.Font = fontLabel;
            label1.ForeColor = cTextMid;
            label1.Location = new Point(16, 46);
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Name = "label1";
            label1.TabIndex = 4;

            txtId.Location = new Point(16, 62);
            txtId.Size = new Size(224, 27);
            txtId.ReadOnly = true;
            txtId.TabIndex = 0;
            txtId.Name = "txtId";
            txtId.BackColor = cBgInputRO;
            txtId.ForeColor = cTextLight;
            txtId.Font = fontInput;
            txtId.BorderStyle = BorderStyle.FixedSingle;

            // Nombre
            label2.Text = "NOMBRE";
            label2.Font = fontLabel;
            label2.ForeColor = cTextMid;
            label2.Location = new Point(16, 100);
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Name = "label2";
            label2.TabIndex = 3;

            txtNombre.Location = new Point(16, 116);
            txtNombre.Size = new Size(224, 27);
            txtNombre.TabIndex = 1;
            txtNombre.Name = "txtNombre";
            txtNombre.BackColor = cBgInput;
            txtNombre.ForeColor = cTextDark;
            txtNombre.Font = fontInput;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;

            // Edad
            label3.Text = "EDAD";
            label3.Font = fontLabel;
            label3.ForeColor = cTextMid;
            label3.Location = new Point(16, 154);
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Name = "label3";
            label3.TabIndex = 2;

            txtEdad.Location = new Point(16, 170);
            txtEdad.Size = new Size(224, 27);
            txtEdad.TabIndex = 2;
            txtEdad.Name = "txtEdad";
            txtEdad.BackColor = cBgInput;
            txtEdad.ForeColor = cTextDark;
            txtEdad.Font = fontInput;
            txtEdad.BorderStyle = BorderStyle.FixedSingle;

            // Posición
            label4.Text = "POSICIÓN";
            label4.Font = fontLabel;
            label4.ForeColor = cTextMid;
            label4.Location = new Point(16, 208);
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Name = "label4";
            label4.TabIndex = 1;

            txtPosicion.Location = new Point(16, 224);
            txtPosicion.Size = new Size(224, 27);
            txtPosicion.TabIndex = 3;
            txtPosicion.Name = "txtPosicion";
            txtPosicion.BackColor = cBgInput;
            txtPosicion.ForeColor = cTextDark;
            txtPosicion.Font = fontInput;
            txtPosicion.BorderStyle = BorderStyle.FixedSingle;

            // Divisor
            Panel divReg = new Panel();
            divReg.BackColor = cBorder;
            divReg.Location = new Point(16, 264);
            divReg.Size = new Size(224, 1);

            // Guardar
            btnGuardar.Location = new Point(16, 276);
            btnGuardar.Size = new Size(224, 34);
            btnGuardar.Text = "Guardar Registro";
            btnGuardar.TabIndex = 4;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.BackColor = cRose;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Font = fontBtn;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Click += btnGuardar_Click;

            // Editar
            btnEditar.Location = new Point(16, 320);
            btnEditar.Size = new Size(108, 30);
            btnEditar.Text = "Editar";
            btnEditar.TabIndex = 15;
            btnEditar.Name = "btnEditar";
            btnEditar.BackColor = cBgPanel;
            btnEditar.ForeColor = cMauve;
            btnEditar.Font = fontBtnSm;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.FlatAppearance.BorderColor = cMauve;
            btnEditar.FlatAppearance.BorderSize = 1;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Click += btnEditar_Click;

            // Eliminar
            btnEliminar.Location = new Point(132, 320);
            btnEliminar.Size = new Size(108, 30);
            btnEliminar.Text = "Eliminar";
            btnEliminar.TabIndex = 16;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.BackColor = cBgPanel;
            btnEliminar.ForeColor = cRoseDark;
            btnEliminar.Font = fontBtnSm;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.FlatAppearance.BorderColor = cRoseDark;
            btnEliminar.FlatAppearance.BorderSize = 1;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Click += btnEliminar_Click;

            // Cargar
            btnCargar.Location = new Point(16, 360);
            btnCargar.Size = new Size(108, 30);
            btnCargar.Text = "Cargar";
            btnCargar.TabIndex = 17;
            btnCargar.Name = "btnCargar";
            btnCargar.BackColor = cBgPanel;
            btnCargar.ForeColor = cTextLight;
            btnCargar.Font = fontBtnSm;
            btnCargar.FlatStyle = FlatStyle.Flat;
            btnCargar.FlatAppearance.BorderColor = cTextLight;
            btnCargar.FlatAppearance.BorderSize = 1;
            btnCargar.Cursor = Cursors.Hand;
            btnCargar.Click += btnCargar_Click;

            // Vaciar
            btnVaciar.Location = new Point(132, 360);
            btnVaciar.Size = new Size(108, 30);
            btnVaciar.Text = "Vaciar";
            btnVaciar.TabIndex = 19;
            btnVaciar.Name = "btnVaciar";
            btnVaciar.BackColor = cBgPanel;
            btnVaciar.ForeColor = cTextLight;
            btnVaciar.Font = fontBtnSm;
            btnVaciar.FlatStyle = FlatStyle.Flat;
            btnVaciar.FlatAppearance.BorderColor = cTextLight;
            btnVaciar.FlatAppearance.BorderSize = 1;
            btnVaciar.Cursor = Cursors.Hand;
            btnVaciar.Click += btnVaciar_Click;

            // Divisor lote
            Panel divLote = new Panel();
            divLote.BackColor = cBorder;
            divLote.Location = new Point(16, 404);
            divLote.Size = new Size(224, 1);

            // Tamaño de lote
            lblLote.Text = "TAMAÑO DE LOTE";
            lblLote.Font = fontLabel;
            lblLote.ForeColor = cTextMid;
            lblLote.Location = new Point(16, 414);
            lblLote.AutoSize = true;
            lblLote.BackColor = Color.Transparent;

            txtTamañoLote.Location = new Point(16, 432);
            txtTamañoLote.Size = new Size(224, 40);
            txtTamañoLote.Font = new Font("Segoe UI", 12F);
            txtTamañoLote.Multiline = true;
            txtTamañoLote.TabIndex = 18;
            txtTamañoLote.Name = "txtTamañoLote";
            txtTamañoLote.BackColor = cBgInput;
            txtTamañoLote.ForeColor = cTextDark;
            txtTamañoLote.BorderStyle = BorderStyle.FixedSingle;

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
            pnlLeft.Controls.Add(lblLote);
            pnlLeft.Controls.Add(txtTamañoLote);

            // ══════════════════════════════════════════════════════════════
            //  PANEL CENTRAL  —  Búsqueda
            // ══════════════════════════════════════════════════════════════
            pnlCenter.BackColor = cBgPanel;
            pnlCenter.Location = new Point(282, 82);
            pnlCenter.Size = new Size(258, 500);
            pnlCenter.Name = "pnlCenter";

            lblSeccionBusqueda.Text = "BÚSQUEDA";
            lblSeccionBusqueda.Font = fontSection;
            lblSeccionBusqueda.ForeColor = cTextLight;
            lblSeccionBusqueda.Location = new Point(16, 18);
            lblSeccionBusqueda.AutoSize = true;
            lblSeccionBusqueda.BackColor = Color.Transparent;

            label5.Text = "ID A BUSCAR";
            label5.Font = fontLabel;
            label5.ForeColor = cTextMid;
            label5.Location = new Point(16, 46);
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Name = "label5";
            label5.TabIndex = 0;

            txtBuscarId.Location = new Point(16, 62);
            txtBuscarId.Size = new Size(224, 27);
            txtBuscarId.TabIndex = 5;
            txtBuscarId.Name = "txtBuscarId";
            txtBuscarId.BackColor = cBgInput;
            txtBuscarId.ForeColor = cTextDark;
            txtBuscarId.Font = fontInput;
            txtBuscarId.BorderStyle = BorderStyle.FixedSingle;

            btnBuscarSecuencial.Location = new Point(16, 104);
            btnBuscarSecuencial.Size = new Size(224, 32);
            btnBuscarSecuencial.Text = "Búsqueda Secuencial";
            btnBuscarSecuencial.TabIndex = 6;
            btnBuscarSecuencial.Name = "btnBuscarSecuencial";
            btnBuscarSecuencial.BackColor = cBgPanel;
            btnBuscarSecuencial.ForeColor = cMauve;
            btnBuscarSecuencial.Font = fontBtnSm;
            btnBuscarSecuencial.FlatStyle = FlatStyle.Flat;
            btnBuscarSecuencial.FlatAppearance.BorderColor = cMauve;
            btnBuscarSecuencial.FlatAppearance.BorderSize = 1;
            btnBuscarSecuencial.Cursor = Cursors.Hand;
            btnBuscarSecuencial.Click += btnBuscarSecuencial_Click;

            btnBuscarIndexado.Location = new Point(16, 146);
            btnBuscarIndexado.Size = new Size(224, 32);
            btnBuscarIndexado.Text = "Búsqueda Indexada";
            btnBuscarIndexado.TabIndex = 7;
            btnBuscarIndexado.Name = "btnBuscarIndexado";
            btnBuscarIndexado.BackColor = cSage;
            btnBuscarIndexado.ForeColor = Color.White;
            btnBuscarIndexado.Font = fontBtnSm;
            btnBuscarIndexado.FlatStyle = FlatStyle.Flat;
            btnBuscarIndexado.FlatAppearance.BorderSize = 0;
            btnBuscarIndexado.Cursor = Cursors.Hand;
            btnBuscarIndexado.Click += btnBuscarIndexado_Click;

            Panel divRes = new Panel();
            divRes.BackColor = cBorder;
            divRes.Location = new Point(16, 194);
            divRes.Size = new Size(224, 1);

            lblResultado.Text = "Esperando búsqueda...";
            lblResultado.Font = fontSmall;
            lblResultado.ForeColor = cTextLight;
            lblResultado.Location = new Point(16, 200);
            lblResultado.Size = new Size(224, 42);
            lblResultado.AutoSize = false;
            lblResultado.BackColor = Color.Transparent;
            lblResultado.Name = "lblResultado";
            lblResultado.TabIndex = 10;

            Label lblTimingTitle = new Label();
            lblTimingTitle.Text = "TIEMPOS DE EJECUCIÓN";
            lblTimingTitle.Font = fontLabel;
            lblTimingTitle.ForeColor = cTextLight;
            lblTimingTitle.Location = new Point(16, 252);
            lblTimingTitle.AutoSize = true;
            lblTimingTitle.BackColor = Color.Transparent;

            lblTiempoSecuencial.Text = "Secuencial:  0 ticks";
            lblTiempoSecuencial.Font = fontSmall;
            lblTiempoSecuencial.ForeColor = cTextMid;
            lblTiempoSecuencial.Location = new Point(16, 274);
            lblTiempoSecuencial.AutoSize = true;
            lblTiempoSecuencial.BackColor = Color.Transparent;
            lblTiempoSecuencial.Name = "lblTiempoSecuencial";
            lblTiempoSecuencial.TabIndex = 8;

            lblTiempoIndexado.Text = "Indexada:    0 ticks";
            lblTiempoIndexado.Font = fontSmall;
            lblTiempoIndexado.ForeColor = cSage;
            lblTiempoIndexado.Location = new Point(16, 296);
            lblTiempoIndexado.AutoSize = true;
            lblTiempoIndexado.BackColor = Color.Transparent;
            lblTiempoIndexado.Name = "lblTiempoIndexado";
            lblTiempoIndexado.TabIndex = 9;

            Panel divOps = new Panel();
            divOps.BackColor = cBorder;
            divOps.Location = new Point(16, 328);
            divOps.Size = new Size(224, 1);

            lblSeccionOps.Text = "OPERACIONES";
            lblSeccionOps.Font = fontSection;
            lblSeccionOps.ForeColor = cTextLight;
            lblSeccionOps.Location = new Point(16, 340);
            lblSeccionOps.AutoSize = true;
            lblSeccionOps.BackColor = Color.Transparent;

            btnMigrarSql.Location = new Point(16, 364);
            btnMigrarSql.Size = new Size(224, 32);
            btnMigrarSql.Text = "Migrar a SQL Server";
            btnMigrarSql.TabIndex = 11;
            btnMigrarSql.Name = "btnMigrarSql";
            btnMigrarSql.BackColor = cSlate;
            btnMigrarSql.ForeColor = Color.White;
            btnMigrarSql.Font = fontBtnSm;
            btnMigrarSql.FlatStyle = FlatStyle.Flat;
            btnMigrarSql.FlatAppearance.BorderSize = 0;
            btnMigrarSql.Cursor = Cursors.Hand;
            btnMigrarSql.Click += btnMigrarSql_Click;

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

            // ══════════════════════════════════════════════════════════════
            //  PANEL DERECHO  —  Datos
            // ══════════════════════════════════════════════════════════════
            pnlRight.BackColor = cBgPanel;
            pnlRight.Location = new Point(552, 82);
            pnlRight.Size = new Size(706, 500);
            pnlRight.Name = "pnlRight";

            label6.Text = "DATOS DE CIUDADANOS";
            label6.Font = fontSection;
            label6.ForeColor = cTextLight;
            label6.Location = new Point(16, 20);
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Name = "label6";
            label6.TabIndex = 13;

            btnMostrarDatos.Location = new Point(558, 12);
            btnMostrarDatos.Size = new Size(130, 32);
            btnMostrarDatos.Text = "Mostrar Datos";
            btnMostrarDatos.TabIndex = 14;
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.BackColor = cRose;
            btnMostrarDatos.ForeColor = Color.White;
            btnMostrarDatos.Font = fontBtn;
            btnMostrarDatos.FlatStyle = FlatStyle.Flat;
            btnMostrarDatos.FlatAppearance.BorderSize = 0;
            btnMostrarDatos.Cursor = Cursors.Hand;
            btnMostrarDatos.Click += btnMostrarDatos_Click;

            dgvCiudadanos.Location = new Point(16, 52);
            dgvCiudadanos.Size = new Size(672, 436);
            dgvCiudadanos.Name = "dgvCiudadanos";
            dgvCiudadanos.TabIndex = 12;
            dgvCiudadanos.RowHeadersWidth = 51;
            dgvCiudadanos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCiudadanos.CellDoubleClick += dgvCiudadanos_CellDoubleClick;

            pnlRight.Controls.Add(label6);
            pnlRight.Controls.Add(btnMostrarDatos);
            pnlRight.Controls.Add(dgvCiudadanos);

            // ── Separadores visuales ──────────────────────────────────────
            Panel sepLC = new Panel();
            sepLC.BackColor = cPanelGap;
            sepLC.Location = new Point(270, 82);
            sepLC.Size = new Size(12, 500);

            Panel sepCR = new Panel();
            sepCR.BackColor = cPanelGap;
            sepCR.Location = new Point(540, 82);
            sepCR.Size = new Size(12, 500);

            // ══════════════════════════════════════════════════════════════
            //  FORMULARIO
            // ══════════════════════════════════════════════════════════════
            BackColor = cBgForm;
            ClientSize = new Size(1270, 594);
            Text = "El Arquitecto de Datos";
            Name = "Form1";
            Font = new Font("Segoe UI", 9.5F);

            Controls.Add(pnlHeader);
            Controls.Add(pnlLeft);
            Controls.Add(sepLC);
            Controls.Add(pnlCenter);
            Controls.Add(sepCR);
            Controls.Add(pnlRight);

            Load += Form1_Load;

            ((System.ComponentModel.ISupportInitialize)dgvCiudadanos).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}
