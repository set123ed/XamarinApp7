using System;
using System.ComponentModel;
using practica7.Services;
using Prism.Commands;
using Xamarin.Forms;
using Prism.Commands;
using Prism.Mvvm;
using Prism;
using System.Windows.Input;

namespace practica7.ViewModel
{
    public class OrientationViewModel : INotifyPropertyChanged

    {

        //public ICommand Orientation { get; }

        //public string LabelText { get; set; }
        ////public IDeviceOrientationService deviceOrientation { get; }
        //public IDeviceOrientationService orientationService;

        public event PropertyChangedEventHandler PropertyChanged;

        //public OrientationViewModel(IDeviceOrientationService orientation)
        //{
        //    Orientation = new Command(GetOrientation);
        //}

        //public void GetOrientation()
        //{
        //    orientationService.GetOrientation();
        //    LabelText = orientationService.GetOrientation().ToString();
        //}

        //public event PropertyChangedEventHandler PropertyChanged;
        //public OrientationViewModel(IDeviceOrientationService orientationService)
        //{
        //    deviceOrientation = orientationService;
        //    var orientation = deviceOrientation.GetOrientation();
        //    LabelText = orientation.ToString();
        //    Orientation = new Command(GetOrientationPage);
        //}

        //private void GetOrientationPage()
        //{
        //    var orientation = deviceOrientation.GetOrientation();
        //    LabelText = orientation.ToString();
        //}

    }
}
