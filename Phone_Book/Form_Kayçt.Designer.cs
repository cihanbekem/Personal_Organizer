namespace Phone_Book
{
    partial class Form_Kayıt
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
            this.txt_name.Location = new System.Drawing.Point(25, 25);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(148, 20);
            this.txt_name.TabIndex = 0;
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(22, 67);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(49, 13);
            this.lbl_surname.TabIndex = 2;
            this.lbl_surname.Text = "Surname";
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(25, 83);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(148, 20);
            this.txt_surname.TabIndex = 3;
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(542, 27);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(75, 23);
            this.btn_kayit.TabIndex = 4;
            this.btn_kayit.Text = "Log In";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(22, 137);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(78, 13);
            this.lbl_phone.TabIndex = 7;
            this.lbl_phone.Text = "Phone Number";
            // 
            // mtxt_phone
            // 
            this.mtxt_phone.Location = new System.Drawing.Point(25, 153);
            this.mtxt_phone.Mask = "(999) 000-0000";
            this.mtxt_phone.Name = "mtxt_phone";
            this.mtxt_phone.Size = new System.Drawing.Size(148, 20);
            this.mtxt_phone.TabIndex = 8;
            this.mtxt_phone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxt_phone_MaskInputRejected);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(22, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(23, 9);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(45, 13);
            this.lbl_address.TabIndex = 9;
            this.lbl_address.Text = "Address";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(26, 25);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(148, 20);
            this.txt_address.TabIndex = 10;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(23, 76);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(60, 13);
            this.lbl_description.TabIndex = 11;
            this.lbl_description.Text = "Description";
            // 
            // txt_dcrpt
            // 
            this.txt_dcrpt.Location = new System.Drawing.Point(26, 92);
            this.txt_dcrpt.Multiline = true;
            this.txt_dcrpt.Name = "txt_dcrpt";
            this.txt_dcrpt.Size = new System.Drawing.Size(148, 20);
            this.txt_dcrpt.TabIndex = 12;
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Location = new System.Drawing.Point(23, 146);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(36, 13);
            this.lbl_Mail.TabIndex = 13;
            this.lbl_Mail.Text = "E-Mail";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(26, 162);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(148, 20);
            this.txt_mail.TabIndex = 14;
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
            this.panel1.Location = new System.Drawing.Point(60, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 192);
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
            this.panel2.Location = new System.Drawing.Point(299, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 191);
            this.panel2.TabIndex = 16;
            // 
            // Form_Kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 250);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_kayit);
            this.Name = "Form_Kayıt";
            this.Text = "Form_Kayıt";
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