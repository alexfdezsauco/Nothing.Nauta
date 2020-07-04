namespace Nothing.Nauta.Helpers
{
    using System;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    using Nothing.Nauta.Helpers.Interfaces;

    public class RegexProcessor : IProcessor
    {
        private readonly Action<string> action;

        private readonly Predicate<Group> groupPredicate;

        private readonly Predicate<Match> predicate;

        private readonly Regex regex;

        public RegexProcessor(
            Regex regex,
            Predicate<Match> matchPredicate = null,
            Predicate<Group> groupPredicate = null,
            Action<string> action = null)
        {
            this.regex = regex;
            this.predicate = matchPredicate;
            this.groupPredicate = groupPredicate;
            this.action = action;
        }

        public Task Execute(string content)
        {
            var match = this.regex.Match(content);
            if (match.Success)
            {
                var invoke = this.predicate?.Invoke(match);
                if (invoke.HasValue && invoke.Value)
                {
                    this.action(match.Groups[0].Value);
                }

                if (this.groupPredicate != null)
                {
                    for (var index = 1; index < match.Groups.Count; index++)
                    {
                        var matchGroup = match.Groups[index];
                        if (this.groupPredicate(matchGroup))
                        {
                            this.action(match.Groups[0].Value);
                        }
                    }
                }
            }

            return Task.CompletedTask;
        }
    }
}