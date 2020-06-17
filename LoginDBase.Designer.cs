using System.Diagnostics;
using System.Drawing;

namespace Login
{
    partial class LoginDBase
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
            this.button = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();

            //
            //button
            //
            this.button.Location = new System.Drawing.Point(200, 40);
            this.button.Size = new System.Drawing.Size(200, 50);
            this.button.Text = "Show the data";
            this.button.Font = new System.Drawing.Font("Courier New", 10F);
            this.button.Click += new System.EventHandler(this.button_Click);
           
            //
            //label
            //
            this.label.Location = new System.Drawing.Point(90,10);
            this.label.Size = new System.Drawing.Size(500,20);
            this.label.Text = "Congrats, you're connected to the Database";
            this.label.Font = new System.Drawing.Font("Courier New", 13F);

            //
            //datagrewview
            //           
            this.datagridview.Location = new System.Drawing.Point(25,100);
            this.datagridview.Size = new System.Drawing.Size(540,300);
            this.datagridview.BackgroundColor = Color.Azure;
            
            // 
            // LoginDBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "LoginDBase";
            this.Text = "LoginDBase";
            this.Load += new System.EventHandler(this.LoginDBase_Load);
            this.ResumeLayout(false);

            this.Controls.Add(this.button);
            this.Controls.Add(this.label);
            this.Controls.Add(this.datagridview);


        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.DataGridView datagridview;
    }
}