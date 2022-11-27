
namespace Punto_de_Venta
{
    partial class formVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridVentas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodProducto = new System.Windows.Forms.TextBox();
            this.textBoxProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBuscarPorProducto = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonaAgregar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.textBoxCanProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxStockProducto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxVuelto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxClienteAbona = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLimpiarTodo = new System.Windows.Forms.Button();
            this.textBoxPrecioProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.textBoxCodigoVenta = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxProductoIF = new System.Windows.Forms.TextBox();
            this.textBoxSumarPrecios = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridVentas
            // 
            this.dataGridVentas.AllowUserToAddRows = false;
            this.dataGridVentas.AllowUserToDeleteRows = false;
            this.dataGridVentas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4});
            this.dataGridVentas.Location = new System.Drawing.Point(16, 52);
            this.dataGridVentas.Name = "dataGridVentas";
            this.dataGridVentas.ReadOnly = true;
            this.dataGridVentas.RowHeadersVisible = false;
            this.dataGridVentas.Size = new System.Drawing.Size(634, 355);
            this.dataGridVentas.TabIndex = 0;
            this.dataGridVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVentas_CellContentClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Stock";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cantidad";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SubTotal";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Panel De Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(309, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cod.Producto:";
            // 
            // textBoxCodProducto
            // 
            this.textBoxCodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxCodProducto.Location = new System.Drawing.Point(111, 25);
            this.textBoxCodProducto.Name = "textBoxCodProducto";
            this.textBoxCodProducto.Size = new System.Drawing.Size(111, 21);
            this.textBoxCodProducto.TabIndex = 3;
            // 
            // textBoxProducto
            // 
            this.textBoxProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxProducto.Location = new System.Drawing.Point(791, 53);
            this.textBoxProducto.Name = "textBoxProducto";
            this.textBoxProducto.Size = new System.Drawing.Size(168, 23);
            this.textBoxProducto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(663, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Producto:";
            // 
            // buttonBuscarPorProducto
            // 
            this.buttonBuscarPorProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonBuscarPorProducto.Location = new System.Drawing.Point(713, 268);
            this.buttonBuscarPorProducto.Name = "buttonBuscarPorProducto";
            this.buttonBuscarPorProducto.Size = new System.Drawing.Size(108, 35);
            this.buttonBuscarPorProducto.TabIndex = 8;
            this.buttonBuscarPorProducto.Text = "Buscar";
            this.buttonBuscarPorProducto.UseVisualStyleBackColor = true;
            this.buttonBuscarPorProducto.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonaAgregar
            // 
            this.buttonaAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonaAgregar.Location = new System.Drawing.Point(713, 320);
            this.buttonaAgregar.Name = "buttonaAgregar";
            this.buttonaAgregar.Size = new System.Drawing.Size(108, 35);
            this.buttonaAgregar.TabIndex = 11;
            this.buttonaAgregar.Text = "Agregar";
            this.buttonaAgregar.UseVisualStyleBackColor = true;
            this.buttonaAgregar.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button5.Location = new System.Drawing.Point(827, 320);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 35);
            this.button5.TabIndex = 12;
            this.button5.Text = "Quitar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonConfirmar.Location = new System.Drawing.Point(941, 320);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(108, 35);
            this.buttonConfirmar.TabIndex = 13;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBoxCanProducto
            // 
            this.textBoxCanProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCanProducto.Location = new System.Drawing.Point(791, 93);
            this.textBoxCanProducto.Name = "textBoxCanProducto";
            this.textBoxCanProducto.Size = new System.Drawing.Size(168, 23);
            this.textBoxCanProducto.TabIndex = 15;
            this.textBoxCanProducto.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(663, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cant. Producto:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxStockProducto);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxVuelto);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxTotal);
            this.groupBox1.Controls.Add(this.textBoxClienteAbona);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxCanProducto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonLimpiarTodo);
            this.groupBox1.Controls.Add(this.textBoxPrecioProducto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.textBoxProducto);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxCodigoVenta);
            this.groupBox1.Controls.Add(this.textBoxCodProducto);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.buttonBuscarPorProducto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.buttonaAgregar);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.buttonConfirmar);
            this.groupBox1.Controls.Add(this.dataGridVentas);
            this.groupBox1.Location = new System.Drawing.Point(12, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1057, 471);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // textBoxStockProducto
            // 
            this.textBoxStockProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxStockProducto.Location = new System.Drawing.Point(791, 212);
            this.textBoxStockProducto.Name = "textBoxStockProducto";
            this.textBoxStockProducto.Size = new System.Drawing.Size(168, 23);
            this.textBoxStockProducto.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(663, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Stock. Producto:";
            // 
            // textBoxVuelto
            // 
            this.textBoxVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxVuelto.Location = new System.Drawing.Point(497, 428);
            this.textBoxVuelto.Name = "textBoxVuelto";
            this.textBoxVuelto.Size = new System.Drawing.Size(120, 23);
            this.textBoxVuelto.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(403, 428);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "VUELTO:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxTotal.Location = new System.Drawing.Point(280, 428);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(120, 23);
            this.textBoxTotal.TabIndex = 25;
            // 
            // textBoxClienteAbona
            // 
            this.textBoxClienteAbona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxClienteAbona.Location = new System.Drawing.Point(791, 174);
            this.textBoxClienteAbona.Name = "textBoxClienteAbona";
            this.textBoxClienteAbona.Size = new System.Drawing.Size(168, 23);
            this.textBoxClienteAbona.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(663, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Cliente Abona:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(200, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "TOTAL:";
            // 
            // buttonLimpiarTodo
            // 
            this.buttonLimpiarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonLimpiarTodo.Location = new System.Drawing.Point(827, 268);
            this.buttonLimpiarTodo.Name = "buttonLimpiarTodo";
            this.buttonLimpiarTodo.Size = new System.Drawing.Size(108, 35);
            this.buttonLimpiarTodo.TabIndex = 21;
            this.buttonLimpiarTodo.Text = "Limpiar";
            this.buttonLimpiarTodo.UseVisualStyleBackColor = true;
            this.buttonLimpiarTodo.Click += new System.EventHandler(this.buttonLimpiarTodo_Click);
            // 
            // textBoxPrecioProducto
            // 
            this.textBoxPrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxPrecioProducto.Location = new System.Drawing.Point(791, 135);
            this.textBoxPrecioProducto.Name = "textBoxPrecioProducto";
            this.textBoxPrecioProducto.Size = new System.Drawing.Size(168, 23);
            this.textBoxPrecioProducto.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(663, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Precio Producto:";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(228, 25);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 19;
            this.button9.Text = "Buscar";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBoxCodigoVenta
            // 
            this.textBoxCodigoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxCodigoVenta.Location = new System.Drawing.Point(413, 25);
            this.textBoxCodigoVenta.Name = "textBoxCodigoVenta";
            this.textBoxCodigoVenta.Size = new System.Drawing.Size(111, 21);
            this.textBoxCodigoVenta.TabIndex = 20;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button8.Location = new System.Drawing.Point(941, 373);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(108, 35);
            this.button8.TabIndex = 16;
            this.button8.Text = "Volver";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(23, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cod. Venta:";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button7.Location = new System.Drawing.Point(827, 373);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 35);
            this.button7.TabIndex = 15;
            this.button7.Text = "Abrir BD";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(713, 373);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 35);
            this.button3.TabIndex = 14;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 32);
            this.panel1.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Administrar Ventas";
            // 
            // textBoxProductoIF
            // 
            this.textBoxProductoIF.Enabled = false;
            this.textBoxProductoIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxProductoIF.Location = new System.Drawing.Point(901, 38);
            this.textBoxProductoIF.Name = "textBoxProductoIF";
            this.textBoxProductoIF.Size = new System.Drawing.Size(168, 23);
            this.textBoxProductoIF.TabIndex = 30;
            this.textBoxProductoIF.Visible = false;
            // 
            // textBoxSumarPrecios
            // 
            this.textBoxSumarPrecios.Enabled = false;
            this.textBoxSumarPrecios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSumarPrecios.Location = new System.Drawing.Point(725, 38);
            this.textBoxSumarPrecios.Name = "textBoxSumarPrecios";
            this.textBoxSumarPrecios.Size = new System.Drawing.Size(168, 23);
            this.textBoxSumarPrecios.TabIndex = 31;
            this.textBoxSumarPrecios.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(725, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 32;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(851, 67);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 33;
            // 
            // formVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 642);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxSumarPrecios);
            this.Controls.Add(this.textBoxProductoIF);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.formVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodProducto;
        private System.Windows.Forms.TextBox textBoxProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBuscarPorProducto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonaAgregar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.TextBox textBoxCanProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCodigoVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBoxPrecioProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonLimpiarTodo;
        private System.Windows.Forms.TextBox textBoxVuelto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxClienteAbona;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStockProducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox textBoxProductoIF;
        private System.Windows.Forms.TextBox textBoxSumarPrecios;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}