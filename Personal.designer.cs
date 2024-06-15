namespace Personal_Information
{
    partial class Personal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personal));
            this.pictureBox_profile = new System.Windows.Forms.PictureBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_phone_number = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.label_adress = new System.Windows.Forms.Label();
            this.textBox_adress = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_change_picture = new System.Windows.Forms.Button();
            this.button_password = new System.Windows.Forms.Button();
            this.label_authority = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_profile
            // 
            this.pictureBox_profile.Location = new System.Drawing.Point(138, 139);
            this.pictureBox_profile.Name = "pictureBox_profile";
            this.pictureBox_profile.Size = new System.Drawing.Size(202, 248);
            this.pictureBox_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_profile.TabIndex = 0;
            this.pictureBox_profile.TabStop = false;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_name.Location = new System.Drawing.Point(392, 113);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(47, 16);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name:";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(392, 173);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(82, 22);
            this.label_surname.TabIndex = 2;
            this.label_surname.Text = "Surname:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(392, 417);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(85, 22);
            this.label_password.TabIndex = 10;
            this.label_password.Text = "Password:";
            // 
            // label_phone_number
            // 
            this.label_phone_number.AutoSize = true;
            this.label_phone_number.Location = new System.Drawing.Point(392, 234);
            this.label_phone_number.Name = "label_phone_number";
            this.label_phone_number.Size = new System.Drawing.Size(136, 22);
            this.label_phone_number.TabIndex = 4;
            this.label_phone_number.Text = "Phone Number: ";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(395, 139);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(322, 30);
            this.textBox_name.TabIndex = 0;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(395, 199);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(322, 30);
            this.textBox_surname.TabIndex = 1;
            this.textBox_surname.TextChanged += new System.EventHandler(this.textBox_surname_TextChanged);
            // 
            // label_adress
            // 
            this.label_adress.AutoSize = true;
            this.label_adress.Location = new System.Drawing.Point(392, 294);
            this.label_adress.Name = "label_adress";
            this.label_adress.Size = new System.Drawing.Size(69, 22);
            this.label_adress.TabIndex = 6;
            this.label_adress.Text = "Adress: ";
            // 
            // textBox_adress
            // 
            this.textBox_adress.Location = new System.Drawing.Point(395, 320);
            this.textBox_adress.Name = "textBox_adress";
            this.textBox_adress.Size = new System.Drawing.Size(322, 30);
            this.textBox_adress.TabIndex = 3;
            this.textBox_adress.TextChanged += new System.EventHandler(this.textBox_adress_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(395, 443);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(322, 30);
            this.textBox_password.TabIndex = 5;
            this.textBox_password.UseSystemPasswordChar = true;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(392, 355);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(55, 22);
            this.label_email.TabIndex = 8;
            this.label_email.Text = "Email:";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(395, 382);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(322, 30);
            this.textBox_email.TabIndex = 4;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(514, 481);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(202, 67);
            this.button_save.TabIndex = 8;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_change_picture
            // 
            this.button_change_picture.Location = new System.Drawing.Point(138, 406);
            this.button_change_picture.Name = "button_change_picture";
            this.button_change_picture.Size = new System.Drawing.Size(202, 67);
            this.button_change_picture.TabIndex = 7;
            this.button_change_picture.Text = "Change Profile Picture";
            this.button_change_picture.UseVisualStyleBackColor = true;
            this.button_change_picture.Click += new System.EventHandler(this.button_change_picture_Click);
            // 
            // button_password
            // 
            this.button_password.Location = new System.Drawing.Point(723, 443);
            this.button_password.Name = "button_password";
            this.button_password.Size = new System.Drawing.Size(120, 32);
            this.button_password.TabIndex = 6;
            this.button_password.Text = "See";
            this.button_password.UseVisualStyleBackColor = true;
            this.button_password.Click += new System.EventHandler(this.button_password_Click);
            // 
            // label_authority
            // 
            this.label_authority.AutoSize = true;
            this.label_authority.Location = new System.Drawing.Point(134, 96);
            this.label_authority.Name = "label_authority";
            this.label_authority.Size = new System.Drawing.Size(66, 22);
            this.label_authority.TabIndex = 15;
            this.label_authority.Text = "ADMIN";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(396, 256);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(320, 30);
            this.maskedTextBox1.TabIndex = 16;
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Return to Home Page";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(900, 619);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label_authority);
            this.Controls.Add(this.button_password);
            this.Controls.Add(this.button_change_picture);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_adress);
            this.Controls.Add(this.label_adress);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_phone_number);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.pictureBox_profile);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Personal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Information";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_profile;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_phone_number;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.Label label_adress;
        private System.Windows.Forms.TextBox textBox_adress;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_change_picture;
        private System.Windows.Forms.Button button_password;
        private System.Windows.Forms.Label label_authority;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

