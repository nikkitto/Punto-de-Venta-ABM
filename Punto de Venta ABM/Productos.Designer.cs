
namespace Punto_de_Venta
{
    partial class Productos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridStock = new System.Windows.Forms.DataGridView();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxProducto2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodProducto2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.textBoxSumarProductos = new System.Windows.Forms.TextBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.textBoxCostoProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxViatico = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxImpTarjeta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxGananciaPorcentaje = new System.Windows.Forms.TextBox();
            this.textBoxMaterial = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1487, 32);
            this.panel1.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Administrar Productos";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(1122, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1122, 575);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 35);
            this.button2.TabIndex = 99;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridStock
            // 
            this.dataGridStock.AllowUserToAddRows = false;
            this.dataGridStock.AllowUserToDeleteRows = false;
            this.dataGridStock.BackgroundColor = System.Drawing.Color.White;
            this.dataGridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column2,
            this.Column12,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column1,
            this.Column7,
            this.Column9,
            this.Column8,
            this.Column10});
            this.dataGridStock.Location = new System.Drawing.Point(12, 50);
            this.dataGridStock.Name = "dataGridStock";
            this.dataGridStock.ReadOnly = true;
            this.dataGridStock.RowHeadersVisible = false;
            this.dataGridStock.Size = new System.Drawing.Size(1104, 630);
            this.dataGridStock.TabIndex = 100;
            this.dataGridStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStock_CellContentClick);
            // 
            // textBoxStock
            // 
            this.textBoxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxStock.Location = new System.Drawing.Point(1268, 157);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(205, 23);
            this.textBoxStock.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1118, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Stock:";
            // 
            // textBoxProducto2
            // 
            this.textBoxProducto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxProducto2.Location = new System.Drawing.Point(1268, 104);
            this.textBoxProducto2.Name = "textBoxProducto2";
            this.textBoxProducto2.Size = new System.Drawing.Size(205, 23);
            this.textBoxProducto2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1118, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre:";
            // 
            // textBoxCodProducto2
            // 
            this.textBoxCodProducto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCodProducto2.Location = new System.Drawing.Point(1268, 444);
            this.textBoxCodProducto2.Name = "textBoxCodProducto2";
            this.textBoxCodProducto2.Size = new System.Drawing.Size(205, 23);
            this.textBoxCodProducto2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1118, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 166;
            this.label2.Text = "Código:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(1236, 575);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 35);
            this.button3.TabIndex = 26;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.Location = new System.Drawing.Point(1350, 645);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 35);
            this.button4.TabIndex = 27;
            this.button4.Text = "Volver";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button5.Location = new System.Drawing.Point(1236, 645);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 35);
            this.button5.TabIndex = 28;
            this.button5.Text = "Limpiar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button6.Location = new System.Drawing.Point(1122, 645);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 35);
            this.button6.TabIndex = 29;
            this.button6.Text = "BD Completa";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.label4.Location = new System.Drawing.Point(1181, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 35);
            this.label4.TabIndex = 30;
            this.label4.Text = "Base de Datos";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button7.Location = new System.Drawing.Point(1236, 514);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 35);
            this.button7.TabIndex = 14;
            this.button7.Text = "Modificar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBoxSumarProductos
            // 
            this.textBoxSumarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSumarProductos.Location = new System.Drawing.Point(1427, 38);
            this.textBoxSumarProductos.Name = "textBoxSumarProductos";
            this.textBoxSumarProductos.Size = new System.Drawing.Size(46, 23);
            this.textBoxSumarProductos.TabIndex = 32;
            this.textBoxSumarProductos.Visible = false;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxResultado.Location = new System.Drawing.Point(1427, 67);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(46, 23);
            this.textBoxResultado.TabIndex = 34;
            this.textBoxResultado.Visible = false;
            // 
            // textBoxCostoProducto
            // 
            this.textBoxCostoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCostoProducto.Location = new System.Drawing.Point(1268, 185);
            this.textBoxCostoProducto.Name = "textBoxCostoProducto";
            this.textBoxCostoProducto.Size = new System.Drawing.Size(205, 23);
            this.textBoxCostoProducto.TabIndex = 4;
            this.textBoxCostoProducto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1118, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Costo:";
            // 
            // textBoxViatico
            // 
            this.textBoxViatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxViatico.Location = new System.Drawing.Point(1268, 211);
            this.textBoxViatico.Name = "textBoxViatico";
            this.textBoxViatico.Size = new System.Drawing.Size(205, 23);
            this.textBoxViatico.TabIndex = 5;
            this.textBoxViatico.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1118, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Viatico:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxImpTarjeta
            // 
            this.textBoxImpTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxImpTarjeta.Location = new System.Drawing.Point(1268, 242);
            this.textBoxImpTarjeta.Name = "textBoxImpTarjeta";
            this.textBoxImpTarjeta.Size = new System.Drawing.Size(205, 23);
            this.textBoxImpTarjeta.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1118, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Impuesto Tarj:";
            // 
            // textBoxGananciaPorcentaje
            // 
            this.textBoxGananciaPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxGananciaPorcentaje.Location = new System.Drawing.Point(1268, 391);
            this.textBoxGananciaPorcentaje.Name = "textBoxGananciaPorcentaje";
            this.textBoxGananciaPorcentaje.Size = new System.Drawing.Size(205, 23);
            this.textBoxGananciaPorcentaje.TabIndex = 11;
            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxMaterial.Location = new System.Drawing.Point(1268, 130);
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.Size = new System.Drawing.Size(205, 23);
            this.textBoxMaterial.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1118, 130);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 20);
            this.label19.TabIndex = 53;
            this.label19.Text = "Material:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1118, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Porc. Gananc:";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre";
            this.Column3.MaxInputLength = 3276;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Material";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Stock";
            this.Column12.MaxInputLength = 3276;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Costo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Viatico";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Impuesto Tarjeta";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Precio Tarjeta";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ganancia Tarjeta";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Precio Efectivo";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ganancia Efectivo";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Porcentaje de Ganancia";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 687);
            this.Controls.Add(this.textBoxMaterial);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBoxGananciaPorcentaje);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxImpTarjeta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxViatico);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxCostoProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.textBoxSumarProductos);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxProducto2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCodProducto2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridStock);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridStock;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxProducto2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodProducto2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBoxSumarProductos;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.TextBox textBoxCostoProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxViatico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxImpTarjeta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxGananciaPorcentaje;
        private System.Windows.Forms.TextBox textBoxMaterial;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}