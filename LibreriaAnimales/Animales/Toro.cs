using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaAnimales.Animales;

namespace LibreriaAnimales.Animales
{
    public class Toro : Animal
    {
        public Toro(string nombre, string edad, string altura, string peso,string tipocomida) : base(nombre, edad, altura, peso, tipocomida)
        {

        }

        
        public override string Comida()
        {
            return $"Comida: {TipoComida}";
        }
    }
}
