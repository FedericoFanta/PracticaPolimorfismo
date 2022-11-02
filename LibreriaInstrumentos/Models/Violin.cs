using LibreriaInstrumentos.ModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaInstrumentos.Models
{
    public class Violin:Instrumento

    {
        
        public override string Afinar()
        {
            return base.Afinar() + "stradivarius";
        }
    }
}
