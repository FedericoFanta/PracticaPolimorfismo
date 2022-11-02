using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaInstrumentos.Models;
using LibreriaInstrumentos.ModelBase;
using LibreriaInstrumentos.Instrumentos;
using LibreriaAjedrez.Models;
using LibreriaAjedrez.Models.Base;
using LibreriaAnimales.Animales;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAfinar_Click(object sender, EventArgs e)
        {
            Guitarra guitarra = new Guitarra()
            {
               
                Nombre= "Guitarra",
                
            };

            Violin violin = new Violin()
            {
               
                Nombre = "Violin",
                
            };

            Piano piano = new Piano()
            {
                Nombre = "Piano"
            };



            MessageBox.Show(guitarra.Afinar());
            MessageBox.Show(violin.Afinar());
            MessageBox.Show(piano.Afinar());
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            Peon peon = new Peon()
            {
                Nombre = "Peon"
            };

            Caballo caballo = new Caballo()
            {
                Nombre = "Caballo"
            };

            Torre torre = new Torre()
            {
                Nombre = "Torre"
            };

            MessageBox.Show(peon.mover());
            MessageBox.Show(caballo.mover());
            MessageBox.Show(torre.mover());

        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            Toro toro = new Toro("ToroAlfonzo", "25años", "2mts", "1499kg", "Pastito");

            Leon leon = new Leon("LeonPepe", "27años", "1.78m", "333kg", "Carne" );

            Conejo conejo = new Conejo("Conejin", "11años", "60cm", "55kg", "Semillas");

            MessageBox.Show(toro.Imprimir() +toro.Comida());

            MessageBox.Show(leon.Imprimir() +leon.Comida());

            MessageBox.Show(conejo.Imprimir() +conejo.Comida());
            
        }
    }
}
