#pragma checksum "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddOperationsDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d171833f742f8a3d068cdfbacb09690c516fab54"
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
    public partial class AddOperationsDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddOperationsDialog.razor"
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
            __builder.AddMarkupContent(12, "<h5 class=\"modal-title font-weight-bold\" id=\"titleLabel\">Add Operation</h5>\r\n                    ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "class", "close");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddOperationsDialog.razor"
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
#line 13 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddOperationsDialog.razor"
                                      Operation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddOperationsDialog.razor"
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
                __builder2.AddMarkupContent(33, "<label for=\"operationName\">Operation Name: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(34);
                __builder2.AddAttribute(35, "id", "operationName");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "placeholder", "Enter operation name");
                __builder2.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddOperationsDialog.razor"
                                                                                             Operation.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Operation.Name = __value, Operation.Name))));
                __builder2.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Operation.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                        ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group");
                __builder2.AddMarkupContent(44, "<label for=\"orderOfExecution\">Order of Execution: </label>\r\n                            ");
                __Blazor.BlazorDemo.Components.AddOperationsDialog.TypeInference.CreateInputNumber_0(__builder2, 45, 46, "orderOfExecution", 47, "form-control", 48, "Enter order of execution", 49, 
#nullable restore
#line 22 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddOperationsDialog.razor"
                                                                                                  Operation.OrderInWhichToPerform

#line default
#line hidden
#nullable disable
                , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Operation.OrderInWhichToPerform = __value, Operation.OrderInWhichToPerform)), 51, () => Operation.OrderInWhichToPerform);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                        ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group");
                __builder2.AddMarkupContent(55, "<label for=\"orderOfExecution\">Uplod Image: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(56);
                __builder2.AddAttribute(57, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddOperationsDialog.razor"
                                                  OnFileSelection

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n                            ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "row");
                __builder2.OpenElement(61, "img");
                __builder2.AddAttribute(62, "src", 
#nullable restore
#line 28 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddOperationsDialog.razor"
                                           imgUrl

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                        ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group");
                __builder2.AddMarkupContent(66, "<label>Device: </label>\r\n                            ");
                __builder2.OpenComponent<BlazorDemo.Components.Devices>(67);
                __builder2.AddAttribute(68, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddOperationsDialog.razor"
                                                   Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Name = __value, Name))));
                __builder2.AddComponentReferenceCapture(70, (__value) => {
#nullable restore
#line 33 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddOperationsDialog.razor"
                                                               Devices = (BlazorDemo.Components.Devices)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n                            ");
                __Blazor.BlazorDemo.Components.AddOperationsDialog.TypeInference.CreateValidationMessage_1(__builder2, 72, 73, 
#nullable restore
#line 34 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddOperationsDialog.razor"
                                                      () => Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                        ");
                __builder2.AddMarkupContent(75, "<button type=\"submit\" class=\"btn btn-primary\">Save operation</button>\r\n                        ");
                __builder2.OpenElement(76, "a");
                __builder2.AddAttribute(77, "class", "btn btn-outline-primary");
                __builder2.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddOperationsDialog.razor"
                                                                      Close

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(79, "Close");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddOperationsDialog.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Jake\Downloads\BlazorDemo\BlazorDemo\BlazorDemo\Components\AddOperationsDialog.razor"
          
        string imgUrl = string.Empty;
        private async Task OnFileSelection(InputFileChangeEventArgs e)
        {
            IBrowserFile imgFile = e.File;
            var buffers = new byte[imgFile.Size];
            Operation.ImageData = buffers;
            await imgFile.OpenReadStream().ReadAsync(buffers);
            string imageType = imgFile.ContentType;
        }
    

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorDemo.Components.AddOperationsDialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
