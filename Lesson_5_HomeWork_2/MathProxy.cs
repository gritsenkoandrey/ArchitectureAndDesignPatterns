namespace Lesson_5_HomeWork_2
{
    public class MathProxy : ICalculate
    {
        private Math _math;
        private string _nameOperation;

        public MathProxy(string nameOperation)
        {
            _nameOperation = nameOperation;
        }

        public int Calculate(int num1, int num2)
        {
            if(_math == null)
            {
                _math = new Math(_nameOperation);
            }
            return _math.Calculate(num1, num2);
        }
    }
}