using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Punto_de_Venta
{
    public partial class formVentas : Form
    {
        int contar = 1;
        double total = 0;
        double precio = 0;
        public OleDbConnection conexionDB = new OleDbConnection("provider=microsoft.ACE.OLEDB.12.0;Data Source = PuntoDeVentaBD.accdb");
        public OleDbCommand orden;
        public OleDbDataReader lector;
        public formVentas()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            formMenu irFormMenu = new formMenu();
            irFormMenu.Show();
            this.Close();
        }

        private void formVentas_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {   
            //BOTON CONFIRMAR
            //Este if encuentra si falta algun campo a completar y da un error
            if (textBoxProducto.Text == "" || textBoxCanProducto.Text == "" || textBoxPrecioProducto.Text == "")
            {
                MessageBox.Show("Faltan completar campos.");
            }
            //Este if verifica que todos los campos necesarios para la carga estén completos
            if (textBoxProducto.Text != "" && textBoxCanProducto.Text != "" && textBoxPrecioProducto.Text != "")
            {
                // Insertamos datos en tabla Ticket
                conexionDB.Open();

                String escritura = "INSERT INTO Ticket(producto, cantidad, precio, stock) VALUES('" + textBoxProducto.Text + "'," + "'" + Convert.ToInt64(textBoxCanProducto.Text) + "'," + "'" + Convert.ToInt64(textBoxPrecioProducto.Text) + "'," + "'" + Convert.ToInt64(textBoxStockProducto.Text) + "')";
                orden = new OleDbCommand(escritura, conexionDB);
                orden.ExecuteNonQuery();

                MessageBox.Show("Carga Exitosa");

                
                //TRAIGO EL STOCKACTUALIZADO DE TABLA TICKET PARA LLEVARLO A LA TABLA STOCK
                string mostrarDataGrid = "SELECT * FROM Ticket WHERE producto = '" + textBoxProducto.Text + "'";

                orden = new OleDbCommand(mostrarDataGrid, conexionDB);
                lector = orden.ExecuteReader();

                while (lector.Read())
                {
                    dataGridVentas.Rows.Clear();//Borra para que lo que estaba antes no quede

                    dataGridVentas.Rows.Add(); //Agregamos una fila

                    dataGridVentas[0, dataGridVentas.Rows.Count - 1].Value = lector["producto"];
                    dataGridVentas[1, dataGridVentas.Rows.Count - 1].Value = lector["stockActualizado"];
                    dataGridVentas[3, dataGridVentas.Rows.Count - 1].Value = lector["precio"];
                }
                

                textBoxStockProducto.Text = Convert.ToString(dataGridVentas[1, 0].Value);

                //ACTUALIZACION DEL STOCK EN TABLA STOCK DESDE TEXTBOX STOCK !!!! UPDATE ANDA CONFIRMANDO VENTA DE A UN PRODUCTO

                String consultaActualizar = "UPDATE Stock SET cantidad = '" + Convert.ToInt64(textBoxStockProducto.Text) + "' WHERE producto = '" + textBoxProducto.Text + "'";

                orden = new OleDbCommand(consultaActualizar, conexionDB);
                orden.ExecuteNonQuery();

                conexionDB.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BOTON BUSCAR
            conexionDB.Open();

            string mostarDataGrid = "SELECT * FROM Stock WHERE producto = '" + textBoxProducto.Text + "'";

            orden = new OleDbCommand(mostarDataGrid, conexionDB);
            lector = orden.ExecuteReader();

            while (lector.Read())
            {
                dataGridVentas.Rows.Clear();//Borra para que lo que estaba antes no quede

                dataGridVentas.Rows.Add(); //Agregamos una fila

                dataGridVentas[0, dataGridVentas.Rows.Count - 1].Value = lector["producto"];
                dataGridVentas[1, dataGridVentas.Rows.Count - 1].Value = lector["cantidad"];
                dataGridVentas[3, dataGridVentas.Rows.Count - 1].Value = lector["precio"];
                

            }
            conexionDB.Close();
        }

        private void dataGridVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            //BOTON AGREGAR

            
            //Este if encuentra si falta algun campo a completar y da un error
            if (textBoxProducto.Text == "")
            {
                MessageBox.Show("Faltan completar campos.");
            }
            //Este if verifica que todos los campos necesarios para la carga estén completos
            if (textBoxProducto.Text != "")
            {
                //Estoy intentando de sumar la cantidad de producto individualmente
                if (textBoxProductoIF.Text == textBoxProducto.Text)
                {
                    contar++;
                    textBoxCanProducto.Text = Convert.ToString(contar);
                }
                else
                {
                    contar = 1;
                }

                textBoxCanProducto.Text = Convert.ToString(contar);
                textBoxProductoIF.Text = textBoxProducto.Text;
                

                //BUSCAMOS EN LA TABLA STOCK EL PRODUCTO Y LO LLEVAMOS A LOS CAMPOS PARA LUEGO COPIARLOS EN LA TABLA TICKET
                conexionDB.Open();
                string mostrarDataGrid = "SELECT * FROM Stock WHERE producto = '" + textBoxProducto.Text + "'";

                orden = new OleDbCommand(mostrarDataGrid, conexionDB);
                lector = orden.ExecuteReader();

                while (lector.Read())
                {
                    dataGridVentas.Rows.Clear();//Borra para que lo que estaba antes no quede

                    dataGridVentas.Rows.Add(); //Agregamos una fila

                    dataGridVentas[0, dataGridVentas.Rows.Count - 1].Value = lector["producto"];
                    dataGridVentas[1, dataGridVentas.Rows.Count - 1].Value = lector["cantidad"];
                    dataGridVentas[3, dataGridVentas.Rows.Count - 1].Value = lector["precio"];
                }
                

                textBoxStockProducto.Text = Convert.ToString(dataGridVentas[1, 0].Value);
                textBoxPrecioProducto.Text = Convert.ToString(dataGridVentas[3,0].Value);


                //Agregamos a listbox los items de textboxprecio y los sumamos para mandarlos al textboxTOTAL
                precio = listBox1.Items.Add(textBoxPrecioProducto.Text);
                listBox2.Items.Add(textBoxProducto.Text);

                foreach (object item in listBox1.Items)
                {
                    total += Convert.ToDouble(item);
                    textBoxTotal.Text = (total).ToString();
                }
                conexionDB.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Productos irFormProductos = new Productos();
            irFormProductos.Show();
            this.Close();
        }

        private void buttonLimpiarTodo_Click(object sender, EventArgs e)
        {
            //Limpiamos el data grid y los campos a rellenar
            dataGridVentas.Rows.Clear();

            textBoxProducto.Text = "";
            textBoxCanProducto.Text = "";
            textBoxPrecioProducto.Text = "";
            textBoxClienteAbona.Text = "";
        }
    }
}
