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
        List<SavedValue> savedvalues = new List<SavedValue>();
        public Forms1()
        {
            InitializeComponent();
            LoadSavedValues();
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            await CalculateBMIandSave();

            PrintOutSavedValues();
        }

        public async Task CalculateBMIandSave()
        {
            float wheigt = 0;
            float Height = 0;
            float bmi = 0;

            try
            {
                wheigt = float.Parse(WheigtInput_Box.Text);
                Height = float.Parse(LenhgInput_Box.Text);

                bmi = CalcBmi.Calcbmi(Height, wheigt);

                CreateBmiSavedValue(bmi);

                BMI_PrintOut.Text = bmi.ToString();
                Message_LBL.Text = BMIHealthCheck.BMIHealthcheck(bmi);
            }
            catch
            {
                Message_LBL.Text = "Error.\r Please put in an valid numbers in the input.\r Like wheigt 65.3 and heigt 170cm";
            }

            try
            {
                await saveToFile.SaveInfoToFileAsync(savedvalues);
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee);

                ErrorMessage_LBL.Text = "Error While saveing";
                Console.WriteLine("Error While saving");
            }
        }

        private void CreateBmiSavedValue(float bmi)
        {
            SavedValue lastvalueenterd = new SavedValue();

            lastvalueenterd.bmi         = bmi;
            lastvalueenterd.Date        = DateTime.Now;
            lastvalueenterd.heahltRec   = BMIHealthCheck.BMIHealthcheck(bmi);

            savedvalues.Add(lastvalueenterd);

            if (savedvalues.Count > 10)
                savedvalues.RemoveAt(0);
        }

        private void PrintOutSavedValues()
        {
            ListBox_SavedValues.Items.Clear();

            foreach (SavedValue BmiVBalue in savedvalues)
            {
                ListBox_SavedValues.Items.Add("BMI: " + BmiVBalue.bmi + ", Date: " + BmiVBalue.Date + ", Health: " + BmiVBalue.heahltRec);
            }
        }

        private async void LoadSavedValues()
        {
            try
            {
                savedvalues = await LoadFromFile.LoadValuesFromXmlAsync();
                PrintOutSavedValues();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                ErrorMessage_LBL.Text = "Error While Loading History";
            }
        }

        private void Ext_Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
