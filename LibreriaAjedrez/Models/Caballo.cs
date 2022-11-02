using LibreriaAjedrez.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAjedrez.Models
{
    public class Caballo:PiezaAJedrez
    {
        public override string mover()
        {
            return base.mover() + "  " + "En L, teniendo la posibilidad de saltar piezas";
        }
    }
}
