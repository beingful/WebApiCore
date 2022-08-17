namespace WebApiCore
{
    public abstract class Handler
    {
        protected readonly string Data;

        public Handler(string data) => Data = data;

        public abstract OperationResult GetResult();
    }
}