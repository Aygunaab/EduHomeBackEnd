#pragma checksum "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Teacher\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbdc5a902d873432fc87f80cea6be7639752c7e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Detail), @"mvc.1.0.view", @"/Views/Teacher/Detail.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbdc5a902d873432fc87f80cea6be7639752c7e2", @"/Views/Teacher/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ae20ccc31c3d500249ef95605d3909b27711f99", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Teacher\Detail.cshtml"
  
    ViewData["Title"] = "TEACHERS / DETAILS";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Teacher Start -->\r\n<div class=\"teacher-details-area pt-150 pb-60\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-5\">\r\n                <div class=\"teacher-details-img\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cbdc5a902d873432fc87f80cea6be7639752c7e24355", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 318, "~/img/slider/", 318, 13, true);
#nullable restore
#line 12 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Teacher\Detail.cshtml"
AddHtmlAttributeValue("", 331, Model.Image, 331, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-7\">\r\n                <div class=\"teacher-details-content ml-50\">\r\n                    <h2>");
#nullable restore
#line 17 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h5>");
#nullable restore
#line 18 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                   Write(Model.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h4>About Me</h4>\r\n                    <p>");
#nullable restore
#line 20 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                  Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <ul>\r\n                        <li><span>degree: </span>");
#nullable restore
#line 22 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                            Write(Model.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>experience: </span>");
#nullable restore
#line 23 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                                Write(Model.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>hobbies: </span>");
#nullable restore
#line 24 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                             Write(Model.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>faculty: </span>");
#nullable restore
#line 25 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                             Write(Model.Faculty);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-3 col-md-4"">
                <div class=""teacher-contact"">
                    <h4>contact information</h4>
                    <p><span>mail me : </span>");
#nullable restore
#line 34 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                         Write(Model.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><span>make a call : </span>");
#nullable restore
#line 35 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                             Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><span>skype : </span> ");
#nullable restore
#line 36 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                        Write(Model.Skype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <ul>\r\n");
#nullable restore
#line 38 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                         foreach (var social in Model.SocialToTeachers)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1615, "\"", 1634, 1);
#nullable restore
#line 40 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 1622, social.Link, 1622, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                                  Write(Html.Raw(social.Social.Icon));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 41 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                            
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                </div>
            </div>
            <div class=""col-lg-9 col-md-8"">
                <div class=""skill-area"">
                    <h4>skills</h4>
                </div>
                <div class=""skill-wrapper"">
                    <div class=""row"">
");
#nullable restore
#line 52 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                         foreach (var skills in Model.SkillsToTeachers)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-4\">\r\n                                <div class=\"skill-bar-item\">\r\n                                    <span>");
#nullable restore
#line 56 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                     Write(skills.Skills.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    <div class=""progress"">
                                        <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 85%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                            <span class=""text-top"">");
#nullable restore
#line 59 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                                                              Write(skills.Progress);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</span>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 64 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Teacher\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Teacher End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
