﻿
namespace TF.WIN
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsrLog = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.cerrarsesion = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnMetodo = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.PanelConector = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsrCar = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BarraTitulo.Controls.Add(this.lblUsrCar);
            this.BarraTitulo.Controls.Add(this.label2);
            this.BarraTitulo.Controls.Add(this.label3);
            this.BarraTitulo.Controls.Add(this.lblUsrLog);
            this.BarraTitulo.Controls.Add(this.labelHora);
            this.BarraTitulo.Controls.Add(this.button1);
            this.BarraTitulo.Controls.Add(this.label1);
            this.BarraTitulo.Controls.Add(this.btnRestaurar);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnMaximizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1215, 64);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(831, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Usuario:";
            // 
            // lblUsrLog
            // 
            this.lblUsrLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsrLog.AutoSize = true;
            this.lblUsrLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsrLog.Location = new System.Drawing.Point(927, 10);
            this.lblUsrLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsrLog.Name = "lblUsrLog";
            this.lblUsrLog.Size = new System.Drawing.Size(88, 26);
            this.lblUsrLog.TabIndex = 7;
            this.lblUsrLog.Text = "Usr Log";
            // 
            // labelHora
            // 
            this.labelHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHora.Location = new System.Drawing.Point(290, 14);
            this.labelHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(59, 26);
            this.labelHora.TabIndex = 6;
            this.labelHora.Text = "Hora";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(250, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "__\r\n--";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu Principal";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1150, 14);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1119, 14);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1150, 14);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1181, 14);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.SystemColors.HotTrack;
            this.MenuVertical.Controls.Add(this.cerrarsesion);
            this.MenuVertical.Controls.Add(this.button2);
            this.MenuVertical.Controls.Add(this.btnEstadisticas);
            this.MenuVertical.Controls.Add(this.btnInformes);
            this.MenuVertical.Controls.Add(this.btnMetodo);
            this.MenuVertical.Controls.Add(this.btnEmpleados);
            this.MenuVertical.Controls.Add(this.btnEmpresa);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 64);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(240, 586);
            this.MenuVertical.TabIndex = 1;
            // 
            // cerrarsesion
            // 
            this.cerrarsesion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cerrarsesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cerrarsesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarsesion.FlatAppearance.BorderSize = 0;
            this.cerrarsesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.cerrarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarsesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarsesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cerrarsesion.Image = ((System.Drawing.Image)(resources.GetObject("cerrarsesion.Image")));
            this.cerrarsesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cerrarsesion.Location = new System.Drawing.Point(0, 516);
            this.cerrarsesion.Name = "cerrarsesion";
            this.cerrarsesion.Size = new System.Drawing.Size(290, 70);
            this.cerrarsesion.TabIndex = 14;
            this.cerrarsesion.Text = "Cerrar Sesion";
            this.cerrarsesion.UseVisualStyleBackColor = false;
            this.cerrarsesion.Click += new System.EventHandler(this.cerrarsesion_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(285, 70);
            this.button2.TabIndex = 2;
            this.button2.TabStop = false;
            this.button2.Text = "Ergo Asist";
            this.button2.UseMnemonic = false;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadisticas.FlatAppearance.BorderSize = 0;
            this.btnEstadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEstadisticas.Image = ((System.Drawing.Image)(resources.GetObject("btnEstadisticas.Image")));
            this.btnEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadisticas.Location = new System.Drawing.Point(0, 376);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(290, 70);
            this.btnEstadisticas.TabIndex = 13;
            this.btnEstadisticas.Text = "Estadísticas";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnInformes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformes.FlatAppearance.BorderSize = 0;
            this.btnInformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInformes.Image = ((System.Drawing.Image)(resources.GetObject("btnInformes.Image")));
            this.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Location = new System.Drawing.Point(-2, 300);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(290, 70);
            this.btnInformes.TabIndex = 11;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = false;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnMetodo
            // 
            this.btnMetodo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMetodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMetodo.FlatAppearance.BorderSize = 0;
            this.btnMetodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMetodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetodo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMetodo.Image = ((System.Drawing.Image)(resources.GetObject("btnMetodo.Image")));
            this.btnMetodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMetodo.Location = new System.Drawing.Point(-2, 224);
            this.btnMetodo.Name = "btnMetodo";
            this.btnMetodo.Size = new System.Drawing.Size(290, 70);
            this.btnMetodo.TabIndex = 9;
            this.btnMetodo.Text = "Metodos";
            this.btnMetodo.UseVisualStyleBackColor = false;
            this.btnMetodo.Click += new System.EventHandler(this.btnMetodo_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 148);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(290, 70);
            this.btnEmpleados.TabIndex = 7;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpresa.FlatAppearance.BorderSize = 0;
            this.btnEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpresa.Image")));
            this.btnEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpresa.Location = new System.Drawing.Point(-5, 79);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(290, 70);
            this.btnEmpresa.TabIndex = 1;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = false;
            this.btnEmpresa.Click += new System.EventHandler(this.btnempresa_Click);
            // 
            // PanelConector
            // 
            this.PanelConector.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PanelConector.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelConector.BackgroundImage")));
            this.PanelConector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelConector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelConector.Location = new System.Drawing.Point(240, 64);
            this.PanelConector.Name = "PanelConector";
            this.PanelConector.Size = new System.Drawing.Size(975, 586);
            this.PanelConector.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(847, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cargo:";
            // 
            // lblUsrCar
            // 
            this.lblUsrCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsrCar.AutoSize = true;
            this.lblUsrCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsrCar.Location = new System.Drawing.Point(927, 36);
            this.lblUsrCar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsrCar.Name = "lblUsrCar";
            this.lblUsrCar.Size = new System.Drawing.Size(87, 26);
            this.lblUsrCar.TabIndex = 11;
            this.lblUsrCar.Text = "Usr Car";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 650);
            this.Controls.Add(this.PanelConector);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel PanelConector;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnMetodo;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cerrarsesion;
        private System.Windows.Forms.Label lblUsrLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsrCar;
        private System.Windows.Forms.Label label2;
    }
}