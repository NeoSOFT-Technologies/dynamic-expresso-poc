using DynamicExpresso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicExpressoPOC.Features
{
    public class IdentifierDetections
    {
        public static void IdentifierDetection()
        {
            // Identifier detection  => Interpreter.DetectIdentifiers method will detect an unknown identifier and will notify the user if there is any

            Interpreter interpreter = new Interpreter();

            interpreter.SetVariable("x", 6);
            interpreter.SetVariable("y", 5.5);

            string expression = "x + y + z";

            var detectedIdentifiers = interpreter.DetectIdentifiers(expression);

            var unknownIdentifiers = detectedIdentifiers.UnknownIdentifiers.ToList();

            if (unknownIdentifiers.Count > 0)
            {
                foreach (var unknownIdentifier in unknownIdentifiers)
                {
                    Console.WriteLine("Identifier \"{0}\" is not defined in your expression.", unknownIdentifier);
                }
            }
            else
            {
                var result = interpreter.Eval(expression);

                Console.WriteLine("{0} = {1}", expression, result);
            }
        }
    }
}
