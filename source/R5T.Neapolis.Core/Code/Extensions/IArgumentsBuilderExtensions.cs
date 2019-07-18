using System;


namespace R5T.Neapolis
{
    public static class IArgumentsBuilderExtensions
    {
        public static IArgumentsBuilder AddToken(this IArgumentsBuilder argumentsBuilder, IArgumentToken token)
        {
            var tokenValue = token.GetTokenValue();

            argumentsBuilder.AddToken(tokenValue);

            return argumentsBuilder;
        }

        public static IArgumentsBuilder AddName(this IArgumentsBuilder argumentsBuilder, IArgumentName name)
        {
            argumentsBuilder.AddToken(name);

            return argumentsBuilder;
        }

        public static IArgumentsBuilder AddValue(this IArgumentsBuilder argumentsBuilder, IArgumentValue value)
        {
            argumentsBuilder.AddToken(value);

            return argumentsBuilder;
        }

        public static IArgumentsBuilder AddValue(this IArgumentsBuilder argumentsBuilder, string value)
        {
            argumentsBuilder.AddToken(value);

            return argumentsBuilder;
        }

        public static IArgumentsBuilder AddPath(this IArgumentsBuilder argumentsBuilder, string path)
        {
            var token = $@"""{path}""";

            argumentsBuilder.AddToken(token);

            return argumentsBuilder;
        }

        public static IArgumentsBuilder AddVerb(this IArgumentsBuilder argumentsBuilder, VerbArgument verb)
        {
            argumentsBuilder.AddName(verb.Name);

            var verbArguments = verb.Arguments.Build();

            argumentsBuilder.AddToken(verbArguments);

            return argumentsBuilder;
        }

        public static IVerbArgumentsBuilder AddVerb(this IArgumentsBuilder argumentsBuilder, string name)
        {
            var verbArgumentsBuilder = new VerbArgumentsBuilder(name, argumentsBuilder);

            return verbArgumentsBuilder;
        }

        /// <summary>
        /// Allows adding an value-less option that turned on just by being present.
        /// </summary>
        public static IArgumentsBuilder AddFlag(this IArgumentsBuilder argumentsBuilder, IArgumentName flag)
        {
            argumentsBuilder.AddName(flag);

            return argumentsBuilder;
        }

        public static IArgumentsBuilder AddNameValue(this IArgumentsBuilder argumentsBuilder, NameValueArgument nameValue)
        {
            argumentsBuilder.AddToken(nameValue);

            return argumentsBuilder;
        }
    }
}
