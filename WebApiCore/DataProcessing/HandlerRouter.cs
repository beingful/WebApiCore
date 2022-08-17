namespace WebApiCore
{
    public class HandlerRouter
    {
        private readonly string _data;
        private readonly Type[] _types;
        private readonly Handler _defaultHandler;
        private readonly Dictionary<Type, Func<string, TypifiedData>> _typedHandlers;

        public HandlerRouter(string data, params Type[] types)
        {
            _data = data;
            _types = types;
            _defaultHandler = new ReversedString(_data);
            _typedHandlers = new Dictionary<Type, Func<string, TypifiedData>>
            {
                { typeof(double), (data) => new TypifiedData(.0, new SquareRoot(data)) }
            };
        }

        public Handler GetHandler()
        {
            Handler dataHandler = _defaultHandler;

            foreach (var type in _types)
            {
                if (_typedHandlers.ContainsKey(type))
                {
                    TypifiedData data = _typedHandlers[type](_data);

                    var inspector = new TypeValidator(_data, data.DefaultValue);

                    if (inspector.IsThatType())
                    {
                        dataHandler = data.Handler;

                        break;
                    }
                }
            }

            return dataHandler;
        }
    }
}