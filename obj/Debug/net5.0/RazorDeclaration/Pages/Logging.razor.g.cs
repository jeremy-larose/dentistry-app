// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorDentistry.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/logging")]
    public partial class Logging : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\Pages\Logging.razor"
       

    private void LogWarning()
    {
        Log.Warning("This is a warning!");
    }

    private void LogError()
    {
        Log.Error("This is an error!");
    }

    private void LogInfo()
    {
        Log.Information("This is information.");
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
