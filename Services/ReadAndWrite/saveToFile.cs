using System;
using System.Xml;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BMI.Services
{
    class saveToFile
    {
        public async static Task SaveInfoToFileAsync(List<SavedValue> BmiIndfoHistroy)
        {
            // Create the XmlDocument.
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<SavedBmiValue><name>Saved values History</name></SavedBmiValue>");

            foreach (SavedValue saveditem in BmiIndfoHistroy)
            {
                XmlElement BMI = doc.CreateElement("Bmi_Calculation_result");
                BMI.AppendChild(doc.CreateElement("BMI", saveditem.bmi.ToString()));
                BMI.AppendChild(doc.CreateElement("Date", saveditem.Date.ToString()));
                BMI.AppendChild(doc.CreateElement("Health", saveditem.heahltRec.ToString()));
                doc.DocumentElement.AppendChild(BMI);

                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                // Save the document to a file and auto-indent the output.
                XmlWriter writer = XmlWriter.Create("SavedEntries.xml", settings);
                doc.Save(writer);

                writer.Close();
            }
        }
    }
}
