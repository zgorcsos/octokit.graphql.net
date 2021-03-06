namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Ordering options for language connections.
    /// </summary>
    public class LanguageOrder
    {
        public LanguageOrderField Field { get; set; }

        public OrderDirection Direction { get; set; }
    }
}