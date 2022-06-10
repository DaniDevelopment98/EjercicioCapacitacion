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
   
    public partial class LINQ : Form
    {
       
        public LINQ()
        {
            InitializeComponent();
        }

        private void btnMuestra_Click(object sender, EventArgs e)
        {

            controlCarro crC = new controlCarro();
            crC.getCarro(txtYear.Text);

            

        }

        class Carro
        {
            public string idCarro { get; set; }
           
            public string Modelo { get; set; }
            public string Year { get; set; }
            public string Valor { get; set; }
            public string idMarca { get; set; }

            public string  GetCArro() 
            {
                                
                 string ds = ("idCarro: "+idCarro+"Modelo: "+ Modelo+"año :"+ Year+ "Valor: "+Valor+"La marca Corresponde a la empresa" +idMarca);
                return ds;
                
            }
            
        }
        class Marca
        {
            public int idMarca { get; set; }
            public string nombre { get; set; }
        }

        class controlCarro
        {

            public controlCarro()
            {
                ListaCarro = new List<Carro>();
                ListaMarca = new List<Marca>();

                ListaMarca.Add(new Marca {idMarca=1, nombre= "Nissan" } );
                ListaMarca.Add(new Marca { idMarca = 2, nombre = "Chevrolet" });
                ListaMarca.Add(new Marca { idMarca = 3, nombre = "Ford" });

                ListaCarro.Add(new Carro { idCarro = "1", Modelo="N25-Versa", Year = "2020",Valor = "2500000", idMarca="1" });
                ListaCarro.Add(new Carro { idCarro = "1", Modelo = "C87-Camaro", Year = "2022", Valor = "12500000", idMarca = "2" });
                ListaCarro.Add(new Carro { idCarro = "1", Modelo = "F69-Fiesta", Year = "2022", Valor = "250060", idMarca = "3" });
                ListaCarro.Add(new Carro { idCarro = "1", Modelo = "N35-350z", Year = "2021", Valor = "980000", idMarca = "1" });
                ListaCarro.Add(new Carro { idCarro = "1", Modelo = "C87-Aveo", Year = "2020", Valor = "250600", idMarca = "2" });
                ListaCarro.Add(new Carro { idCarro = "1", Modelo = "F52-Mustang", Year = "2021", Valor = "293000", idMarca = "3" });


            }
            public List<Carro> ListaCarro;
            public List<Marca> ListaMarca;

            public void getCarro( string año )
            {
                IEnumerable<Carro> Obmarca = from Carro in ListaCarro where Carro.Year == año select Carro;                               

                foreach (Carro marca1 in Obmarca)
                {                    
                    marca1.GetCArro();                    
                               
                }
                
            }

            
        }

        


    }
}
