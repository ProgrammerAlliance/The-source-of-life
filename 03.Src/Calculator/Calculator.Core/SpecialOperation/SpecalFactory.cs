namespace Calculator.Core
{
    public class SpecalFactory
    {
        public static ISpecialOperation CreateSpecial_Operation(string operate)
        {
            ISpecialOperation spo = null;

            switch (operate)
            {
                
                case "X²":
                    {
                        spo = new Square();
                        break;
                    }
                case "√":
                    {
                        spo = new Sqrt();
                        break;
                    }
                case "1/x":
                    {
                        spo = new Reciprocal();
                        break;
                    }
                case "%":
                    {
                        spo = new Percent();
                        break;
                    }
            }
            return spo;
        }
    }
}
