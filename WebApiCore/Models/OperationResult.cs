namespace WebApiCore
{
    public class OperationResult
    {
        public object? Result { get; private set; }

        public OperationResult(object? result) => Result = result;
    }
}