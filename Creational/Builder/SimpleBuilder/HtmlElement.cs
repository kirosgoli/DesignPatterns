using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBuilder
{
    internal class HtmlElement
    {
        public string Name { get; set; }
        public string Value { get; set; }

        private const int indentSize = 2;
        private List<HtmlElement> elements = new List<HtmlElement>();

        public HtmlElement()
        {
        }

        public HtmlElement(string name)
        {
            Name = name;
        }

        public HtmlElement(string name, string value)
        {
            Name = name;
            Value = value;
        }

        internal void AddChild(HtmlElement element)
        {
            elements.Add(element);
        }


        public override string ToString()
        {
            string html = String.Empty;
            if (!string.IsNullOrEmpty(Value))
                html = $"<{Name}>{Value}</{Name}>";
            else if (elements.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"<{Name}>");
                foreach (var element in elements)
                    sb.AppendLine($"{new String(' ',indentSize)}{element.ToString()}");
                sb.AppendLine($"</{Name}>");
                html = sb.ToString();
            }
            else
                html = $"<{Name} />";
            return html;
        }
    }
}
