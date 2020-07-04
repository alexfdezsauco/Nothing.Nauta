namespace Nothing.Nauta.Helpers
{
    using System;
    using System.Threading.Tasks;

    using Nothing.Nauta.Helpers.Interfaces;

    public class TextProcessor : IProcessor
    {
        private readonly Action<string> action;

        private readonly Predicate<string> predicate;

        public TextProcessor(Predicate<string> predicate, Action<string> action)
        {
            this.predicate = predicate;
            this.action = action;
        }

        public Task Execute(string content)
        {
            if (this.predicate(content))
            {
                this.action(content);
            }

            return Task.CompletedTask;
        }
    }
}