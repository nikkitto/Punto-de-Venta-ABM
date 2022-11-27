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
    public partial class formLogin : Form
    {
        public OleDbConnection conexionDB = new OleDbConnection("provider=microsoft.ACE.OLEDB.12.0;Data Source = PuntoDeVentaBD.accdb");
        public OleDbCommand orden;
        public OleDbDataReader lector;
        public formLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            
            formMenu irFormMenu = new formMenu();
            irFormMenu.Show();
            this.Hide();
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
