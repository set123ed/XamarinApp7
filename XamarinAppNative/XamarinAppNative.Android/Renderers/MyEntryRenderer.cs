using System;
using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinAppNative.Droid.CustomRendered;
using XamarinAppNative.Rendered;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace XamarinAppNative.Droid.CustomRendered
{
    class MyEntryRenderer : EntryRenderer
    {
        public MyEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.LightBlue);
            }
        }
    }
}
