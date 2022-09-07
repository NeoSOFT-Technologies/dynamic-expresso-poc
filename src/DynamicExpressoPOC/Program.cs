using DynamicExpressoPOC.Features;

PrintHeading("Identifier Detection");
IdentifierDetections.IdentifierDetection();

PrintHeading("Exception Handling");
ExceptionsHandling.ExceptionHandling();


PrintHeading("Dynamic Delegate");
DynamicDelegates.DynamicDelegate();

PrintHeading("Lambda Expression");
LambdaExpressions.LambdaExpression();


void PrintHeading(string topic)
{
    Console.WriteLine($"\n\n*******************************************{topic}*******************************************");
}
