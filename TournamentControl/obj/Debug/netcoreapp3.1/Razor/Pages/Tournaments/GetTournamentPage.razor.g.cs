#pragma checksum "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Pages\Tournaments\GetTournamentPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "910e06e3fa32f69c9ade1f795d71a203c82205e8"
// <auto-generated/>
#pragma warning disable 1591
namespace TournamentControl.Pages.Tournaments
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
#line 2 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Pages\Tournaments\GetTournamentPage.razor"
using BL.Tournaments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Pages\Tournaments\GetTournamentPage.razor"
using Comm.ViewModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tournaments/Get/{TournamentId}")]
    public partial class GetTournamentPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-12 d-flex flex-wrap justify-content-center");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-8 d-flex flex-wrap");
            __builder.AddAttribute(5, "style", "height: fit-content;");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<TournamentControl.Components.Tournaments.GetTournamentComponent>(7);
            __builder.AddAttribute(8, "positionTables", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Comm.ViewModels.PositionTable>>(
#nullable restore
#line 9 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Pages\Tournaments\GetTournamentPage.razor"
                                                PositionTables

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-lg-3 flex-wrap d-flex p-0");
            __builder.AddAttribute(13, "style", "height: fit-content;");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenComponent<TournamentControl.Components.WorkDays.GetWorkDayComponent>(15);
            __builder.AddAttribute(16, "WorkDay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Comm.ViewModels.WorkDayVM>(
#nullable restore
#line 12 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Pages\Tournaments\GetTournamentPage.razor"
                                      currentWorkDay

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "ChangeWorkDay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 13 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Pages\Tournaments\GetTournamentPage.razor"
                                            ChangeWorkDay

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(18, "refresTournament", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 14 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Pages\Tournaments\GetTournamentPage.razor"
                                               refresTournament

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Pages\Tournaments\GetTournamentPage.razor"
       
    [Parameter]
    public string TournamentId { get; set; }

    TournamentVM tournament = new TournamentVM();
    List<WorkDayVM> workDays = new List<WorkDayVM>();
    int currentWorkDayIndex = 0;
    WorkDayVM currentWorkDay = new WorkDayVM();
    List<PositionTable> PositionTables { get; set; }

    protected override async Task OnInitializedAsync()
    {
        refresTournament();
    }

    public void ChangeWorkDay(int index)
    {
        if ((currentWorkDayIndex + index) >= 0 && (currentWorkDayIndex + index) < workDays.Count)
        {
            currentWorkDayIndex += index;
            currentWorkDay = workDays[currentWorkDayIndex];
        }

    }

    public void refresTournament()
    {
        tournament = router.Get(Int32.Parse(TournamentId));
        workDays = tournament.WorkDays.OrderBy(x => x.Number).ToList();
        currentWorkDay = workDays[currentWorkDayIndex];
        PositionTables = router.GetPositionTable(tournament);
        PositionTables = PositionTables.OrderByDescending(x => x.Points).ThenByDescending(x => x.GoalsDiference).ThenByDescending(x => x.GoalsFor).ToList();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RouterTournament router { get; set; }
    }
}
#pragma warning restore 1591
