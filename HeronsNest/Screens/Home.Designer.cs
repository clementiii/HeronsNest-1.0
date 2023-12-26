﻿namespace HeronsNest.Screens
{
    partial class Home
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
            leftNavBar1 = new Components.LeftNavBar();
            label1 = new Label();
            categoryListView = new Components.List.CustomListView();
            homeSection2 = new Components.Home.HomeSection();
            homeSection1 = new Components.Home.HomeSection();
            categoryListView.SuspendLayout();
            SuspendLayout();
            // 
            // leftNavBar1
            // 
            leftNavBar1.AutoSize = true;
            leftNavBar1.BackColor = Color.White;
            leftNavBar1.Location = new Point(0, 0);
            leftNavBar1.Name = "leftNavBar1";
            leftNavBar1.Size = new Size(200, 600);
            leftNavBar1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(215, 82);
            label1.Name = "label1";
            label1.Size = new Size(267, 37);
            label1.TabIndex = 22;
            label1.Text = "Good Morning, User!";
            // 
            // categoryListView
            // 
            categoryListView.Anchor = AnchorStyles.None;
            categoryListView.AutoScroll = true;
            categoryListView.Controls.Add(homeSection2);
            categoryListView.Controls.Add(homeSection1);
            categoryListView.DataSource = null;
            categoryListView.FlowDirection = FlowDirection.TopDown;
            categoryListView.Location = new Point(215, 128);
            categoryListView.Name = "categoryListView";
            categoryListView.Size = new Size(769, 451);
            categoryListView.TabIndex = 24;
            categoryListView.WrapContents = false;
            // 
            // homeSection2
            // 
            homeSection2.Location = new Point(3, 3);
            homeSection2.Name = "homeSection2";
            homeSection2.Size = new Size(773, 251);
            homeSection2.TabIndex = 24;
            // 
            // homeSection1
            // 
            homeSection1.Location = new Point(3, 260);
            homeSection1.Name = "homeSection1";
            homeSection1.Size = new Size(773, 251);
            homeSection1.TabIndex = 25;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(categoryListView);
            Controls.Add(label1);
            Controls.Add(leftNavBar1);
            Name = "Home";
            Size = new Size(1000, 600);
            Load += Home_Load_1;
            categoryListView.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Components.LeftNavBar leftNavBar1;
        private Label label1;
        private Components.List.CustomListView categoryListView;
        private Components.Home.HomeSection homeSection2;
        private Components.Home.HomeSection homeSection1;
    }
}
