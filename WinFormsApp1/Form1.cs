using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmGradeMarking : Form
    {
        public FrmGradeMarking()
        {
            InitializeComponent();
        }

        
        double grade=0;
        double average;

        private void FrmGradeMarking_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            grade = (double.Parse(txtGrade1.Text) + double.Parse(txtGrade2.Text) + double.Parse(txtGrade3.Text) + double.Parse(txtGrade4.Text)) / 4;

            if (grade >= 1 && grade <= 25)
            {
                lblResult.Text = "You Scored " + grade.ToString() + "% which means you did not do well at all";
                lblResult.Visible = true;
            }
            else if (grade >= 26 && grade <= 50)
            {
                lblResult.Text = "You Scored " + grade.ToString() + "% which means you need to try harder next time";
                lblResult.Visible = true;
            }
            else if (grade >= 51 && grade <= 75)
            {
                lblResult.Text = "You Scored " + grade.ToString() + "% which means you did really well!";
                lblResult.Visible = true;
            }
            else if (grade >= 76 && grade <= 100)
            {
                lblResult.Text = "WOW! You Scored " + grade.ToString() + "% which is brilliant!";
                lblResult.Visible = true;
            }
            else
            {
                lblResult.Text = "Error, you must have entered incorrect numbers as the score is " + grade.ToString() + " please enter anything between 1-100";
                lblResult.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtGrade1.Text = "";
            txtGrade2.Text = "";
            txtGrade3.Text = "";
            txtGrade4.Text = "";
            lblResult.Text = "";
        }
    }
}
