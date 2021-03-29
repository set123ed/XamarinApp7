using System;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Practice_7.Services;
using Xamarin.Forms.Internals;

namespace Practice_7.Droid.Services
{
    public class DependencyServiceDemos
    {
        public DependencyServiceDemos()
        {
        }
    }
    public class DeviceOrientationService : IDeviceOrientationService
    {
        public DeviceOrientation GetOrientation()
        {
            IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

            SurfaceOrientation orientation = windowManager.DefaultDisplay.Rotation;
            bool isLandscape = orientation == SurfaceOrientation.Rotation90 ||
                orientation == SurfaceOrientation.Rotation270;
            return isLandscape ? DeviceOrientation.Landscape : DeviceOrientation.Portrait;
        }
    }
}
