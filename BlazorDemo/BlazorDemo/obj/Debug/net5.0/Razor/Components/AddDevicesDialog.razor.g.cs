#pragma checksum "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddDevicesDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de59c9ee42c5067963d07e28557e5c0203a79e93"
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
#nullable restore
#line 1 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddDevicesDialog.razor"
using BlazorDemo.Model;

#line default
#line hidden
#nullable disable
    public partial class AddDevicesDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddDevicesDialog.razor"
 if (ShowDialog)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show d-block");
            __builder.AddAttribute(2, "id", "exampleModal");
            __builder.AddAttribute(3, "tabindex", "-1");
            __builder.AddAttribute(4, "role", "dialog");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "modal-dialog");
            __builder.AddAttribute(7, "role", "document");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-content");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-header");
            __builder.AddMarkupContent(12, "<h5 class=\"modal-title font-weight-bold\" id=\"titleLabel\">Add Device</h5>\r\n                    ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "class", "close");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddDevicesDialog.razor"
                                                                   Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "data-dismiss", "modal");
            __builder.AddAttribute(18, "aria-label", "Close");
            __builder.AddMarkupContent(19, "<span aria-hidden=\"true\">×</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "modal-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(23);
            __builder.AddAttribute(24, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddDevicesDialog.razor"
                                      Device

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddDevicesDialog.razor"
                                                              HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(27);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(29);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n                        ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "<label for=\"deviceName\">Device Name: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(34);
                __builder2.AddAttribute(35, "id", "deviceName");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "placeholder", "Enter device name");
                __builder2.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddDevicesDialog.razor"
                                                                                          Device.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Device.Name = __value, Device.Name))));
                __builder2.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Device.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                        ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group");
                __builder2.AddMarkupContent(44, "<label for=\"deviceType\">Device type: </label>\r\n                            ");
                __Blazor.BlazorDemo.Components.AddDevicesDialog.TypeInference.CreateInputSelect_0(__builder2, 45, 46, 
#nullable restore
#line 24 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddDevicesDialog.razor"
                                                      Device.DeviceType

#line default
#line hidden
#nullable disable
                , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Device.DeviceType = __value, Device.DeviceType)), 48, () => Device.DeviceType, 49, (__builder3) => {
#nullable restore
#line 25 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddDevicesDialog.razor"
                                 foreach (var deviceType in Enum.GetValues(typeof(DeviceType)))
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(50, "option");
                    __builder3.AddAttribute(51, "value", 
#nullable restore
#line 27 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddDevicesDialog.razor"
                                                    deviceType

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(52, 
#nullable restore
#line 27 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddDevicesDialog.razor"
                                                                 deviceType

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 28 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddDevicesDialog.razor"
                                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                        \r\n                        ");
                __builder2.AddMarkupContent(54, "<button type=\"submit\" class=\"btn btn-primary\">Save device</button>\r\n                        ");
                __builder2.OpenElement(55, "a");
                __builder2.AddAttribute(56, "class", "btn btn-outline-primary");
                __builder2.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddDevicesDialog.razor"
                                                                      Close

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(58, "Close");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddDevicesDialog.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.BlazorDemo.Components.AddDevicesDialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591