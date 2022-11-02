using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAjedrez.Models.Base
{
    public abstract class PiezaAJedrez
    {
        public string Nombre { get; set; }
        

        public virtual string mover()
        {
            return "Pieza:" + " " +Nombre + " " +"\nSe mueve en:" ;
        }
    }
}
