using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;



[assembly: ExportEffect(typeof(practica7.Droid.FocusEffect), nameof(practica7.Droid.FocusEffect))]
[assembly: ResolutionGroupName("MyCompany")]
namespace practica7.Droid
{
    
        public class FocusEffect : PlatformEffect
        {
            Android.Graphics.Color originalBackgroundColor = new Android.Graphics.Color(0, 0, 0, 0);
            Android.Graphics.Color backgroundColor;

            protected override void OnAttached()
            {
                try
                {
                    backgroundColor = Android.Graphics.Color.LightBlue;
                    Control.SetBackgroundColor(backgroundColor);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
                }
            }

            protected override void OnDetached()
            {
            }

            protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
            {
                base.OnElementPropertyChanged(args);
                try
                {
                    if (args.PropertyName == "IsFocused")
                    {
                        if (((Android.Graphics.Drawables.ColorDrawable)Control.Background).Color == backgroundColor)
                        {
                            Control.SetBackgroundColor(originalBackgroundColor);
                        }
                        else
                        {
                            Control.SetBackgroundColor(backgroundColor);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
                }
            }
        }
    
}
