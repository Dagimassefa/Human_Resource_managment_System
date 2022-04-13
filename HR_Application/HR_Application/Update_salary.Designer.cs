
namespace HR_Application
{
    partial class Update_salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_salary));
            this.label6 = new System.Windows.Forms.Label();
            this.txteid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnregisteremp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = " Employee\'s ID";
            // 
            // txteid
            // 
            this.txteid.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteid.Location = new System.Drawing.Point(410, 202);
            this.txteid.Name = "txteid";
            this.txteid.Size = new System.Drawing.Size(574, 32);
            this.txteid.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "New Salary";
            // 
            // txtsalary
            // 
            this.txtsalary.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalary.Location = new System.Drawing.Point(410, 273);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(574, 32);
            this.txtsalary.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(435, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(372, 33);
            this.label7.TabIndex = 27;
            this.label7.Text = "Update Salary Of Employee";
            // 
            // btnregisteremp
            // 
            this.btnregisteremp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregisteremp.Location = new System.Drawing.Point(228, 332);
            this.btnregisteremp.Name = "btnregisteremp";
            this.btnregisteremp.Size = new System.Drawing.Size(230, 59);
            this.btnregisteremp.TabIndex = 28;
            this.btnregisteremp.Text = "Back";
            this.btnregisteremp.UseVisualStyleBackColor = true;
            this.btnregisteremp.Click += new System.EventHandler(this.btnregisteremp_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(496, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 59);
            this.button2.TabIndex = 28;
            this.button2.Text = "Show Employee\'s Salary history";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(749, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 59);
            this.button1.TabIndex = 28;
            this.button1.Text = "Update Salary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update_salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1053, 615);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnregisteremp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txteid);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update_salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Salary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Update_salary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txteid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnregisteremp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}