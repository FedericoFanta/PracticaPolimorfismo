using LibreriaInstrumentos.ModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaInstrumentos.Models
{
    public class Piano:Instrumento
    {
        public override string Afinar()
        {
            return base.Afinar() + "de pedal";
        }

    }
}
