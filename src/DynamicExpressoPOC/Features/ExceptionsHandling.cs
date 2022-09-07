using DynamicExpresso;
using DynamicExpresso.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicExpressoPOC.Features
{
    public class ExceptionsHandling
    {
        public static void ExceptionHandling()
        {
            //invalid syntax

            try
            {
                Interpreter interpreter = new Interpreter();

                interpreter.SetVariable("x", 6);
                interpreter.SetVariable("y", 5.5);

                string expression = "x + y +";

                var result = interpreter.Eval(expression);

                Console.WriteLine("{0} = {1}", expression, result);
            }
            catch (ParseException ex)
            {
                Console.WriteLine(ex.Message);
            }



            // not defined variable

            try
            {
                Interpreter interpreter = new Interpreter();
                string expression = "x + y + z";

                interpreter.SetVariable("x", 6);
                interpreter.SetVariable("y", 5.5);

                var result = interpreter.Eval(expression);

                Console.WriteLine("{0} = {1}", expression, result);
            }
            catch (ParseException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
