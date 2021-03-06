#pragma checksum "C:\Users\milic\Desktop\blazor\Pages\Shortoverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77f7660e87805da5dfb4d3f198a20e1ffea9b2d7"
// <auto-generated/>
#pragma warning disable 1591
namespace blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\milic\Desktop\blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\milic\Desktop\blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\milic\Desktop\blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\milic\Desktop\blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\milic\Desktop\blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\milic\Desktop\blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\milic\Desktop\blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\milic\Desktop\blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\milic\Desktop\blazor\_Imports.razor"
using blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\milic\Desktop\blazor\_Imports.razor"
using blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\milic\Desktop\blazor\_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\milic\Desktop\blazor\Pages\Shortoverview.razor"
using blazor.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/shortoverview")]
    public partial class Shortoverview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<head><meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" charset=\"utf-8\">\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"css/style.css\"></head>\r\n\r\n\r\n");
            __builder.OpenElement(1, "body");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "flex-wrapper");
            __builder.OpenComponent<blazor.Components.Topbar>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenComponent<blazor.Components.Buttonbar>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "style", "overflow:auto");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "orderchange");
            __builder.OpenComponent<blazor.Components.Left>(12);
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.AddMarkupContent(14, "<div class=\"main\"><p>Very likely the earliest system of written symbols in ancient Mesopotamia was a system of symbols for numbers. Modern numeral systems are place-value systems. That is, the value of the symbol depends upon the position or place of the symbol in the representation; for example, the 2 in 20 and 200 represents two tens and two hundreds, respectively. Most ancient systems, such as the Egyptian, Roman, Hebrew, and Greek numeral systems, did not have a positional characteristic, and this complicated arithmetical calculations. </p>\r\n                    <p class=\"imgp2p\"><a><img src=\"assets/egypt.png\" alt=\"Egypt\" class=\"imgp2\"></a></p>\r\n\t                <p style=\"text-align:center\" class=\"source\">Source:https://en.wikipedia.org/wiki/List_of_numeral_systems</p>\r\n                    <p>Other systems, however, including the Babylonian, one version each of the Chinese and Indian, as well as the Mayan system, did employ the principle of place value.</p>\r\n                    <p class=\"imgp2p\"><a><img src=\"assets/maya.png\" alt=\"Maya\" class=\"imgp2\"></a></p>\r\n                    <p style=\"text-align:center\" class=\"source\">Source:https://en.wikipedia.org/wiki/List_of_numeral_systems</p>\r\n                    <p>The most commonly used numeral system is the decimal positional numeral system, the decimal referring to the use of 10 symbols???0, 1, 2, 3, 4, 5, 6, 7, 8, 9???to construct all numbers. This was an invention of the Indians, perfected by medieval Islam. Two other common positional systems are used in computers and computing science???namely the binary system, with its two symbols 0, 1, and the hexadecimal system, with its 16 symbols 0, 1, 2,???, 9, A, B,???, F.</p></div>\r\n                <div class=\"right\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenComponent<blazor.Components.Footer>(16);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
