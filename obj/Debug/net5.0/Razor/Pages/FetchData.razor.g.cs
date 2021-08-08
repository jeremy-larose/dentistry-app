#pragma checksum "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15c4ef6c96f3926d8704cb16ff927e080bf64b44"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-4xl font-bold mb-4\">Weather Forecast</h1>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server.</p>");
#nullable restore
#line 8 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table-auto w-3/5 mt-4 mx-auto");
            __builder.AddMarkupContent(5, "<thead><tr><th class=\"tableheader\">Date</th>\r\n            <th class=\"tableheader\">Temp. (C)</th>\r\n            <th class=\"tableheader\">Temp. (F)</th>\r\n            <th class=\"tableheader\">Summary</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 26 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\Pages\FetchData.razor"
         foreach (var forecast in forecasts)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.AddAttribute(8, "class", "hover:bg-green-100 odd:bg-purple-50");
            __builder.OpenElement(9, "td");
            __builder.AddAttribute(10, "class", "p-2");
            __builder.AddContent(11, 
#nullable restore
#line 29 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\Pages\FetchData.razor"
                                 forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddAttribute(14, "class", "p-2");
            __builder.AddContent(15, 
#nullable restore
#line 30 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\Pages\FetchData.razor"
                                 forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddAttribute(18, "class", "p-2");
            __builder.AddContent(19, 
#nullable restore
#line 31 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\Pages\FetchData.razor"
                                 forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddAttribute(22, "class", "p-2");
            __builder.AddContent(23, 
#nullable restore
#line 32 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\Pages\FetchData.razor"
                                 forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\Pages\FetchData.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Jeremy\Documents\Code\Blazor Apps\BlazorDentistry\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
