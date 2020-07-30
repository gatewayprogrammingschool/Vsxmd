﻿//-----------------------------------------------------------------------
// <copyright file="AssemblyUnit.cs" company="Junle Li">
//     Copyright (c) Junle Li. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vsxmd.Units
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Linq;

    /// <summary>
    /// Assembly unit.
    /// </summary>
    internal class AssemblyUnit : BaseUnit
    {
        private const string Href = "assembly";

        /// <summary>
        /// Initializes a new instance of the <see cref="AssemblyUnit"/> class.
        /// </summary>
        /// <param name="element">The assembly XML element.</param>
        /// <exception cref="ArgumentException">Throw if XML element name is not <c>assembly</c>.</exception>
        internal AssemblyUnit(XDocument document, XElement element)
            : base(document, element, "assembly")
        {
        }

        private string AssemblyName => this.GetChild("name").Value;

        /// <inheritdoc />
        public override IEnumerable<string> ToMarkdown() =>
            new[]
            {
                $"##### {this.AssemblyName}",
                $"# {Href.ToAnchor()}Assembly: {this.AssemblyName}",
                $"!include(./{this.AssemblyName}.md)",
            };
    }
}
