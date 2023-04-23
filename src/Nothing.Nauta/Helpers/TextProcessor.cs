// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TextProcessor.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

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

        public bool Execute(string content)
        {
            var executed = false;
            if (this.predicate(content))
            {
                this.action(content);
                executed = true;
            }

            return executed;
        }
    }
}