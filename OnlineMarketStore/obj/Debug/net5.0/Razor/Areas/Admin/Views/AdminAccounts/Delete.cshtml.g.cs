#pragma checksum "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\project\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminAccounts\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04337f679fcb29b77c5ad0e7e668490476ab4b66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminAccounts_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminAccounts/Delete.cshtml")]
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
#line 1 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\project\OnlineMarketStore\OnlineMarketStore\Areas\Admin\_ViewImports.cshtml"
using OnlineMarketStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\project\OnlineMarketStore\OnlineMarketStore\Areas\Admin\_ViewImports.cshtml"
using OnlineMarketStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04337f679fcb29b77c5ad0e7e668490476ab4b66", @"/Areas/Admin/Views/AdminAccounts/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b9bfa5795c05cd3e47c90b4b7e2a1ad4f7317f1", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminAccounts_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineMarketStore.Models.Account>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminAccounts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\project\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminAccounts\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04337f679fcb29b77c5ad0e7e668490476ab4b666598", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "04337f679fcb29b77c5ad0e7e668490476ab4b666860", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 8 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\project\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminAccounts\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AccountId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <div class=\"page-header\">\r\n        <div class=\"header-sub-title\">\r\n            <nav class=\"breadcrumb breadcrumb-dash\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04337f679fcb29b77c5ad0e7e668490476ab4b668775", async() => {
                    WriteLiteral("<i class=\"anticon anticon-home m-r-5\"></i>Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04337f679fcb29b77c5ad0e7e668490476ab4b6610561", async() => {
                    WriteLiteral("Account List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <span class=""breadcrumb-item active"">Delete Account </span>
            </nav>
        </div>
    </div>

    <div class=""page-header no-gutters has-tab"">
        <div class=""d-md-flex m-b-15 align-items-center justify-content-between"">
            <div class=""media align-items-center m-b-15"">
                <div class=""avatar avatar-image rounded"" style=""height:70px; width:70px"">
");
                WriteLiteral("                </div>\r\n                <div class=\"m-l-15\">\r\n                    <h4 class=\"m-b-0\">");
#nullable restore
#line 26 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\project\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminAccounts\Delete.cshtml"
                                 Write(Model.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                    <p class=\"text-muted m-b-0\">ID: #");
#nullable restore
#line 27 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\project\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminAccounts\Delete.cshtml"
                                                Write(Model.AccountId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                </div>
            </div>
            <div class=""m-b-15"">
                <input type=""submit"" value=""Delete Confirm"" class=""btn btn-danger"" />
            </div>
        </div>
        <ul class=""nav nav-tabs"">
            <li class=""nav-item"">
                <a class=""nav-link active"" data-toggle=""tab"" href=""#product-overview"">Overview</a>
            </li>
");
                WriteLiteral(@"        </ul>
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
                                        <td>Account Name:</td>
                                        <td class=""text-dark font-weight-semibold"">");
#nullable restore
#line 54 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\project\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminAccounts\Delete.cshtml"
                                                                              Write(Model.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td>Phone:</td>\r\n                                        <td>");
#nullable restore
#line 58 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\project\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminAccounts\Delete.cshtml"
                                       Write(Model.Phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td>Email:</td>\r\n                                        <td>");
#nullable restore
#line 62 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\project\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminAccounts\Delete.cshtml"
                                       Write(Model.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td>Created Date:</td>\r\n                                        <td>");
#nullable restore
#line 66 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\project\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminAccounts\Delete.cshtml"
                                       Write(Model.CreateDate.Value.ToString("HH:mm dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td>Last Login:</td>\r\n                                        <td>");
#nullable restore
#line 70 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\project\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminAccounts\Delete.cshtml"
                                       Write(Model.LastLogin.Value.ToString("HH:mm dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td>Salt:</td>\r\n                                        <td>");
#nullable restore
#line 74 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\project\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminAccounts\Delete.cshtml"
                                       Write(Model.Salt);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td>Password:</td>\r\n                                        <td>");
#nullable restore
#line 78 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\project\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminAccounts\Delete.cshtml"
                                       Write(Model.Password);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td>Role:</td>\r\n                                        <td>");
#nullable restore
#line 82 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\project\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminAccounts\Delete.cshtml"
                                       Write(Model.Role.RoleName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td>Status:</td>\r\n");
#nullable restore
#line 86 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\project\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminAccounts\Delete.cshtml"
                                         if (Model.Active)
                                        {



#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <td>\r\n                                                <span class=\"badge badge-pill badge-cyan\">Public</span>\r\n                                            </td>\r\n");
#nullable restore
#line 93 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\project\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminAccounts\Delete.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <td>\r\n                                                <span class=\"badge badge-pill badge-red\">Block</span>\r\n                                            </td>\r\n");
#nullable restore
#line 99 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\project\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminAccounts\Delete.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </tr>\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
                WriteLiteral("            </div>\r\n");
                WriteLiteral("        </div>\r\n    </div>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04337f679fcb29b77c5ad0e7e668490476ab4b6620769", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 7 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\project\OnlineMarketStore\OnlineMarketStore\Areas\Admin\Views\AdminAccounts\Delete.cshtml"
                            WriteLiteral(Model.AccountId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineMarketStore.Models.Account> Html { get; private set; }
    }
}
#pragma warning restore 1591
