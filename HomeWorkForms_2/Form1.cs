using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkForms_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        ////Результат
        /// </summary>
        public double Result
        { get; private set;}
        /// <summary>
        ///Вывести результат 
        /// </summary>
        private void PrintResult()
        {
            resultLbl.Text = string.Format("Результат: {0}", Result);
        }
        /// <summary>
        ////Переиминовать кнопку Увеличит_Уменьшить в зависимости от чекбокса
        /// </summary>
        private void renameCheckMoreOrLessBt()
        {
            if (moreOrLessChB.Checked)
            {
                moreOrLessBt.Text = "Увеличить";
            }
            else
            {
                moreOrLessBt.Text = "Уменьшить";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control.Name != "GenerateBT")
                {
                    control.Enabled = false;
                }
            }
            renameCheckMoreOrLessBt();
        }
        /// <summary>
        /// Сгенерировать число от 0 до 9999
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateBT_Click(object sender, EventArgs e)
        {
            const int MIN_RANDOM_NUMBER = 0;
            const int MAX_RANDOM_NUMBER = 9999;
            foreach (Control control in Controls)
            {
                control.Enabled = true;
            }
            Random rnd = new Random();
            Result = rnd.Next(MIN_RANDOM_NUMBER,MAX_RANDOM_NUMBER);
            PrintResult();
        }
        private void moreOrLessChB_CheckedChanged(object sender, EventArgs e)
        {
            renameCheckMoreOrLessBt();
        }

        private void moreOrLessBt_Click(object sender, EventArgs e)
        {
            if(moreOrLessChB.Checked)
            {
                if (unitsRB.Checked) { Result++; }
                if (tensRB.Checked) { Result = Result + 10;}
                if (hundredsRB.Checked) { Result = Result + 100; }
                if (thousandsRB.Checked) { Result=Result + 1000; }
            }
            else
            {
                if (unitsRB.Checked) { Result--; }
                if (tensRB.Checked) { Result = Result - 10; }
                if (hundredsRB.Checked) { Result = Result - 100; }
                if (thousandsRB.Checked) { Result = Result - 1000; }
            }
            PrintResult();
            123
        }
    }
}
