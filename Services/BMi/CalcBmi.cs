using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.Services
{
    public class CalcBmi
    {
        /// <summary>
        /// This function takes in height in cm and wheigt in kg and convert this to bmi.
        /// Heigt first and wheigt in last.
        /// </summary>
        /// <param name="height"></param>
        /// <param name="wheigt"></param>
        /// <returns></returns>
        public static float Calcbmi(float height, float wheigt)
        {
            // Converting to heigt to m.
            float bmi = wheigt / ((height / 100) * (height / 100));

            return bmi;
        }
    }
}
