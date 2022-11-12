using BattleHub.DataAccess.Models;
using BattleHub.Web.Services;
using Microsoft.AspNetCore.Components;

namespace BattleHub.Web.Pages;

public partial class ViewGame : ComponentBase
{
    [Inject] public NavigationManager NavigationManager { get; set; }
    [Inject] public GameService GameService { get; set; }
    
    [Parameter] public string Id { get; set; }
    [Parameter] public string Slug { get; set; }

    public Game Game { get; set; } = new()
    {
        Id = "mvc2",
        Name = "Marvel vs Capcom 2"
    };

    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();
        
        
    }
}