namespace WebApiCore
{
    public class ReversedString : Handler
    {
        public ReversedString(string data) : base(data) { }

        public override OperationResult GetResult()
        {
            string rootOfNumber = Reverse();

            return new OperationResult(rootOfNumber);
        }

        private string Reverse()
        {
            var stringByChars = Data.ToCharArray();
            int size = stringByChars.Length;
            char buffer;

            for (int i = 0; i < size / 2.0; i++)
            {
                buffer = stringByChars[i];
                stringByChars[i] = stringByChars[size - i - 1];
                stringByChars[size - i - 1] = buffer;
            }

            return String.Join(String.Empty, stringByChars);
        }
    }
}