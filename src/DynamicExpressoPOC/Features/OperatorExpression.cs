using DynamicExpresso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicExpressoPOC.Features
{
    public class OperatorExpression
    {
        public static void operatorExpression()
        {
            ExpressoService expS = new ExpressoService();
            //Operator

            Console.Write("Enter the Expression: ");
            var expression = Console.ReadLine();

            var result = expS.Evaluation(expression);
            Console.WriteLine("{0} = {1}", expression, result);
        }
    }
}
