using Template10.Services.NavigationService;

namespace GrooveSandbox
{
    public sealed partial class Shell
    {
        public Shell(INavigationService navigationService)
        {
            this.InitializeComponent();
            Menu.NavigationService = navigationService;
        }
    }
}
