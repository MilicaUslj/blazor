#pragma checksum "C:\Users\milic\Desktop\blazor\Pages\Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8235537a2d771375b6c8856430cfabe18517bc8f"
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
#line 2 "C:\Users\milic\Desktop\blazor\Pages\Home.razor"
using blazor.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/home")]
    public partial class Home : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(14, @"<div class=""main""><p>A numeral system (or system of numeration) is a writing system for expressing numbers; that is, a mathematical notation for representing numbers of a given set, using digits or other symbols in a consistent manner.</p>
                    <p>The same sequence of symbols may represent different numbers in different numeral systems. For example, ""11"" represents the number eleven in the decimal numeral system (used in common life), the number three in the binary numeral system (used in computers).</p>
                    <p>This website provides short overview of the most commonly used numeral systems, as well as a convertor between different numeral systems.</p></div>
                ");
            __builder.AddMarkupContent(15, "<div class=\"right\"><a><img src=\"assets/light-bulb.gif\" border=\"0\" alt=\"its funny\"></a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenComponent<blazor.Components.Footer>(17);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
