﻿namespace Clipper_Project
{
    partial class Identificar_Operador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Identificar_Operador));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_empleado = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Empleado:";
            // 
            // txt_empleado
            // 
            this.txt_empleado.Location = new System.Drawing.Point(95, 22);
            this.txt_empleado.Name = "txt_empleado";
            this.txt_empleado.Size = new System.Drawing.Size(295, 20);
            this.txt_empleado.TabIndex = 1;
            this.txt_empleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_empleado_KeyDown);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(190, 48);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 2;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.Btn_aceptar_Click);
            // 
            // Identificar_Operador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 90);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_empleado);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Identificar_Operador";
            this.Text = "Identificar_Operador";
            this.Load += new System.EventHandler(this.Identificar_Operador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_empleado;
        private System.Windows.Forms.Button btn_aceptar;
    }
}