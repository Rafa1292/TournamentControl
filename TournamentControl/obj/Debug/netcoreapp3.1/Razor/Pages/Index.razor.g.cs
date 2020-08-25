#pragma checksum "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66d1811a9f339b8f18cf03a69efb37ae4f83b59b"
// <auto-generated/>
#pragma warning disable 1591
namespace TournamentControl.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\_Imports.razor"
using TournamentControl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\_Imports.razor"
using TournamentControl.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\_Imports.razor"
using TournamentControl.Components.Players;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\_Imports.razor"
using TournamentControl.Components.Teams;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\_Imports.razor"
using TournamentControl.Components.Tournaments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\_Imports.razor"
using TournamentControl.Components.WorkDays;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\_Imports.razor"
using TournamentControl.Components.Matches;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Pages\Index.razor"
using BL.Matches;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Pages\Index.razor"
using Comm.ViewModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-8 p-0 d-flex flex-wrap justify-content-center mt-2");
            __builder.AddAttribute(2, "style", "background: rgba(0,0,0,.5)");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<h4 class=\"col-12 text-center font-weight-bold my-4\" style=\"color: rgba(255,255,255,.9); text-shadow: 1px 1px 1px #000;\">Resultados recientes</h4>\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Pages\Index.razor"
     foreach (var match in matches)
    {


#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "        ");
            __builder.OpenComponent<TournamentControl.Components.Matches.GetMatchComponent>(6);
            __builder.AddAttribute(7, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Comm.ViewModels.MatchVM>(
#nullable restore
#line 14 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Pages\Index.razor"
                                  match

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 15 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Pages\Index.razor"

        i++;

        if (i >= 5)
            break;
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n<img src=\"/Images/uefaCopa.png\" style=\"width:150px; height: 150px; position:absolute; bottom:2vh; left:calc(50vw - 75px); opacity: .7;\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Pages\Index.razor"
 
    List<MatchVM> matches = new List<MatchVM>();
    int i = 0;

    protected override void OnInitialized()
    {
        matches = _routerMatch.GetMatchesByWorkDay();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RouterMatch _routerMatch { get; set; }
    }
}
#pragma warning restore 1591
