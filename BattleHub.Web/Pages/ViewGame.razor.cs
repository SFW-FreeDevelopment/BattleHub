using BattleHub.DataAccess.Models;
using BattleHub.Web.Services;
using Microsoft.AspNetCore.Components;

namespace BattleHub.Web.Pages;

public partial class ViewGame : ComponentBase
{
    [Inject] public NavigationManager NavigationManager { get; set; }
    [Inject] public GameService GameService { get; set; }
    
    [Parameter] public string Id { get; set; }

    public Game Game { get; set; } = new();
    public string PageHeading => Game?.Name ?? "Not A Real Game";

    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();

        Game = await GameService.Get(Id);
        if (Game == null)
        {
            NavigationManager.NavigateTo("/");
        }
    }
}