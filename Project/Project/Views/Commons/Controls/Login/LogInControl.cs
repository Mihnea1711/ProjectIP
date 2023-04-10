﻿using System;
using System.Windows.Forms;

namespace Project.Controls
{
    public partial class LogInControl : UserControl
    {
        public LogInControl()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();

            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();

            ((Form)this.TopLevelControl).Close();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            this.panelLogIn.Controls.Clear();
            SignUpControl signUpControl = new SignUpControl();

            this.panelLogIn.Controls.Add(signUpControl);
        }
    }
}