using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квалификационный_Экзамен
{
   public class Storage
    {
        public double result;
        public Storage(double oby,double storage) {

            result = storage - oby;
        }
        public double Vivod()
        {
            return result;
        }
    }
}
