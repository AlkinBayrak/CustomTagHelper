using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelper.UI.MyCustomTagHelper
{
    [HtmlTargetElement("batu")]
    public class BatuTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h1"; 
            output.Attributes.SetAttribute("style", "color:blue;");
            output.Content.SetContent("Batu her şey çözülür bana ulaşın");
            
        }
    }
}
