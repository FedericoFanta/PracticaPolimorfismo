using LibreriaAjedrez.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAjedrez.Models
{
    public class Peon:PiezaAJedrez
    {
        public override string mover()
        {
            return base.mover() + "  " + "1 en 1 o de a 2 casilleros en el primer movimiento";
        }

    }
}
