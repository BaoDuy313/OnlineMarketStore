#pragma checksum "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d081bafdf9fa39c5c6c63f4efcc80fb320eea19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminNews_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminNews/Details.cshtml")]
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
#line 1 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\_ViewImports.cshtml"
using OnlineMarketStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\_ViewImports.cshtml"
using OnlineMarketStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d081bafdf9fa39c5c6c63f4efcc80fb320eea19", @"/Areas/Admin/Views/AdminNews/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b9bfa5795c05cd3e47c90b4b7e2a1ad4f7317f1", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminNews_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineMarketStore.Models.News>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminNews", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
  
    ViewData["Title"] = "Details New";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"new-header\">\r\n    <div class=\"header-sub-title\">\r\n        <nav class=\"breadcrumb breadcrumb-dash\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d081bafdf9fa39c5c6c63f4efcc80fb320eea196849", async() => {
                WriteLiteral("<i class=\"anticon anticon-home m-r-5\"></i>Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d081bafdf9fa39c5c6c63f4efcc80fb320eea198547", async() => {
                WriteLiteral("News List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <span class=""breadcrumb-item active"">Details News </span>
        </nav>
    </div>
</div>

<div class=""new-header no-gutters has-tab"">
    <div class=""d-md-flex m-b-15 align-items-center justify-content-between"">
        <div class=""media align-items-center m-b-15"">
            <div class=""avatar avatar-image rounded"" style=""height:70px; width:70px"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3d081bafdf9fa39c5c6c63f4efcc80fb320eea1910596", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 930, "~/images/news/", 930, 14, true);
#nullable restore
#line 21 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
AddHtmlAttributeValue("", 944, Model.Thumb, 944, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 21 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
AddHtmlAttributeValue("", 963, Model.Title, 963, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"m-l-15\">\r\n                <h4 class=\"m-b-0\">");
#nullable restore
#line 24 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
                             Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p class=\"text-muted m-b-0\">ID: #");
#nullable restore
#line 25 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
                                            Write(Model.PostId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"m-b-15\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d081bafdf9fa39c5c6c63f4efcc80fb320eea1913478", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
                                                                                                       WriteLiteral(Model.PostId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
    <ul class=""nav nav-tabs"">
        <li class=""nav-item"">
            <a class=""nav-link active"" data-toggle=""tab"" href=""#product-overview"">Overview</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""tab"" href=""#product-images"">News Images</a>
        </li>
    </ul>
</div>
<div class=""container-fluid"">
    <div class=""tab-content m-t-15"">
        <div class=""tab-pane fade show active"" id=""product-overview"">
            <div class=""card"">
                <div class=""card-body"">
                    <h4 class=""card-title"">Basic Info</h4>
                    <div class=""table-responsive"">
                        <table class=""product-info-table m-t-20"">
                            <tbody>
                                <tr>
                                    <td>Title:</td>
                                    <td>");
#nullable restore
#line 52 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
                                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Create Date:</td>\r\n                                    <td>");
#nullable restore
#line 56 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
                                   Write(Model.CreateDate.Value.ToString("HH:mm dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Alias:</td>\r\n                                    <td>");
#nullable restore
#line 60 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
                                   Write(Model.Alias);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Author:</td>\r\n                                    <td>");
#nullable restore
#line 64 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
                                   Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Account:</td>\r\n                                    <td>");
#nullable restore
#line 68 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
                                   Write(Model.Account.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>IsHot:</td>\r\n");
#nullable restore
#line 72 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
                                     if (Model.IsHot)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            <span class=\"badge badge-pill badge-cyan\">Public</span>\r\n                                        </td>\r\n");
#nullable restore
#line 77 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            <span class=\"badge badge-pill badge-red\">Block</span>\r\n                                        </td>\r\n");
#nullable restore
#line 83 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tr>\r\n                                <tr>\r\n                                    <td>IsNewfeed:</td>\r\n");
#nullable restore
#line 87 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
                                     if (Model.IsNewfeed)
                                    {



#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            <span class=\"badge badge-pill badge-cyan\">Public</span>\r\n                                        </td>\r\n");
#nullable restore
#line 94 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            <span class=\"badge badge-pill badge-red\">Block</span>\r\n                                        </td>\r\n");
#nullable restore
#line 100 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tr>\r\n                                <tr>\r\n                                    <td>Status:</td>\r\n");
#nullable restore
#line 104 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
                                     if (Model.Published)
                                    {



#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            <span class=\"badge badge-pill badge-cyan\">Public</span>\r\n                                        </td>\r\n");
#nullable restore
#line 111 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            <span class=\"badge badge-pill badge-red\">Block</span>\r\n                                        </td>\r\n");
#nullable restore
#line 117 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-header"">
                    <h4 class=""card-title"">SContents</h4>
                </div>
                <div class=""card-body"">
                    <p>");
#nullable restore
#line 129 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
                  Write(Html.Raw(Model.Scontents));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-header"">
                    <h4 class=""card-title"">Contents</h4>
                </div>
                <div class=""card-body"">
                    <p>");
#nullable restore
#line 137 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
                  Write(Html.Raw(Model.Contents));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>
        </div>
        <div class=""tab-pane fade"" id=""product-images"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-3"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3d081bafdf9fa39c5c6c63f4efcc80fb320eea1925636", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6508, "~/images/news/", 6508, 14, true);
#nullable restore
#line 146 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
AddHtmlAttributeValue("", 6522, Model.Thumb, 6522, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3d081bafdf9fa39c5c6c63f4efcc80fb320eea1927453", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6681, "~/images/news/", 6681, 14, true);
#nullable restore
#line 149 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
AddHtmlAttributeValue("", 6695, Model.Thumb, 6695, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3d081bafdf9fa39c5c6c63f4efcc80fb320eea1929270", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6854, "~/images/news/", 6854, 14, true);
#nullable restore
#line 152 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminNews\Details.cshtml"
AddHtmlAttributeValue("", 6868, Model.Thumb, 6868, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d081bafdf9fa39c5c6c63f4efcc80fb320eea1931131", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineMarketStore.Models.News> Html { get; private set; }
    }
}
#pragma warning restore 1591
