using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaconstructor
{
    class resta
    {
        public double V1;
        public double V2;

        public resta()
        {
        }

        public resta(double v1, double v2)
        {
            V1 = v1;
            V2 = v2;
        }

        public double restar()
        {
            return V1 - V2;
        }
    }
    
}
