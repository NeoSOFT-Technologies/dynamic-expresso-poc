using DynamicExpressoPOC.Features;

PrintHeading("Variables");
Variable.SetVariable();
Variable.TypeVariable();

PrintHeading("Parameter");
Parameters.ParameterSet();
Parameters.InvokeParamter();

PrintHeading("Case Sensitive");
CaseSensitive.ExampleCaseSesitive2();

PrintHeading("Enable Reflection");
CustomizingParser.Reflection();

PrintHeading("Disable Assignment Operator");
CustomizingParser.Assignment();

PrintHeading("Operator Expression");
OperatorExpression.operatorExpression();

PrintHeading("Access Member");
AccessTypeMember.AccessMember();

PrintHeading("Identifier Detection");
IdentifierDetections.IdentifierDetection();

PrintHeading("Exception Handling");
ExceptionsHandling.ExceptionHandling();

PrintHeading("Dynamic Delegate");
DynamicDelegates.DynamicDelegate();

PrintHeading("Lambda Expression");
LambdaExpressions.LambdaExpression();


void PrintHeading(string heading)
{
    Console.WriteLine($"\n\n*******************************************{heading}*******************************************");
}
