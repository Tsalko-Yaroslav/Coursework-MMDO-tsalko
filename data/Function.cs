using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mmdo.main.module
{
    public class Function
    {
        public double[] variables;
        public bool isExtrMax;

        public Function(double[] variables, bool isExtrMax)
        {
            this.variables = variables;
            this.isExtrMax = isExtrMax;
        }
    }
}
