using Microsoft.AspNetCore.Components;

namespace Portfolio.Pages.Shared
{
    public partial class Section
    {
        [Parameter]
        public RenderFragment Title { get; set; } = default!;

        [Parameter]
        public RenderFragment? Content { get; set; }
    }
}
