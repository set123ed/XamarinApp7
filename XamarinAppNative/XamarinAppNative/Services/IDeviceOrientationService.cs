using System;
using Xamarin.Forms.Internals;

namespace XamarinAppNative.Services
{
    public interface IDeviceOrientationService
    {
        DeviceOrientation GetOrientation();
    }
}
