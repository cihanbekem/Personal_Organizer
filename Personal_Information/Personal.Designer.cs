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
            this.pictureBox_profile = new System.Windows.Forms.PictureBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_phone_number = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_phone_number = new System.Windows.Forms.TextBox();
            this.label_adress = new System.Windows.Forms.Label();
            this.textBox_adress = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_change_picture = new System.Windows.Forms.Button();
            this.button_password = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_profile
            // 
            this.pictureBox_profile.Location = new System.Drawing.Point(136, 62);
            this.pictureBox_profile.Name = "pictureBox_profile";
            this.pictureBox_profile.Size = new System.Drawing.Size(180, 180);
            this.pictureBox_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_profile.TabIndex = 0;
            this.pictureBox_profile.TabStop = false;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_name.Location = new System.Drawing.Point(362, 43);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(47, 16);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name:";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(362, 87);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(64, 16);
            this.label_surname.TabIndex = 2;
            this.label_surname.Text = "Surname:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(362, 264);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(70, 16);
            this.label_password.TabIndex = 10;
            this.label_password.Text = "Password:";
            // 
            // label_phone_number
            // 
            this.label_phone_number.AutoSize = true;
            this.label_phone_number.Location = new System.Drawing.Point(362, 131);
            this.label_phone_number.Name = "label_phone_number";
            this.label_phone_number.Size = new System.Drawing.Size(103, 16);
            this.label_phone_number.TabIndex = 4;
            this.label_phone_number.Text = "Phone Number: ";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(365, 62);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(286, 22);
            this.textBox_name.TabIndex = 1;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(365, 106);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(286, 22);
            this.textBox_surname.TabIndex = 3;
            this.textBox_surname.TextChanged += new System.EventHandler(this.textBox_surname_TextChanged);
            // 
            // textBox_phone_number
            // 
            this.textBox_phone_number.Location = new System.Drawing.Point(365, 150);
            this.textBox_phone_number.Name = "textBox_phone_number";
            this.textBox_phone_number.Size = new System.Drawing.Size(286, 22);
            this.textBox_phone_number.TabIndex = 5;
            this.textBox_phone_number.TextChanged += new System.EventHandler(this.textBox_phone_number_TextChanged);
            // 
            // label_adress
            // 
            this.label_adress.AutoSize = true;
            this.label_adress.Location = new System.Drawing.Point(362, 175);
            this.label_adress.Name = "label_adress";
            this.label_adress.Size = new System.Drawing.Size(56, 16);
            this.label_adress.TabIndex = 6;
            this.label_adress.Text = "Adress: ";
            // 
            // textBox_adress
            // 
            this.textBox_adress.Location = new System.Drawing.Point(365, 194);
            this.textBox_adress.Name = "textBox_adress";
            this.textBox_adress.Size = new System.Drawing.Size(286, 22);
            this.textBox_adress.TabIndex = 7;
            this.textBox_adress.TextChanged += new System.EventHandler(this.textBox_adress_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(365, 283);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(286, 22);
            this.textBox_password.TabIndex = 11;
            this.textBox_password.UseSystemPasswordChar = true;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(362, 219);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(44, 16);
            this.label_email.TabIndex = 8;
            this.label_email.Text = "Email:";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(365, 239);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(286, 22);
            this.textBox_email.TabIndex = 9;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(544, 331);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(107, 61);
            this.button_save.TabIndex = 12;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_change_picture
            // 
            this.button_change_picture.Location = new System.Drawing.Point(136, 256);
            this.button_change_picture.Name = "button_change_picture";
            this.button_change_picture.Size = new System.Drawing.Size(180, 49);
            this.button_change_picture.TabIndex = 13;
            this.button_change_picture.Text = "Change Profile Picture";
            this.button_change_picture.UseVisualStyleBackColor = true;
            this.button_change_picture.Click += new System.EventHandler(this.button_change_picture_Click);
            // 
            // button_password
            // 
            this.button_password.Location = new System.Drawing.Point(657, 283);
            this.button_password.Name = "button_password";
            this.button_password.Size = new System.Drawing.Size(107, 23);
            this.button_password.TabIndex = 14;
            this.button_password.Text = "See";
            this.button_password.UseVisualStyleBackColor = true;
            this.button_password.Click += new System.EventHandler(this.button_password_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_password);
            this.Controls.Add(this.button_change_picture);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_adress);
            this.Controls.Add(this.label_adress);
            this.Controls.Add(this.textBox_phone_number);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_phone_number);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.pictureBox_profile);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Information";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile)).EndInit();
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
        private System.Windows.Forms.TextBox textBox_phone_number;
        private System.Windows.Forms.Label label_adress;
        private System.Windows.Forms.TextBox textBox_adress;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_change_picture;
        private System.Windows.Forms.Button button_password;
    }
}

