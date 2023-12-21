﻿namespace HeronsNest.Screens
{
    public partial class Login : UserControl
    {
        Landing mainForm;

        // Reason why we pass the main form is because
        // need rin natin ng access sa SwitchView (naka-public siya).
        // Very important rin siya so that we can have full control
        // ng main form functions.
        public Login(Landing mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.SwitchView(new Home(mainForm));
        }
    }
}
