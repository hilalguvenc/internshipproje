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
            this.textFirmName = new System.Windows.Forms.TextBox();
            this.textWebSite = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateStartingInternship = new System.Windows.Forms.DateTimePicker();
            this.endinngdateofınternship = new System.Windows.Forms.Label();
            this.dateEndingInternship = new System.Windows.Forms.DateTimePicker();
            this.dateStartingDepartment = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textNameSurname = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.NameSurname = new System.Windows.Forms.Label();
            this.checkBoxCourses = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxWorkshop = new System.Windows.Forms.CheckBox();
            this.checkBoxSaturday = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.buttonfinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firmname
            // 
            this.firmname.AutoSize = true;
            this.firmname.Location = new System.Drawing.Point(89, 186);
            this.firmname.Name = "firmname";
            this.firmname.Size = new System.Drawing.Size(57, 13);
            this.firmname.TabIndex = 0;
            this.firmname.Text = "Firm Name";
            // 
            // websiteaddress
            // 
            this.websiteaddress.AutoSize = true;
            this.websiteaddress.Location = new System.Drawing.Point(89, 222);
            this.websiteaddress.Name = "websiteaddress";
            this.websiteaddress.Size = new System.Drawing.Size(87, 13);
            this.websiteaddress.TabIndex = 1;
            this.websiteaddress.Text = "Website Address";
            // 
            // cityoffirm
            // 
            this.cityoffirm.AutoSize = true;
            this.cityoffirm.Location = new System.Drawing.Point(89, 257);
            this.cityoffirm.Name = "cityoffirm";
            this.cityoffirm.Size = new System.Drawing.Size(58, 13);
            this.cityoffirm.TabIndex = 2;
            this.cityoffirm.Text = "City of Firm";
            // 
            // textFirmName
            // 
            this.textFirmName.Location = new System.Drawing.Point(196, 177);
            this.textFirmName.Name = "textFirmName";
            this.textFirmName.Size = new System.Drawing.Size(100, 20);
            this.textFirmName.TabIndex = 3;
            this.textFirmName.TextChanged += new System.EventHandler(this.firmNameChanged);
            // 
            // textWebSite
            // 
            this.textWebSite.Location = new System.Drawing.Point(196, 215);
            this.textWebSite.Name = "textWebSite";
            this.textWebSite.Size = new System.Drawing.Size(100, 20);
            this.textWebSite.TabIndex = 4;
            this.textWebSite.TextChanged += new System.EventHandler(this.WebChanged);
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(196, 254);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(100, 20);
            this.textCity.TabIndex = 5;
            this.textCity.TextChanged += new System.EventHandler(this.CityChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Starting Date of Internship";
            // 
            // dateStartingInternship
            // 
            this.dateStartingInternship.Location = new System.Drawing.Point(96, 82);
            this.dateStartingInternship.Name = "dateStartingInternship";
            this.dateStartingInternship.Size = new System.Drawing.Size(200, 20);
            this.dateStartingInternship.TabIndex = 7;
            this.dateStartingInternship.ValueChanged += new System.EventHandler(this.StartingDateIntChanged);
            // 
            // endinngdateofınternship
            // 
            this.endinngdateofınternship.AutoSize = true;
            this.endinngdateofınternship.Location = new System.Drawing.Point(131, 118);
            this.endinngdateofınternship.Name = "endinngdateofınternship";
            this.endinngdateofınternship.Size = new System.Drawing.Size(127, 13);
            this.endinngdateofınternship.TabIndex = 8;
            this.endinngdateofınternship.Text = "Ending Date of Internship";
            // 
            // dateEndingInternship
            // 
            this.dateEndingInternship.Location = new System.Drawing.Point(96, 134);
            this.dateEndingInternship.Name = "dateEndingInternship";
            this.dateEndingInternship.Size = new System.Drawing.Size(200, 20);
            this.dateEndingInternship.TabIndex = 9;
            this.dateEndingInternship.ValueChanged += new System.EventHandler(this.EndingDateIntChanged);
            // 
            // dateStartingDepartment
            // 
            this.dateStartingDepartment.Location = new System.Drawing.Point(372, 106);
            this.dateStartingDepartment.Name = "dateStartingDepartment";
            this.dateStartingDepartment.Size = new System.Drawing.Size(200, 20);
            this.dateStartingDepartment.TabIndex = 11;
            this.dateStartingDepartment.ValueChanged += new System.EventHandler(this.StartingDateDeptChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Starting Date To The Department";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(476, 201);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 16;
            this.textId.TextChanged += new System.EventHandler(this.IdChanged);
            // 
            // textNameSurname
            // 
            this.textNameSurname.Location = new System.Drawing.Point(476, 163);
            this.textNameSurname.Name = "textNameSurname";
            this.textNameSurname.Size = new System.Drawing.Size(100, 20);
            this.textNameSurname.TabIndex = 15;
            this.textNameSurname.TextChanged += new System.EventHandler(this.NameSurnameChanged);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(369, 204);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(56, 13);
            this.Id.TabIndex = 13;
            this.Id.Text = "Student Id";
            // 
            // NameSurname
            // 
            this.NameSurname.AutoSize = true;
            this.NameSurname.Location = new System.Drawing.Point(369, 166);
            this.NameSurname.Name = "NameSurname";
            this.NameSurname.Size = new System.Drawing.Size(101, 13);
            this.NameSurname.TabIndex = 12;
            this.NameSurname.Text = "Name and Surname";
            // 
            // checkBoxCourses
            // 
            this.checkBoxCourses.AutoSize = true;
            this.checkBoxCourses.Location = new System.Drawing.Point(372, 307);
            this.checkBoxCourses.Name = "checkBoxCourses";
            this.checkBoxCourses.Size = new System.Drawing.Size(219, 17);
            this.checkBoxCourses.TabIndex = 17;
            this.checkBoxCourses.Text = "Did you take all of the following courses?";
            this.checkBoxCourses.UseVisualStyleBackColor = true;
            this.checkBoxCourses.CheckedChanged += new System.EventHandler(this.CheckboxCoursesChecked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "ENM214";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(587, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "BIL211";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(587, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "BIL255";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(587, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "ENM102";
            // 
            // checkBoxWorkshop
            // 
            this.checkBoxWorkshop.AutoSize = true;
            this.checkBoxWorkshop.Location = new System.Drawing.Point(92, 310);
            this.checkBoxWorkshop.Name = "checkBoxWorkshop";
            this.checkBoxWorkshop.Size = new System.Drawing.Size(243, 17);
            this.checkBoxWorkshop.TabIndex = 22;
            this.checkBoxWorkshop.Text = "Does the firm have a manufacturing workshop";
            this.checkBoxWorkshop.UseVisualStyleBackColor = true;
            this.checkBoxWorkshop.CheckedChanged += new System.EventHandler(this.CheckboxWorkshopChecked);
            // 
            // checkBoxSaturday
            // 
            this.checkBoxSaturday.AutoSize = true;
            this.checkBoxSaturday.Location = new System.Drawing.Point(92, 370);
            this.checkBoxSaturday.Name = "checkBoxSaturday";
            this.checkBoxSaturday.Size = new System.Drawing.Size(240, 17);
            this.checkBoxSaturday.TabIndex = 23;
            this.checkBoxSaturday.Text = "Does the firm consider saturday as work day?";
            this.checkBoxSaturday.UseVisualStyleBackColor = true;
            this.checkBoxSaturday.CheckedChanged += new System.EventHandler(this.ChechboxSaturdayChecked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "and at least one engineer?";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(476, 243);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 20);
            this.textEmail.TabIndex = 26;
            this.textEmail.TextChanged += new System.EventHandler(this.EmailChanged);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(369, 246);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(72, 13);
            this.Email.TabIndex = 25;
            this.Email.Text = "Student Email";
            // 
            // buttonfinish
            // 
            this.buttonfinish.Location = new System.Drawing.Point(476, 370);
            this.buttonfinish.Name = "buttonfinish";
            this.buttonfinish.Size = new System.Drawing.Size(75, 23);
            this.buttonfinish.TabIndex = 27;
            this.buttonfinish.Text = "Finish";
            this.buttonfinish.UseVisualStyleBackColor = true;
            this.buttonfinish.Click += new System.EventHandler(this.FinishButton);
            // 
            // ınternship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 508);
            this.Controls.Add(this.buttonfinish);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBoxSaturday);
            this.Controls.Add(this.checkBoxWorkshop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxCourses);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.textNameSurname);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.NameSurname);
            this.Controls.Add(this.dateStartingDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateEndingInternship);
            this.Controls.Add(this.endinngdateofınternship);
            this.Controls.Add(this.dateStartingInternship);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textWebSite);
            this.Controls.Add(this.textFirmName);
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
        private System.Windows.Forms.TextBox textFirmName;
        private System.Windows.Forms.TextBox textWebSite;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateStartingInternship;
        private System.Windows.Forms.Label endinngdateofınternship;
        private System.Windows.Forms.DateTimePicker dateEndingInternship;
        private System.Windows.Forms.DateTimePicker dateStartingDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textNameSurname;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label NameSurname;
        private System.Windows.Forms.CheckBox checkBoxCourses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxWorkshop;
        private System.Windows.Forms.CheckBox checkBoxSaturday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button buttonfinish;
    }
}

