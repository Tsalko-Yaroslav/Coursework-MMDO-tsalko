using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mmdo.main.module
{
    public class MainElement
    {
        public Tuple<int, int> index;
        public TableAnswerType result;

        public MainElement(Tuple<int, int> index, TableAnswerType result)
        {
            this.index = index;
            this.result = result;
        }
    }
}
