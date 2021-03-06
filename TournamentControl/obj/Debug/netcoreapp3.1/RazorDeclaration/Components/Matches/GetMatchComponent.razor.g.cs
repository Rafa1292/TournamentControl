#pragma checksum "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b980160f73c12d33a8543d937432e4067907d0b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TournamentControl.Components.Matches
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
#line 1 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
using Comm.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
using BL.Matches;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
using BL.Teams;

#line default
#line hidden
#nullable disable
    public partial class GetMatchComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
      
    [Parameter]
    public MatchVM Match { get; set; }
    public bool EditMode { get; set; }
    List<TeamVM> teams = new List<TeamVM>();
    [Parameter] public EventCallback refresTournament { get; set; }


    protected override void OnInitialized()
    {
        teams = routerTeam.GetAll();
    }

    private void EditModeEnable()
    {
        EditMode = true;
    }

    private void Save()
    {
        Match.Played = true;
        var response = routerMatch.Update(Match);

        if (response)
        {
            EditMode = false;
            refresTournament.InvokeAsync(true);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RouterMatch routerMatch { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RouterTeam routerTeam { get; set; }
    }
}
#pragma warning restore 1591
