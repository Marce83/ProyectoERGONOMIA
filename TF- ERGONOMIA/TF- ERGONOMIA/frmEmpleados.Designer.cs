﻿namespace TF.WIN
{
    partial class frmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtApellido = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.cboGenero = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPeso = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtDNI = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvempleados = new System.Windows.Forms.DataGridView();
            this.txtcuitconsulta = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCUITEncontrado = new MaterialSkin.Controls.MaterialTextBox2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCUIT = new System.Windows.Forms.Button();
            this.txtPuestoDeTrabajo = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblPuesto = new MaterialSkin.Controls.MaterialLabel();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAltura = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscartodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(1023, 129);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(155, 43);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Actualizar Datos";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargar.Location = new System.Drawing.Point(1023, 79);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(155, 43);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Nuevo";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(1023, 180);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(155, 43);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(35, 145);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 34;
            this.materialLabel1.Text = "Nombre";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(35, 90);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 19);
            this.materialLabel2.TabIndex = 35;
            this.materialLabel2.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.HideSelection = true;
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(203, 135);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PrefixSuffixText = null;
            this.txtNombre.ReadOnly = false;
            this.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(251, 48);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TabStop = false;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtApellido
            // 
            this.txtApellido.AnimateReadOnly = false;
            this.txtApellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtApellido.Depth = 0;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellido.HideSelection = true;
            this.txtApellido.LeadingIcon = null;
            this.txtApellido.Location = new System.Drawing.Point(203, 82);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.MaxLength = 32767;
            this.txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.PrefixSuffixText = null;
            this.txtApellido.ReadOnly = false;
            this.txtApellido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtApellido.SelectedText = "";
            this.txtApellido.SelectionLength = 0;
            this.txtApellido.SelectionStart = 0;
            this.txtApellido.ShortcutsEnabled = true;
            this.txtApellido.Size = new System.Drawing.Size(251, 48);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.TabStop = false;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtApellido.TrailingIcon = null;
            this.txtApellido.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(35, 41);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(27, 19);
            this.materialLabel3.TabIndex = 36;
            this.materialLabel3.Text = "DNI";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(33, 202);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(129, 19);
            this.materialLabel8.TabIndex = 41;
            this.materialLabel8.Text = "Fecha Nacimiento";
            // 
            // cboGenero
            // 
            this.cboGenero.AutoResize = false;
            this.cboGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboGenero.Depth = 0;
            this.cboGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboGenero.DropDownHeight = 174;
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.DropDownWidth = 121;
            this.cboGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.IntegralHeight = false;
            this.cboGenero.ItemHeight = 43;
            this.cboGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "No Binario"});
            this.cboGenero.Location = new System.Drawing.Point(201, 242);
            this.cboGenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboGenero.MaxDropDownItems = 4;
            this.cboGenero.MouseState = MaterialSkin.MouseState.OUT;
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(252, 49);
            this.cboGenero.StartIndex = 0;
            this.cboGenero.TabIndex = 4;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(33, 258);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(51, 19);
            this.materialLabel4.TabIndex = 37;
            this.materialLabel4.Text = "Genero";
            // 
            // txtPeso
            // 
            this.txtPeso.AnimateReadOnly = false;
            this.txtPeso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPeso.Depth = 0;
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPeso.HideSelection = true;
            this.txtPeso.LeadingIcon = null;
            this.txtPeso.Location = new System.Drawing.Point(88, 30);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPeso.MaxLength = 32767;
            this.txtPeso.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.PasswordChar = '\0';
            this.txtPeso.PrefixSuffixText = null;
            this.txtPeso.ReadOnly = false;
            this.txtPeso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPeso.SelectedText = "";
            this.txtPeso.SelectionLength = 0;
            this.txtPeso.SelectionStart = 0;
            this.txtPeso.ShortcutsEnabled = true;
            this.txtPeso.Size = new System.Drawing.Size(99, 48);
            this.txtPeso.TabIndex = 0;
            this.txtPeso.TabStop = false;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPeso.TrailingIcon = null;
            this.txtPeso.UseSystemPasswordChar = false;
            // 
            // txtDNI
            // 
            this.txtDNI.AnimateReadOnly = false;
            this.txtDNI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDNI.Depth = 0;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDNI.HideSelection = true;
            this.txtDNI.LeadingIcon = null;
            this.txtDNI.Location = new System.Drawing.Point(203, 23);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDNI.MaxLength = 32767;
            this.txtDNI.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.PasswordChar = '\0';
            this.txtDNI.PrefixSuffixText = null;
            this.txtDNI.ReadOnly = false;
            this.txtDNI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDNI.SelectedText = "";
            this.txtDNI.SelectionLength = 0;
            this.txtDNI.SelectionStart = 0;
            this.txtDNI.ShortcutsEnabled = true;
            this.txtDNI.Size = new System.Drawing.Size(252, 48);
            this.txtDNI.TabIndex = 0;
            this.txtDNI.TabStop = false;
            this.txtDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDNI.TrailingIcon = null;
            this.txtDNI.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(208, 46);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(43, 19);
            this.materialLabel5.TabIndex = 38;
            this.materialLabel5.Text = "Altura";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(19, 46);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(36, 19);
            this.materialLabel6.TabIndex = 39;
            this.materialLabel6.Text = "Peso";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(532, 43);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(155, 43);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar por DNI";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvempleados
            // 
            this.dgvempleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvempleados.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvempleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleados.Location = new System.Drawing.Point(5, 101);
            this.dgvempleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvempleados.Name = "dgvempleados";
            this.dgvempleados.RowHeadersWidth = 51;
            this.dgvempleados.RowTemplate.Height = 24;
            this.dgvempleados.Size = new System.Drawing.Size(969, 257);
            this.dgvempleados.TabIndex = 57;
            this.dgvempleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempleados_CellContentClick_1);
            // 
            // txtcuitconsulta
            // 
            this.txtcuitconsulta.AnimateReadOnly = false;
            this.txtcuitconsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtcuitconsulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcuitconsulta.Depth = 0;
            this.txtcuitconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtcuitconsulta.HideSelection = true;
            this.txtcuitconsulta.LeadingIcon = null;
            this.txtcuitconsulta.Location = new System.Drawing.Point(248, 37);
            this.txtcuitconsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcuitconsulta.MaxLength = 32767;
            this.txtcuitconsulta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtcuitconsulta.Name = "txtcuitconsulta";
            this.txtcuitconsulta.PasswordChar = '\0';
            this.txtcuitconsulta.PrefixSuffixText = null;
            this.txtcuitconsulta.ReadOnly = false;
            this.txtcuitconsulta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtcuitconsulta.SelectedText = "";
            this.txtcuitconsulta.SelectionLength = 0;
            this.txtcuitconsulta.SelectionStart = 0;
            this.txtcuitconsulta.ShortcutsEnabled = true;
            this.txtcuitconsulta.Size = new System.Drawing.Size(251, 48);
            this.txtcuitconsulta.TabIndex = 0;
            this.txtcuitconsulta.TabStop = false;
            this.txtcuitconsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcuitconsulta.TrailingIcon = null;
            this.txtcuitconsulta.UseSystemPasswordChar = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(187, 54);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(27, 19);
            this.materialLabel10.TabIndex = 53;
            this.materialLabel10.Text = "DNI";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(465, 34);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(29, 19);
            this.materialLabel11.TabIndex = 59;
            this.materialLabel11.Text = "Cuit";
            // 
            // txtCUITEncontrado
            // 
            this.txtCUITEncontrado.AnimateReadOnly = false;
            this.txtCUITEncontrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCUITEncontrado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCUITEncontrado.Depth = 0;
            this.txtCUITEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCUITEncontrado.HideSelection = true;
            this.txtCUITEncontrado.LeadingIcon = null;
            this.txtCUITEncontrado.Location = new System.Drawing.Point(569, 23);
            this.txtCUITEncontrado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCUITEncontrado.MaxLength = 32767;
            this.txtCUITEncontrado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCUITEncontrado.Name = "txtCUITEncontrado";
            this.txtCUITEncontrado.PasswordChar = '\0';
            this.txtCUITEncontrado.PrefixSuffixText = null;
            this.txtCUITEncontrado.ReadOnly = true;
            this.txtCUITEncontrado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCUITEncontrado.SelectedText = "";
            this.txtCUITEncontrado.SelectionLength = 0;
            this.txtCUITEncontrado.SelectionStart = 0;
            this.txtCUITEncontrado.ShortcutsEnabled = true;
            this.txtCUITEncontrado.Size = new System.Drawing.Size(277, 48);
            this.txtCUITEncontrado.TabIndex = 5;
            this.txtCUITEncontrado.TabStop = false;
            this.txtCUITEncontrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCUITEncontrado.TrailingIcon = null;
            this.txtCUITEncontrado.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarCUIT);
            this.groupBox1.Controls.Add(this.txtPuestoDeTrabajo);
            this.groupBox1.Controls.Add(this.lblPuesto);
            this.groupBox1.Controls.Add(this.dtpNacimiento);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cboGenero);
            this.groupBox1.Controls.Add(this.materialLabel11);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.txtCUITEncontrado);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.materialLabel8);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Location = new System.Drawing.Point(35, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(981, 355);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE EMPLEADOS";
            // 
            // btnBuscarCUIT
            // 
            this.btnBuscarCUIT.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarCUIT.FlatAppearance.BorderSize = 0;
            this.btnBuscarCUIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscarCUIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCUIT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarCUIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCUIT.Location = new System.Drawing.Point(853, 28);
            this.btnBuscarCUIT.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCUIT.Name = "btnBuscarCUIT";
            this.btnBuscarCUIT.Size = new System.Drawing.Size(89, 43);
            this.btnBuscarCUIT.TabIndex = 72;
            this.btnBuscarCUIT.Text = "...";
            this.btnBuscarCUIT.UseVisualStyleBackColor = false;
            this.btnBuscarCUIT.Click += new System.EventHandler(this.btnBuscarCUIT_Click);
            // 
            // txtPuestoDeTrabajo
            // 
            this.txtPuestoDeTrabajo.AnimateReadOnly = false;
            this.txtPuestoDeTrabajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPuestoDeTrabajo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPuestoDeTrabajo.Depth = 0;
            this.txtPuestoDeTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPuestoDeTrabajo.HideSelection = true;
            this.txtPuestoDeTrabajo.LeadingIcon = null;
            this.txtPuestoDeTrabajo.Location = new System.Drawing.Point(656, 135);
            this.txtPuestoDeTrabajo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPuestoDeTrabajo.MaxLength = 32767;
            this.txtPuestoDeTrabajo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPuestoDeTrabajo.Name = "txtPuestoDeTrabajo";
            this.txtPuestoDeTrabajo.PasswordChar = '\0';
            this.txtPuestoDeTrabajo.PrefixSuffixText = null;
            this.txtPuestoDeTrabajo.ReadOnly = false;
            this.txtPuestoDeTrabajo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPuestoDeTrabajo.SelectedText = "";
            this.txtPuestoDeTrabajo.SelectionLength = 0;
            this.txtPuestoDeTrabajo.SelectionStart = 0;
            this.txtPuestoDeTrabajo.ShortcutsEnabled = true;
            this.txtPuestoDeTrabajo.Size = new System.Drawing.Size(277, 48);
            this.txtPuestoDeTrabajo.TabIndex = 6;
            this.txtPuestoDeTrabajo.TabStop = false;
            this.txtPuestoDeTrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPuestoDeTrabajo.TrailingIcon = null;
            this.txtPuestoDeTrabajo.UseSystemPasswordChar = false;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblPuesto.Depth = 0;
            this.lblPuesto.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPuesto.Location = new System.Drawing.Point(473, 162);
            this.lblPuesto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(132, 19);
            this.lblPuesto.TabIndex = 65;
            this.lblPuesto.Text = "Puesto De Trabajo";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dtpNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(203, 197);
            this.dtpNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(249, 26);
            this.dtpNacimiento.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAltura);
            this.groupBox2.Controls.Add(this.materialLabel6);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.Controls.Add(this.txtPeso);
            this.groupBox2.Location = new System.Drawing.Point(476, 202);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(417, 116);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos para Metodos de Analisis";
            // 
            // txtAltura
            // 
            this.txtAltura.AnimateReadOnly = false;
            this.txtAltura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAltura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAltura.Depth = 0;
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAltura.HideSelection = true;
            this.txtAltura.LeadingIcon = null;
            this.txtAltura.Location = new System.Drawing.Point(271, 30);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAltura.MaxLength = 32767;
            this.txtAltura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.PasswordChar = '\0';
            this.txtAltura.PrefixSuffixText = null;
            this.txtAltura.ReadOnly = false;
            this.txtAltura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAltura.SelectedText = "";
            this.txtAltura.SelectionLength = 0;
            this.txtAltura.SelectionStart = 0;
            this.txtAltura.ShortcutsEnabled = true;
            this.txtAltura.Size = new System.Drawing.Size(99, 48);
            this.txtAltura.TabIndex = 1;
            this.txtAltura.TabStop = false;
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAltura.TrailingIcon = null;
            this.txtAltura.UseSystemPasswordChar = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(1023, 236);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(155, 43);
            this.btnLimpiar.TabIndex = 73;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(678, 38);
            this.label1.TabIndex = 62;
            this.label1.Text = "REGISTRO Y CONSULTA DE EMPLEADOS";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscartodo);
            this.groupBox3.Controls.Add(this.txtcuitconsulta);
            this.groupBox3.Controls.Add(this.materialLabel10);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.dgvempleados);
            this.groupBox3.Location = new System.Drawing.Point(35, 454);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(981, 394);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CONSULTAR EMPLEADOS REGISTRADOS";
            // 
            // btnBuscartodo
            // 
            this.btnBuscartodo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscartodo.FlatAppearance.BorderSize = 0;
            this.btnBuscartodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscartodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscartodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscartodo.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBuscartodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscartodo.Location = new System.Drawing.Point(695, 43);
            this.btnBuscartodo.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscartodo.Name = "btnBuscartodo";
            this.btnBuscartodo.Size = new System.Drawing.Size(155, 43);
            this.btnBuscartodo.TabIndex = 58;
            this.btnBuscartodo.Text = "Buscar Todos";
            this.btnBuscartodo.UseVisualStyleBackColor = false;
            this.btnBuscartodo.Click += new System.EventHandler(this.btnBuscartodo_Click_1);
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1196, 858);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleadoss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnEliminar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombre;
        private MaterialSkin.Controls.MaterialTextBox2 txtApellido;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialComboBox cboGenero;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 txtPeso;
        private MaterialSkin.Controls.MaterialTextBox2 txtDNI;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvempleados;
        private MaterialSkin.Controls.MaterialTextBox2 txtcuitconsulta;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialTextBox2 txtCUITEncontrado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private MaterialSkin.Controls.MaterialTextBox2 txtPuestoDeTrabajo;
        private MaterialSkin.Controls.MaterialLabel lblPuesto;
        private System.Windows.Forms.Button btnBuscarCUIT;
        private MaterialSkin.Controls.MaterialTextBox2 txtAltura;
        private System.Windows.Forms.Button btnBuscartodo;
        private System.Windows.Forms.Button btnLimpiar;
    }
}