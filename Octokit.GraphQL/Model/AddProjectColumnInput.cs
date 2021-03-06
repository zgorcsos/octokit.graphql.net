namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of AddProjectColumn
    /// </summary>
    public class AddProjectColumnInput
    {
        public ID ProjectId { get; set; }

        public string Name { get; set; }

        public string ClientMutationId { get; set; }
    }
}