using DynamicExpresso;
using DynamicExpresso.Exceptions;

namespace DynamicExpressoPOC.Features
{
    public class CustomizingParser
    {
        static Interpreter interpreter = new Interpreter();
        public static void Reflection()
        {
            try
            {
                interpreter.EnableReflection();
                string expression = "typeof(string).GetMethods()";
                var result = interpreter.Eval(expression);
                Console.WriteLine($"{expression} = {result}");

                expression = "typeof(Enumerable).Assembly";
                result = interpreter.Eval(expression);
                Console.WriteLine($"{expression} = {result}");
            }
            catch (ParseException e)
            {

                Console.WriteLine(e.Message);
            }

        }
        public static void Assignment() 
        { 
            try
            {
                interpreter.EnableAssignment(AssignmentOperators.None);
                int x = 10;
                interpreter.SetVariable("x", x);

                string expression = "x = 13;";
                var result = interpreter.Eval(expression);
                Console.WriteLine($"After evaluation, x = {x}");
            }
            catch (ParseException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
