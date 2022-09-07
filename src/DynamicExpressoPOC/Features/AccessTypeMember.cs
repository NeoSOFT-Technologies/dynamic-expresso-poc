using DynamicExpresso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicExpressoPOC.Features
{
    public class AccessTypeMember
    {
        public static void AccessMember()
        {
            ExpressoService expS = new ExpressoService();
            var result1 = expS.Evaluation("demoObj.Evaluate(demoObj.fieldVal + demoObj.Val1)");
            Console.WriteLine("result1 = {0}", result1);
            Console.WriteLine();
        }
    }
}
