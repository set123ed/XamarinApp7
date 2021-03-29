using System;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism;
using Prism.Ioc;
using Practice_7.Views;

using Prism.Navigation;


namespace Practice_7
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer plaformInitializer = null) : base(plaformInitializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
             await NavigationService.NavigateAsync("DependencyServicePage");
        }

       

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<DependencyServicePage>();
            //containerRegistry.RegisterForNavigation<DependencyServicePage, DependencyServiceViewModel>();
        }

        //protected override void OnStart()
        //{
        //}

        //protected override void OnSleep()
        //{
        //}

        //protected override void OnResume()
        //{
        //}
    }
}
