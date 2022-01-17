#pragma checksum "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\63. 17-01-2022\PustokP201\PustokP201\Views\Book\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "505fce842bd242f5a618c3c4aca648820ebcb531"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Checkout), @"mvc.1.0.view", @"/Views/Book/Checkout.cshtml")]
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
#line 1 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\63. 17-01-2022\PustokP201\PustokP201\Views\_ViewImports.cshtml"
using PustokP201;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\63. 17-01-2022\PustokP201\PustokP201\Views\_ViewImports.cshtml"
using PustokP201.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\63. 17-01-2022\PustokP201\PustokP201\Views\_ViewImports.cshtml"
using PustokP201.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"505fce842bd242f5a618c3c4aca648820ebcb531", @"/Views/Book/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5884438bbf247ea6d9f39676e18e38800fdc98e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckoutViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\63. 17-01-2022\PustokP201\PustokP201\Views\Book\Checkout.cshtml"
   
    decimal total = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"      
        <section class=""breadcrumb-section"">
            <h2 class=""sr-only"">Site Breadcrumb</h2>
            <div class=""container"">
                <div class=""breadcrumb-contents"">
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb"">
                            <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                            <li class=""breadcrumb-item active"">Checkout</li>
                        </ol>
                    </nav>
                </div>
            </div>
        </section>
        <main id=""content"" class=""page-section inner-page-sec-padding-bottom space-db--20"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-12"">
                        <!-- Checkout Form s-->
                        <div class=""checkout-form"">
                            <div class=""row row-40"">
                                <div class=""col-lg-7 mb--20"">
         ");
            WriteLiteral("                          ");
#nullable restore
#line 27 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\63. 17-01-2022\PustokP201\PustokP201\Views\Book\Checkout.cshtml"
                              Write(Html.Partial("_CheckoutFormPartial", Model.Order));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
                                </div>
                                <div class=""col-lg-5"">
                                    <div class=""row"">
                                        <!-- Cart Total -->
                                        <div class=""col-12"">
                                            <div class=""checkout-cart-total"">
                                                <h2 class=""checkout-title"">YOUR ORDER</h2>
                                                <h4>Product <span>Total</span></h4>
                                                <ul>
");
#nullable restore
#line 37 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\63. 17-01-2022\PustokP201\PustokP201\Views\Book\Checkout.cshtml"
                                                     foreach (var item in Model.CheckoutItems)
                                                    {
                                                        decimal salePrice = item.Book.DiscountPercent > 0 ? (item.Book.SalePrice*(1-item.Book.DiscountPercent/100)) : item.Book.SalePrice;


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <li>\r\n                                                            <span class=\"left\">");
#nullable restore
#line 42 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\63. 17-01-2022\PustokP201\PustokP201\Views\Book\Checkout.cshtml"
                                                                          Write(item.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" X ");
#nullable restore
#line 42 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\63. 17-01-2022\PustokP201\PustokP201\Views\Book\Checkout.cshtml"
                                                                                            Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span class=\"right\">$");
#nullable restore
#line 42 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\63. 17-01-2022\PustokP201\PustokP201\Views\Book\Checkout.cshtml"
                                                                                                                                     Write((salePrice*item.Count).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                        </li>\r\n");
#nullable restore
#line 44 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\63. 17-01-2022\PustokP201\PustokP201\Views\Book\Checkout.cshtml"

                                                        total+=(salePrice * item.Count);
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </ul>\r\n                                                <p>Sub Total <span>$");
#nullable restore
#line 48 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\63. 17-01-2022\PustokP201\PustokP201\Views\Book\Checkout.cshtml"
                                                               Write(total.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                                               
                                                <div class=""method-notice mt--25"">
                                                    <article>
                                                        <h3 class=""d-none sr-only"">blog-article</h3>
                                                        Sorry, it seems that there are no available payment methods for
                                                        your state. Please contact us if you
                                                        require
                                                        assistance
                                                        or wish to make alternate arrangements.
                                                    </article>
                                                </div>
                                                <div class=""term-block"">
                                                    <input type=""checkbox""");
            WriteLiteral(@" id=""accept_terms2"">
                                                    <label for=""accept_terms2"">
                                                        I’ve read and accept the terms &
                                                        conditions
                                                    </label>
                                                </div>
                                                <button type=""submit"" form=""order-form"" class=""place-order w-100"">Place order</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </main>
   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckoutViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
