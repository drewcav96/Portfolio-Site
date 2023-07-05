using Blazorise;

namespace Portfolio
{
    public partial class App
    {
        private readonly Theme _theme = new()
        {
            BackgroundOptions = new()
            {
                Body = "#000000"
            },
            BarOptions = new()
            {                
                DarkColors = new()
                {
                    //BackgroundColor = "#191919",
                    Color = "#f4f4f4",
                    DropdownColorOptions = new()
                    {
                        BackgroundColor = "#191919"
                    },
                    ItemColorOptions = new()
                    {
                        ActiveBackgroundColor = "#3f3f3f",
                        ActiveColor = "#f4f4f4",
                        HoverBackgroundColor = "#545454",
                        HoverColor = "#ffffff"
                    }
                }
            },
            BodyOptions = new()
            {
                TextColor = "#f4f4f4"
            },
            ColorOptions = new()
            {
                Primary = "#0062b2",
                Info = "#00708c",
                Success = "#769231",
                Warning = "#ef601f",
                Danger = "#97002e",
                Secondary = "#751269"
            },
            IsGradient = true
        };
    }
}
