using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAnimales.Animales
{
    public abstract class Animal
    {

        public Animal(string nombre, string edad, string altura, string peso, string tipocomida)
        {
            NombreAnimal = nombre;
            EdadAnimal = edad;
            AlturaAnimal = altura;
            PesoAnimal = peso;
            TipoComida = tipocomida;
            
        }
        
        public string NombreAnimal { get; }
        public string EdadAnimal { get; }
        public string AlturaAnimal { get; }
        public string PesoAnimal { get; }

        public string TipoComida { get; }

        public virtual string Imprimir()
        {
            return $"Animal: {NombreAnimal}\nEdad:{EdadAnimal}\nAltura:{AlturaAnimal}\nPeso:{PesoAnimal}\n";
        }
        public abstract string Comida();
    }
}
