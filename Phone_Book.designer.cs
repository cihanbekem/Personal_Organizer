namespace Phone_Book
{
    partial class Phone_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phone_Book));
            this.rehber = new System.Windows.Forms.ListView();
            this.cl_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_kayit = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rehber
            // 
            this.rehber.BackColor = System.Drawing.Color.AliceBlue;
            this.rehber.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_name,
            this.cl_surname,
            this.cl_phone,
            this.cl_address,
            this.cl_description,
            this.cl_email});
            this.rehber.Cursor = System.Windows.Forms.Cursors.Default;
            this.rehber.HideSelection = false;
            this.rehber.Location = new System.Drawing.Point(101, 77);
            this.rehber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rehber.Name = "rehber";
            this.rehber.Size = new System.Drawing.Size(1002, 445);
            this.rehber.TabIndex = 0;
            this.rehber.UseCompatibleStateImageBehavior = false;
            this.rehber.View = System.Windows.Forms.View.Details;
            this.rehber.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.rehber_ColumnClick);
            // 
            // cl_name
            // 
            this.cl_name.Text = "Name";
            this.cl_name.Width = 85;
            // 
            // cl_surname
            // 
            this.cl_surname.Text = "Surname";
            this.cl_surname.Width = 85;
            // 
            // cl_phone
            // 
            this.cl_phone.Text = "Phone Number";
            this.cl_phone.Width = 170;
            // 
            // cl_address
            // 
            this.cl_address.Text = "Address";
            this.cl_address.Width = 160;
            // 
            // cl_description
            // 
            this.cl_description.Text = "Description";
            this.cl_description.Width = 338;
            // 
            // cl_email
            // 
            this.cl_email.Text = "E-Mail";
            this.cl_email.Width = 160;
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(323, 543);
            this.btn_kayit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(112, 38);
            this.btn_kayit.TabIndex = 1;
            this.btn_kayit.Text = "Create";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(539, 543);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(112, 38);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(743, 543);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 38);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Return to Home Page";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // Phone_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1174, 606);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.rehber);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Phone_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone_Book";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView rehber;
        private System.Windows.Forms.ColumnHeader cl_surname;
        private System.Windows.Forms.ColumnHeader cl_phone;
        private System.Windows.Forms.ColumnHeader cl_address;
        private System.Windows.Forms.ColumnHeader cl_description;
        private System.Windows.Forms.ColumnHeader cl_email;
        private System.Windows.Forms.Button btn_kayit;
        public System.Windows.Forms.ColumnHeader cl_name;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

