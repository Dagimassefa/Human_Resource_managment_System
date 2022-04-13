
namespace HR_Application
{
    partial class change_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(change_password));
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtold = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnew = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtverify = new System.Windows.Forms.TextBox();
            this.btnmlogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(187, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 23);
            this.label6.TabIndex = 32;
            this.label6.Text = "Old Password";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Enter Your ID";
            this.label3.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtold
            // 
            this.txtold.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtold.Location = new System.Drawing.Point(319, 148);
            this.txtold.Name = "txtold";
            this.txtold.Size = new System.Drawing.Size(600, 32);
            this.txtold.TabIndex = 33;
            this.txtold.UseSystemPasswordChar = true;
            this.txtold.TextChanged += new System.EventHandler(this.txtold_TextChanged);
            this.txtold.Leave += new System.EventHandler(this.txtold_Leave);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(319, 81);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(600, 32);
            this.txtid.TabIndex = 33;
            this.txtid.TextChanged += new System.EventHandler(this.txtold_TextChanged);
            this.txtid.Leave += new System.EventHandler(this.txtold_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(358, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 33);
            this.label7.TabIndex = 34;
            this.label7.Text = "Change Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "New Password";
            // 
            // txtnew
            // 
            this.txtnew.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnew.Location = new System.Drawing.Point(155, 47);
            this.txtnew.Name = "txtnew";
            this.txtnew.Size = new System.Drawing.Size(513, 32);
            this.txtnew.TabIndex = 39;
            this.txtnew.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Verify Password";
            // 
            // txtverify
            // 
            this.txtverify.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtverify.Location = new System.Drawing.Point(155, 108);
            this.txtverify.Name = "txtverify";
            this.txtverify.Size = new System.Drawing.Size(513, 32);
            this.txtverify.TabIndex = 38;
            this.txtverify.UseSystemPasswordChar = true;
            // 
            // btnmlogin
            // 
            this.btnmlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnmlogin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmlogin.ForeColor = System.Drawing.Color.White;
            this.btnmlogin.Location = new System.Drawing.Point(466, 164);
            this.btnmlogin.Name = "btnmlogin";
            this.btnmlogin.Size = new System.Drawing.Size(193, 50);
            this.btnmlogin.TabIndex = 41;
            this.btnmlogin.Text = "Confirm";
            this.btnmlogin.UseVisualStyleBackColor = false;
            this.btnmlogin.Click += new System.EventHandler(this.btnmlogin_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(46, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 50);
            this.button1.TabIndex = 40;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnmlogin);
            this.panel1.Controls.Add(this.txtverify);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtnew);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(191, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 260);
            this.panel1.TabIndex = 36;
            this.panel1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(921, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 50);
            this.button2.TabIndex = 41;
            this.button2.Text = "Verify";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Red;
            this.btnback.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(5, 186);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(180, 50);
            this.btnback.TabIndex = 42;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.button3_Click);
            // 
            // change_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1135, 618);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtold);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "change_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.change_password_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtold;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtverify;
        private System.Windows.Forms.Button btnmlogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnback;
    }
}