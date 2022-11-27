using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Punto_de_Venta
{
    public partial class Productos : Form
    {
        //definiciones de n1 n2 r para boton modificar...
        Double n1;
        Double n2;
        Double r;

        //definiciones para boton agregar...
        Double costo = 0;
        Double viatico = 65;
        Double impuestoTarjeta = 1.12;
        Double precioTarjeta = 0;
        Double gananciaTarjeta = 0;
        Double precioEfectivo = 0;
        Double gananciaEfectivo = 0;
        Double gananciaPorcentaje = 1.70;
        Double costoFinal = 0;
        

        public OleDbConnection conexionDB = new OleDbConnection("provider=microsoft.ACE.OLEDB.12.0;Data Source = PuntoDeVentaBD.accdb");
        public OleDbCommand orden;
        public OleDbDataReader lector;
        public Productos()
        {
            InitializeComponent();
        }

        //Cargo de manera instantanea el datagrid a penas carga el form...
        private void Productos_Load(object sender, EventArgs e)
        {
            //Los textBox pasan a tener el valor de las variables fijas...
            textBoxViatico.Text = Convert.ToString(viatico);
            textBoxImpTarjeta.Text = Convert.ToString(impuestoTarjeta);
            textBoxGananciaPorcentaje.Text = Convert.ToString(gananciaPorcentaje);

            conexionDB.Open();
            //funcion mostrar datagrid
            string mostarDataGrid = "SELECT * FROM StockGin";

            orden = new OleDbCommand(mostarDataGrid, conexionDB);
            lector = orden.ExecuteReader();

            while (lector.Read())
            {
                //dataGridStock.Rows.Clear();//Borra para que lo que estaba antes no quede

                dataGridStock.Rows.Add(); //Agregamos una fila

                dataGridStock[0, dataGridStock.Rows.Count - 1].Value = lector["nombre"];
                dataGridStock[1, dataGridStock.Rows.Count - 1].Value = lector["material"];
                dataGridStock[2, dataGridStock.Rows.Count - 1].Value = lector["stock"];
                dataGridStock[3, dataGridStock.Rows.Count - 1].Value = lector["costo"];
                dataGridStock[4, dataGridStock.Rows.Count - 1].Value = lector["viatico"];
                dataGridStock[5, dataGridStock.Rows.Count - 1].Value = lector["impuestoTarjeta"];
                dataGridStock[6, dataGridStock.Rows.Count - 1].Value = lector["precioTarjeta"];
                dataGridStock[7, dataGridStock.Rows.Count - 1].Value = lector["gananciaTarjeta"];
                dataGridStock[8, dataGridStock.Rows.Count - 1].Value = lector["precioEfectivo"];
                dataGridStock[9, dataGridStock.Rows.Count - 1].Value = lector["gananciaEfectivo"];
                dataGridStock[10, dataGridStock.Rows.Count - 1].Value = lector["gananciaPorcentaje"];
            }
            conexionDB.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //Este if encuentra si falta algun campo a completar y da un error
            if (textBoxProducto2.Text == "" || textBoxStock.Text == "" || textBoxCostoProducto.Text == "" || textBoxViatico.Text == "" || textBoxImpTarjeta.Text == "" || textBoxGananciaPorcentaje.Text == "")
            {
                MessageBox.Show("Faltan completar campos.");
            }
            //Este if verifica que todos los campos necesarios para la carga estén completos
            if (textBoxProducto2.Text != "" && textBoxStock.Text != "" && textBoxCostoProducto.Text != "" && textBoxViatico.Text != "" && textBoxImpTarjeta.Text != "" && textBoxGananciaPorcentaje.Text != "")
            {
                costo = Convert.ToDouble(textBoxCostoProducto.Text);//la variable costo cambia segun lo que ponga el usuario...

                //costoFinal = costo + viatico;  a reemplazar y agregar a la base de datos


                precioTarjeta = ((costo + viatico) * impuestoTarjeta) * gananciaPorcentaje;
                gananciaTarjeta = precioTarjeta - (costo + viatico);

                precioEfectivo = (costo + viatico) * gananciaPorcentaje;
                gananciaEfectivo = precioEfectivo - (costo + viatico);

                

                // Insertamos productos en tabla STOCKGIN
                conexionDB.Open();
                //seguir completando con lo correspondiente en el acces...
                String escritura = "INSERT INTO StockGin(nombre, material, stock, costo, viatico, impuestoTarjeta, precioTarjeta, gananciaTarjeta, precioEfectivo, gananciaEfectivo, gananciaPorcentaje ) VALUES('" + textBoxProducto2.Text + "'," + "'" + textBoxMaterial.Text + "'," + "'" + Convert.ToDouble(textBoxStock.Text) + "'," + "'" + Convert.ToDouble(textBoxCostoProducto.Text) + "'," + "'" + Convert.ToDouble(textBoxViatico.Text) + "'," + "'" + Convert.ToDouble(textBoxImpTarjeta.Text) + "'," + "'" + precioTarjeta + "'," + "'" + gananciaTarjeta + "'," + "'" + precioEfectivo + "'," + "'" + gananciaEfectivo + "'," + "'" + gananciaPorcentaje + "')";
                orden = new OleDbCommand(escritura, conexionDB);
                orden.ExecuteNonQuery();

                MessageBox.Show("Carga Exitosa");

                conexionDB.Close();

                textBoxProducto2.Text = "";
                textBoxStock.Text = "";
                textBoxCostoProducto.Text = "";
                textBoxMaterial.Text = "";

                //ACTUALIZO EL DATA GRID PARA QUE APAREZCA EL ULTIMO PRODUCTO AGREGADO
                dataGridStock.Rows.Clear();
                conexionDB.Open();

                string mostarDataGrid = "SELECT * FROM StockGin";

                orden = new OleDbCommand(mostarDataGrid, conexionDB);
                lector = orden.ExecuteReader();

                while (lector.Read())
                {
                    //dataGridStock.Rows.Clear();//Borra para que lo que estaba antes no quede

                    dataGridStock.Rows.Add(); //Agregamos una fila

                    dataGridStock[0, dataGridStock.Rows.Count - 1].Value = lector["nombre"];
                    dataGridStock[1, dataGridStock.Rows.Count - 1].Value = lector["material"];
                    dataGridStock[2, dataGridStock.Rows.Count - 1].Value = lector["stock"];
                    dataGridStock[3, dataGridStock.Rows.Count - 1].Value = lector["costo"];
                    dataGridStock[4, dataGridStock.Rows.Count - 1].Value = lector["viatico"];
                    dataGridStock[5, dataGridStock.Rows.Count - 1].Value = lector["impuestoTarjeta"];
                    dataGridStock[6, dataGridStock.Rows.Count - 1].Value = lector["precioTarjeta"];
                    dataGridStock[7, dataGridStock.Rows.Count - 1].Value = lector["gananciaTarjeta"];
                    dataGridStock[8, dataGridStock.Rows.Count - 1].Value = lector["precioEfectivo"];
                    dataGridStock[9, dataGridStock.Rows.Count - 1].Value = lector["gananciaEfectivo"];
                    dataGridStock[10, dataGridStock.Rows.Count - 1].Value = lector["gananciaPorcentaje"];



                }
                conexionDB.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPrecioProducto2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//BOTON BUSCAR
        {
            //Aca buscamos un producto en la tabla StockGin segun el parametro de "textBoxProducto2.Text"
            conexionDB.Open();

            string mostarDataGrid = "SELECT * FROM StockGin WHERE tipo = '" + textBoxProducto2.Text + "'";

            orden = new OleDbCommand(mostarDataGrid, conexionDB);
            lector = orden.ExecuteReader();

            while (lector.Read())
            {
                dataGridStock.Rows.Clear();//Borra para que lo que estaba antes no quede

                dataGridStock.Rows.Add(); //Agregamos una fila

                dataGridStock[0, dataGridStock.Rows.Count - 1].Value = lector["nombre"];
                dataGridStock[1, dataGridStock.Rows.Count - 1].Value = lector["material"];
                dataGridStock[2, dataGridStock.Rows.Count - 1].Value = lector["stock"];
                dataGridStock[3, dataGridStock.Rows.Count - 1].Value = lector["costo"];
                dataGridStock[4, dataGridStock.Rows.Count - 1].Value = lector["viatico"];
                dataGridStock[5, dataGridStock.Rows.Count - 1].Value = lector["impuestoTarjeta"];
                dataGridStock[6, dataGridStock.Rows.Count - 1].Value = lector["precioTarjeta"];
                dataGridStock[7, dataGridStock.Rows.Count - 1].Value = lector["gananciaTarjeta"];
                dataGridStock[8, dataGridStock.Rows.Count - 1].Value = lector["precioEfectivo"];
                dataGridStock[9, dataGridStock.Rows.Count - 1].Value = lector["gananciaEfectivo"];
                dataGridStock[10, dataGridStock.Rows.Count - 1].Value = lector["gananciaPorcentaje"];


            }
            conexionDB.Close();
        }

        private void dataGridStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            formMenu irFormMenu = new formMenu();
            irFormMenu.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {   
            //Limpiamos el data grid y los campos a rellenar
            dataGridStock.Rows.Clear();
            textBoxProducto2.Text = "";
            textBoxStock.Text = "";
        }

        //mostramos la base de datos completa
        private void button6_Click(object sender, EventArgs e)
        {   
            
            dataGridStock.Rows.Clear();//Esto evita que se genera la tabla una y otra vez

            conexionDB.Open();

            string mostarDataGrid = "SELECT * FROM StockGin";

            orden = new OleDbCommand(mostarDataGrid, conexionDB);
            lector = orden.ExecuteReader();

            while (lector.Read())
            {
                //dataGridStock.Rows.Clear();//Borra para que lo que estaba antes no quede

                dataGridStock.Rows.Add(); //Agregamos una fila

                dataGridStock[0, dataGridStock.Rows.Count - 1].Value = lector["nombre"];
                dataGridStock[1, dataGridStock.Rows.Count - 1].Value = lector["material"];
                dataGridStock[2, dataGridStock.Rows.Count - 1].Value = lector["stock"];
                dataGridStock[3, dataGridStock.Rows.Count - 1].Value = lector["costo"];
                dataGridStock[4, dataGridStock.Rows.Count - 1].Value = lector["viatico"];
                dataGridStock[5, dataGridStock.Rows.Count - 1].Value = lector["impuestoTarjeta"];
                dataGridStock[6, dataGridStock.Rows.Count - 1].Value = lector["precioTarjeta"];
                dataGridStock[7, dataGridStock.Rows.Count - 1].Value = lector["gananciaTarjeta"];
                dataGridStock[8, dataGridStock.Rows.Count - 1].Value = lector["precioEfectivo"];
                dataGridStock[9, dataGridStock.Rows.Count - 1].Value = lector["gananciaEfectivo"];
                dataGridStock[10, dataGridStock.Rows.Count - 1].Value = lector["gananciaPorcentaje"];

            }
            conexionDB.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        //ESTO BORRA TOTALMENTE EL PRODUCTO
        private void button2_Click(object sender, EventArgs e)
        {
            //si es marcado que sí el message box borra el producto, sinó no hace nada.
            if ((MessageBox.Show("¿Seguro quere eliminarlo?", "The Title",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                conexionDB.Open();
                //FROM <<nombre BD>> WHERE <<CRITERIO DE BUSQUEDA>>
                string borrarRegistro = "DELETE * FROM StockGin WHERE tipo = '" + textBoxProducto2.Text + "'";

                orden = new OleDbCommand(borrarRegistro, conexionDB);
                orden.ExecuteNonQuery();


                //Limpiar Campos
                dataGridStock.Rows.Clear();
                textBoxProducto2.Text = "";
                textBoxStock.Text = "";

                //ACTUALIZAMOS EL DATAGRID
                string mostarDataGrid = "SELECT * FROM StockGin";

                orden = new OleDbCommand(mostarDataGrid, conexionDB);
                lector = orden.ExecuteReader();

                while (lector.Read())
                {
                    //dataGridStock.Rows.Clear();//Borra para que lo que estaba antes no quede

                    dataGridStock.Rows.Add(); //Agregamos una fila

                    dataGridStock[0, dataGridStock.Rows.Count - 1].Value = lector["nombre"];
                    dataGridStock[1, dataGridStock.Rows.Count - 1].Value = lector["material"];
                    dataGridStock[2, dataGridStock.Rows.Count - 1].Value = lector["stock"];
                    dataGridStock[3, dataGridStock.Rows.Count - 1].Value = lector["costo"];
                    dataGridStock[4, dataGridStock.Rows.Count - 1].Value = lector["viatico"];
                    dataGridStock[5, dataGridStock.Rows.Count - 1].Value = lector["impuestoTarjeta"];
                    dataGridStock[6, dataGridStock.Rows.Count - 1].Value = lector["precioTarjeta"];
                    dataGridStock[7, dataGridStock.Rows.Count - 1].Value = lector["gananciaTarjeta"];
                    dataGridStock[8, dataGridStock.Rows.Count - 1].Value = lector["precioEfectivo"];
                    dataGridStock[9, dataGridStock.Rows.Count - 1].Value = lector["gananciaEfectivo"];
                    dataGridStock[10, dataGridStock.Rows.Count - 1].Value = lector["gananciaPorcentaje"];


                }

                conexionDB.Close();

                MessageBox.Show("Se borraron los datos");
            }

             
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Este if encuentra si falta algun campo a completar y da un error
            if (textBoxProducto2.Text == "" || textBoxStock.Text == "")
            {
                MessageBox.Show("Faltan completar campos.");
            }
            //Este if verifica que todos los campos necesarios para la carga estén completos
            if (textBoxProducto2.Text != "" && textBoxStock.Text != "")
            {

                //Aca buscamos un producto en la tabla Stock segun el parametro de "textBoxProducto2.Text"
                conexionDB.Open();

                string mostarDataGrid1 = "SELECT * FROM Stock WHERE producto = '" + textBoxProducto2.Text + "'";

                orden = new OleDbCommand(mostarDataGrid1, conexionDB);
                lector = orden.ExecuteReader();

                while (lector.Read())
                {
                    dataGridStock.Rows.Clear();//Borra para que lo que estaba antes no quede

                    dataGridStock.Rows.Add(); //Agregamos una fila

                    dataGridStock[0, dataGridStock.Rows.Count - 1].Value = lector["producto"];
                    dataGridStock[1, dataGridStock.Rows.Count - 1].Value = lector["cantidad"];
                    dataGridStock[2, dataGridStock.Rows.Count - 1].Value = lector["precio"];


                }
                textBoxSumarProductos.Text = Convert.ToString(dataGridStock[1, 0].Value);
                conexionDB.Close();

                n1 = double.Parse(textBoxSumarProductos.Text);
                n2 = double.Parse(textBoxStock.Text);
                r = n1 + n2;
                textBoxResultado.Text = r.ToString();
                textBoxStock.Text = textBoxResultado.Text;

                conexionDB.Open();

                String consultaActualizar = "UPDATE Stock SET cantidad = '" + textBoxStock.Text + "' WHERE producto = '" + textBoxProducto2.Text + "'";

                orden = new OleDbCommand(consultaActualizar, conexionDB);
                orden.ExecuteNonQuery();

                //mostramos la base de datos completa
                dataGridStock.Rows.Clear();//Esto evita que se genera la tabla una y otra vez

                string mostarDataGrid = "SELECT * FROM Stock";

                orden = new OleDbCommand(mostarDataGrid, conexionDB);
                lector = orden.ExecuteReader();

                while (lector.Read())
                {
                    //dataGridStock.Rows.Clear();//Borra para que lo que estaba antes no quede

                    dataGridStock.Rows.Add(); //Agregamos una fila

                    dataGridStock[0, dataGridStock.Rows.Count - 1].Value = lector["producto"];
                    dataGridStock[1, dataGridStock.Rows.Count - 1].Value = lector["cantidad"];
                    dataGridStock[2, dataGridStock.Rows.Count - 1].Value = lector["precio"];


                }
                conexionDB.Close();
                MessageBox.Show("Se actualizaron los datos");
            }
            
            //Limpiar Campos
            textBoxProducto2.Text = "";
            textBoxStock.Text = "";
            textBoxResultado.Text = "";
            textBoxSumarProductos.Text = "";
        }
    }
}
