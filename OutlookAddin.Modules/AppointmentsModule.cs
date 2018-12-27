using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using OutlookAddin.Infrastructure.Constants;
using OutlookAddin.Module.Appointments.ViewModels;

namespace OutlookAddin.Module.Appointments
{
    public class AppointmentsModule : IModule
    {
        private readonly IRegionManager regionManager;
        private readonly IUnityContainer container;

        public AppointmentsModule(IUnityContainer container, IRegionManager regionManager)
        {
            this.container = container;
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            this.regionManager.RegisterViewWithRegion(RegionNames.TitleRegion, () => container.Resolve<TitleViewModel>());
        }
    }
}