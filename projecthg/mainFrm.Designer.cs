namespace projecthg
{
    partial class ınternship
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
            this.firmname = new System.Windows.Forms.Label();
            this.websiteaddress = new System.Windows.Forms.Label();
            this.cityoffirm = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.endinngdateofınternship = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // firmname
            // 
            this.firmname.AutoSize = true;
            this.firmname.Location = new System.Drawing.Point(12, 21);
            this.firmname.Name = "firmname";
            this.firmname.Size = new System.Drawing.Size(57, 13);
            this.firmname.TabIndex = 0;
            this.firmname.Text = "Firm Name";
            // 
            // websiteaddress
            // 
            this.websiteaddress.AutoSize = true;
            this.websiteaddress.Location = new System.Drawing.Point(12, 57);
            this.websiteaddress.Name = "websiteaddress";
            this.websiteaddress.Size = new System.Drawing.Size(87, 13);
            this.websiteaddress.TabIndex = 1;
            this.websiteaddress.Text = "Website Address";
            // 
            // cityoffirm
            // 
            this.cityoffirm.AutoSize = true;
            this.cityoffirm.Location = new System.Drawing.Point(12, 92);
            this.cityoffirm.Name = "cityoffirm";
            this.cityoffirm.Size = new System.Drawing.Size(58, 13);
            this.cityoffirm.TabIndex = 2;
            this.cityoffirm.Text = "City of Firm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Starting Date of Internship";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(460, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // endinngdateofınternship
            // 
            this.endinngdateofınternship.AutoSize = true;
            this.endinngdateofınternship.Location = new System.Drawing.Point(494, 67);
            this.endinngdateofınternship.Name = "endinngdateofınternship";
            this.endinngdateofınternship.Size = new System.Drawing.Size(127, 13);
            this.endinngdateofınternship.TabIndex = 8;
            this.endinngdateofınternship.Text = "Ending Date of Internship";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(460, 92);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // ınternship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 518);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.endinngdateofınternship);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cityoffirm);
            this.Controls.Add(this.websiteaddress);
            this.Controls.Add(this.firmname);
            this.Name = "ınternship";
            this.Text = "Internship";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firmname;
        private System.Windows.Forms.Label websiteaddress;
        private System.Windows.Forms.Label cityoffirm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label endinngdateofınternship;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}

