using System;


namespace R5T.Neapolis
{
    public static class NameValueExtensions
    {
        public static NameValueArgument SetName(this NameValueArgument nameValue, IArgumentName name)
        {
            nameValue.Name = name;

            return nameValue;
        }

        public static NameValueArgument SetNameShort(this NameValueArgument nameValue, string name)
        {
            nameValue.SetName(new ShortArgumentName(name));

            return nameValue;
        }

        public static NameValueArgument SetNameFull(this NameValueArgument nameValue, string name)
        {
            nameValue.SetName(new FullArgumentName(name));

            return nameValue;
        }

        public static NameValueArgument SetValue(this NameValueArgument nameValue, IArgumentValue value)
        {
            nameValue.Value = value;

            return nameValue;
        }

        public static NameValueArgument SetValue(this NameValueArgument nameValue, string value)
        {
            nameValue.SetValue(new ArgumentValue(value));

            return nameValue;
        }

        public static NameValueArgument SetValuePath(this NameValueArgument nameValue, string path)
        {
            nameValue.SetValue(new PathArgumentValue(path));

            return nameValue;
        }
    }
}
