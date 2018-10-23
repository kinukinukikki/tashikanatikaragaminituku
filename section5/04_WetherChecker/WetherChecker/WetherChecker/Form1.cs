using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace WetherChecker
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> cityNames;

        public Form1()
        {
            InitializeComponent();

            this.cityNames = new Dictionary<string, string>();

            ReadFromFile();

            foreach (KeyValuePair<string, string> data in this.cityNames)
            {
                areaBox.Items.Add(data.Key);
            }

        }

        private void ReadFromFile()
        {
            using (StreamReader file = new StreamReader(@"..\..\area_code.txt"))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    string[] cityAndCode = line.Split(',');
                                      //   city        code
                    this.cityNames.Add(cityAndCode[1], cityAndCode[0]);
                }
            }
        }

        private void CitySelected(object sender, EventArgs e)
        {
            string cityCode = cityNames[areaBox.Text];
            string url = "http://and-idea.sbcr.jp/sp/90261/weatherCheck.php?city=" + cityCode;
            HttpClient client = new HttpClient();
            string result = client.GetStringAsync(url).Result;
            JObject jobj = JObject.Parse(result);
            string todayWeatherIcon = (string)((jobj["url"] as JValue).Value);
            wetherIcon.ImageLocation = todayWeatherIcon;
        }

        private void ExitMenuClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
