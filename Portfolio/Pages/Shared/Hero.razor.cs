using Microsoft.AspNetCore.Components;

namespace Portfolio.Pages.Shared
{
    public partial class Hero
    {
        [Parameter, EditorRequired]
        public RenderFragment Title { get; set; } = default!;

        [Parameter]
        public RenderFragment? Subtitle { get; set; }
    }
}
