﻿//-----------------------------------------------------------------------
// <copyright file="ReturnsUnit.cs" company="Junle Li">
//     Copyright (c) Junle Li. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vsxmd.Units
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    /// <summary>
    /// Returns unit.
    /// </summary>
    internal class ReturnsUnit : BaseUnit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnsUnit"/> class.
        /// </summary>
        /// <param name="element">The returns XML element.</param>
        /// <exception cref="ArgumentException">Throw if XML element name is not <c>returns</c>.</exception>
        internal ReturnsUnit(XDocument document, XElement element)
            : base(document, element, "returns")
        {
        }

        /// <inheritdoc />
        public override IEnumerable<string> ToMarkdown() =>
            new[]
            {
                "### Returns",
                this.ElementContent,
            };

        /// <summary>
        /// Convert the returns XML element to Markdown safely.
        /// If element is <value>null</value>, return empty string.
        /// </summary>
        /// <param name="element">The returns XML element.</param>
        /// <returns>The generated Markdown.</returns>
        internal static IEnumerable<string> ToMarkdown(XDocument document, XElement element) =>
            element != null
                ? new ReturnsUnit(document, element).ToMarkdown()
                : Enumerable.Empty<string>();
    }
}
