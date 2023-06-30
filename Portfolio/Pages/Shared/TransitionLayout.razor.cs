namespace Portfolio.Pages.Shared
{
    public partial class TransitionLayout
    {
        private string GetTransitioningCssClass()
        {
            return Transition.FirstRender
                ? string.Empty
                : $"{GetAnimationName()} animate__faster animate__animated";
        }

        private string GetTransitionedCssClass()
        {
            return Transition.IntoView
                ? "transitioned"
                : "transitioned_behind";
        }

        internal string GetAnimationName()
        {
            if (Transition.IntoView)
            {
                if (Transition.Backwards)
                {
                    return "animate__fadeInRight";
                }
                return "animate__fadeInLeft";
            }
            else if (Transition.Backwards)
            {
                return "animate__fadeOutLeft";
            }
            return "animate__fadeOutRight";
        }
    }
}
