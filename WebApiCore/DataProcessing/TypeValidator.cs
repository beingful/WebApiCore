using System.ComponentModel;

namespace WebApiCore
{
    public class TypeValidator
    {
        private readonly string _data;
        private readonly object _defaultValue; 

        public TypeValidator(string data, object defaultValue) 
        {
            _data = data;
            _defaultValue = defaultValue;
        }

        public bool IsThatType()
        {
            TypeConverter converter = GetTypeConverter();

            return converter.IsValid(_data);
        }

        private TypeConverter GetTypeConverter() 
        { 
            return TypeDescriptor.GetConverter(_defaultValue);
        }
    }
}