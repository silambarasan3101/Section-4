using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomHelperMethods.Views.Home
{
    public class CustomHelper
    {
        public static HtmlString File(string id)
        {
            TagBuilder tb = new TagBuilder("input");
            tb.Attributes.Add("type", "file");
            tb.Attributes.Add("id", id);
            return new HtmlString(tb.ToString());
        }

    }
}
