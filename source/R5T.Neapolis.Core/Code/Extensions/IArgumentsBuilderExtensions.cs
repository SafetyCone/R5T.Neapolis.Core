using System;


namespace R5T.Neapolis
{
    public static class IArgumentsBuilderExtensions
    {
        public static T AddToken<T>(this T argumentsBuilder, IArgumentToken token)
            where T: IArgumentsBuilder
        {
            var tokenValue = token.GetTokenValue();

            argumentsBuilder.AddToken(tokenValue);

            return argumentsBuilder;
        }

        public static T AddName<T>(this T argumentsBuilder, IArgumentName name)
            where T: IArgumentsBuilder
        {
            argumentsBuilder.AddToken(name);

            return argumentsBuilder;
        }

        public static T AddValue<T>(this T argumentsBuilder, IArgumentValue value)
            where T : IArgumentsBuilder
        {
            argumentsBuilder.AddToken(value);

            return argumentsBuilder;
        }

        public static T AddValue<T>(this T argumentsBuilder, string value)
            where T : IArgumentsBuilder
        {
            argumentsBuilder.AddToken(value);

            return argumentsBuilder;
        }

        public static T AddPath<T>(this T argumentsBuilder, string path)
            where T : IArgumentsBuilder
        {
            var token = $@"""{path}""";

            argumentsBuilder.AddToken(token);

            return argumentsBuilder;
        }

        public static T AddVerb<T>(this T argumentsBuilder, VerbArgument verb)
            where T : IArgumentsBuilder
        {
            argumentsBuilder.AddName(verb.Name);

            var verbArguments = verb.Arguments.Build();

            argumentsBuilder.AddToken(verbArguments);

            return argumentsBuilder;
        }

        public static T AddVerb<T>(this T argumentsBuilder, string name, Action<IArgumentsBuilder> configureVerbArguments)
            where T : IArgumentsBuilder
        {
            var verb = new VerbArgument(name);

            configureVerbArguments(verb.Arguments);

            argumentsBuilder.AddVerb(verb);

            return argumentsBuilder;
        }

        /// <summary>
        /// Allows adding an value-less option that turned on just by being present.
        /// </summary>
        public static T AddFlag<T>(this T argumentsBuilder, IArgumentName flag)
            where T : IArgumentsBuilder
        {
            argumentsBuilder.AddName(flag);

            return argumentsBuilder;
        }

        public static T AddFlagShort<T>(this T argumentsBuilder, string flag)
            where T : IArgumentsBuilder
        {
            argumentsBuilder.AddName(new ShortArgumentName(flag));

            return argumentsBuilder;
        }

        public static T AddFlagFull<T>(this T argumentsBuilder, string flag)
            where T : IArgumentsBuilder
        {
            argumentsBuilder.AddName(new FullArgumentName(flag));

            return argumentsBuilder;
        }

        public static T AddNameValue<T>(this T argumentsBuilder, NameValueArgument nameValue)
            where T : IArgumentsBuilder
        {
            argumentsBuilder.AddToken(nameValue);

            return argumentsBuilder;
        }

        public static T AddNameValue<T>(this T argumentsBuilder, Action<NameValueArgument> configureNameValue)
            where T : IArgumentsBuilder
        {
            var nameValue = new NameValueArgument();

            configureNameValue(nameValue);

            argumentsBuilder.AddToken(nameValue);

            return argumentsBuilder;
        }
    }
}
