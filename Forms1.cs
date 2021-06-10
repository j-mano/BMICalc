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

        // Calculation button
        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            await CalculateBMIandSave();

            PrintOutSavedValues();
        }

        /// <summary>
        /// Calculates the BMI and send list and saving.""
        /// </summary>
        /// <returns>The BMI and save.</returns>
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
                Message_LBL.Text = "Error.\r Please put in an valid numbers in the input.\r Like weight 65.3 and height 170cm";
            }

            try
            {
                await saveToFile.SaveInfoToFileAsync(savedvalues);
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee);

                ErrorMessage_LBL.Text = "Error While saving";
                Console.WriteLine("Error While saving");
            }
        }

        /// <summary>
        /// adding value to list
        /// </summary>
        /// <param name="bmi">Bmi.</param>
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

        /// <summary>
        /// Printing out saves values in the system.
        /// </summary>
        private void PrintOutSavedValues()
        {
            ListBox_SavedValues.Items.Clear();

            foreach (SavedValue BmiVBalue in savedvalues)
            {
                ListBox_SavedValues.Items.Add("BMI: " + BmiVBalue.bmi + ", Datum vid beräkning: " + BmiVBalue.Date + ", Medelande: " + BmiVBalue.heahltRec);
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
                ErrorMessage_LBL.Text = "Fel vid laddning av hiostorik.";
            }
        }

        private void Ext_Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
