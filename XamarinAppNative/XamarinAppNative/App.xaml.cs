using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;
using XamarinAppNative.Views;
using XamarinAppNative.ViewModel;


namespace XamarinAppNative
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer = null) : base(platformInitializer) { }

        public Config Contants = new Config();
        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync($"{Config.NavigationPage}/{Config.TabbedPage}");
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>(Config.NavigationPage);
            containerRegistry.RegisterForNavigation<MyTabbedPage>(Config.TabbedPage);
            containerRegistry.RegisterForNavigation<CustomRenderedPage>(Config.CustomRendered);
            containerRegistry.RegisterForNavigation<DeviceOrientationPage>(Config.DeviceOrientationPage);
            containerRegistry.RegisterForNavigation<DeviceOrientationPage,DeviceOrientationPageViewModel>();
        }
    }
}
