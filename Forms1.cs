using BMI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Forms1 : Form
    {
        public Forms1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            float wheigt = 0;
            float Height = 0;
            float bmi    = 0;

            try
            {
                wheigt = float.Parse(WheigtInput_Box.Text);
                Height = float.Parse(LenhgInput_Box.Text);

                bmi = CalcBmi.Calcbmi(Height, wheigt);

                BMI_PrintOut.Text = bmi.ToString();
                Message_LBL.Text = BMIHealthCheck.BMIHealthcheck(bmi);
            }
            catch
            {
                Message_LBL.Text = "Error.\r Please put in an valid numbers in the input.\r Like wheigt 65.3 and heigt 170cm";
            }

            try
            {
                await saveToFile.SaveInfoToFileAsync(bmi);
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee);

                ErrorMessage_LBL.Text = "Error While saveing";
                Console.WriteLine("Error While saveing");
            }
        }

        private void Ext_Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
