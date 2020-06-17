using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;

namespace Login
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();

            //Buttons
            this.LoginButton = new System.Windows.Forms.Button();
            this.CancellButton = new System.Windows.Forms.Button();
            this.Clear1Button = new System.Windows.Forms.Button();
            this.Clear2Button = new System.Windows.Forms.Button();
            this.Clear3Button = new System.Windows.Forms.Button();
            this.Clear4Button = new System.Windows.Forms.Button();

            //Labels
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Phonenumber = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();

            //Textboxes
            this.Tboxname = new System.Windows.Forms.TextBox();
            this.Tboxpass = new System.Windows.Forms.TextBox();
            this.Tboxpnumber = new System.Windows.Forms.TextBox();
            this.Tboxloc = new System.Windows.Forms.TextBox();
       
            //
            //button Login
            //
            this.LoginButton.Location = new System.Drawing.Point(150, 255);
            this.LoginButton.Size = new System.Drawing.Size(100, 50);
            this.LoginButton.Text = " ✔ ";
           this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);

            //
            //button Cancell
            //
            this.CancellButton.Location = new System.Drawing.Point(250, 255);
            this.CancellButton.Size = new System.Drawing.Size(100, 50);
            this.CancellButton.Text = " ❌ ";
            this.CancellButton.Click += new System.EventHandler(this.CancellButton_Click);

            //
            //button Clear1
            //
            this.Clear1Button.Location = new System.Drawing.Point(350,100);
            this.Clear1Button.Size = new System.Drawing.Size(80,30);
            this.Clear1Button.Text = " ◁ ";
            this.Clear1Button.Click += new System.EventHandler(this.Clear1_Click);

            //
            //button Clear2
            //
            this.Clear2Button.Location = new System.Drawing.Point(350, 140);
            this.Clear2Button.Size = new System.Drawing.Size(80, 30);
            this.Clear2Button.Text = " ◁ ";
            this.Clear2Button.Click += new System.EventHandler(this.Clear2_Click);

            //
            //button Clear3
            //
            this.Clear3Button.Location = new System.Drawing.Point(350, 180);
            this.Clear3Button.Size = new System.Drawing.Size(80, 30);
            this.Clear3Button.Text = " ◁ ";
            this.Clear3Button.Click += new System.EventHandler(this.Clear3_Click);

            //
            //button Clear4
            //
            this.Clear4Button.Location = new System.Drawing.Point(350, 220);
            this.Clear4Button.Size = new System.Drawing.Size(80, 30);
            this.Clear4Button.Text = " ◁ ";
            this.Clear4Button.Click += new System.EventHandler(this.Clear4_Click);

            //
            //textbox username
            //
            this.Tboxname.Location = new System.Drawing.Point(150,100);
            this.Tboxname.Size = new System.Drawing.Size(200,30);
            this.Tboxname.Multiline = MultilineStringConverter.Equals(1, 1);
            this.Tboxname.Font = new System.Drawing.Font("Courier New", 13F);

            //
            //textbox password
            //
            this.Tboxpass.Location = new System.Drawing.Point(150,140);
            this.Tboxpass.Size = new System.Drawing.Size(200,30);
            this.Tboxpass.Multiline = MultilineStringConverter.Equals(1, 1);
            this.Tboxpass.Font = new System.Drawing.Font("Courier New", 13F);

            //
            //textbox phone number
            //
            this.Tboxpnumber.Location = new System.Drawing.Point(150, 180);
            this.Tboxpnumber.Size = new System.Drawing.Size(200, 30);
            this.Tboxpnumber.Multiline = MultilineStringConverter.Equals(1, 1);
            this.Tboxpnumber.Font = new System.Drawing.Font("Courier New", 13F);

            //
            //textbox location
            //
            this.Tboxloc.Location = new System.Drawing.Point(150, 220);
            this.Tboxloc.Size = new System.Drawing.Size(200, 30);
            this.Tboxloc.Multiline = MultilineStringConverter.Equals(1, 1);
            this.Tboxloc.Font = new System.Drawing.Font("Courier New", 13F);

            //
            //label username
            //
            this.Username.Location = new System.Drawing.Point(50,105);
            this.Username.Size = new System.Drawing.Size(100, 30);
            this.Username.Text = "Username ";
            this.Username.Font = new System.Drawing.Font("Courier New", 13F);

            //
            //label password
            //
            this.Password.Location = new System.Drawing.Point(50,145);
            this.Password.Size = new System.Drawing.Size(100,30);
            this.Password.Text = "Password";
            this.Password.Font = new System.Drawing.Font("Courier New", 13F);

            //
            //label phone number
            //
            this.Phonenumber.Location = new System.Drawing.Point(50, 185);
            this.Phonenumber.Size = new System.Drawing.Size(100, 30);
            this.Phonenumber.Text = "P.Number";
            this.Phonenumber.Font = new System.Drawing.Font("Courier New", 13F);

            //
            //label location
            //
            this.location.Location = new System.Drawing.Point(50,225);
            this.location.Size = new System.Drawing.Size(100,30);
            this.location.Text = "Location";
            this.location.Font = new System.Drawing.Font("Courier New", 13F);

            // 
            //LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.ShowIcon = false;
            
            //buttons
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.CancellButton);
            this.Controls.Add(this.Clear1Button);
            this.Controls.Add(this.Clear2Button);
            this.Controls.Add(this.Clear3Button);
            this.Controls.Add(this.Clear4Button);
            //labels
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Phonenumber);
            this.Controls.Add(this.location);
            //textboxes
            this.Controls.Add(this.Tboxname);
            this.Controls.Add(this.Tboxpass);
            this.Controls.Add(this.Tboxpnumber);
            this.Controls.Add(this.Tboxloc);
          

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button CancellButton;
        private System.Windows.Forms.Button Clear1Button;
        private System.Windows.Forms.Button Clear2Button;
        private System.Windows.Forms.Button Clear3Button;
        private System.Windows.Forms.Button Clear4Button;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Phonenumber;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.TextBox Tboxname;
        private System.Windows.Forms.TextBox Tboxpass;
        private System.Windows.Forms.TextBox Tboxpnumber;
        private System.Windows.Forms.TextBox Tboxloc;

    }
}