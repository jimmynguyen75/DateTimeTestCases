using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckDayMonthYear;

namespace DateTimeChecker
{
    public partial class Form1 : Form
    {
        Check check = new Check();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            String dayStr = textBox1.Text;
            String monthStr = textBox2.Text;
            String yearStr = textBox3.Text;
            String valid = "";

            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter day in the textbox");
                return; // return because we don't want to run normal code of buton click
            }
            if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter month in the textbox");
                return; // return because we don't want to run normal code of buton click
            }
            if (textBox3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter year in the textbox");
                return; // return because we don't want to run normal code of buton click
            }
            if (!check.checkDayFormat(dayStr))
            {
                valid += "Input data for Day is incorrect format!\n";               
            }
            if (!check.checkMonthFormat(monthStr))
            {
                valid += "Input data for Month is incorrect format!\n";
            }
            if (!check.checkYearFormat(yearStr))
            {
                valid += "Input data for Year is incorrect format!\n";
            }
            if (!check.checkRangeOfDay(Convert.ToInt32(dayStr)))
            {
                valid += "Input data for Day is out of range\n";
            }
            if (!check.checkRangeOfMonth(Convert.ToInt32(monthStr)))
            {
                valid += "Input data for Month is out of range\n";
            }
            if (!check.checkRangeOfYear(Convert.ToInt32(yearStr)))
            {
                valid += "Input data for Year is out of range\n";
            }
            if (valid.Equals(""))
            {
                if (check.isValidDate(Convert.ToInt32(dayStr), Convert.ToInt32(monthStr), Convert.ToInt32(yearStr))) {
                    if (dayStr.Length == 1)
                    {
                        dayStr = "0" + dayStr;
                    }
                    if (monthStr.Length == 1)
                    {
                        monthStr = "0" + monthStr;
                    }
                    MessageBox.Show(dayStr + "/" + monthStr + "/" + yearStr + " is correct date time!");
                } else
                {
                    if (dayStr.Length == 1)
                    {
                        dayStr = "0" + dayStr;
                    }
                    if (monthStr.Length == 1)
                    {
                        monthStr = "0" + monthStr;
                    }
                    MessageBox.Show(dayStr + "/" + monthStr + "/" + yearStr + " is incorrect date time!");
                }
            }
            else
            {
                MessageBox.Show(valid, "Error", MessageBoxButtons.RetryCancel);
            }
        }
    }
}
