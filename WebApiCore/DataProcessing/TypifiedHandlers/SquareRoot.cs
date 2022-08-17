namespace WebApiCore
{
    public class SquareRoot : Handler
    {
        public SquareRoot(string data) : base(data) { }

        public override OperationResult GetResult()
        {
            double number = GetNumber();

            var result = new OperationResult("Not a number");

            if (number >= 0)
            {
                double rootOfNumber = Calculate(number);

                result = new OperationResult(rootOfNumber);
            }

            return result;
        }

        private double GetNumber() 
        { 
            return Convert.ToDouble(Data, new System.Globalization.CultureInfo("en-US"));
        }

        private double Calculate(double number) 
        { 
            return Math.Sqrt(number);
        }
    }
}