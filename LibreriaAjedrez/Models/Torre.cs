using LibreriaAjedrez.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAjedrez.Models
{
    public class Torre:PiezaAJedrez
    {
        public override string mover()
        {
            return base.mover() + "  " + "en linea recta";
        }
    }
}
