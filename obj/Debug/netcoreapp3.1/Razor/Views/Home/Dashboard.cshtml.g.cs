#pragma checksum "/Users/josephgarrett/Desktop/coding_dojo/C#/BeltPrep/WeddingPlanner/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d80bb5f2c670b72f4765233cf940d767547935f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "/Users/josephgarrett/Desktop/coding_dojo/C#/BeltPrep/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d80bb5f2c670b72f4765233cf940d767547935f7", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b943d62a6e7910a24eb93adbadedbd9e52657c1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wrapper>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RSVP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UNRSVP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d80bb5f2c670b72f4765233cf940d767547935f74838", async() => {
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <title>Wedding Planner Dashboard</title>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d80bb5f2c670b72f4765233cf940d767547935f75942", async() => {
                WriteLiteral(@"
    <header>
        <h1>Welcome to the Wedding Planner!</h1>
        <a href=""/logout"">Log Out</a>
    </header>
    <main>
        <table>
            <thead>
                <tr>
                    <th>Wedding</th>
                    <th>Date</th>
                    <th>Guests</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 25 "/Users/josephgarrett/Desktop/coding_dojo/C#/BeltPrep/WeddingPlanner/Views/Home/Dashboard.cshtml"
                 foreach (Wedding wedding in Model.AllWeddings)
                {
                    Boolean IsGoing = false;
                    foreach (GuestList guest in wedding.Guests)
                    {
                        if (guest.UserId == Model.CurrentUser)
                        {
                            IsGoing = true;
                        }
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\n                        <td><a");
                BeginWriteAttribute("href", " href=\"", 1054, "\"", 1088, 2);
                WriteAttributeValue("", 1061, "/wedding/", 1061, 9, true);
#nullable restore
#line 36 "/Users/josephgarrett/Desktop/coding_dojo/C#/BeltPrep/WeddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1070, wedding.WeddingId, 1070, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 36 "/Users/josephgarrett/Desktop/coding_dojo/C#/BeltPrep/WeddingPlanner/Views/Home/Dashboard.cshtml"
                                                             Write(wedding.WedderOne);

#line default
#line hidden
#nullable disable
                WriteLiteral(" & ");
#nullable restore
#line 36 "/Users/josephgarrett/Desktop/coding_dojo/C#/BeltPrep/WeddingPlanner/Views/Home/Dashboard.cshtml"
                                                                                  Write(wedding.WedderTwo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\n                        <td>");
#nullable restore
#line 37 "/Users/josephgarrett/Desktop/coding_dojo/C#/BeltPrep/WeddingPlanner/Views/Home/Dashboard.cshtml"
                       Write(wedding.Date.ToString("MMM d, yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 38 "/Users/josephgarrett/Desktop/coding_dojo/C#/BeltPrep/WeddingPlanner/Views/Home/Dashboard.cshtml"
                       Write(wedding.Guests.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        <td>\n");
#nullable restore
#line 40 "/Users/josephgarrett/Desktop/coding_dojo/C#/BeltPrep/WeddingPlanner/Views/Home/Dashboard.cshtml"
                             if (wedding.UserId == Model.CurrentUser)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d80bb5f2c670b72f4765233cf940d767547935f79290", async() => {
                    WriteLiteral("\n                                    <input type=\"hidden\" name=\"id\"");
                    BeginWriteAttribute("value", " value=\"", 1555, "\"", 1581, 1);
#nullable restore
#line 43 "/Users/josephgarrett/Desktop/coding_dojo/C#/BeltPrep/WeddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1563, wedding.WeddingId, 1563, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\n                                    <button>Delete</button>\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 46 "/Users/josephgarrett/Desktop/coding_dojo/C#/BeltPrep/WeddingPlanner/Views/Home/Dashboard.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
#nullable restore
#line 48 "/Users/josephgarrett/Desktop/coding_dojo/C#/BeltPrep/WeddingPlanner/Views/Home/Dashboard.cshtml"
                             if (!IsGoing && wedding.UserId != Model.CurrentUser)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d80bb5f2c670b72f4765233cf940d767547935f712340", async() => {
                    WriteLiteral("\n                                    <input type=\"hidden\" name=\"weddingID\"");
                    BeginWriteAttribute("value", " value=\"", 1993, "\"", 2019, 1);
#nullable restore
#line 51 "/Users/josephgarrett/Desktop/coding_dojo/C#/BeltPrep/WeddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2001, wedding.WeddingId, 2001, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\n                                    <input type=\"hidden\" name=\"userID\"");
                    BeginWriteAttribute("value", " value=\"", 2092, "\"", 2118, 1);
#nullable restore
#line 52 "/Users/josephgarrett/Desktop/coding_dojo/C#/BeltPrep/WeddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2100, Model.CurrentUser, 2100, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\n                                    <button>RSVP</button>\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 55 "/Users/josephgarrett/Desktop/coding_dojo/C#/BeltPrep/WeddingPlanner/Views/Home/Dashboard.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
#nullable restore
#line 57 "/Users/josephgarrett/Desktop/coding_dojo/C#/BeltPrep/WeddingPlanner/Views/Home/Dashboard.cshtml"
                             if (IsGoing && wedding.UserId != Model.CurrentUser)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d80bb5f2c670b72f4765233cf940d767547935f715873", async() => {
                    WriteLiteral("\n                                    <input type=\"hidden\" name=\"weddingID\"");
                    BeginWriteAttribute("value", " value=\"", 2529, "\"", 2555, 1);
#nullable restore
#line 60 "/Users/josephgarrett/Desktop/coding_dojo/C#/BeltPrep/WeddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2537, wedding.WeddingId, 2537, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\n                                    <input type=\"hidden\" name=\"userID\"");
                    BeginWriteAttribute("value", " value=\"", 2628, "\"", 2654, 1);
#nullable restore
#line 61 "/Users/josephgarrett/Desktop/coding_dojo/C#/BeltPrep/WeddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2636, Model.CurrentUser, 2636, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\n                                    <button>Un-RSVP</button>\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 64 "/Users/josephgarrett/Desktop/coding_dojo/C#/BeltPrep/WeddingPlanner/Views/Home/Dashboard.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </td>\n                    </tr>\n");
#nullable restore
#line 67 "/Users/josephgarrett/Desktop/coding_dojo/C#/BeltPrep/WeddingPlanner/Views/Home/Dashboard.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\n        </table>\n        <a href=\"/wedding/new\">New Wedding</a>\n    </main>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wrapper> Html { get; private set; }
    }
}
#pragma warning restore 1591
