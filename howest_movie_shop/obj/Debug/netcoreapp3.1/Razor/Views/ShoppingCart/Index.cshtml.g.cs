#pragma checksum "C:\Users\Mobeen\Downloads\project\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bd4d8cc895c563c26ac8f6cc1afc1579daf8fe3"
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
#line 1 "C:\Users\Mobeen\Downloads\project\Views\_ViewImports.cshtml"
using project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mobeen\Downloads\project\Views\_ViewImports.cshtml"
using project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bd4d8cc895c563c26ac8f6cc1afc1579daf8fe3", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6489460591dedbaaa7ef634782f0f12b0f7a4e7", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<howest_movie_shop.Library.DTO.MovieDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section id=\"cart\">\r\n    <div id=\"cartoverview\">\r\n");
#nullable restore
#line 5 "C:\Users\Mobeen\Downloads\project\Views\ShoppingCart\Index.cshtml"
         if (Model == null || Model.Count == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>Your shopping cart is empty. Please click here to move to home page</h2><a");
            BeginWriteAttribute("href", " href=\"", 256, "\"", 287, 1);
#nullable restore
#line 7 "C:\Users\Mobeen\Downloads\project\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 263, Url.Action("", "Movie"), 263, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Click here</a>\r\n");
#nullable restore
#line 8 "C:\Users\Mobeen\Downloads\project\Views\ShoppingCart\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <h2>Your shopping cart</h2>
            <p>You have selected the following movies so far:</p>
            <div class=""items"">
                <table>
                    <thead>
                        <tr>
                            <th>Movie</th>
                            <th>Price</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 22 "C:\Users\Mobeen\Downloads\project\Views\ShoppingCart\Index.cshtml"
                           double total = 0;
                            foreach (var movie in Model)
                            {
                                total = total + Convert.ToDouble(movie.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 27 "C:\Users\Mobeen\Downloads\project\Views\ShoppingCart\Index.cshtml"
                                   Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>€ ");
#nullable restore
#line 28 "C:\Users\Mobeen\Downloads\project\Views\ShoppingCart\Index.cshtml"
                                     Write(movie.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Mobeen\Downloads\project\Views\ShoppingCart\Index.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </tbody>\r\n                    <tfoot>\r\n                        <tr>\r\n                            <td></td>\r\n                            <td>\r\n                                Total:€ ");
#nullable restore
#line 39 "C:\Users\Mobeen\Downloads\project\Views\ShoppingCart\Index.cshtml"
                                   Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n                    </tfoot>\r\n                </table>\r\n            </div>\r\n            <a class=\"order\"");
            BeginWriteAttribute("href", " href=\"", 1606, "\"", 1636, 1);
#nullable restore
#line 45 "C:\Users\Mobeen\Downloads\project\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 1613, Url.Action("","Order"), 1613, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Proceed to checkout</a>\r\n");
#nullable restore
#line 46 "C:\Users\Mobeen\Downloads\project\Views\ShoppingCart\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<howest_movie_shop.Library.DTO.MovieDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
