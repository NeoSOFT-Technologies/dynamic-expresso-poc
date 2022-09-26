using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicExpressoPOC.Features
{
    public class AccessMemberDemo
    {

        public int fieldVal;
        public int Val1 { get; set; }

        public int Evaluate(int value)
        {
            return 2 * value + 3;
        }

        public void SetFieldValue(int value)
        {
            fieldVal = value;
        }
    }
}
