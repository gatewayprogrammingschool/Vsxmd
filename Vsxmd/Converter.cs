//-----------------------------------------------------------------------
// <copyright file="Converter.cs" company="Junle Li">
//     Copyright (c) Junle Li. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vsxmd
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using Vsxmd.Units;

    /// <inheritdoc/>
    public class Converter : IConverter
    {
        private readonly XDocument document;

        /// <summary>
        /// Initializes a new instance of the <see cref="Converter"/> class.
        /// </summary>
        /// <param name="document">The XML document.</param>
        public Converter(XDocument document)
        {
            this.document = document;
        }

        /// <summary>
        /// Convert VS XML document to Markdown syntax.
        /// </summary>
        /// <param name="document">The XML document.</param>
        /// <returns>The generated Markdown content.</returns>
        public static string ToMarkdown(XDocument document) =>
            new Converter(document).ToMarkdown();

        /// <inheritdoc/>
        public string ToMarkdown() =>
            ToUnits(this.document, this.document.Root)
                .SelectMany(x => x.ToMarkdown())
                .Join("\n\n")
                .Suffix("\n");

        private static IEnumerable<IUnit> ToUnits(XDocument document, XElement docElement)
        {
            var assemblyNode = docElement.Element("assembly");
            var au = new AssemblyUnit(document, assemblyNode);

            // member units
            var memberUnits = docElement
                .Element("members")
                .Elements("member")
                .Select(element => new MemberUnit(document, element))
                .Where(member => member.Kind != MemberKind.NotSupported)
                .GroupBy(unit => unit.TypeName)
                .Select(group => MemberUnit.ComplementType(document, group))
                .SelectMany(group => group)
                .OrderBy(member => member, MemberUnit.Comparer)
                .ToList<IUnit>();

            memberUnits.Insert(0, au);

            return memberUnits.ToArray();
        }
    }
}
