using System.Threading.Tasks;
using Template10.Common;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;

namespace GrooveSandbox
{
    sealed partial class App
    {
        public App()
        {
            this.InitializeComponent();
        }

        public override Task OnInitializeAsync(IActivatedEventArgs args)
        {
            var nav = NavigationServiceFactory(BackButton.Attach, ExistingContent.Include);
            Window.Current.Content = new Shell(nav);
            return Task.FromResult<object>(null);
        }

        public override Task OnStartAsync(BootStrapper.StartKind startKind, IActivatedEventArgs args)
        {
            NavigationService.Navigate(typeof(Views.MainPage));
            return Task.FromResult<object>(null);
        }
    }
}
