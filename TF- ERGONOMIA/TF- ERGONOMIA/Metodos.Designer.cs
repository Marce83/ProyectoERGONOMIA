﻿namespace TF.WIN
{
    partial class Metodos
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
            this.btnRula = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRula
            // 
            this.btnRula.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRula.FlatAppearance.BorderSize = 0;
            this.btnRula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRula.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRula.Location = new System.Drawing.Point(13, 157);
            this.btnRula.Margin = new System.Windows.Forms.Padding(4);
            this.btnRula.Name = "btnRula";
            this.btnRula.Size = new System.Drawing.Size(155, 43);
            this.btnRula.TabIndex = 34;
            this.btnRula.Text = "RULA";
            this.btnRula.UseVisualStyleBackColor = false;
            this.btnRula.Click += new System.EventHandler(this.btnRula_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(12, 93);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(150, 19);
            this.materialLabel1.TabIndex = 34;
            this.materialLabel1.Text = "Métodos Disponibles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 38);
            this.label1.TabIndex = 63;
            this.label1.Text = "SELECCION DE METODO DE ANALISIS";
            // 
            // Metodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRula);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Metodos";
            this.Text = "Metodos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRula;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label label1;
    }
}