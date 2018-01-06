namespace Calculator.Core
{
    public class SpecalFactory
    {
        public static Special_Operation creatSpecial_Operation(string operate)
        {
            Special_Operation spo = null;

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
            }
            return spo;
        }
    }
}
