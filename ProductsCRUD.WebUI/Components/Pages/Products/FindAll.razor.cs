using Microsoft.AspNetCore.Components;
using ProductsCRUD.WebUI.Models;

namespace ProductsCRUD.WebUI.Components.Pages.Products
{
    public partial class FindAll
    {
        private IEnumerable<ProductEntity>? products { get; set; }

        [Parameter]
        public int Page { get; set; }

        protected override async Task OnInitializedAsync()
        {
            products = await _service.GetProductsAsync(Page);
        }
    }
}
