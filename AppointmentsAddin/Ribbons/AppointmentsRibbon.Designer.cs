﻿namespace AppointmentsAddin.Ribbons
{
    partial class AppointmentsRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public AppointmentsRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.gAppointments = this.Factory.CreateRibbonGroup();
            this.tbtnAppointments = this.Factory.CreateRibbonToggleButton();
            this.tab1.SuspendLayout();
            this.gAppointments.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.gAppointments);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // gAppointments
            // 
            this.gAppointments.Items.Add(this.tbtnAppointments);
            this.gAppointments.Label = "Appintments";
            this.gAppointments.Name = "gAppointments";
            // 
            // tbtnAppointments
            // 
            this.tbtnAppointments.Image = global::AppointmentsAddin.Properties.Resources.Microsoft_Outlook_2010_icon;
            this.tbtnAppointments.Label = "Appointments";
            this.tbtnAppointments.Name = "tbtnAppointments";
            this.tbtnAppointments.ShowImage = true;
            this.tbtnAppointments.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.tbtnAppointments_Click);
            // 
            // AppointmentsRibbon
            // 
            this.Name = "AppointmentsRibbon";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tab1);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.gAppointments.ResumeLayout(false);
            this.gAppointments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup gAppointments;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton tbtnAppointments;
    }

    partial class ThisRibbonCollection
    {
        internal AppointmentsRibbon AppointmentsRibbon
        {
            get { return this.AppointmentsRibbon; }
        }
    }
}
