#pragma checksum "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\ViewMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e56389cf25a9840125e2afff8f417e2a9e00586b"
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
#line 2 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\ViewMovie.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\ViewMovie.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\ViewMovie.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/movie/{id:int}/view")]
    public partial class ViewMovie : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ViewMovie</h3>");
#nullable restore
#line 8 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\ViewMovie.razor"
 if (_movie != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "img");
            __builder.AddAttribute(2, "src", 
#nullable restore
#line 10 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\ViewMovie.razor"
               _movie.Poster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "alt", "Poster");
            __builder.AddAttribute(4, "class", "movie-poster");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "h4");
#nullable restore
#line 11 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\ViewMovie.razor"
__builder.AddContent(7, _movie.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "h5");
#nullable restore
#line 12 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\ViewMovie.razor"
__builder.AddContent(10, _movie.Summary);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\ViewMovie.razor"
     if (_movie.InTheaters)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<h5>In Theaters</h5>");
#nullable restore
#line 16 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\ViewMovie.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<h5>Coming Soon</h5>");
#nullable restore
#line 20 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\ViewMovie.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "href", 
#nullable restore
#line 21 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\ViewMovie.razor"
              _movie.Trailer

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, "Trailer");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "h5");
#nullable restore
#line 22 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\ViewMovie.razor"
__builder.AddContent(18, _movie.ReleaseDate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "ul");
#nullable restore
#line 24 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\ViewMovie.razor"
         foreach (var genre in _movie.MoviesGenres)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "li");
#nullable restore
#line 26 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\ViewMovie.razor"
__builder.AddContent(22, genre);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\ViewMovie.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "ul");
#nullable restore
#line 30 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\ViewMovie.razor"
         foreach (var actor in _movie.MoviesActors)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "li");
#nullable restore
#line 32 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\ViewMovie.razor"
__builder.AddContent(26, actor);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\ViewMovie.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\ViewMovie.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(27, "<p><em>Loading...</em></p>");
#nullable restore
#line 39 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\ViewMovie.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\andrii\Desktop\MovieApp\MovieApp\MovieApp\Client\Pages\ViewMovie.razor"
       
    [Parameter]
    public int Id { get; set; }

    private Movie _movie;

    protected override async Task OnInitializedAsync()
    {
        await GetMovie();
    }

    private async Task GetMovie()
    {
        var response = await httpClient.GetAsync($"api/movies/{Id}");

        if (response.IsSuccessStatusCode)
        {
            var responseString = await response.Content.ReadAsStringAsync();
            _movie = JsonSerializer.Deserialize<Movie>(responseString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591