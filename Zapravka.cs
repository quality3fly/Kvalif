using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квалификационный_Экзамен
{
    public class Zapravka
    {
        public double result;
        public Zapravka(double oby,double strorage) {

            result = strorage + oby;
        }
        public double Vivod()
        {
            return result;
        }
    }
}
