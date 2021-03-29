using Practice_7.iOS.Services;
using Practice_7.Services;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

[assembly: Dependency(typeof(IDeviceOrientationService))]
namespace Practice_7.iOS.Services
{
    public class DependencyServiceDemos : IDeviceOrientationService
    {
        //public DependencyServiceDemos()
        //{
        //}
        public DeviceOrientation GetOrientation()
        {
            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;

            bool isPortrait = orientation == UIInterfaceOrientation.Portrait ||
                orientation == UIInterfaceOrientation.PortraitUpsideDown;
            return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
        }

    }
}
