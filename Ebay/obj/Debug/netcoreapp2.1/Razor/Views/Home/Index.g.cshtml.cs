#pragma checksum "C:\bootcamp2019\Ebay\Ebay\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36fa3b8cafe568398cb87e137bfcf9d6ff016391"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\bootcamp2019\Ebay\Ebay\Views\_ViewImports.cshtml"
using Ebay;

#line default
#line hidden
#line 2 "C:\bootcamp2019\Ebay\Ebay\Views\_ViewImports.cshtml"
using Ebay.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36fa3b8cafe568398cb87e137bfcf9d6ff016391", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d45acddf5f0c727242cf0cff7efb043df42d4787", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ebay.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/banner1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("First slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/banner2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Second slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/banner3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Third slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\bootcamp2019\Ebay\Ebay\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(88, 697, true);
            WriteLiteral(@"<div class=""container-fluid"" style=""margin-top: 20px;"">

    <div class=""row"">

        <div class=""col-md-12"">

            <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                <ol class=""carousel-indicators"">
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
                </ol>
                <div class=""carousel-inner"">
                    <div class=""carousel-item active"">
                        ");
            EndContext();
            BeginContext(785, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "43809682580f4c26b49d32fc431d6dc5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(857, 103, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"carousel-item\">\r\n                        ");
            EndContext();
            BeginContext(960, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "882c616476c44f82b4211782cdf2c3c3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1033, 103, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"carousel-item\">\r\n                        ");
            EndContext();
            BeginContext(1136, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c1080526405c4fe0aafba51279fc2acb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1208, 678, true);
            WriteLiteral(@"
                    </div>
                </div>
                <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>

        </div>
        <hr />
");
            EndContext();
#line 41 "C:\bootcamp2019\Ebay\Ebay\Views\Home\Index.cshtml"
         foreach (var product in Model)
        {

#line default
#line hidden
            BeginContext(1938, 143, true);
            WriteLiteral("            <div class=\"col-md-4 text-center\">\r\n\r\n                <div class=\"card mb-3\">\r\n                    <h3 class=\"card-header bg-info\">");
            EndContext();
            BeginContext(2082, 19, false);
#line 46 "C:\bootcamp2019\Ebay\Ebay\Views\Home\Index.cshtml"
                                               Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2101, 153, true);
            WriteLiteral("</h3>\r\n                    <div class=\"card-body bg-transparent text-center\" style=\" max-height:200px;\">\r\n                        <h5 class=\"card-title\">");
            EndContext();
            BeginContext(2255, 25, false);
#line 48 "C:\bootcamp2019\Ebay\Ebay\Views\Home\Index.cshtml"
                                          Write(product.ProductDscription);

#line default
#line hidden
            EndContext();
            BeginContext(2280, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 49 "C:\bootcamp2019\Ebay\Ebay\Views\Home\Index.cshtml"
                         if (product.Image != null)
                        {

#line default
#line hidden
            BeginContext(2367, 116, true);
            WriteLiteral("                            <img class=\"img img-thumbnail\" style=\"max-height:150px; max-width:300px; display: block\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2483, "\"", 2545, 2);
            WriteAttributeValue("", 2489, "data:image;base64,", 2489, 18, true);
#line 51 "C:\bootcamp2019\Ebay\Ebay\Views\Home\Index.cshtml"
WriteAttributeValue("", 2507, Convert.ToBase64String(product.Image), 2507, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2546, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 52 "C:\bootcamp2019\Ebay\Ebay\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2635, 65, true);
            WriteLiteral("                            <p class=\"text-danger\">No Image</p>\r\n");
            EndContext();
#line 56 "C:\bootcamp2019\Ebay\Ebay\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2727, 169, true);
            WriteLiteral("                    </div>\r\n                    \r\n                    <ul class=\"list-group list-group-flush\">\r\n                        <li class=\"list-group-item\">Qty: ");
            EndContext();
            BeginContext(2897, 11, false);
#line 60 "C:\bootcamp2019\Ebay\Ebay\Views\Home\Index.cshtml"
                                                    Write(product.Qty);

#line default
#line hidden
            EndContext();
            BeginContext(2908, 14, true);
            WriteLiteral(" | Discount: $");
            EndContext();
            BeginContext(2923, 16, false);
#line 60 "C:\bootcamp2019\Ebay\Ebay\Views\Home\Index.cshtml"
                                                                              Write(product.Discount);

#line default
#line hidden
            EndContext();
            BeginContext(2939, 79, true);
            WriteLiteral(" | Price:  <text class=\"bg-primary\" style=\" font-weight: bold; color: white;\">$");
            EndContext();
            BeginContext(3019, 13, false);
#line 60 "C:\bootcamp2019\Ebay\Ebay\Views\Home\Index.cshtml"
                                                                                                                                                                              Write(product.price);

#line default
#line hidden
            EndContext();
            BeginContext(3032, 82, true);
            WriteLiteral("</text></li>\r\n                        <li class=\"list-group-item text-center\">\r\n\r\n");
            EndContext();
#line 63 "C:\bootcamp2019\Ebay\Ebay\Views\Home\Index.cshtml"
                             if (product.Qty > 0)
                            {

#line default
#line hidden
            BeginContext(3196, 34, true);
            WriteLiteral("                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3230, "\"", 3263, 2);
            WriteAttributeValue("", 3237, "/Orders/Create/", 3237, 15, true);
#line 65 "C:\bootcamp2019\Ebay\Ebay\Views\Home\Index.cshtml"
WriteAttributeValue("", 3252, product.Id, 3252, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3264, 47, true);
            WriteLiteral(" class=\"btn btn-sm btn-success\">Order Now</a>\r\n");
            EndContext();
#line 66 "C:\bootcamp2019\Ebay\Ebay\Views\Home\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3407, 34, true);
            WriteLiteral("                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3441, "\"", 3474, 2);
            WriteAttributeValue("", 3448, "/Orders/Create/", 3448, 15, true);
#line 69 "C:\bootcamp2019\Ebay\Ebay\Views\Home\Index.cshtml"
WriteAttributeValue("", 3463, product.Id, 3463, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3475, 74, true);
            WriteLiteral(" class=\"btn btn-sm btn-danger disabled\"> <text> Out of order </text></a>\r\n");
            EndContext();
#line 70 "C:\bootcamp2019\Ebay\Ebay\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(3580, 106, true);
            WriteLiteral("\r\n                        </li>\r\n                    </ul>\r\n\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 77 "C:\bootcamp2019\Ebay\Ebay\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3697, 28, true);
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ebay.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
