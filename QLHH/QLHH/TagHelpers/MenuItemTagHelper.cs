using Microsoft.AspNetCore.Razor.TagHelpers;

namespace QLHH.TagHelpers
{
    public class MenuItemTagHelper: TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "li";    // Replaces <email> with <a> tag
            output.Content.Append("");
        }
    }
}
