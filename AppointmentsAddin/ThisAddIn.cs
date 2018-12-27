using AppointmentsAddin.Ribbons;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.ServiceLocation;
using Office = Microsoft.Office.Core;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace AppointmentsAddin
{
    public partial class ThisAddIn
    {
        private Bootstrapper bootstrapper { get; set; }

        public Bootstrapper Bootstrapper { get { return bootstrapper; } }
        
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            bootstrapper = new Bootstrapper();
            bootstrapper.Run();

            Outlook.Application application = this.Application;

            var eventAggregator = ServiceLocator.Current.GetInstance<IEventAggregator>();
            new AddinManager(eventAggregator);
        }

        protected override Office.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            return Globals.Factory.GetRibbonFactory().CreateRibbonManager(
                new Microsoft.Office.Tools.Ribbon.IRibbonExtension[]
                { new AppointmentsRibbon() });
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
