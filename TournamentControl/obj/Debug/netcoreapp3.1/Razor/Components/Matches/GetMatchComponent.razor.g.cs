#pragma checksum "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b980160f73c12d33a8543d937432e4067907d0b"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
                 Match

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "class", "d-flex flex-wrap p-0");
            __builder.AddAttribute(3, "style", "width: 100%; border-bottom: 1px solid white;");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "match");
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenElement(9, "span");
                __builder2.AddAttribute(10, "style", "width:33%; text-align: center;");
                __builder2.AddMarkupContent(11, "\r\n            <img src=\"/Images/pngocean.com.png\" style=\"width: 30%; height: 7vh; object-fit:contain; margin: 0 1%;\">\r\n            ");
                __builder2.AddContent(12, 
#nullable restore
#line 12 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
             Match.HomePlayer.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenElement(15, "span");
                __builder2.AddAttribute(16, "style", "width: 10%; text-align: center;");
                __builder2.AddMarkupContent(17, "\r\n");
#nullable restore
#line 15 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
             if (Match.Played)
            {
                

#line default
#line hidden
#nullable disable
                __builder2.AddContent(18, 
#nullable restore
#line 17 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
                 Match.HomeGoal

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 17 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
                               
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
             if (EditMode)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(19, "                ");
                __Blazor.TournamentControl.Components.Matches.GetMatchComponent.TypeInference.CreateInputNumber_0(__builder2, 20, 21, "width: 100%", 22, 
#nullable restore
#line 21 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
                                          Match.HomeGoal

#line default
#line hidden
#nullable disable
                , 23, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Match.HomeGoal = __value, Match.HomeGoal)), 24, () => Match.HomeGoal);
                __builder2.AddMarkupContent(25, "\r\n");
#nullable restore
#line 22 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(26, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.AddMarkupContent(28, "<span style=\"width: 10%; text-align: center;\"><strong>V</strong></span>\r\n        ");
                __builder2.OpenElement(29, "span");
                __builder2.AddAttribute(30, "style", "width: 10%; text-align: center;");
                __builder2.AddMarkupContent(31, "\r\n");
#nullable restore
#line 26 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
             if (Match.Played)
            {
                

#line default
#line hidden
#nullable disable
                __builder2.AddContent(32, 
#nullable restore
#line 28 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
                 Match.AwayGoal

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 28 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
                               
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
             if (EditMode)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(33, "                ");
                __Blazor.TournamentControl.Components.Matches.GetMatchComponent.TypeInference.CreateInputNumber_1(__builder2, 34, 35, "width: 100%", 36, 
#nullable restore
#line 32 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
                                          Match.AwayGoal

#line default
#line hidden
#nullable disable
                , 37, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Match.AwayGoal = __value, Match.AwayGoal)), 38, () => Match.AwayGoal);
                __builder2.AddMarkupContent(39, "\r\n");
#nullable restore
#line 33 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(40, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.OpenElement(42, "span");
                __builder2.AddAttribute(43, "style", "width:33%; text-align: center;");
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.AddContent(45, 
#nullable restore
#line 36 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
             Match.AwayPlayer.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(46, "\r\n            <img src=\"/Images/pngocean.com.png\" style=\"width: 30%; height: 7vh; object-fit:contain; margin: 0 1%;\">\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n    ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", " p-0 mb-2 col-12 d-flex justify-content-center align-items-center ");
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.OpenElement(52, "span");
                __builder2.AddAttribute(53, "style", "width:30%;");
                __builder2.AddAttribute(54, "class", "d-flex justify-content-center");
                __builder2.AddMarkupContent(55, "\r\n");
#nullable restore
#line 42 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
             if (EditMode)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(56, "                ");
                __builder2.OpenElement(57, "select");
                __builder2.AddAttribute(58, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
                                Match.HomeTeamId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Match.HomeTeamId = __value, Match.HomeTeamId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(60, "\r\n");
#nullable restore
#line 45 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
                     foreach (var team in teams)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(61, "                        ");
                __builder2.OpenElement(62, "option");
                __builder2.AddAttribute(63, "value", 
#nullable restore
#line 47 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
                                        team.TeamId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(64, 
#nullable restore
#line 47 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
                                                      team.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n");
#nullable restore
#line 48 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(66, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n");
#nullable restore
#line 50 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(68, "                <img src=\"/Images/escudo.png\" style=\"height:50px; width: 60px; object-fit: contain;\">\r\n");
#nullable restore
#line 54 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(69, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n        ");
                __builder2.OpenElement(71, "span");
                __builder2.AddAttribute(72, "style", "width:33%; font-size: 30px");
                __builder2.AddAttribute(73, "class", "d-flex justify-content-center");
                __builder2.AddMarkupContent(74, "\r\n");
#nullable restore
#line 57 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
             if (EditMode)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(75, "                ");
                __builder2.OpenElement(76, "i");
                __builder2.AddAttribute(77, "class", "fas fa-cloud-upload-alt text-white");
                __builder2.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
                                                                        Save

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n");
#nullable restore
#line 60 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(80, "                ");
                __builder2.OpenElement(81, "i");
                __builder2.AddAttribute(82, "class", "fas fa-keyboard text-white");
                __builder2.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
                                                                EditModeEnable

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n");
#nullable restore
#line 64 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(85, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n        ");
                __builder2.OpenElement(87, "span");
                __builder2.AddAttribute(88, "style", "width:33%;");
                __builder2.AddAttribute(89, "class", "d-flex justify-content-center");
                __builder2.AddMarkupContent(90, "\r\n");
#nullable restore
#line 67 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
             if (EditMode)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(91, "                ");
                __builder2.OpenElement(92, "select");
                __builder2.AddAttribute(93, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 69 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
                               Match.AwayTeamId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Match.AwayTeamId = __value, Match.AwayTeamId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(95, "\r\n");
#nullable restore
#line 70 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
                     foreach (var team in teams)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(96, "                        ");
                __builder2.OpenElement(97, "option");
                __builder2.AddAttribute(98, "value", 
#nullable restore
#line 72 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
                                        team.TeamId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(99, 
#nullable restore
#line 72 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
                                                      team.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n");
#nullable restore
#line 73 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(101, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n");
#nullable restore
#line 75 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
            }
            else
            {
                if (Match.AwayTeamId > 0)
                {
                    var awayTeam = teams.Find(x => x.TeamId == Match.AwayTeamId);


#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(103, "                    <img src=\"/Images/escudo.png\" style=\"height:50px; width: 60px; object-fit: contain;\">\r\n");
#nullable restore
#line 83 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(104, "                <img src=\"/Images/escudo.png\" style=\"height:50px; width: 60px; object-fit: contain;\">\r\n");
#nullable restore
#line 85 "C:\Users\rvill\source\repos\TournamentControl\TournamentControl\Components\Matches\GetMatchComponent.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(105, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n\r\n\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n");
            }
            ));
            __builder.CloseComponent();
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
namespace __Blazor.TournamentControl.Components.Matches.GetMatchComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
