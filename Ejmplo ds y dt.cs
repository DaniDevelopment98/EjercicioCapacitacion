using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemplosCapacitacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Implementacion del datatable
            DataTable tabla = new DataTable();

            // Variables para las columnas y las filas
            DataColumn column;
            DataRow row;

            // Se tiene que crear primero la columna asignandole Nombre y Tipo de datos    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Codigo";
            tabla.Columns.Add(column);

            // Se tienen que crear todas las columnas que queramos
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Descripcion";
            tabla.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Decimal");
            column.ColumnName = "ValorUnitario";
            tabla.Columns.Add(column);

            // Se crea una fila por cada registro que necesitemos agregar    
            for (int i = 1; i < 11; i++)
            {
                row = tabla.NewRow();
                row["Codigo"] = i;
                row["Descripcion"] = "Nombre del codigo " + i.ToString();
                row["ValorUnitario"] = i * 2;
                tabla.Rows.Add(row);
            }
            dataGridView1.DataSource = tabla;
           // dataGridView1.DataBindings();
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            //Ejemplo de como usar un data set
          
            var query = Conexion.transacBD("select CustomerID,CompanyName,ContactName,Address from customers where customerID like'%"+txtNombre.Text+ "%' or CompanyName like'%" + txtNombre.Text +"%'  ",true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            
            if (Conexion.ds.Tables[0].Rows.Count != 0)
            {
                dataGridView2.DataSource = Conexion.ds.Tables[0];
            }
            //var query= (select CustomerID,CompanyName,ContactName,Address from customers)


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            EjemploConstructor frm = new EjemploConstructor();
            frm.Show();
        }
    }
}
