using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace kutuphane_otomasyon_
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            XmlDocument config = new XmlDocument();
            config.Load("config.xml");
 
            string AuthDomain = config.DocumentElement.SelectSingleNode("/FireBase/AuthDomain").InnerText.Trim();
            string ApiKey = config.DocumentElement.SelectSingleNode("/FireBase/ApiKey").InnerText.Trim();
         
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GirisEkranı(AuthDomain, ApiKey));
        }
    }
}
