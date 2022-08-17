namespace WebApiCore
{
    public class TypifiedData
    {
        public readonly object DefaultValue;
        public readonly Handler Handler;

        public TypifiedData(object defaultValue, Handler handler)
        {
            DefaultValue = defaultValue;
            Handler = handler;
        }
    }
}