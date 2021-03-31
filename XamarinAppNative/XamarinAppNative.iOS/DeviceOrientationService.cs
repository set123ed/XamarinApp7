using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using XamarinAppNative.Services;
using XamarinAppNative.iOS;

[assembly: Dependency(typeof(DeviceOrientationService))]
namespace XamarinAppNative.iOS
{
    public class DeviceOrientationService : IDeviceOrientationService
    {
        public DeviceOrientation GetOrientation()
        {
            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;

            bool isPortrait = orientation == UIInterfaceOrientation.Portrait ||
                orientation == UIInterfaceOrientation.PortraitUpsideDown;
            return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
        }
        //public DeviceOrientationService()
        //{
        //}
    }
}
