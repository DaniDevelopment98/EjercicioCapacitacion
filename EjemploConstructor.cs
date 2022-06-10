using com.sun.org.apache.xpath.@internal.operations;
using CsQuery.Engine.PseudoClassSelectors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lt = CsQuery.Engine.PseudoClassSelectors.Lt;

namespace EjemplosCapacitacion
{
    public partial class EjemploConstructor : Form
    {

        public EjemploConstructor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // asignacion de variables 
            int n1, n2;
            n1 = Convert.ToInt32(txtNum1.Text);
            n2 = Convert.ToInt32(txtNum2.Text);
            int rest, sum;
            string cal;

            // llamo al constructor para indicar que tya estaré ejecutando su codigo
            Constructor1 ob = new Constructor1(n1, n2);
            rest = ob.resta();
            sum = ob.Suma();
            cal = Convert.ToString("La resta es " + rest + " " + "la suma es: " + sum);
            listBox1.Items.Add(cal);

        }

        public class Constructor1
        {

            int a;
            int b;
            //declaramos el constructor
            public Constructor1(int x, int y)
            {
                a = x;
                b = y;
            }

            public int Suma()
            {
                return a + b;
            }

            public int resta()
            {
                return a - b;
            }


        }
        //Muestra como se declara un enum
        public class ejemplenum
        {

            public enum meses
            {
                enero,
                febrero,
                abril,
                junio,
                agosto,
                octubre,
                noviembre,
                diciembre
            }

        }
        // carga los datos en el load
        private void EjemploConstructor_Load(object sender, EventArgs e)
        {
            //Para unsar los enumerable tipe

            string[] values = Enum.GetNames(typeof(ejemplenum.meses));
            foreach (string s in values)
            {
                listBox2.Items.Add(s);
            }
        }

        private void btbNex_Click(object sender, EventArgs e)
        {
            this.Hide();
            LINQ frm = new LINQ();
            frm.Show();
        }
    }

}
