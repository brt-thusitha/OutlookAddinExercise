using AppointmentsAddin.UserControls;
using Microsoft.Office.Tools;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.ServiceLocation;
using System;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace AppointmentsAddin
{
    public class AddinManager
    {
        private IEventAggregator EventAggregator;
        private AddinShellViewModel ShellViewModel;
        private AddinShell addinShell;
        private TaskPaneCtrl appointmentsTaskPaneControl;

        private Outlook.Folder olAppointmentsFolder = null;

        private AddinShell AddinShell
        {
            get
            {
                if (addinShell == null)
                {
                    ShellViewModel = ServiceLocator.Current.GetInstance<AddinShellViewModel>();                    
                    addinShell = new AddinShell(ShellViewModel);
                }
                return addinShell;
            }
        }

        protected CustomTaskPane CustomTaskPane { get; private set; }

        public AddinManager(IEventAggregator eventAggregator)
        {
            EventAggregator = eventAggregator;
            
            Outlook.Application oApp = new Outlook.Application();
            olAppointmentsFolder = (Outlook.Folder)oApp.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderCalendar);

            CreateTaskPane();
        }

        protected void CreateTaskPane()
        {
            appointmentsTaskPaneControl = new TaskPaneCtrl();
            appointmentsTaskPaneControl.SetChild(AddinShell);

            //taskPaneControl = new TaskPaneControl();
            //taskPaneControl.SetChild(AddinShell);

            CustomTaskPane = Globals.ThisAddIn.CustomTaskPanes.Add(appointmentsTaskPaneControl, "Outlook Addin - Appointments");
            
            CustomTaskPane.VisibleChanged += new EventHandler(TaskPaneValue_VisibleChanged);
            CustomTaskPane.Visible = true;

            //CustomTaskPane.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionFloating;
            //CustomTaskPane.Height = 500;
            //CustomTaskPane.Width = 250;          

        }

        private void TaskPaneValue_VisibleChanged(object sender, System.EventArgs e)
        {
            //Globals.Ribbons.GetRibbon<AppointmentsRibbon>().tbtnAppointments.Checked = appointmentsTaskPaneControl.Visible;
        }

    }
}
