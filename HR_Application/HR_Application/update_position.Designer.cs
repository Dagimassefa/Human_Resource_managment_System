
namespace HR_Application
{
    partial class update_position
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_position));
            this.label6 = new System.Windows.Forms.Label();
            this.txteid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtposition = new System.Windows.Forms.TextBox();
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
            this.label6.Location = new System.Drawing.Point(168, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = " Employee\'s ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txteid
            // 
            this.txteid.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteid.Location = new System.Drawing.Point(325, 191);
            this.txteid.Name = "txteid";
            this.txteid.Size = new System.Drawing.Size(574, 32);
            this.txteid.TabIndex = 32;
            this.txteid.TextChanged += new System.EventHandler(this.txteid_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "New Position";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtposition
            // 
            this.txtposition.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtposition.Location = new System.Drawing.Point(325, 262);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(574, 32);
            this.txtposition.TabIndex = 31;
            this.txtposition.TextChanged += new System.EventHandler(this.txtposition_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(350, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(394, 33);
            this.label7.TabIndex = 33;
            this.label7.Text = "Update Position Of Employee";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnregisteremp
            // 
            this.btnregisteremp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregisteremp.Location = new System.Drawing.Point(126, 338);
            this.btnregisteremp.Name = "btnregisteremp";
            this.btnregisteremp.Size = new System.Drawing.Size(230, 55);
            this.btnregisteremp.TabIndex = 35;
            this.btnregisteremp.Text = "Back";
            this.btnregisteremp.UseVisualStyleBackColor = true;
            this.btnregisteremp.Click += new System.EventHandler(this.btnregisteremp_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(406, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 55);
            this.button2.TabIndex = 35;
            this.button2.Text = "Show Employee\'s Position history";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(678, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 55);
            this.button1.TabIndex = 34;
            this.button1.Text = "Update Position";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // update_position
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 552);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnregisteremp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtposition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txteid);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "update_position";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Position";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txteid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtposition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnregisteremp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}