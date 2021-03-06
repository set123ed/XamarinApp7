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
            NavigationService.NavigateAsync($"{Config.HomePage}");
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>(Config.NavigationPage);
            //containerRegistry.RegisterForNavigation<MyTabbedPage>(Config.TabbedPage);
            containerRegistry.RegisterForNavigation<HomePage,HomeViewModel>(Config.HomePage);
            containerRegistry.RegisterForNavigation<DevicePage>(Config.DevicePage);
            containerRegistry.RegisterForNavigation<FocusPage>(Config.FocusPage);
            containerRegistry.RegisterForNavigation<PlatformPage>(Config.PlatformPage);
            containerRegistry.RegisterForNavigation<DevicePage, DeviceOrientationPageViewModel>();
        }
    }
}
