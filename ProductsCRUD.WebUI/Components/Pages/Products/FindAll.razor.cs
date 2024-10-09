using Microsoft.AspNetCore.Components;
using ProductsCRUD.WebUI.Models;

namespace ProductsCRUD.WebUI.Components.Pages.Products
{
    public partial class FindAll
    {
        private IEnumerable<ProductEntity>? products { get; set; }

        [Parameter]
        public int Page { get; set; }

        private int TotalPages { get; set; }

        protected override async Task OnInitializedAsync()
        {
            products = await _service.GetProductsAsync(Page);
            var totalItems = await _service.CountItemsAsync();
            TotalPages = (int)Math.Ceiling((double)totalItems / 10);
        }

        private List<int> MakePaginator()
        {
            var paginator = new List<int>();

            for (int i = 1; i <= TotalPages; i++)
            {
                paginator.Add(i);
            }

            return paginator;
        }
    }
}
