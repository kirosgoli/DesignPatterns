
using SimpleBuilder;

HtmlBuilder ulBuilder = new HtmlBuilder("ul");
ulBuilder.AddChild("li", "1");
ulBuilder.AddChild("li", "2");

Console.WriteLine(ulBuilder.ToString());

HtmlBuilder bodyBuilder = new HtmlBuilder("body");
bodyBuilder.AddChild(ulBuilder.Build());

Console.WriteLine(bodyBuilder.ToString());