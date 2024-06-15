using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Calculator
{
    public partial class Salary_Calculator : Form
    {


        double coefficient = 1; // Coefficient for calculating salary
        double base_wage = 40005; // Brüt Asgari Ücret * 2 = 20.002,50 * 2 = 40.005 TL 
        double min_salary = 0;

        public Salary_Calculator()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (CalculateSalary()) // Hesaplama işlemi başarılıysa maaşı güncelle
            {
                min_salary = base_wage * coefficient;
                textBoxSalary.Text = min_salary.ToString() + "₺";
            }
        }

        private bool CalculateSalary()
        {
            coefficient = 1; // Katsayıyı sıfırla

            //years of experience
            if (radioButton2_4.Checked)
            {
                coefficient += 0.6;
            }
            else if (radioButton5_9.Checked)
            {
                coefficient += 1.00;
            }
            else if (radioButton10_15.Checked)
            {
                coefficient += 1.20;
            }
            else if (radioButton15_20.Checked)
            {
                coefficient += 1.35;
            }
            else if (radioButton20.Checked)
            {
                coefficient += 1.50;
            }
            else if (radioButtonOther.Checked)
            {
                coefficient += 0.00; // etkisi yok
            }
            else
            {
                MessageBox.Show("Please select the years of experience");
                return false; // Hesaplama başarısız

            }

            //city of recidence
            bool citySelected = false;

            for (int i = 0; i < comboBoxCity.Items.Count; i++)
            {
                if (comboBoxCity.SelectedIndex == i)
                {
                    citySelected = true;

                    // Şehir seçilmiş, katsayı belirleniyor
                    if (i == 0)
                    {
                        coefficient += 0.30;
                    }
                    else if (i == 1 || i == 2)
                    {
                        coefficient += 0.20;
                    }
                    else if (i >= 3 && i <= 10)
                    {
                        coefficient += 0.10;
                    }
                    else if (i >= 11 && i <= 29)
                    {
                        coefficient += 0.05;
                    }
                    else if (i == 30)
                    {
                        coefficient += 0.00; // Diğer
                    }
                }
            }

            if (!citySelected)
            {
                MessageBox.Show("Please select the city of recidence!");
                return false; // Hesaplama başarısız
            }

            // academic degree
            bool academicDegreeSelected = false;

            for (int i = 0; i < comboBoxAcademic.Items.Count; i++)
            {
                if (comboBoxAcademic.SelectedIndex == i)
                {
                    academicDegreeSelected = true;

                    // Akademik derece seçilmiş, katsayı belirleniyor
                    if (i == 0)
                    {
                        coefficient += 0.10;
                    }
                    else if (i == 1)
                    {
                        coefficient += 0.30;
                    }
                    else if (i == 2)
                    {
                        coefficient += 0.35;
                    }
                    else if (i == 3)
                    {
                        coefficient += 0.05;
                    }
                    else if (i == 4)
                    {
                        coefficient += 0.15;
                    }
                    else if (i == 5)
                    {
                        coefficient += 0.00; // Etkisi yok
                    }
                }
            }

            if (!academicDegreeSelected)
            {
                MessageBox.Show("Please select the academic degree!");
                return false; // Hesaplama başarısız
            }

            // english degree
            bool englishDegreeSelected = false;
            for (int i = 0; i < comboBoxEnglish.Items.Count; i++)
            {
                
                if (comboBoxEnglish.SelectedIndex == i)
                {
                    englishDegreeSelected = true;
                    if (i == 0)
                    {
                        coefficient += 0.20;
                    }
                    else if (i == 1)
                    {
                        coefficient += 0.20;
                    }
                    else
                    {
                        coefficient += 0.00; // etkisi yok
                    }
                }
            }
            if(!englishDegreeSelected)
            {
                MessageBox.Show("Please select the english degree!");
                return false; // Hesaplama başarısız
            }

            // other languages
            if (checkBoxAlm.Checked)
            {
                coefficient += 0.05;
            }
            if (checkBoxFra.Checked)
            {
                coefficient += 0.05;
            }
            if (checkBoxİsp.Checked)
            {
                coefficient += 0.05;
            }
            if (checkBoxArap.Checked)
            {
                coefficient += 0.05;
            }
            if (checkBoxCin.Checked)
            {
                coefficient += 0.05;
            }
            if (checkBoxRus.Checked)
            {
                coefficient += 0.05;
            }

            // management
            for (int i = 0; i < comboBoxManage.Items.Count; i++)
            {
                if (comboBoxManage.SelectedIndex == i)
                {
                    if (i == 0)
                    {
                        coefficient += 0.50;
                    }
                    else if (i == 1)
                    {
                        coefficient += 0.75;
                    }
                    else if (i == 2)
                    {
                        coefficient += 0.85;
                    }
                    else if (i == 3)
                    {
                        coefficient += 1.00;
                    }
                    else if (i == 4)
                    {
                        coefficient += 0.40;
                    }
                    else if (i == 5)
                    {
                        coefficient += 0.60;
                    }
                    else if (i == 6)
                    {
                        coefficient += 0.00;
                    }
                    else
                    {
                        MessageBox.Show("Please select the management degree");
                        return false; // Hesaplama başarısız
                    }

                }
            }

            // family
            // married status
            if (radioButtonMarried.Checked)
            {
                if (radioButtonNoWork.Checked)
                {
                    coefficient += 0.20;
                
                }
                else if (radioButtonWork.Checked)
                {
                    coefficient += 0.00; // no change
                }
            }
            else if (radioButtonSingle.Checked)
            {
                coefficient += 0.00; // no change
            }

            // çocuk durumu
            if (radioButton0_6Age.Checked)
            {
                coefficient += 0.20;
            }
            else if (radioButton7_18Age.Checked)
            {
                coefficient += 0.30;
            }
            else if (radioButton18Over.Checked)
            {
                coefficient += 0.40;
            }

            if (radioButton0_6Age2.Checked)
            {
                coefficient += 0.20;
            }
            else if (radioButton7_18Age2.Checked)
            {
                coefficient += 0.30;
            }
            else if (radioButton18Over2.Checked)
            {
                coefficient += 0.40;
            }


            //diğer durumlar
            bool radioButtonSingleChecked = radioButtonSingle.Checked;
            bool radioButtonMarriedChecked = radioButtonMarried.Checked;
            if (radioButtonSingleChecked == false && radioButtonMarriedChecked == false)
            {
                MessageBox.Show("Please select the family status!");
                return false; // Hesaplama başarısız
            }

            bool radioButtonNoWorkChecked = radioButtonNoWork.Checked;
            bool radioButtonWorkChecked = radioButtonWork.Checked;
            if(radioButtonMarried.Checked)
            {
                if (radioButtonNoWorkChecked == false && radioButtonWorkChecked == false)
                {
                    MessageBox.Show("Please select the partner's working status!");
                    return false; // Hesaplama başarısız
                }
            }

            bool radioButtonNoChildChecked = radioButtonNoChild.Checked;
            bool radioButtonOneChildChecked = radioButtonOneChild.Checked;
            bool radioButtonTwoChildrenChecked = radioButtonTwoChildren.Checked;
            if (radioButtonNoChild.Checked == false && radioButtonOneChild.Checked == false && radioButtonTwoChildren.Checked == false)
            {
                MessageBox.Show("Please select your child status!");
                return false; // Hesaplama başarısız
            }



            bool radioButton0_6AgeChecked = radioButton0_6Age.Checked;
            bool radioButton7_18AgeChecked = radioButton7_18Age.Checked;
            bool radioButton18OverChecked = radioButton18Over.Checked;
            if (radioButtonOneChild.Checked)
            {
                if (radioButton0_6Age.Checked == false && radioButton7_18Age.Checked == false && radioButton18Over.Checked == false)
                {
                    MessageBox.Show("Please select the age of the child!");
                    return false; // Hesaplama başarısız
                }
            }

            bool radioButton0_6Age2Checked = radioButton0_6Age2.Checked;
            bool radioButton7_18Age2Checked = radioButton7_18Age2.Checked;
            bool radioButton18Over2Checked = radioButton18Over2.Checked;
            if(radioButtonTwoChildren.Checked)
            {
                if (radioButton0_6Age.Checked == false && radioButton7_18Age.Checked == false && radioButton18Over.Checked == false)
                {
                    MessageBox.Show("Please select the age of the first child!");
                    return false; // Hesaplama başarısız
                }
                if (radioButton0_6Age2.Checked == false && radioButton7_18Age2.Checked == false && radioButton18Over2.Checked == false)
                {
                    MessageBox.Show("Please select the age of the second child!");
                    return false; // Hesaplama başarısız
                }
            }
            


            return true; // Hesaplama başarılı

        }


        
        private void radioButtonMarried_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxPartner.Visible = true;
            if (radioButtonMarried.Checked)
            {
                radioButtonSingle.Checked = false; 
                radioButtonWork.Enabled = true; 
                radioButtonNoWork.Enabled = true; 
            }
        }

        private void radioButtonSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSingle.Checked)
            {
                radioButtonMarried.Checked = false; 
                groupBoxPartner.Visible = false; 
                radioButtonWork.Enabled = false; 
                radioButtonNoWork.Enabled = false; 
                radioButtonNoWork.Checked = false;
                radioButtonWork.Checked = false;
            }
        }

        private void radioButtonNoChild_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNoChild.Checked)
            {
                radioButtonOneChild.Checked = false;
                radioButton0_6Age.Checked = false;
                radioButton7_18Age.Checked = false;
                radioButton18Over.Checked = false;
                radioButton0_6Age2.Checked = false;
                radioButton7_18Age2.Checked = false;
                radioButton18Over2.Checked = false;
                radioButtonTwoChildren.Checked = false;
                groupBoxFirstChild.Visible = false;
                groupBoxSecondChild.Visible = false;
                groupBoxFirstChild.Enabled = false;
                groupBoxSecondChild.Enabled = false;
            }
        }
        private void radioButtonOneChild_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOneChild.Checked)
            {
                radioButton0_6Age2.Checked = false;
                radioButton7_18Age2.Checked = false;
                radioButton18Over2.Checked = false;
                radioButtonNoChild.Checked = false;
                radioButtonTwoChildren.Checked = false;
                groupBoxFirstChild.Visible = true;
                groupBoxSecondChild.Visible = false;
                groupBoxFirstChild.Enabled = true;
                groupBoxSecondChild.Enabled = false;
            }

        }

        private void radioButtonTwoChildren_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTwoChildren.Checked)
            {
                radioButtonNoChild.Checked = false;
                radioButtonOneChild.Checked = false;
                groupBoxFirstChild.Visible = true;
                groupBoxSecondChild.Visible = true;
                groupBoxFirstChild.Enabled = true;
                groupBoxSecondChild.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ComboBox'ların seçeneklerinin değiştirilmesini engelle
            comboBoxCity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAcademic.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEnglish.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxManage.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
            
}   
  

        


