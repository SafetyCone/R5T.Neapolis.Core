using System;

using R5T.NetStandard;


namespace R5T.Neapolis
{
    public class ArgumentToken : TypedString, IArgumentToken
    {
        public ArgumentToken(string value)
            : base(value)
        {
        }

        public virtual string GetTokenValue()
        {
            var output = this.Value;
            return output;
        }

        public override string ToString()
        {
            var representation = this.GetTokenValue();
            return representation;
        }
    }
}
