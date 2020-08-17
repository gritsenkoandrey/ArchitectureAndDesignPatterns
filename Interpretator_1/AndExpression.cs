namespace Interpretator_1
{
    public class AndExpression : IExpression
    {
        private IExpression _exp1 = null;
        private IExpression _exp2 = null;

        public AndExpression(IExpression exp1, IExpression exp2)
        {
            _exp1 = exp1;
            _exp2 = exp2;
        }

        public bool Interpret(string context)
        {
            return _exp1.Interpret(context) && _exp2.Interpret(context);
        }
    }
}