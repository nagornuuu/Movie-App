#pragma checksum "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\MovieForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa83bb5db12646d95a88342b483744cac3e79537"
// <auto-generated/>
#pragma warning disable 1591
namespace MovieApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\_Imports.razor"
using MovieApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\_Imports.razor"
using MovieApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\_Imports.razor"
using MovieApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\_Imports.razor"
using MovieApp.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\MovieForm.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\MovieForm.razor"
using MovieApp.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\MovieForm.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/movie-form/{Id:int?}")]
    public partial class MovieForm : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AddMovie</h3>\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 9 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\MovieForm.razor"
                  _model

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "OnValidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\MovieForm.razor"
                                         OnValidSubmit

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(4, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "form-group");
                __builder2.AddMarkupContent(7, "<label for=\"title\">Title</label>\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(8);
                __builder2.AddAttribute(9, "type", (object)("text"));
                __builder2.AddAttribute(10, "class", (object)("form-control"));
                __builder2.AddAttribute(11, "id", (object)("title"));
                __builder2.AddAttribute(12, "name", (object)("title"));
                __builder2.AddAttribute(13, "placeholder", (object)("Put the name of a movie here"));
                __builder2.AddAttribute(14, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 12 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\MovieForm.razor"
                                _model.Title

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(15, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _model.Title = __value, _model.Title)))));
                __builder2.AddAttribute(16, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _model.Title)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                global::__Blazor.MovieApp.Client.Pages.MovieForm.TypeInference.CreateValidationMessage_0(__builder2, 18, 19, 
#nullable restore
#line 13 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\MovieForm.razor"
                                  () => _model.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n\r\n    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "<label for=\"summary\">Summary</label>\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "class", (object)("form-control"));
                __builder2.AddAttribute(26, "name", (object)("summary"));
                __builder2.AddAttribute(27, "id", (object)("summary"));
                __builder2.AddAttribute(28, "placeholder", (object)("Tell something about a movie"));
                __builder2.AddAttribute(29, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 18 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\MovieForm.razor"
                                _model.Summary

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(30, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _model.Summary = __value, _model.Summary)))));
                __builder2.AddAttribute(31, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _model.Summary)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n\r\n    ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "<label for=\"in_theaters\">In theaters</label>\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputCheckbox>(36);
                __builder2.AddAttribute(37, "type", (object)("checkbox"));
                __builder2.AddAttribute(38, "class", (object)("form-control"));
                __builder2.AddAttribute(39, "name", (object)("In cinema"));
                __builder2.AddAttribute(40, "id", (object)("In cinema"));
                __builder2.AddAttribute(41, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 23 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\MovieForm.razor"
                                    _model.InTheaters

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(42, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Boolean>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _model.InTheaters = __value, _model.InTheaters)))));
                __builder2.AddAttribute(43, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => _model.InTheaters)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n\r\n    ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.AddMarkupContent(47, "<label for=\"trailer\">Trailer</label>\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(48);
                __builder2.AddAttribute(49, "type", (object)("text"));
                __builder2.AddAttribute(50, "class", (object)("form-control"));
                __builder2.AddAttribute(51, "id", (object)("trailer"));
                __builder2.AddAttribute(52, "name", (object)("trailer"));
                __builder2.AddAttribute(53, "placeholder", (object)("put the path to the trailer"));
                __builder2.AddAttribute(54, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 28 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\MovieForm.razor"
                                _model.Trailer

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(55, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _model.Trailer = __value, _model.Trailer)))));
                __builder2.AddAttribute(56, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _model.Trailer)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n\r\n    ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group");
                __builder2.AddMarkupContent(60, "<label for=\"releaseDate\">Release date</label>\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<DateTime>>(61);
                __builder2.AddAttribute(62, "class", (object)("form-control"));
                __builder2.AddAttribute(63, "name", (object)("releaseDate"));
                __builder2.AddAttribute(64, "id", (object)("releaseDate"));
                __builder2.AddAttribute(65, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DateTime>(
#nullable restore
#line 33 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\MovieForm.razor"
                                _model.ReleaseDate

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(66, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<DateTime>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<DateTime>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _model.ReleaseDate = __value, _model.ReleaseDate)))));
                __builder2.AddAttribute(67, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<global::System.Func<DateTime>>>(() => _model.ReleaseDate)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n        ");
                global::__Blazor.MovieApp.Client.Pages.MovieForm.TypeInference.CreateValidationMessage_1(__builder2, 69, 70, 
#nullable restore
#line 34 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\MovieForm.razor"
                                  () => _model.ReleaseDate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n\r\n    ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group");
                __builder2.AddMarkupContent(74, "<label for=\"poster\">Poster</label>\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(75);
                __builder2.AddAttribute(76, "type", (object)("text"));
                __builder2.AddAttribute(77, "class", (object)("form-control"));
                __builder2.AddAttribute(78, "name", (object)("poster"));
                __builder2.AddAttribute(79, "id", (object)("poster"));
                __builder2.AddAttribute(80, "placeholder", (object)("put the path to your poster here"));
                __builder2.AddAttribute(81, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 39 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\MovieForm.razor"
                                _model.Poster

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(82, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _model.Poster = __value, _model.Poster)))));
                __builder2.AddAttribute(83, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _model.Poster)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n\r\n    ");
                __builder2.OpenElement(85, "button");
                __builder2.AddAttribute(86, "class", "btn btn-primary");
#nullable restore
#line 43 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\MovieForm.razor"
         if (Id.HasValue)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(87, "<span>Update</span>");
#nullable restore
#line 46 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\MovieForm.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(88, "<span>Create</span>");
#nullable restore
#line 50 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\MovieForm.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\MovieForm.razor"
       
    private MovieFormDTO _model = new();

    [Parameter]
    public int? Id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (Id.HasValue)
        {
            _model = await HttpClient.GetFromJsonAsync<MovieFormDTO>($"api/movies/{Id}");
        }
        else
        {
            Console.WriteLine("No id, creating new movie");
        }
    }

    private void OnValidSubmit()
    {
        if (Id.HasValue)
        {
            HttpClient.PutAsJsonAsync($"api/movies/{Id}", _model);
        }
        else
        {
            HttpClient.PostAsJsonAsync("api/movies", _model);
        }

        NavigationManager.NavigateTo("/movies");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
namespace __Blazor.MovieApp.Client.Pages.MovieForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
