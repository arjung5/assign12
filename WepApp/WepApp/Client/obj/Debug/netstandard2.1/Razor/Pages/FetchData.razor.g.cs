#pragma checksum "E:\Assignment12\WepApp\WepApp\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cee86020c70b20cf4cdf95205a417b943590e19"
// <auto-generated/>
#pragma warning disable 1591
namespace WepApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Assignment12\WepApp\WepApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Assignment12\WepApp\WepApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Assignment12\WepApp\WepApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Assignment12\WepApp\WepApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Assignment12\WepApp\WepApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Assignment12\WepApp\WepApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Assignment12\WepApp\WepApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Assignment12\WepApp\WepApp\Client\_Imports.razor"
using WepApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Assignment12\WepApp\WepApp\Client\_Imports.razor"
using WepApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Assignment12\WepApp\WepApp\Client\Pages\FetchData.razor"
using WepApp.Client.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates the maximum and minimum value fetching data from the server.</p>\r\n\r\n");
#nullable restore
#line 9 "E:\Assignment12\WepApp\WepApp\Client\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 12 "E:\Assignment12\WepApp\WepApp\Client\Pages\FetchData.razor"
}
else
{
    
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Assignment12\WepApp\WepApp\Client\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "               ");
            __builder.OpenElement(5, "div");
            __builder.OpenElement(6, "bold");
            __builder.AddContent(7, 
#nullable restore
#line 18 "E:\Assignment12\WepApp\WepApp\Client\Pages\FetchData.razor"
                           forecast.Key

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(8, " ");
            __builder.AddContent(9, 
#nullable restore
#line 18 "E:\Assignment12\WepApp\WepApp\Client\Pages\FetchData.razor"
                                                forecast.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 19 "E:\Assignment12\WepApp\WepApp\Client\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\Assignment12\WepApp\WepApp\Client\Pages\FetchData.razor"
             
      
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "E:\Assignment12\WepApp\WepApp\Client\Pages\FetchData.razor"
       
    private Dictionary<string, string> forecasts { get; set; }

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<Dictionary<string, string>>("FetchData");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591