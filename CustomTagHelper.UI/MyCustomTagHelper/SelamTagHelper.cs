using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelper.UI.MyCustomTagHelper
{
    [HtmlTargetElement("selam")]
    public class SelamTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h1"; //h1 etiketini içinde yazıcak
            output.Attributes.SetAttribute("style", "color:green;");
            output.Content.SetContent("Merhaba ! Hoşgeldiniz ❤️");
        }
    }
}
