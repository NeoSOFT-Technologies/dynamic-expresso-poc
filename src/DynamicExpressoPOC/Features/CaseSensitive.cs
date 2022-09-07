using DynamicExpresso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicExpressoPOC.Features
{
    public class CaseSensitive
    {
        public static void ExampleCaseSesitive()
        {
            Interpreter interpreter = new Interpreter();
            interpreter.SetVariable("param", 6);

            string expression = "param + PARAM + Param";
            var result = interpreter.Eval(expression);

            Console.WriteLine("{0} = {1}", expression, result);
        }

        public static void ExampleCaseSesitive2()
        {
            // InterpreterOptions.CaseInsensitive

            Interpreter interpreter = new Interpreter(InterpreterOptions.CaseInsensitive);
            interpreter.SetVariable("param", 6);

            string expression = "param + PARAM + Param";
            var result = interpreter.Eval(expression);

            Console.WriteLine("{0} = {1}", expression, result);
        }
    }
}
