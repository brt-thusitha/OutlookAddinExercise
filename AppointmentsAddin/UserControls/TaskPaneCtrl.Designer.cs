﻿namespace AppointmentsAddin.UserControls
{
    partial class TaskPaneCtrl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.WpfHost = new System.Windows.Forms.Integration.ElementHost();
            this.SuspendLayout();
            // 
            // WpfHost
            // 
            this.WpfHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WpfHost.Location = new System.Drawing.Point(0, 0);
            this.WpfHost.Name = "WpfHost";
            this.WpfHost.Size = new System.Drawing.Size(150, 150);
            this.WpfHost.TabIndex = 0;
            this.WpfHost.Text = "WpfHost";
            this.WpfHost.Child = null;
            // 
            // TaskPaneCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WpfHost);
            this.Name = "TaskPaneCtrl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost WpfHost;
    }
}
