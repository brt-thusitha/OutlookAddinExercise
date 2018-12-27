using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppointmentsAddin.UserControls
{
    public partial class TaskPaneCtrl : UserControl
    {
        public TaskPaneCtrl()
        {
            InitializeComponent();
        }

        public void SetChild(System.Windows.Controls.UserControl wpfView)
        {
            this.WpfHost.Child = wpfView;
        }
    }
}
