using DynamicExpresso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicExpressoPOC.Features
{
    public class Parameters
    {
        public static void ParameterSet()
        {
            Interpreter interpreter = new Interpreter();

            var parameters = new[]
            {
                new Parameter("x", 23),
                new Parameter("y", 7)
            };

            string expression = "x + y * (x - y)";
            var result = interpreter.Eval(expression, parameters);

            Console.WriteLine("{0} = {1}", expression, result);
        }

        public static void InvokeParamter()
        {
            //Example interpreter.Parse and interpreter.Invoke

            Interpreter interpreter = new Interpreter();

            var parameters = new[]
            {
                new Parameter("x", 23),
                new Parameter("y", 7)
            };

            var myFunc = interpreter.Parse("x + y", parameters);

            Console.WriteLine(myFunc.Invoke(2, 4));
            Console.WriteLine(myFunc.Invoke(21, -4));
            Console.WriteLine(myFunc.Invoke(3, 6));
            Console.WriteLine(myFunc.Invoke(17, 9));
        }
    }
}
