//-----------------------------------------------------------------------
// <copyright file="MemberUnit.cs" company="Junle Li">
//     Copyright (c) Junle Li. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Xml;
using System.Xml.XPath;

namespace Vsxmd.Units
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    /// <summary>
    /// Member unit.
    /// </summary>
    internal class MemberUnit : BaseUnit
    {
        static MemberUnit()
        {
            Comparer = new MemberUnitComparer();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberUnit"/> class.
        /// </summary>
        /// <param name="document"></param>
        /// <param name="element">The member XML element.</param>
        /// <exception cref="ArgumentException">Throw if XML element name is not <c>member</c>.</exception>
        internal MemberUnit(XDocument document, XElement element)
            : base(document, element, "member")
        {
        }

        /// <summary>
        /// Gets the member unit comparer.
        /// </summary>
        /// <value>The member unit comparer.</value>
        internal static IComparer<MemberUnit> Comparer { get; }

        /// <summary>
        /// Gets the type name.
        /// </summary>
        /// <value>The the type name.</value>
        /// <example><c>Vsxmd.Program</c>, <c>Vsxmd.Units.TypeUnit</c>.</example>
        internal string TypeName => this.name.TypeName;

        /// <summary>
        /// Gets the member kind, one of <see cref="MemberKind"/>.
        /// </summary>
        /// <value>The member kind.</value>
        internal MemberKind Kind => this.name.Kind;

        /// <summary>
        /// Gets the link pointing to this member unit.
        /// </summary>
        /// <value>The link pointing to this member unit.</value>
        internal string Link => this.name.Link;

        private IEnumerable<string> InheritDoc =>
            this.GetChild("inheritdoc") == null
                ? Enumerable.Empty<string>()
                : new[]
                {
                    "### Summary",
                    "*Inherit from parent.*",
                };

        private IEnumerable<string> Namespace =>
            this.Kind != MemberKind.Type
            ? Enumerable.Empty<string>()
            : new[]
            {
                $"### Namespace",
                $"{this.name.Namespace}",
            };

        private IEnumerable<string> Summary =>
            SummaryUnit.ToMarkdown(this.Document, this.GetChild("summary"));

        private IEnumerable<string> ChildMembers =>
            ChildMembersUnit.ToMarkdown(this.Document, this.Element);

        private IEnumerable<string> Returns =>
            ReturnsUnit.ToMarkdown(this.Document, this.GetChild("returns"));

        private IEnumerable<string> Params =>
            ParamUnit.ToMarkdown(
                this.Document,
                this.GetChildren("param"),
                this.name.GetParamTypes(),
                this.Kind);

        private IEnumerable<string> Typeparams =>
            TypeparamUnit.ToMarkdown(Document, this.GetChildren("typeparam"));

        private IEnumerable<string> Exceptions =>
            ExceptionUnit.ToMarkdown(Document, this.GetChildren("exception"));

        private IEnumerable<string> Permissions =>
            PermissionUnit.ToMarkdown(Document, this.GetChildren("permission"));

        private IEnumerable<string> Example =>
            ExampleUnit.ToMarkdown(Document, this.GetChild("example"));

        private IEnumerable<string> Remarks =>
            RemarksUnit.ToMarkdown(Document, this.GetChild("remarks"));

        private IEnumerable<string> Seealsos =>
            SeealsoUnit.ToMarkdown(Document, this.GetChildren("seealso"));

        /// <inheritdoc />
        public override IEnumerable<string> ToMarkdown() =>
            new[] { this.name.Caption }
                .Concat(this.Namespace)
                .Concat(this.InheritDoc)
                .Concat(this.Summary)
                .Concat(this.ChildMembers)
                .Concat(this.Returns)
                .Concat(this.Params)
                .Concat(this.Typeparams)
                .Concat(this.Exceptions)
                .Concat(this.Permissions)
                .Concat(this.Example)
                .Concat(this.Remarks)
                .Concat(this.Seealsos);

        /// <summary>
        /// Complement a type unit if the member unit <paramref name="group"/> does not have one.
        /// One member unit group has the same <see cref="TypeName"/>.
        /// </summary>
        /// <param name="group">The member unit group.</param>
        /// <returns>The complemented member unit group.</returns>
        internal static IEnumerable<MemberUnit> ComplementType(
            XDocument document,
            IEnumerable<MemberUnit> group) =>
            group.Any(unit => unit.Kind == MemberKind.Type)
                ? group
                : group.Concat(new[] { Create(document, group.First().TypeName) });

        private static MemberUnit Create(XDocument document, string typeName) =>
            new MemberUnit(
                document: document,
                element: new XElement(
                    name: "member",
                    content: new XAttribute(name: "name", value: $"T:{typeName}")));

        private class MemberUnitComparer : IComparer<MemberUnit>
        {
            /// <inheritdoc />
            public int Compare(MemberUnit x, MemberUnit y) =>
                $"{(int)x.name.Kind}:{x.TypeName}".CompareTo($"{(int)y.name.Kind}:{y.TypeName}");
        }

    }
}
