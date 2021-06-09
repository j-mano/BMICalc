using System;
using System.Xml;
using System.Threading.Tasks;

namespace BMI.Services
{
    class saveToFile
    {
        public async static Task SaveInfoToFileAsync(float Bmi)
        {
            // Create the XmlDocument.
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<item><name>Last saved bmi value</name></item>");

            // Add a price element.
            XmlElement newElem = doc.CreateElement("Bmi_Calculation");
                newElem.InnerText = Bmi.ToString();
            doc.DocumentElement.AppendChild(newElem);

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            // Save the document to a file and auto-indent the output.
            XmlWriter writer = XmlWriter.Create("SavedEntries.xml", settings);
            doc.Save(writer);

            writer.Close();
        }
    }
}
