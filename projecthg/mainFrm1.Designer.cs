namespace projecthg
{
    partial class internship
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
            this.name = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.ıd = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.startingtodepartment = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(8, 18);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            this.name.Click += new System.EventHandler(this.label1_Click);
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(8, 52);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(49, 13);
            this.surname.TabIndex = 1;
            this.surname.Text = "Surname";
            // 
            // ıd
            // 
            this.ıd.AutoSize = true;
            this.ıd.Location = new System.Drawing.Point(8, 86);
            this.ıd.Name = "ıd";
            this.ıd.Size = new System.Drawing.Size(18, 13);
            this.ıd.TabIndex = 2;
            this.ıd.Text = "ID";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(8, 116);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(32, 13);
            this.email.TabIndex = 3;
            this.email.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(120, 109);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // startingtodepartment
            // 
            this.startingtodepartment.AutoSize = true;
            this.startingtodepartment.Location = new System.Drawing.Point(-2, 150);
            this.startingtodepartment.Name = "startingtodepartment";
            this.startingtodepartment.Size = new System.Drawing.Size(113, 13);
            this.startingtodepartment.TabIndex = 8;
            this.startingtodepartment.Text = "Starting to Department";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(120, 143);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // internship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 495);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.startingtodepartment);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.ıd);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Name = "internship";
            this.Text = "Internship";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label ıd;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label startingtodepartment;
        private System.Windows.Forms.TextBox textBox5;
    }
}