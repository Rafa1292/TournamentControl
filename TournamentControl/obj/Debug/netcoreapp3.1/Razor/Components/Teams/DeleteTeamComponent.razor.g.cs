#pragma checksum "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Teams\DeleteTeamComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8eb24e630569c6c4af4d7aa0f53c7d9ec5b9bb26"
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
#line 1 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Teams\DeleteTeamComponent.razor"
using Comm.ViewModels;

#line default
#line hidden
#nullable disable
    public partial class DeleteTeamComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-12 d-flex flex-wrap justify-content-center text-white");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<span class=\"col-12 h4 text-center font-weight-bolder mt-5 mb-5\">\r\n        Eliminar equipo\r\n    </span>\r\n    ");
            __builder.AddMarkupContent(4, "<label class=\"col-12 text-center\">¿Seguro que deseas eliminar este equipo?</label>\r\n    ");
            __builder.OpenElement(5, "h5");
            __builder.AddAttribute(6, "class", "col-12 mb-4 text-center");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "strong");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddContent(10, 
#nullable restore
#line 10 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Teams\DeleteTeamComponent.razor"
             team.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, " \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "form-group justify-content-center d-flex flex-wrap");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "span");
            __builder.AddAttribute(18, "class", "col-12 text-danger text-center h5");
            __builder.AddContent(19, 
#nullable restore
#line 14 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Teams\DeleteTeamComponent.razor"
                                                         message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "value", "Eliminar equipo");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Teams\DeleteTeamComponent.razor"
                                                               Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "class", "form-control btn btn-danger col-12");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.AddMarkupContent(27, "<a href=\"Teams/Index\" class=\"btn btn-secondary m-3\">Volver</a>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Teams\DeleteTeamComponent.razor"
       
    [Parameter]
    public string TeamId { get; set; }
    public string message { get; set; }
    TeamVM team = new TeamVM();

    protected override async Task OnInitializedAsync()
    {
        team.Name = "Barcelona";
    }

    private void Delete()
    {

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591