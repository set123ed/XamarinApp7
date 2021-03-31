using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism;
using Prism.Unity;
using Prism.Ioc;
using practica7.ViewModel;

namespace practica7
{
    public partial class App : PrismApplication 
    {
        public App(IPlatformInitializer platformInitializer = null) : base(platformInitializer) { }

        public Config Contants = new Config();

        protected override async  void OnInitialized()
        {
            InitializeComponent();
           //await NavigationService.NavigateAsync($"{Config.NavigationPage}/{Config.MyTabbedPage}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterForNavigation<NavigationPage>(Config.NavigationPage);
            //containerRegistry.RegisterForNavigation<MyTabbedPage>(Config.MyTabbedPage);
            //containerRegistry.RegisterForNavigation<DependecyPage>(Config.DependencyPage);
            //containerRegistry.RegisterForNavigation<EntrySamplePage>(Config.EntrySamplePage);
            //containerRegistry.RegisterForNavigation<MainPage>(Config.MainPage);
            //containerRegistry.RegisterForNavigation<DependecyPage, OrientationViewModel>();
        }
    }
}
