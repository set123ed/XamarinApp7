using System;
using System.Windows.Input;
using Prism.Commands;
using Xamarin.Forms;
using XamarinAppNative.Services;
namespace XamarinAppNative.ViewModel
{
    public class DeviceOrientationPageViewModel
    {
        public string ButtonText { get; } = "Get Device Orientation";
        //public string LabelText { get; set; }
        //public ICommand Orientation;

        //public IDeviceOrientationService orientationdevice;

        //public DeviceOrientationPageViewModel()
        //{

        //    Orientation = new Command(GetOrientation);

        //}

        //private void GetOrientation()
        //{
        //    var orientation = orientationdevice.GetOrientation();
        //    LabelText = orientation.ToString();
        //}
    }
}
