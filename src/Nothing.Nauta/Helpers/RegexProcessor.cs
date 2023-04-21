namespace Nothing.Nauta.Helpers
{
    using System;
    using System.Text.RegularExpressions;

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

        public bool Execute(string content)
        {
            bool executed = false;
            var match = this.regex.Match(content);
            if (match.Success)
            {
                var invoke = this.predicate?.Invoke(match);
                if (invoke.HasValue && invoke.Value)
                {
                    this.action(match.Groups[0].Value);
                    executed = true;
                }

                if (!executed && this.groupPredicate != null)
                {
                    int index = 1;
                    while (!executed && index < match.Groups.Count)
                    {
                        var matchGroup = match.Groups[index];
                        if (this.groupPredicate(matchGroup))
                        {
                            this.action(matchGroup.Value);
                            executed = true;
                        }

                        index++;
                    }
                }
            }

            return executed;
        }
    }
}