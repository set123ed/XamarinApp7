using System;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Xamarin.Forms;
using Android.App;
using practica7.Services;
using Xamarin.Forms.Internals;

namespace practica7.Droid
{
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
        //public DeviceOrientationService()
        //{
        //}
    }
}

    


