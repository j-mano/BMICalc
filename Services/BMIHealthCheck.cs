using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.Services
{
    class BMIHealthCheck
    {
        public static string BMIHealthcheck(float BMI)
        {
            string Messsage = "";

            if(BMI <= 18.5)
                Messsage = "undernärd";
            else if (BMI > 18.5 && BMI <= 30)
                Messsage = "Normalt värde";
            else if (BMI > 30)
                Messsage = "Över normalt värde";

            return Messsage;
        }
    }
}
