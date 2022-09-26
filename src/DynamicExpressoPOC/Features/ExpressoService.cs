using DynamicExpresso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicExpressoPOC.Features
{
    public class ExpressoService
    {
        readonly Interpreter _interpreter;
        public ExpressoService()
        {
            _interpreter = new Interpreter();

            _interpreter.Reference(typeof(AccessMemberDemo));
            _interpreter.SetVariable("demoObj", new AccessMemberDemo()
            {
                Val1 = 10
            });
        }

        public object Evaluation(string expression)
        {

            var result = _interpreter.Eval(expression);

            return result;
        }
    }
}
