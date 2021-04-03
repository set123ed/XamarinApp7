using XamarinAppNative.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinAppNative.ViewModel
{
    public class DeviceOrientationPageViewModel
    {
        public string ButtonText { get; } = "Get Device Orientation";
        public ICommand OrientationCommand { get; }
        public IDeviceOrientationService deviceOrientation;
        public string LabelText { get; set; }
        public string TitleText { get; } = "Device Orientation";

        //public string LabelText { get; set; }
        //public ICommand Orientation;

        //public IDeviceOrientationService orientationdevice;

        public DeviceOrientationPageViewModel(IDeviceOrientationService orientationService)
        {

            LabelText = orientationService.GetOrientation().ToString();
            OrientationCommand = new Command(GetOrientation);
            
        }

        private void GetOrientation()
        {
            LabelText = deviceOrientation.GetOrientation().ToString();
        }
    }
}
