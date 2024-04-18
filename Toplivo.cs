using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квалификационный_Экзамен
{
   public class Toplivo
    {
        public double mass;
        public Toplivo(double oby,double plotn)
        {
            mass = oby * plotn;
        }
        public double Vivod()
        {
            return mass;
        }
    }
}
