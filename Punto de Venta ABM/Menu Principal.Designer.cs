﻿
namespace Punto_de_Venta
{
    partial class formMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 19F);
            this.button1.Location = new System.Drawing.Point(190, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 91);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ventas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 19F);
            this.button2.Location = new System.Drawing.Point(749, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 91);
            this.button2.TabIndex = 1;
            this.button2.Text = "Compras";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Yu Gothic UI", 19F);
            this.button3.Location = new System.Drawing.Point(467, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 91);
            this.button3.TabIndex = 2;
            this.button3.Text = "Productos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Yu Gothic UI", 19F);
            this.button4.Location = new System.Drawing.Point(190, 468);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 91);
            this.button4.TabIndex = 3;
            this.button4.Text = "Clientes";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Yu Gothic UI", 19F);
            this.button5.Location = new System.Drawing.Point(467, 468);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(206, 91);
            this.button5.TabIndex = 4;
            this.button5.Text = "Proveedores";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Yu Gothic UI", 19F);
            this.button6.Location = new System.Drawing.Point(749, 468);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(206, 91);
            this.button6.TabIndex = 5;
            this.button6.Text = "Mantenimiento";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "Punto de Venta";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button7.Location = new System.Drawing.Point(1082, 626);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 39);
            this.button7.TabIndex = 7;
            this.button7.Text = "Salir";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 32);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Menú Principal";
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 677);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}