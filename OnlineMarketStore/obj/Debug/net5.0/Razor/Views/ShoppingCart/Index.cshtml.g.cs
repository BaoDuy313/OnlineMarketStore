#pragma checksum "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1ec16fb551e19b666813b60038880f499735da7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
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
#line 1 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Views\_ViewImports.cshtml"
using OnlineMarketStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Views\_ViewImports.cshtml"
using OnlineMarketStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1ec16fb551e19b666813b60038880f499735da7", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b9bfa5795c05cd3e47c90b4b7e2a1ad4f7317f1", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OnlineMarketStore.ModelViews.CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("javascript:void(0)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Views\ShoppingCart\Index.cshtml"
  
    ViewData["Title"] = "Cart";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var returnUrl = Context.Request.Query["ReturnUrl"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""/assets/images/banner/2-1-1920x523.jpg"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h2 class=""breadcrumb-heading"">Cart</h2>
                        <ul>
                            <li>
                                <a href=""/"">Home<i class=""pe-7s-angle-right""></i></a>
                            </li>
                            <li>Cart</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""cart-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
");
#nullable restore
#line 30 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Views\ShoppingCart\Index.cshtml"
                     if (Model != null && Model.Count() > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1ec16fb551e19b666813b60038880f499735da75501", async() => {
                WriteLiteral(@"
                            <div class=""table-content table-responsive"">
                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th class=""product_remove"">Remove</th>
                                            <th class=""product-thumbnail"">Image</th>
                                            <th class=""cart-product-name"">Product</th>
                                            <th class=""product-price"">Price</th>
                                            <th class=""product-quantity"">Amount</th>
                                            <th class=""product-subtotal"">Total</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 46 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Views\ShoppingCart\Index.cshtml"
                                         if (Model != null && Model.Count() > 0)
                                        {
                                            foreach (var item in Model)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                <tr>
                                                    <td class=""product_remove"">
                                                        <input type=""button"" value=""X"" class=""removecart btn btn-primary"" data-mahh=""");
#nullable restore
#line 52 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Views\ShoppingCart\Index.cshtml"
                                                                                                                                Write(item.product.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" />
                                                    </td>
                                                    <td class=""product-thumbnail"">
                                                        <a href=""javascript:void(0)"">
                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1ec16fb551e19b666813b60038880f499735da78094", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2941, "~/images/products/", 2941, 18, true);
#nullable restore
#line 56 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Views\ShoppingCart\Index.cshtml"
AddHtmlAttributeValue("", 2959, item.product.Thumb, 2959, 19, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 56 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Views\ShoppingCart\Index.cshtml"
AddHtmlAttributeValue("", 2985, item.product.Title, 2985, 19, false);

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
                WriteLiteral("\r\n                                                        </a>\r\n                                                    </td>\r\n                                                    <td class=\"product-name\"><a href=\"javascript:void(0)\">");
#nullable restore
#line 59 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Views\ShoppingCart\Index.cshtml"
                                                                                                     Write(item.product.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                                    <td class=\"product-price\"><span class=\"amount\">$");
#nullable restore
#line 60 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Views\ShoppingCart\Index.cshtml"
                                                                                               Write(item.product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></td>\r\n                                                    <td class=\"quantity\">\r\n                                                        <div");
                BeginWriteAttribute("class", " class=\"", 3539, "\"", 3547, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                            <input style=\"width:50px\" data-mahh=\"");
#nullable restore
#line 63 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Views\ShoppingCart\Index.cshtml"
                                                                                            Write(item.product.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-dongia=\"");
#nullable restore
#line 63 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Views\ShoppingCart\Index.cshtml"
                                                                                                                                  Write(item.product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" class=\"cartItem cart-plus-minus-box\"");
                BeginWriteAttribute("value", " value=\"", 3743, "\"", 3763, 1);
#nullable restore
#line 63 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 3751, item.amount, 3751, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"1\" type=\"number\">\r\n                                                        </div>\r\n                                                    </td>\r\n                                                    <td class=\"product-subtotal\"><span class=\"amount\">$");
#nullable restore
#line 66 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Views\ShoppingCart\Index.cshtml"
                                                                                                  Write(item.TotalMoney);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></td>\r\n                                                </tr>\r\n");
#nullable restore
#line 68 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Views\ShoppingCart\Index.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-5 ml-auto"">
                                    <div class=""cart-page-total"">
                                        <h2>Order</h2>
                                        <ul>
                                            <li>Total <span>$ ");
#nullable restore
#line 78 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Views\ShoppingCart\Index.cshtml"
                                                         Write(Model.Sum(x => x.TotalMoney));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></li>\r\n                                        </ul>\r\n");
#nullable restore
#line 80 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Views\ShoppingCart\Index.cshtml"
                                         if(User.Identity.IsAuthenticated)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <a href=\"/checkout.html\" class=\"btn btn-secondary btn-primary-hover\">Payment</a>\r\n");
#nullable restore
#line 83 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Views\ShoppingCart\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <a href=\"/login.html?returnUrl=/checkout.html\" class=\"btn btn-secondary btn-primary-hover\">Payment</a>\r\n");
#nullable restore
#line 87 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Views\ShoppingCart\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 92 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Views\ShoppingCart\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>There are no items in the cart</p>\r\n");
#nullable restore
#line 96 "C:\Users\duyru\Desktop\Hoc tap\.NETCORE\Tutorial\OnlineMarketStore\OnlineMarketStore\Views\ShoppingCart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            function loadHeaderCart() {
                $('#miniCart').load(""/AjaxContent/HeaderCart"");
                $('#numberCart').load(""/AjaxContent/NumberCart"");
            }
            $("".removecart"").click(function () {
                var productid = $(this).attr(""data-mahh"");
                $.ajax({
                    url: ""api/cart/remove"",
                    type: ""POST"",
                    dataType: ""JSON"",
                    data: { productID: productid },
                    success: function (result) {
                        if (result.success) {
                            loadHeaderCart();//Reload lai gio hang
                            location.reload();
                        }
                    },
                    error: function (rs) {
                        alert(""Remove Cart Error !"")
                    }
                });
            });
            $("".cartItem"").click(function () {
                ");
                WriteLiteral(@"var productid = $(this).attr(""data-mahh"");
                var amount = parseInt($(this).val());
                $.ajax({
                    url: ""api/cart/update"",
                    type: ""POST"",
                    dataType: ""JSON"",
                    data: {
                        productID: productid,
                        amount: amount
                    },
                    success: function (result) {
                        if (result.success) {
                            loadHeaderCart();//Reload lai gio hang
                            window.location = 'cart.html';
                        }
                    },
                    error: function (rs) {
                        alert(""Update Cart Error !"")
                    }
                });
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OnlineMarketStore.ModelViews.CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
