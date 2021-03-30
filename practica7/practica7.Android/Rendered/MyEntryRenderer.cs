using System;
using Android.Content;
using practica7;
using practica7.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using static practica7.MyEntry;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace practica7.Droid
{
    public class MyEntryRenderer : EntryRenderer
    {
        public MyEntryRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.RosyBrown);
            }
        }
    }
}
