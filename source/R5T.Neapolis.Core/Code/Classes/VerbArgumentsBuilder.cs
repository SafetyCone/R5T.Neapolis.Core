using System;


namespace R5T.Neapolis
{
    public class VerbArgumentsBuilder : IVerbArgumentsBuilder
    {
        private VerbArgument Verb { get; set; }
        private IArgumentsBuilder CommandArgumentsBuilder { get; set; }


        public VerbArgumentsBuilder(VerbArgument verb, IArgumentsBuilder comandArgumentsBuilder)
        {
            this.Verb = verb;
            this.CommandArgumentsBuilder = comandArgumentsBuilder;
        }

        public VerbArgumentsBuilder(string name, IArgumentsBuilder comandArgumentsBuilder)
            : this(new VerbArgument(name), comandArgumentsBuilder)
        {
        }

        public IArgumentsBuilder AddToken(string token)
        {
            this.Verb.Arguments.AddToken(token);

            return this;
        }

        public string Build()
        {
            var output = this.Verb.Arguments.Build();
            return output;
        }

        public IArgumentsBuilder Finish()
        {
            this.CommandArgumentsBuilder.AddVerb(this.Verb);

            return this.CommandArgumentsBuilder;
        }
    }
}
