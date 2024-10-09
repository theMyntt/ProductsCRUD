using Microsoft.AspNetCore.Components;
using ProductsCRUD.WebUI.Models;

namespace ProductsCRUD.WebUI.Components.Pages.Products;

public partial class Update : ComponentBase
{
    private ProductEntity? _entity { get; set; } = new();
    
    [Parameter]
    public Guid Id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        _entity = await _service.GetProductsAsync(Id);
    }

    private async Task Submit()
    {
        await _service.UpdateAsync(_entity);
        _navigator.NavigateTo("/");
    }
}