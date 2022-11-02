using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaInstrumentos.ModelBase
{
    public abstract class Instrumento
    {
        public string Nombre { get; set; }
        public string Modelo { get; set; }

        public virtual string Afinar()
        {
            return "Afinando" +Nombre;
        }
    }
}
