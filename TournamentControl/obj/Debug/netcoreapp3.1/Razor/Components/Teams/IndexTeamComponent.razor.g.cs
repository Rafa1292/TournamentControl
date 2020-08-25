#pragma checksum "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Teams\IndexTeamComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a76b337cb96b7352f8f4361fdc52102c97cf857"
// <auto-generated/>
#pragma warning disable 1591
namespace TournamentControl.Components.Teams
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
#line 1 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Teams\IndexTeamComponent.razor"
using Comm.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Teams\IndexTeamComponent.razor"
using BL.Teams;

#line default
#line hidden
#nullable disable
    public partial class IndexTeamComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-12 d-flex flex-wrap justify-content-center");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<span class=\"col-12 h4 text-center font-weight-bolder text-white mt-5 mb-5\">\r\n        Equipos\r\n    </span>\r\n    ");
            __builder.AddMarkupContent(4, "<p class=\"col-12 p-1 d-flex justify-content-center\">\r\n        <a class=\"btn btn-primary \" href=\"Teams/Create\">Agregar equipo</a>\r\n    </p>\r\n    ");
            __builder.OpenElement(5, "label");
            __builder.AddAttribute(6, "class", "text-danger h5 ");
            __builder.AddContent(7, 
#nullable restore
#line 13 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Teams\IndexTeamComponent.razor"
                                    message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-12 p-0 d-flex flex-wrap justify-content-center");
            __builder.AddAttribute(11, "style", "max-height: 60vh; overflow-y: scroll;");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "table");
            __builder.AddAttribute(14, "id", "playersTable");
            __builder.AddAttribute(15, "class", "col-sm-6 table table-striped text-center table-dark");
            __builder.AddAttribute(16, "style", "background: rgba(0,0,0,.8);");
            __builder.AddMarkupContent(17, "\r\n\r\n            ");
            __builder.OpenElement(18, "tbody");
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 19 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Teams\IndexTeamComponent.razor"
                 foreach (var team in teams)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "                    ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "\r\n\r\n                        ");
            __builder.OpenElement(23, "td");
            __builder.AddMarkupContent(24, "\r\n                            ");
            __builder.OpenElement(25, "img");
            __builder.AddAttribute(26, "src", 
#nullable restore
#line 24 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Teams\IndexTeamComponent.razor"
                                       team.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "asp-append-version", "true");
            __builder.AddAttribute(28, "width", "35");
            __builder.AddAttribute(29, "height", "35");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "td");
            __builder.AddAttribute(33, "class", "text-white-50");
            __builder.AddMarkupContent(34, "\r\n                            ");
            __builder.AddContent(35, 
#nullable restore
#line 27 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Teams\IndexTeamComponent.razor"
                             team.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "td");
            __builder.AddAttribute(39, "class", "d-flex flex-wrap justify-content-center");
            __builder.AddMarkupContent(40, "\r\n                            ");
            __builder.OpenElement(41, "a");
            __builder.AddAttribute(42, "class", "m-2");
            __builder.AddAttribute(43, "href", "Teams/Update/" + (
#nullable restore
#line 30 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Teams\IndexTeamComponent.razor"
                                                               team.TeamId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "<i class=\"fas fa-edit text-light\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                            ");
            __builder.OpenElement(46, "a");
            __builder.AddAttribute(47, "class", "m-2");
            __builder.AddAttribute(48, "href", "Teams/Delete/" + (
#nullable restore
#line 31 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Teams\IndexTeamComponent.razor"
                                                               team.TeamId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(49, "<i class=\"fa fa-trash text-danger\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 34 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Teams\IndexTeamComponent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Teams\IndexTeamComponent.razor"
      

    List<TeamVM> teams = new List<TeamVM>();
    string message;


    protected override void OnInitialized()
    {
        teams = router.GetAll();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RouterTeam router { get; set; }
    }
}
#pragma warning restore 1591
