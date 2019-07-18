using System;


namespace R5T.Neapolis
{
    public class VerbArgument
    {
        public IArgumentName Name { get; set; }
        public IArgumentsBuilder Arguments { get; } = ArgumentsBuilder.New();


        public VerbArgument()
        {
        }

        public VerbArgument(string name)
        {
            this.Name = new ArgumentName(name);
        }
    }
}
