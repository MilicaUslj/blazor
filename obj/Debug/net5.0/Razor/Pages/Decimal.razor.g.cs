#pragma checksum "C:\Users\milic\Desktop\blazor\Pages\Decimal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32a4c26874114137bfe63612f3efb268052fd395"
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
#line 2 "C:\Users\milic\Desktop\blazor\Pages\Decimal.razor"
using blazor.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/decimal")]
    public partial class Decimal : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(14, @"<div class=""main""><p></p>
                    <p>Decimal system, also called Hindu-Arabic number system or Arabic number system, in mathematics, positional numeral system employing 10 as the base and requiring 10 different numerals, the digits 0, 1, 2, 3, 4, 5, 6, 7, 8, 9. It also requires a dot (decimal point) to represent decimal fractions. In this scheme, the numerals used in denoting a number take different place values depending upon position. In a base-10 system the number 543.21 represents the sum (5 x 10<sup>2</sup>) + (4 x 10<sup>1</sup>) + (3 x 10<sup>0</sup>) + (2 x 10<sup>-1</sup>) + (1 x 10<sup>-2</sup>).</p>
                    <p>This number system, with its associated arithmetic algorithms, has furnished the basis for the development of Western commerce and science since its introduction to the West in the 12th century CE.</p>
	                <p class=""source"">Source: https://www.britannica.com/science/decimal</p></div>

                ");
            __builder.AddMarkupContent(15, "<div class=\"right sheldon\"><a><img src=\"assets/sheldonfront.jpg\" alt=\"its funny\"></a>\r\n                    <a><img src=\"assets/Sheldon.jpg\" class=\"img-front\" alt=\"its funny\"></a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n       ");
            __builder.OpenComponent<blazor.Components.Footer>(17);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
