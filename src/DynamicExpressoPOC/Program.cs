using DynamicExpressoPOC.Features;

PrintHeading("Identifier Detection");
IdentifierDetections.IdentifierDetection();

PrintHeading("Exception Handling");
ExceptionsHandling.ExceptionHandling();


PrintHeading("Dynamic Delegate");
DynamicDelegates.DynamicDelegate();

PrintHeading("Lambda Expression");
LambdaExpressions.LambdaExpression();


PrintHeading("Operator Expression");
OperatorExpression.operatorExpression();


PrintHeading("Access Member");
AccessTypeMember.AccessMember();



void PrintHeading(string heading)
{
    Console.WriteLine($"\n\n*******************************************{heading}*******************************************");
}
