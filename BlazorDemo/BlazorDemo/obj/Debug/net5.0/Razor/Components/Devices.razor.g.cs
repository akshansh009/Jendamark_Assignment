#pragma checksum "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\Devices.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5be5ef5d6925ab52f281dcaadb3e337f7b9b5b9"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDemo.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\_Imports.razor"
using BlazorDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\_Imports.razor"
using BlazorDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\_Imports.razor"
using BlazorDemo.Components;

#line default
#line hidden
#nullable disable
    public partial class Devices : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\Devices.razor"
 if (DeviceMaster == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading ...</em></p>");
#nullable restore
#line 6 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\Devices.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "select");
            __builder.AddAttribute(2, "class", "custom-select");
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\Devices.razor"
                                             OnValueChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "title", "Device is required ");
            __builder.OpenElement(5, "option");
            __builder.AddAttribute(6, "value", "Select");
            __builder.AddAttribute(7, "selected");
            __builder.AddAttribute(8, "disabled", "disabled");
            __builder.AddContent(9, "(Choose Device)");
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\Devices.razor"
         foreach (var device in DeviceMaster)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "option");
            __builder.AddAttribute(11, "value", (
#nullable restore
#line 13 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\Devices.razor"
                            device

#line default
#line hidden
#nullable disable
            ) + ".");
            __builder.AddContent(12, 
#nullable restore
#line 13 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\Devices.razor"
                                       device.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\Devices.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\Devices.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591