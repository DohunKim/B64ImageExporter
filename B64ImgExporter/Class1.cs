using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: ApplicationName("B64ImgExporter")]

[assembly: Description("B64ImgExporter")]

[assembly: ApplicationActivation(ActivationOption.Server)]

[assembly: ApplicationAccessControl(false)]



namespace B64ImgExporter
{
    public class B64ImgExporter : ServicedComponent
    {
        public string ExportToFile(string strData, string strFileName)
        {
            try
            {
                string[] arStr = strData.Split(',');

                Console.WriteLine(arStr[1]);

                byte[] data = System.Convert.FromBase64String(arStr[1]);

                FileStream fs = System.IO.File.Create(strFileName +"."+ arStr[0].Split(';')[0].Replace("data:image/", ""));
                fs.Write(data, 0, data.Length);
                fs.Close();

                return arStr[0].Split(';')[0].Replace("data:image/", "");
            } catch(Exception e)
            {
                return null;
            }
        }
    }
}
