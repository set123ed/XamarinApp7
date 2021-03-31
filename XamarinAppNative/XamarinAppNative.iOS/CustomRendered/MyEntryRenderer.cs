using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinAppNative.iOS.CustomRendered;
using XamarinAppNative.Rendered;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace XamarinAppNative.iOS.CustomRendered
{
	public class MyEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				// do whatever you want to the UITextField here!
				Control.BackgroundColor = UIColor.FromRGBA(0, 0, 1, 1);
				Control.BorderStyle = UITextBorderStyle.Line;
			}
		}
	}
}
