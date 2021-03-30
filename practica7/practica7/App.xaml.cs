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
        

        protected override async  void OnInitialized()
        {
            InitializeComponent();
           await NavigationService.NavigateAsync("MyTabbedPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MyTabbedPage>();
            containerRegistry.RegisterForNavigation<DependecyPage, OrientationViewModel>();
        }
    }
}
