#pragma checksum "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6444b335c20bf3aaeda45af7d3b02aa2c32e2e24"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDentistry.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\_Imports.razor"
using BlazorDentistry;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\_Imports.razor"
using BlazorDentistry.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\_Imports.razor"
using Serilog;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "class", "flex justify-between mt-6 ml-8 text-white uppercase tracking-wider");
            __builder.AddAttribute(2, "b-5uzd4ppelx");
            __builder.OpenElement(3, "li");
            __builder.AddAttribute(4, "b-5uzd4ppelx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(5);
            __builder.AddAttribute(6, "class", "mr-6 pb-2 border-b-4 border-purple-700 hover:border-green-400");
            __builder.AddAttribute(7, "href", "");
            __builder.AddAttribute(8, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 3 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\Shared\NavMenu.razor"
                                                                                                      NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n            Home\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "li");
            __builder.AddAttribute(13, "b-5uzd4ppelx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(14);
            __builder.AddAttribute(15, "class", "mr-6 pb-2 border-b-4 border-purple-700 hover:border-green-400");
            __builder.AddAttribute(16, "href", "counter");
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(18, "\r\n            Counter\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "li");
            __builder.AddAttribute(21, "b-5uzd4ppelx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(22);
            __builder.AddAttribute(23, "class", "mr-6 pb-2 border-b-4 border-purple-700 hover:border-green-400");
            __builder.AddAttribute(24, "href", "fetchdata");
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "\r\n            Fetch data\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "li");
            __builder.AddAttribute(29, "b-5uzd4ppelx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "class", "mr-6 pb-2 border-b-4 border-purple-700 hover:border-green-400");
            __builder.AddAttribute(32, "href", "logging");
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "\r\n            Logging\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
