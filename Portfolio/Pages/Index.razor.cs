namespace Portfolio.Pages
{
    public partial class Index
    {
        private static readonly DateTime BirthDate = new(1996, 12, 3);
        private int _age;

        protected override void OnInitialized()
        {
            base.OnInitialized();

            _age = (DateTime.Today - BirthDate).Days / 365;
        }
    }
}
