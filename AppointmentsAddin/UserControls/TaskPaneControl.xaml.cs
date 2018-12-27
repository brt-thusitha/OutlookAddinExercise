using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppointmentsAddin.UserControls
{
    /// <summary>
    /// Interaction logic for TaskPaneControl.xaml
    /// </summary>
    public partial class TaskPaneControl : UserControl
    {
        public TaskPaneControl()
        {
            InitializeComponent();
        }

        public void SetChild(UserControl wpfView)
        {
            this.AddChild(wpfView);
        }
    }
}
