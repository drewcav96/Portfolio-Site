namespace Portfolio.Pages.Shared
{
    public partial class MainLayout
    {
        private bool _isActive = false;

        protected string NavbarActiveCssClass
        {
            get =>
                _isActive
                    ? "is-active"
                    : string.Empty;
        }

        private void NavbarBurgerOnClick()
        {
            _isActive = !_isActive;
        }
    }
}
