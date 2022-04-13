
namespace HR_Application
{
    partial class Employee_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmuser = new System.Windows.Forms.TextBox();
            this.txtmpass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnmlogin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.labelError);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtmuser);
            this.panel1.Controls.Add(this.txtmpass);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnmlogin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(388, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 392);
            this.panel1.TabIndex = 28;
            // 
            // labelError
            // 
            this.labelError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Black;
            this.labelError.Location = new System.Drawing.Point(238, 337);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(254, 20);
            this.labelError.TabIndex = 34;
            this.labelError.Text = "Wrong Username Or Password";
            this.labelError.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(270, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 33);
            this.label7.TabIndex = 33;
            this.label7.Text = "Employee Login";
            // 
            // txtmuser
            // 
            this.txtmuser.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmuser.Location = new System.Drawing.Point(193, 123);
            this.txtmuser.Name = "txtmuser";
            this.txtmuser.Size = new System.Drawing.Size(444, 32);
            this.txtmuser.TabIndex = 31;
            // 
            // txtmpass
            // 
            this.txtmpass.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmpass.Location = new System.Drawing.Point(193, 202);
            this.txtmpass.Name = "txtmpass";
            this.txtmpass.Size = new System.Drawing.Size(444, 32);
            this.txtmpass.TabIndex = 32;
            this.txtmpass.UseSystemPasswordChar = true;
            this.txtmpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmpass_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Username";
            // 
            // btnmlogin
            // 
            this.btnmlogin.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnmlogin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmlogin.ForeColor = System.Drawing.Color.White;
            this.btnmlogin.Location = new System.Drawing.Point(272, 273);
            this.btnmlogin.Name = "btnmlogin";
            this.btnmlogin.Size = new System.Drawing.Size(193, 50);
            this.btnmlogin.TabIndex = 30;
            this.btnmlogin.Text = "Login";
            this.btnmlogin.UseVisualStyleBackColor = false;
            this.btnmlogin.Click += new System.EventHandler(this.btnmlogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Password";
            // 
            // Employee_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employee_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmuser;
        private System.Windows.Forms.TextBox txtmpass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnmlogin;
        private System.Windows.Forms.Label label5;
    }
}