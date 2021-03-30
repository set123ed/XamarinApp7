using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace practica7
{
    public partial class PlatformSpecificPage : ContentPage
    {
        public PlatformSpecificPage()
        {
            InitializeComponent();

            //var aboveButton = new Xamarin.Forms.Button { Text = "Button Above BoxView - Click Me" };
            //aboveButton.On<Android>().SetElevation(10);

            //Content = new StackLayout
            //{
            //    Children =
            //{
            //    new Grid
            //    {
            //        Children =
            //        {
            //            new Xamarin.Forms.Button { Text = "Button Beneath BoxView" },
            //            new BoxView { Color = Color.Yellow, Opacity = 0.2, HeightRequest = 50 }
            //        }
            //    },
            //    new Grid
            //    {
            //        Margin = new Thickness(0,20,0,0),
            //        Children =
            //        {
            //            aboveButton,
            //            new BoxView { Color = Color.Red, Opacity = 0.2, HeightRequest = 50 }
            //        }
            //    }
            //}
            //};
        }
    }
}
