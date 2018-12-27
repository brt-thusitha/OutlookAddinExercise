using Microsoft.Practices.ServiceLocation;
using OutlookAddin.Module.Appointments.ViewModels;
using OutlookAddin.Module.Appointments.Views;
using System.Windows.Controls;

namespace AppointmentsAddin
{
    public class AddinShellViewModel
    {
        private TitleViewModel titleViewModel;

        public UserControl TitleRegion { get; set; }


        public AddinShellViewModel()
        {
            titleViewModel = ServiceLocator.Current.GetInstance<TitleViewModel>();
            titleViewModel.Title = "Add-in Title";
            TitleRegion = new TitleView(titleViewModel);

        }
    }
}
