using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBuilder
{
    internal class HtmlBuilder
    {
        private HtmlElement root { get; set; }

        public HtmlBuilder(string name)
        {
            root = new HtmlElement(name);
        }


        public void AddChild(HtmlElement child) => root.AddChild(child);
        public void AddChild(string name, string value) => root.AddChild(new HtmlElement(name, value));
        public override string ToString() => root.ToString();
        public HtmlElement Build() => root;

    }
}
