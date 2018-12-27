using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace AppointmentsAddin.Ribbons
{
    public partial class AppointmentsRibbon
    {
        private void tbtnAppointments_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.CustomTaskPanes[0].Visible = ((RibbonToggleButton)sender).Checked;
        }
    }
}
