using DynamicExpresso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicExpressoPOC.Features
{
    public class Variable
    {
        public static void SetVariable()
        {
            Interpreter interpreter = new Interpreter();

            interpreter.SetVariable("x", 6);
            interpreter.SetVariable("y", 5.5);

            string expression = "x + y * (x - y)";
            var result = interpreter.Eval(expression);

            Console.WriteLine("{0} = {1}", expression, result);
        }

        public static void TypeVariable()
        {
            Interpreter interpreter = new Interpreter();
            interpreter.SetVariable("myInt", 6);
            interpreter.SetVariable("myDouble", -3.6);
            interpreter.SetVariable("myStr", "Hello World");
            interpreter.SetVariable("myArray", new object[] { 3.5, "Test", false });

            List<string> expressions = new List<string>()
            {
                "myInt + myDouble",
                "myStr + \", you are learning Expression Evaluator\"",
                "myArray.Length",
                "myArray[0]",
                "myArray[2]",
            };

            foreach (var expression in expressions)
            {
                var result = interpreter.Eval(expression);
                Console.WriteLine("{0} = {1}", expression, result);
            }
        }


    }
}
