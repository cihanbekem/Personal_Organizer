namespace Salary_Calculator
{
    partial class Salary_Calculator
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxAcademic = new System.Windows.Forms.ComboBox();
            this.comboBoxEnglish = new System.Windows.Forms.ComboBox();
            this.comboBoxManage = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.checkBoxAlm = new System.Windows.Forms.CheckBox();
            this.checkBoxCin = new System.Windows.Forms.CheckBox();
            this.checkBoxArap = new System.Windows.Forms.CheckBox();
            this.radioButtonMarried = new System.Windows.Forms.RadioButton();
            this.radioButtonSingle = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTwoChildren = new System.Windows.Forms.RadioButton();
            this.groupBoxSecondChild = new System.Windows.Forms.GroupBox();
            this.radioButton0_6Age2 = new System.Windows.Forms.RadioButton();
            this.radioButton18Over2 = new System.Windows.Forms.RadioButton();
            this.radioButton7_18Age2 = new System.Windows.Forms.RadioButton();
            this.groupBoxFirstChild = new System.Windows.Forms.GroupBox();
            this.radioButton0_6Age = new System.Windows.Forms.RadioButton();
            this.radioButton7_18Age = new System.Windows.Forms.RadioButton();
            this.radioButton18Over = new System.Windows.Forms.RadioButton();
            this.radioButtonOneChild = new System.Windows.Forms.RadioButton();
            this.radioButtonNoChild = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxPartner = new System.Windows.Forms.GroupBox();
            this.radioButtonNoWork = new System.Windows.Forms.RadioButton();
            this.radioButtonWork = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.radioButton2_4 = new System.Windows.Forms.RadioButton();
            this.radioButton5_9 = new System.Windows.Forms.RadioButton();
            this.radioButton10_15 = new System.Windows.Forms.RadioButton();
            this.radioButton15_20 = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.checkBoxİsp = new System.Windows.Forms.CheckBox();
            this.checkBoxFra = new System.Windows.Forms.CheckBox();
            this.checkBoxRus = new System.Windows.Forms.CheckBox();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBoxSecondChild.SuspendLayout();
            this.groupBoxFirstChild.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxPartner.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "İzmir",
            "Kocaeli",
            "Sakarya",
            "Düzce",
            "Bolu",
            "Yalova",
            "Edirne",
            "Kırklareli",
            "Tekirdağ",
            "Trabzon",
            "Ordu",
            "Giresun",
            "Rize",
            "Artvin",
            "Gümüşhane",
            "Bursa",
            "Eskişehir",
            "Bilecik",
            "Aydın",
            "Denizli",
            "Muğla",
            "Adana",
            "Mersin",
            "Balıkesir",
            "Çanakkale",
            "Antalya",
            "Isparta",
            "Burdur",
            "Diğer"});
            this.comboBoxCity.Location = new System.Drawing.Point(367, 78);
            this.comboBoxCity.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(228, 25);
            this.comboBoxCity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Experience Period(Year):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "City ​​of Residence:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Academic Degree: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Certified English Language Proficiency:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 315);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Managerial Position:";
            // 
            // comboBoxAcademic
            // 
            this.comboBoxAcademic.FormattingEnabled = true;
            this.comboBoxAcademic.Items.AddRange(new object[] {
            "Master\'s degree related to the professional field",
            "Doctorate related to the professional field",
            "Associate professorship related to the professional field",
            "Master\'s degree not related to the professional field",
            "Doctorate/Associate professorship not related to the professional field",
            "Other"});
            this.comboBoxAcademic.Location = new System.Drawing.Point(367, 135);
            this.comboBoxAcademic.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAcademic.Name = "comboBoxAcademic";
            this.comboBoxAcademic.Size = new System.Drawing.Size(424, 25);
            this.comboBoxAcademic.TabIndex = 8;
            // 
            // comboBoxEnglish
            // 
            this.comboBoxEnglish.FormattingEnabled = true;
            this.comboBoxEnglish.Items.AddRange(new object[] {
            "Certified English proficiency",
            "Graduation from an English-medium school",
            "None"});
            this.comboBoxEnglish.Location = new System.Drawing.Point(367, 197);
            this.comboBoxEnglish.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEnglish.Name = "comboBoxEnglish";
            this.comboBoxEnglish.Size = new System.Drawing.Size(358, 25);
            this.comboBoxEnglish.TabIndex = 9;
            // 
            // comboBoxManage
            // 
            this.comboBoxManage.FormattingEnabled = true;
            this.comboBoxManage.Items.AddRange(new object[] {
            "Team Leader/Group Manager/Technical Manager/Software Architect",
            "Project Manager",
            "Director/Projects Manager",
            "CTO/General Manager",
            "IT Supervisor/Manager (if there are up to 5 IT personnel in the IT department)",
            "IT Supervisor/Manager (if there are more than 5 IT personnel in the IT department" +
                ")",
            "None"});
            this.comboBoxManage.Location = new System.Drawing.Point(335, 312);
            this.comboBoxManage.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxManage.Name = "comboBoxManage";
            this.comboBoxManage.Size = new System.Drawing.Size(652, 25);
            this.comboBoxManage.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(30, 262);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Certified Proficiency in Another Language:";
            // 
            // calculateBtn
            // 
            this.calculateBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calculateBtn.Location = new System.Drawing.Point(34, 730);
            this.calculateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(156, 53);
            this.calculateBtn.TabIndex = 14;
            this.calculateBtn.Text = "CALCULATE";
            this.calculateBtn.UseVisualStyleBackColor = false;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // checkBoxAlm
            // 
            this.checkBoxAlm.AutoSize = true;
            this.checkBoxAlm.Location = new System.Drawing.Point(387, 261);
            this.checkBoxAlm.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAlm.Name = "checkBoxAlm";
            this.checkBoxAlm.Size = new System.Drawing.Size(80, 22);
            this.checkBoxAlm.TabIndex = 15;
            this.checkBoxAlm.Text = "Deutsch";
            this.checkBoxAlm.UseVisualStyleBackColor = true;
            // 
            // checkBoxCin
            // 
            this.checkBoxCin.AutoSize = true;
            this.checkBoxCin.Location = new System.Drawing.Point(490, 261);
            this.checkBoxCin.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCin.Name = "checkBoxCin";
            this.checkBoxCin.Size = new System.Drawing.Size(72, 22);
            this.checkBoxCin.TabIndex = 16;
            this.checkBoxCin.Text = "中国人";
            this.checkBoxCin.UseVisualStyleBackColor = true;
            // 
            // checkBoxArap
            // 
            this.checkBoxArap.AutoSize = true;
            this.checkBoxArap.Location = new System.Drawing.Point(784, 261);
            this.checkBoxArap.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxArap.Name = "checkBoxArap";
            this.checkBoxArap.Size = new System.Drawing.Size(61, 22);
            this.checkBoxArap.TabIndex = 17;
            this.checkBoxArap.Text = "عربي";
            this.checkBoxArap.UseVisualStyleBackColor = true;
            // 
            // radioButtonMarried
            // 
            this.radioButtonMarried.AutoSize = true;
            this.radioButtonMarried.Location = new System.Drawing.Point(21, 28);
            this.radioButtonMarried.Name = "radioButtonMarried";
            this.radioButtonMarried.Size = new System.Drawing.Size(74, 22);
            this.radioButtonMarried.TabIndex = 24;
            this.radioButtonMarried.TabStop = true;
            this.radioButtonMarried.Text = "Married";
            this.radioButtonMarried.UseVisualStyleBackColor = true;
            this.radioButtonMarried.CheckedChanged += new System.EventHandler(this.radioButtonMarried_CheckedChanged);
            // 
            // radioButtonSingle
            // 
            this.radioButtonSingle.AutoSize = true;
            this.radioButtonSingle.Location = new System.Drawing.Point(21, 60);
            this.radioButtonSingle.Name = "radioButtonSingle";
            this.radioButtonSingle.Size = new System.Drawing.Size(62, 22);
            this.radioButtonSingle.TabIndex = 25;
            this.radioButtonSingle.TabStop = true;
            this.radioButtonSingle.Text = "Single";
            this.radioButtonSingle.UseVisualStyleBackColor = true;
            this.radioButtonSingle.CheckedChanged += new System.EventHandler(this.radioButtonSingle_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTwoChildren);
            this.groupBox1.Controls.Add(this.groupBoxSecondChild);
            this.groupBox1.Controls.Add(this.groupBoxFirstChild);
            this.groupBox1.Controls.Add(this.radioButtonOneChild);
            this.groupBox1.Controls.Add(this.radioButtonNoChild);
            this.groupBox1.Location = new System.Drawing.Point(34, 508);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1152, 204);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Child\'s Status:";
            // 
            // radioButtonTwoChildren
            // 
            this.radioButtonTwoChildren.AutoSize = true;
            this.radioButtonTwoChildren.Location = new System.Drawing.Point(9, 101);
            this.radioButtonTwoChildren.Name = "radioButtonTwoChildren";
            this.radioButtonTwoChildren.Size = new System.Drawing.Size(144, 22);
            this.radioButtonTwoChildren.TabIndex = 49;
            this.radioButtonTwoChildren.TabStop = true;
            this.radioButtonTwoChildren.Text = "2 or more children";
            this.radioButtonTwoChildren.UseVisualStyleBackColor = true;
            this.radioButtonTwoChildren.CheckedChanged += new System.EventHandler(this.radioButtonTwoChildren_CheckedChanged);
            // 
            // groupBoxSecondChild
            // 
            this.groupBoxSecondChild.Controls.Add(this.radioButton0_6Age2);
            this.groupBoxSecondChild.Controls.Add(this.radioButton18Over2);
            this.groupBoxSecondChild.Controls.Add(this.radioButton7_18Age2);
            this.groupBoxSecondChild.Location = new System.Drawing.Point(963, 47);
            this.groupBoxSecondChild.Name = "groupBoxSecondChild";
            this.groupBoxSecondChild.Size = new System.Drawing.Size(183, 120);
            this.groupBoxSecondChild.TabIndex = 48;
            this.groupBoxSecondChild.TabStop = false;
            this.groupBoxSecondChild.Text = "2nd eldest child";
            this.groupBoxSecondChild.Visible = false;
            // 
            // radioButton0_6Age2
            // 
            this.radioButton0_6Age2.AutoSize = true;
            this.radioButton0_6Age2.Location = new System.Drawing.Point(0, 28);
            this.radioButton0_6Age2.Name = "radioButton0_6Age2";
            this.radioButton0_6Age2.Size = new System.Drawing.Size(111, 22);
            this.radioButton0_6Age2.TabIndex = 41;
            this.radioButton0_6Age2.TabStop = true;
            this.radioButton0_6Age2.Text = "0-6 years old";
            this.radioButton0_6Age2.UseVisualStyleBackColor = true;
            // 
            // radioButton18Over2
            // 
            this.radioButton18Over2.AutoSize = true;
            this.radioButton18Over2.Location = new System.Drawing.Point(0, 88);
            this.radioButton18Over2.Name = "radioButton18Over2";
            this.radioButton18Over2.Size = new System.Drawing.Size(53, 22);
            this.radioButton18Over2.TabIndex = 43;
            this.radioButton18Over2.TabStop = true;
            this.radioButton18Over2.Text = "18+";
            this.radioButton18Over2.UseVisualStyleBackColor = true;
            // 
            // radioButton7_18Age2
            // 
            this.radioButton7_18Age2.AutoSize = true;
            this.radioButton7_18Age2.Location = new System.Drawing.Point(0, 60);
            this.radioButton7_18Age2.Name = "radioButton7_18Age2";
            this.radioButton7_18Age2.Size = new System.Drawing.Size(119, 22);
            this.radioButton7_18Age2.TabIndex = 42;
            this.radioButton7_18Age2.TabStop = true;
            this.radioButton7_18Age2.Text = "7-18 years old";
            this.radioButton7_18Age2.UseVisualStyleBackColor = true;
            // 
            // groupBoxFirstChild
            // 
            this.groupBoxFirstChild.Controls.Add(this.radioButton0_6Age);
            this.groupBoxFirstChild.Controls.Add(this.radioButton7_18Age);
            this.groupBoxFirstChild.Controls.Add(this.radioButton18Over);
            this.groupBoxFirstChild.Location = new System.Drawing.Point(210, 47);
            this.groupBoxFirstChild.Name = "groupBoxFirstChild";
            this.groupBoxFirstChild.Size = new System.Drawing.Size(734, 120);
            this.groupBoxFirstChild.TabIndex = 44;
            this.groupBoxFirstChild.TabStop = false;
            this.groupBoxFirstChild.Text = "1st eldest child";
            this.groupBoxFirstChild.Visible = false;
            // 
            // radioButton0_6Age
            // 
            this.radioButton0_6Age.AutoSize = true;
            this.radioButton0_6Age.Location = new System.Drawing.Point(0, 37);
            this.radioButton0_6Age.Name = "radioButton0_6Age";
            this.radioButton0_6Age.Size = new System.Drawing.Size(111, 22);
            this.radioButton0_6Age.TabIndex = 38;
            this.radioButton0_6Age.TabStop = true;
            this.radioButton0_6Age.Text = "0-6 years old";
            this.radioButton0_6Age.UseVisualStyleBackColor = true;
            // 
            // radioButton7_18Age
            // 
            this.radioButton7_18Age.AutoSize = true;
            this.radioButton7_18Age.Location = new System.Drawing.Point(0, 62);
            this.radioButton7_18Age.Name = "radioButton7_18Age";
            this.radioButton7_18Age.Size = new System.Drawing.Size(119, 22);
            this.radioButton7_18Age.TabIndex = 39;
            this.radioButton7_18Age.TabStop = true;
            this.radioButton7_18Age.Text = "7-18 years old";
            this.radioButton7_18Age.UseVisualStyleBackColor = true;
            // 
            // radioButton18Over
            // 
            this.radioButton18Over.AutoSize = true;
            this.radioButton18Over.Location = new System.Drawing.Point(0, 88);
            this.radioButton18Over.Name = "radioButton18Over";
            this.radioButton18Over.Size = new System.Drawing.Size(599, 22);
            this.radioButton18Over.TabIndex = 40;
            this.radioButton18Over.TabStop = true;
            this.radioButton18Over.Text = "18+ (provided that the student is a university undergraduate/associate degree stu" +
    "dent)";
            this.radioButton18Over.UseVisualStyleBackColor = true;
            // 
            // radioButtonOneChild
            // 
            this.radioButtonOneChild.AutoSize = true;
            this.radioButtonOneChild.Location = new System.Drawing.Point(9, 69);
            this.radioButtonOneChild.Name = "radioButtonOneChild";
            this.radioButtonOneChild.Size = new System.Drawing.Size(66, 22);
            this.radioButtonOneChild.TabIndex = 1;
            this.radioButtonOneChild.TabStop = true;
            this.radioButtonOneChild.Text = "1 child";
            this.radioButtonOneChild.UseVisualStyleBackColor = true;
            this.radioButtonOneChild.CheckedChanged += new System.EventHandler(this.radioButtonOneChild_CheckedChanged);
            // 
            // radioButtonNoChild
            // 
            this.radioButtonNoChild.AutoSize = true;
            this.radioButtonNoChild.Location = new System.Drawing.Point(9, 37);
            this.radioButtonNoChild.Name = "radioButtonNoChild";
            this.radioButtonNoChild.Size = new System.Drawing.Size(44, 22);
            this.radioButtonNoChild.TabIndex = 0;
            this.radioButtonNoChild.TabStop = true;
            this.radioButtonNoChild.Text = "No";
            this.radioButtonNoChild.UseVisualStyleBackColor = true;
            this.radioButtonNoChild.CheckedChanged += new System.EventHandler(this.radioButtonNoChild_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonMarried);
            this.groupBox2.Controls.Add(this.radioButtonSingle);
            this.groupBox2.Location = new System.Drawing.Point(34, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 124);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marital Status:";
            // 
            // groupBoxPartner
            // 
            this.groupBoxPartner.Controls.Add(this.radioButtonNoWork);
            this.groupBoxPartner.Controls.Add(this.radioButtonWork);
            this.groupBoxPartner.Location = new System.Drawing.Point(380, 378);
            this.groupBoxPartner.Name = "groupBoxPartner";
            this.groupBoxPartner.Size = new System.Drawing.Size(200, 124);
            this.groupBoxPartner.TabIndex = 37;
            this.groupBoxPartner.TabStop = false;
            this.groupBoxPartner.Text = "Spouse\'s Status:";
            this.groupBoxPartner.Visible = false;
            // 
            // radioButtonNoWork
            // 
            this.radioButtonNoWork.AutoSize = true;
            this.radioButtonNoWork.Location = new System.Drawing.Point(15, 63);
            this.radioButtonNoWork.Name = "radioButtonNoWork";
            this.radioButtonNoWork.Size = new System.Drawing.Size(100, 22);
            this.radioButtonNoWork.TabIndex = 1;
            this.radioButtonNoWork.TabStop = true;
            this.radioButtonNoWork.Text = "not working";
            this.radioButtonNoWork.UseVisualStyleBackColor = true;
            // 
            // radioButtonWork
            // 
            this.radioButtonWork.AutoSize = true;
            this.radioButtonWork.Location = new System.Drawing.Point(15, 31);
            this.radioButtonWork.Name = "radioButtonWork";
            this.radioButtonWork.Size = new System.Drawing.Size(78, 22);
            this.radioButtonWork.TabIndex = 0;
            this.radioButtonWork.TabStop = true;
            this.radioButtonWork.Text = "Working";
            this.radioButtonWork.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 745);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 18);
            this.label9.TabIndex = 38;
            this.label9.Text = "Minimum Salary:";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(387, 742);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(154, 25);
            this.textBoxSalary.TabIndex = 39;
            // 
            // radioButton2_4
            // 
            this.radioButton2_4.AutoSize = true;
            this.radioButton2_4.Location = new System.Drawing.Point(363, 34);
            this.radioButton2_4.Name = "radioButton2_4";
            this.radioButton2_4.Size = new System.Drawing.Size(47, 22);
            this.radioButton2_4.TabIndex = 40;
            this.radioButton2_4.TabStop = true;
            this.radioButton2_4.Text = "2-4";
            this.radioButton2_4.UseVisualStyleBackColor = true;
            // 
            // radioButton5_9
            // 
            this.radioButton5_9.AutoSize = true;
            this.radioButton5_9.Location = new System.Drawing.Point(427, 34);
            this.radioButton5_9.Name = "radioButton5_9";
            this.radioButton5_9.Size = new System.Drawing.Size(47, 22);
            this.radioButton5_9.TabIndex = 41;
            this.radioButton5_9.TabStop = true;
            this.radioButton5_9.Text = "5-9";
            this.radioButton5_9.UseVisualStyleBackColor = true;
            // 
            // radioButton10_15
            // 
            this.radioButton10_15.AutoSize = true;
            this.radioButton10_15.Location = new System.Drawing.Point(491, 34);
            this.radioButton10_15.Name = "radioButton10_15";
            this.radioButton10_15.Size = new System.Drawing.Size(63, 22);
            this.radioButton10_15.TabIndex = 42;
            this.radioButton10_15.TabStop = true;
            this.radioButton10_15.Text = "10-15";
            this.radioButton10_15.UseVisualStyleBackColor = true;
            // 
            // radioButton15_20
            // 
            this.radioButton15_20.AutoSize = true;
            this.radioButton15_20.Location = new System.Drawing.Point(575, 34);
            this.radioButton15_20.Name = "radioButton15_20";
            this.radioButton15_20.Size = new System.Drawing.Size(63, 22);
            this.radioButton15_20.TabIndex = 43;
            this.radioButton15_20.TabStop = true;
            this.radioButton15_20.Text = "15-20";
            this.radioButton15_20.UseVisualStyleBackColor = true;
            // 
            // radioButton20
            // 
            this.radioButton20.AutoSize = true;
            this.radioButton20.Location = new System.Drawing.Point(668, 34);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(117, 22);
            this.radioButton20.TabIndex = 44;
            this.radioButton20.TabStop = true;
            this.radioButton20.Text = "over 20 years";
            this.radioButton20.UseVisualStyleBackColor = true;
            // 
            // checkBoxİsp
            // 
            this.checkBoxİsp.AutoSize = true;
            this.checkBoxİsp.Location = new System.Drawing.Point(583, 261);
            this.checkBoxİsp.Name = "checkBoxİsp";
            this.checkBoxİsp.Size = new System.Drawing.Size(76, 22);
            this.checkBoxİsp.TabIndex = 45;
            this.checkBoxİsp.Text = "Español";
            this.checkBoxİsp.UseVisualStyleBackColor = true;
            // 
            // checkBoxFra
            // 
            this.checkBoxFra.AutoSize = true;
            this.checkBoxFra.Location = new System.Drawing.Point(682, 261);
            this.checkBoxFra.Name = "checkBoxFra";
            this.checkBoxFra.Size = new System.Drawing.Size(80, 22);
            this.checkBoxFra.TabIndex = 46;
            this.checkBoxFra.Text = "Français";
            this.checkBoxFra.UseVisualStyleBackColor = true;
            // 
            // checkBoxRus
            // 
            this.checkBoxRus.AutoSize = true;
            this.checkBoxRus.Location = new System.Drawing.Point(869, 261);
            this.checkBoxRus.Name = "checkBoxRus";
            this.checkBoxRus.Size = new System.Drawing.Size(80, 22);
            this.checkBoxRus.TabIndex = 47;
            this.checkBoxRus.Text = "Русский";
            this.checkBoxRus.UseVisualStyleBackColor = true;
            // 
            // radioButtonOther
            // 
            this.radioButtonOther.AutoSize = true;
            this.radioButtonOther.Location = new System.Drawing.Point(812, 34);
            this.radioButtonOther.Name = "radioButtonOther";
            this.radioButtonOther.Size = new System.Drawing.Size(60, 22);
            this.radioButtonOther.TabIndex = 48;
            this.radioButtonOther.TabStop = true;
            this.radioButtonOther.Text = "other";
            this.radioButtonOther.UseVisualStyleBackColor = true;
            // 
            // Salary_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 968);
            this.Controls.Add(this.radioButtonOther);
            this.Controls.Add(this.checkBoxRus);
            this.Controls.Add(this.checkBoxFra);
            this.Controls.Add(this.checkBoxİsp);
            this.Controls.Add(this.radioButton20);
            this.Controls.Add(this.radioButton15_20);
            this.Controls.Add(this.radioButton10_15);
            this.Controls.Add(this.radioButton5_9);
            this.Controls.Add(this.radioButton2_4);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBoxPartner);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxArap);
            this.Controls.Add(this.checkBoxCin);
            this.Controls.Add(this.checkBoxAlm);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxManage);
            this.Controls.Add(this.comboBoxEnglish);
            this.Controls.Add(this.comboBoxAcademic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCity);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Salary_Calculator";
            this.Text = "Salary Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSecondChild.ResumeLayout(false);
            this.groupBoxSecondChild.PerformLayout();
            this.groupBoxFirstChild.ResumeLayout(false);
            this.groupBoxFirstChild.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxPartner.ResumeLayout(false);
            this.groupBoxPartner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxAcademic;
        private System.Windows.Forms.ComboBox comboBoxEnglish;
        private System.Windows.Forms.ComboBox comboBoxManage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.CheckBox checkBoxAlm;
        private System.Windows.Forms.CheckBox checkBoxCin;
        private System.Windows.Forms.CheckBox checkBoxArap;
        private System.Windows.Forms.RadioButton radioButtonMarried;
        private System.Windows.Forms.RadioButton radioButtonSingle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonOneChild;
        private System.Windows.Forms.RadioButton radioButtonNoChild;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxPartner;
        private System.Windows.Forms.RadioButton radioButtonNoWork;
        private System.Windows.Forms.RadioButton radioButtonWork;
        private System.Windows.Forms.RadioButton radioButton18Over2;
        private System.Windows.Forms.RadioButton radioButton7_18Age2;
        private System.Windows.Forms.RadioButton radioButton0_6Age2;
        private System.Windows.Forms.RadioButton radioButton18Over;
        private System.Windows.Forms.RadioButton radioButton7_18Age;
        private System.Windows.Forms.RadioButton radioButton0_6Age;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.RadioButton radioButton2_4;
        private System.Windows.Forms.RadioButton radioButton5_9;
        private System.Windows.Forms.RadioButton radioButton10_15;
        private System.Windows.Forms.RadioButton radioButton15_20;
        private System.Windows.Forms.RadioButton radioButton20;
        private System.Windows.Forms.CheckBox checkBoxİsp;
        private System.Windows.Forms.CheckBox checkBoxFra;
        private System.Windows.Forms.CheckBox checkBoxRus;
        private System.Windows.Forms.GroupBox groupBoxSecondChild;
        private System.Windows.Forms.GroupBox groupBoxFirstChild;
        private System.Windows.Forms.RadioButton radioButtonTwoChildren;
        private System.Windows.Forms.RadioButton radioButtonOther;
    }
}

