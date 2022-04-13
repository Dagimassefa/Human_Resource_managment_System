
namespace HR_Application
{
    partial class Employee_reg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_reg));
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_eid = new System.Windows.Forms.TextBox();
            this.combodid = new System.Windows.Forms.ComboBox();
            this.combodname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(312, 44);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(368, 33);
            this.label12.TabIndex = 14;
            this.label12.Text = "Employee registration form";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Employee ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Department ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_eid
            // 
            this.txt_eid.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_eid.Location = new System.Drawing.Point(266, 134);
            this.txt_eid.Margin = new System.Windows.Forms.Padding(5);
            this.txt_eid.Name = "txt_eid";
            this.txt_eid.Size = new System.Drawing.Size(393, 32);
            this.txt_eid.TabIndex = 17;
            this.txt_eid.TextChanged += new System.EventHandler(this.txt_eid_TextChanged);
            // 
            // combodid
            // 
            this.combodid.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combodid.FormattingEnabled = true;
            this.combodid.Location = new System.Drawing.Point(266, 216);
            this.combodid.Name = "combodid";
            this.combodid.Size = new System.Drawing.Size(393, 31);
            this.combodid.TabIndex = 18;
            this.combodid.SelectedIndexChanged += new System.EventHandler(this.combodid_SelectedIndexChanged);
            // 
            // combodname
            // 
            this.combodname.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combodname.FormattingEnabled = true;
            this.combodname.Location = new System.Drawing.Point(266, 288);
            this.combodname.Name = "combodname";
            this.combodname.Size = new System.Drawing.Size(393, 31);
            this.combodname.TabIndex = 18;
            this.combodname.SelectedIndexChanged += new System.EventHandler(this.combodid_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 291);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(156, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Department name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 376);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Position";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 453);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Salary";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 453);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(61, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Salary";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(94, 512);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "Password";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtposition
            // 
            this.txtposition.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtposition.Location = new System.Drawing.Point(266, 367);
            this.txtposition.Margin = new System.Windows.Forms.Padding(5);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(393, 32);
            this.txtposition.TabIndex = 25;
            this.txtposition.TextChanged += new System.EventHandler(this.txtposition_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(266, 444);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(393, 32);
            this.textBox3.TabIndex = 26;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtsalary
            // 
            this.txtsalary.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalary.Location = new System.Drawing.Point(266, 444);
            this.txtsalary.Margin = new System.Windows.Forms.Padding(5);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(393, 32);
            this.txtsalary.TabIndex = 27;
            this.txtsalary.TextChanged += new System.EventHandler(this.txtsalary_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(266, 503);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(393, 32);
            this.txtpassword.TabIndex = 28;
            this.txtpassword.UseSystemPasswordChar = true;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // btnregister
            // 
            this.btnregister.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.Location = new System.Drawing.Point(722, 562);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(237, 44);
            this.btnregister.TabIndex = 29;
            this.btnregister.Text = "Register Employee";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(163, 562);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(237, 44);
            this.btnback.TabIndex = 30;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Employee_reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 650);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtposition);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combodname);
            this.Controls.Add(this.combodid);
            this.Controls.Add(this.txt_eid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employee_reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Employee_reg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_eid;
        private System.Windows.Forms.ComboBox combodid;
        private System.Windows.Forms.ComboBox combodname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtposition;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnback;
    }
}