using Blazorise;
using Microsoft.AspNetCore.Components;
using Portfolio.Pages.Shared;

namespace Portfolio.Pages.Projects
{
    public partial class Invoice
    {
        private Tabs _tabsShowcase = null!;

        private Task ShowLightboxOnClick()
        {
            return _tabsShowcase.SelectedTab switch
            {
                "field" => ModalService.Show<Lightbox>(p => p.Add(c => c.ChildContent, _cslField)),
                "ap" => ModalService.Show<Lightbox>(p => p.Add(c => c.ChildContent, _cslAP)),
                "audit" => ModalService.Show<Lightbox>(p => p.Add(c => c.ChildContent, _cslAudit)),
                "sys" => ModalService.Show<Lightbox>(p => p.Add(c => c.ChildContent, _cslSys)),
                _ => Task.CompletedTask
            };
        }

        #region Parameters

        [Inject]
        protected IModalService ModalService { get; private set; } = default!;

        #endregion
    }
}
