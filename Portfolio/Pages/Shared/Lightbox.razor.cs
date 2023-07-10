using Blazorise;
using Microsoft.AspNetCore.Components;

namespace Portfolio.Pages.Shared
{
    public partial class Lightbox
    {
        private Task CloseLightboxOnClick()
        {
            return ModalService.Hide();
        }

        #region Parameters

        [Inject]
        protected IModalService ModalService { get; private set; } = default!;

        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        #endregion
    }
}
