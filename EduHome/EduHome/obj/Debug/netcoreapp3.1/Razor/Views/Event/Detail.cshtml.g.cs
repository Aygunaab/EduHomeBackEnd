#pragma checksum "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Event\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8b35545e9a92ac1b3eaa3160fe52e3effad5039"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Detail), @"mvc.1.0.view", @"/Views/Event/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8b35545e9a92ac1b3eaa3160fe52e3effad5039", @"/Views/Event/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ae20ccc31c3d500249ef95605d3909b27711f99", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventDetailVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:770px;height:358px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("event-details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("speaker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Event\Detail.cshtml"
  
    ViewData["Title"] = "event / details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"   

   
    <!-- Event Details Start -->
    <div class=""event-details-area blog-area pt-150 pb-140"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-8"">
                    <div class=""event-details"">
                        <div class=""event-details-img"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8b35545e9a92ac1b3eaa3160fe52e3effad50395159", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 463, "~/img/slider/", 463, 13, true);
#nullable restore
#line 15 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Event\Detail.cshtml"
AddHtmlAttributeValue("", 476, Model.Event.Image, 476, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"event-date\">\r\n                                <h3>");
#nullable restore
#line 17 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Event\Detail.cshtml"
                               Write(Model.Event.StartTime.ToString("dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>");
#nullable restore
#line 17 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Event\Detail.cshtml"
                                                                           Write(Model.Event.StartTime.ToString("MMMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"event-details-content\">\r\n                            <h2>");
#nullable restore
#line 21 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Event\Detail.cshtml"
                           Write(Model.Event.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <ul>\r\n                                <li><span>time : </span>");
#nullable restore
#line 23 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Event\Detail.cshtml"
                                                   Write(Model.Event.StartTime.ToString("t"));

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 23 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Event\Detail.cshtml"
                                                                                        Write(Model.Event.EndTime.ToString("t"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                                <li><span>venue : </span>");
#nullable restore
#line 24 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Event\Detail.cshtml"
                                                    Write(Model.Event.Venue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            </ul>\r\n                            <p>");
#nullable restore
#line 26 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Event\Detail.cshtml"
                          Write(Html.Raw(Model.Event.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <div class=\"speakers-area fix\">\r\n                                <h4>speakers</h4>\r\n");
#nullable restore
#line 29 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Event\Detail.cshtml"
                                 foreach (EventSpeakers evspeak in Model.Event.EventSpeakers)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"single-speaker\">\r\n                                        <div class=\"speaker-img\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8b35545e9a92ac1b3eaa3160fe52e3effad503910032", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1677, "~/img/event/", 1677, 12, true);
#nullable restore
#line 33 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Event\Detail.cshtml"
AddHtmlAttributeValue("", 1689, evspeak.Speaker.ProfileImage, 1689, 29, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"speaker-name\">\r\n                                            <h5>");
#nullable restore
#line 36 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Event\Detail.cshtml"
                                           Write(evspeak.Speaker.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <p>");
#nullable restore
#line 37 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Event\Detail.cshtml"
                                          Write(evspeak.Speaker.Position.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 40 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Event\Detail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                     \r\n\r\n\r\n");
            WriteLiteral("                    </div>\r\n                </div>\r\n               ");
#nullable restore
#line 73 "C:\Users\Admin\OneDrive\Desktop\EduHomeBackEnd\EduHome\EduHome\Views\Event\Detail.cshtml"
          Write(await Component.InvokeAsync("SidebarDetailRight"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </div>\r\n        </div>\r\n    </div>\r\n  \r\n  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventDetailVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
