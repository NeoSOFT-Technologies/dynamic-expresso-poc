using DynamicExpressoPOC.Features;

PrintHeading("Identifier Detection");
IdentifierDetections.IdentifierDetection();

PrintHeading("Exception Handling");
ExceptionsHandling.ExceptionHandling();


PrintHeading("Dynamic Delegate");
DynamicDelegates.DynamicDelegate();

PrintHeading("Lambda Expression");
LambdaExpressions.LambdaExpression();

PrintHeading("Enable Reflection");
CustomizingParser.Reflection();

PrintHeading("Disable Assignment Operator");
CustomizingParser.Assignment();

void PrintHeading(string heading)
{
    Console.WriteLine($"\n\n*******************************************{heading}*******************************************");
}
