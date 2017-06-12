using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace QLHH.TagHelpers
{
    [HtmlTargetElement("select2", TagStructure = TagStructure.WithoutEndTag)]
    public class Select2TagHelper : TagHelper
    {
        public Select2TagHelper()
        {
            Source = new List<Select2Item>();
        }
        [HtmlAttributeName("asp-for-model")]
        public ModelExpression AspForExpression { get; set; }
        [HtmlAttributeName("asp-for")]
        public string AspForString { get; set; }
        public List<Select2Item> Source { get; set; }
        public string Value { get; set; }
        public string DefaultValue { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "select";
            output.Attributes.SetAttribute("class",$"{output.Attributes["class"].Value} select2" );
           
            if (!string.IsNullOrEmpty(AspForString))
            {
                output.Attributes.SetAttribute("name", AspForString);
            }
            else if (AspForExpression != null)
            {
                output.Attributes.SetAttribute("name", AspForExpression.Metadata.PropertyName);
            }

            var options = new StringBuilder();
            Source.ForEach(item =>
            {
                if (!string.IsNullOrEmpty(Value) || !string.IsNullOrEmpty(DefaultValue))
                {
                    if ((!string.IsNullOrEmpty(Value) && item.id == Value) || (!string.IsNullOrEmpty(DefaultValue) && item.id == DefaultValue))
                    {
                        options.Append($"<option value=\"{item.id}\" selected=\"selected\">{item.text}</option>");
                    }
                }
                else
                {
                    options.Append($"<option value=\"{item.id}\">{item.text}</option>");
                }
            });
            output.Content.SetHtmlContent(options.ToString());
            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
    
    public class Select2Option
    {

    }

    public class Select2Item
    {
        public string id { get; set; }
        public string text { get; set; }
    }
}
