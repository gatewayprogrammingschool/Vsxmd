using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;
using Microsoft.VisualBasic;
using static System.String;

namespace Vsxmd.Units
{
    internal class ChildMembersUnit : BaseUnit
    {
        private readonly XDocument document;
        private readonly MemberName name;

        internal MemberKind Kind => this.name.Kind;

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryUnit"/> class.
        /// </summary>
        /// <param name="element">The current XML element.</param>
        /// <exception cref="ArgumentException">Throw if XML element name is not <c>summary</c>.</exception>
        internal ChildMembersUnit(XDocument document, XElement element)
            : base(document, element, "member")
        {
            this.document = document;
            this.name = new MemberName(
                this.GetAttribute("name"),
                this.GetChildren("param").Select(x => x.Attribute("name").Value));
        }

        /// <summary>
        /// Build tables of children.
        /// </summary>
        /// <param name="doc">The current document</param>
        /// <param name="element">The current XML element.</param>
        /// <returns>The generated Markdown.</returns>
        public static IEnumerable<string> ToMarkdown(XDocument doc, XElement element)
        {
            var obj = new ChildMembersUnit(doc, element);

            return obj.ToMarkdown();
        }

        /// <summary>
        /// Build tables of children.
        /// </summary>
        /// <returns>The generated Markdown.</returns>
        public override IEnumerable<string> ToMarkdown()
        {
            var memberUnits = this.GetChildren();

            var header = new string[]
            {
                string.Empty,
                "### {0}",
                string.Empty,
                "| Name | Description |",
                "|---|---|",
            };

            const string lineFormat = "|{0}|{1}|";

            var result = new List<string>();

            var keys = new[]
            {
                ("C", kind: MemberKind.Constants),
                ("P", kind: MemberKind.Property),
                ("M", kind: MemberKind.Method),
                ("T", kind: MemberKind.Type),
            };

            foreach (var (_, kind) in keys)
            {
                var subset = memberUnits.Where(m => m.Kind == kind).ToList();

                if (subset.Any())
                {
                    var toAdd = header.ToList();
                    toAdd[1] = Format(toAdd[1], kind.ToString());

                    result.AddRange(toAdd);
                    result.AddRange(collection: 
                        subset.Select(mem => Format(lineFormat, mem.Link, TrimSummary(mem))));

                    result.Add(string.Empty);
                }
                else
                {
                    //result.Add($"\n> No `{kind}` Present.");
                }

                string TrimSummary(MemberUnit mem)
                {
                    var separators = (Environment.NewLine + ".!?|").ToCharArray();
                    var summary = mem.GetChild("summary")?.Value.Trim() ?? "No summary.";
                    var shortened = summary.IndexOfAny(separators) > -1
                        ? summary.Substring(0, summary.IndexOfAny(separators))
                        : summary;

                    return shortened.Trim();
                }
            }

            var finalResult = new[] { result.Join("\n") };

            return finalResult;
        }

        /// <summary>
        /// Get's the children of the current member.
        /// </summary>
        /// <returns>Array of <see cref="MemberUnit"/></returns>
        public List<MemberUnit> GetChildren()
        {
            if (this.Kind != MemberKind.Type)
            {
                return new List<MemberUnit>();
            }

            var memberUnits = this.GetMembers();
            var children = memberUnits?.Where(
                mu => this.name.StrippedName != mu.name.StrippedName
                && mu.name.ParentStrippedName == this.name.StrippedName).ToList();

            return children;
        }


    }
}