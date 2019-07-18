using System;


namespace R5T.Neapolis
{
    public class ArgumentValue : ArgumentToken, IArgumentValue
    {
        public ArgumentValue(string value)
            : base(value)
        {
        }
    }
}
