using System;
using practica7.Services;
using Prism.Commands;
using Xamarin.Forms;

namespace practica7.ViewModel
{
    class OrientationViewModel
    {
        public DelegateCommand Orientation { get; set; }
        public string orientate { get; set; }

        public OrientationViewModel()
        {

            //Orientation = new DelegateCommand(() => {
            //    DependencyService.Get<IDeviceOrientationService>().GetOrientation();

            //});
        }
    }
}
