using Microsoft.AspNetCore.Html;        // для HtmlString
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Encodings.Web;   // для IHtmlHelper

namespace MVC_Fourth
{
    public static class MVC_helper
    {
        public static HtmlString CreateList(this IHtmlHelper html, string[] items)
        {
            //string result = "<ul>";
            //foreach (string item in items) 
            //{
            //    result = $"{result}<li>{item}</li>";
            //}
            //result = $"{result}</ul>";
            TagBuilder ul = new TagBuilder("ul");
            foreach(string item in items)
            {
                TagBuilder li = new TagBuilder("li");
                li.InnerHtml.Append(item);
                ul.InnerHtml.AppendHtml(li);

            }
            ul.Attributes.Add("class", "itemList");
            using var writer = new StringWriter();
            ul.WriteTo(writer, HtmlEncoder.Default);
            return new HtmlString(writer.ToString());

        }
    }
}
