#pragma checksum "C:\Users\borga\Desktop\C#\Resume Templater\Resume Templater\Resume Templater\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27ec9c52e26d60e5f2c123be147808fb6c49504d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ResumeTemplater.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ResumeTemplater.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\borga\Desktop\C#\Resume Templater\Resume Templater\Resume Templater\Pages\_ViewImports.cshtml"
using ResumeTemplater;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\borga\Desktop\C#\Resume Templater\Resume Templater\Resume Templater\Pages\_ViewImports.cshtml"
using ResumeTemplater.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27ec9c52e26d60e5f2c123be147808fb6c49504d", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca3f2fc3671d1b880bdcd14e0da855bf2d49755c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Links", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\borga\Desktop\C#\Resume Templater\Resume Templater\Resume Templater\Pages\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\borga\Desktop\C#\Resume Templater\Resume Templater\Resume Templater\Pages\Index.cshtml"
                       = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"jumbotron jumbotron-fluid jumbotron-container resume-jumbotron text-white\">\r\n    <div class=\"container-fluid jumbotron-content\">\r\n        <p class=\"text-center jumbotron-header mb-4\">Hey there, I\'m ");
#nullable restore
#line 11 "C:\Users\borga\Desktop\C#\Resume Templater\Resume Templater\Resume Templater\Pages\Index.cshtml"
                                                               Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</p>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"container\">\r\n    <div class=\"resume-content\">\r\n        <h4 class=\"general-header mb-3\">Summary:</h4>\r\n        <p class=\"general-content mb-3\">I\'m an enthusiastic software engineer with ");
#nullable restore
#line 19 "C:\Users\borga\Desktop\C#\Resume Templater\Resume Templater\Resume Templater\Pages\Index.cshtml"
                                                                              Write(Model.YearsOfExperience);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"+ years of experience participating in the complete lifecyclye of successfully launched applications. I am skilled in developing business plans, requirements specifications, user documentation, and architectural systems research. Strong written and verbal communications.</p>
    </div>

    <div class=""resume-content"">
        <h4 class=""general-header mb-3"">Languages:</h4>
        <ul class=""list-group general-content"">
");
#nullable restore
#line 25 "C:\Users\borga\Desktop\C#\Resume Templater\Resume Templater\Resume Templater\Pages\Index.cshtml"
             foreach (string language in Model.Languages)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-item\" style=\"width: 18rem;\">\r\n                    ");
#nullable restore
#line 28 "C:\Users\borga\Desktop\C#\Resume Templater\Resume Templater\Resume Templater\Pages\Index.cshtml"
               Write(language);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 30 "C:\Users\borga\Desktop\C#\Resume Templater\Resume Templater\Resume Templater\Pages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n\r\n    <div class=\"resume-content\">\r\n        <h4 class=\"general-header mb-3\">Contact</h4>\r\n        <p class=\"general-content\">For more informatoin regardin my experience please refer to my ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "27ec9c52e26d60e5f2c123be147808fb6c49504d6503", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 36 "C:\Users\borga\Desktop\C#\Resume Templater\Resume Templater\Resume Templater\Pages\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.LinkedInUsername);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
