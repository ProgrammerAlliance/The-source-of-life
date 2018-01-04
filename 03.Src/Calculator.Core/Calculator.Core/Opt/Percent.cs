namespace Calculator.Core.Opt
{
    class Percent: Operation
    {
        public override object GetResult()
        {
            double result = 0;
            result = NumberA +((NumberA* NumberB)/100);
            return result;
        }
    }
}
