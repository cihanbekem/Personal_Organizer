namespace Phone_Book
{
    partial class RegisterForm
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.mtxt_phone = new System.Windows.Forms.MaskedTextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_dcrpt = new System.Windows.Forms.TextBox();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(38, 42);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(220, 26);
            this.txt_name.TabIndex = 0;
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(33, 112);
            this.lbl_surname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(63, 19);
            this.lbl_surname.TabIndex = 2;
            this.lbl_surname.Text = "Surname";
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(38, 140);
            this.txt_surname.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(220, 26);
            this.txt_surname.TabIndex = 1;
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(813, 46);
            this.btn_kayit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(112, 38);
            this.btn_kayit.TabIndex = 6;
            this.btn_kayit.Text = "Log In";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 5;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(33, 233);
            this.lbl_phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(102, 19);
            this.lbl_phone.TabIndex = 7;
            this.lbl_phone.Text = "Phone Number";
            // 
            // mtxt_phone
            // 
            this.mtxt_phone.Location = new System.Drawing.Point(38, 258);
            this.mtxt_phone.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mtxt_phone.Mask = "(999) 000-0000";
            this.mtxt_phone.Name = "mtxt_phone";
            this.mtxt_phone.Size = new System.Drawing.Size(220, 26);
            this.mtxt_phone.TabIndex = 2;
            this.mtxt_phone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxt_phone_MaskInputRejected);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(33, 15);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 19);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(34, 15);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(58, 19);
            this.lbl_address.TabIndex = 9;
            this.lbl_address.Text = "Address";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(39, 42);
            this.txt_address.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(220, 32);
            this.txt_address.TabIndex = 3;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(34, 112);
            this.lbl_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(78, 19);
            this.lbl_description.TabIndex = 11;
            this.lbl_description.Text = "Description";
            // 
            // txt_dcrpt
            // 
            this.txt_dcrpt.Location = new System.Drawing.Point(38, 140);
            this.txt_dcrpt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_dcrpt.Multiline = true;
            this.txt_dcrpt.Name = "txt_dcrpt";
            this.txt_dcrpt.Size = new System.Drawing.Size(220, 32);
            this.txt_dcrpt.TabIndex = 4;
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Location = new System.Drawing.Point(34, 233);
            this.lbl_Mail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(48, 19);
            this.lbl_Mail.TabIndex = 13;
            this.lbl_Mail.Text = "E-Mail";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(38, 258);
            this.txt_mail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(220, 26);
            this.txt_mail.TabIndex = 5;
            this.txt_mail.Leave += new System.EventHandler(this.txt_mail_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.lbl_surname);
            this.panel1.Controls.Add(this.txt_surname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_phone);
            this.panel1.Controls.Add(this.mtxt_phone);
            this.panel1.Location = new System.Drawing.Point(90, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 324);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_address);
            this.panel2.Controls.Add(this.txt_address);
            this.panel2.Controls.Add(this.txt_mail);
            this.panel2.Controls.Add(this.lbl_description);
            this.panel2.Controls.Add(this.lbl_Mail);
            this.panel2.Controls.Add(this.txt_dcrpt);
            this.panel2.Location = new System.Drawing.Point(448, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 323);
            this.panel2.TabIndex = 16;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(969, 424);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_kayit);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.Form_Kayıt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.MaskedTextBox mtxt_phone;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox txt_dcrpt;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}