using MaterialSkin.Controls;
using Microsoft.VisualBasic.FileIO;
using Project3Datavisualisatie.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// hello it's me
//Test jaap
//test 2 jaap
namespace Project3Datavisualisatie
{
    public partial class Form1 : MaterialForm
    {
        public struct ProvinceRecord
        {
            public string province;
            public float selectedYear;
        }
        private bool Slided;
        public Form1()
        {
            InitializeComponent();
            customForm();

            Slided = false;
            Toggle();
        }

        public void getChartInf(int year)
        {
            Dictionary<string, ProvinceRecord> province = new Dictionary<string, ProvinceRecord>();
            //mischien nog path via resources fixen
            using (TextFieldParser parser = new TextFieldParser(Path.GetDirectoryName(Application.ExecutablePath).Replace(@"bin\Debug", string.Empty) + "Resources/Bevolking.csv"))
            {
                parser.Delimiters = new string[] { ";" };
                while (true)
                {
                    string[] parts = parser.ReadFields();
                    if (parts == null)
                    {
                        break;
                    }
                    int yearToPart = year - 2004;
                    ProvinceRecord r;
                    r.province = parts[0];
                    float.TryParse(parts[yearToPart], out r.selectedYear);
                    province.Add(r.province, r);
                }
                ProvinceRecord groningen = province["Groningen (Pr)"];
                ProvinceRecord friesland = province["Friesland"];
                ProvinceRecord drenthe = province["Drenthe"];
                ProvinceRecord overijssel = province["Overijssel"];
                ProvinceRecord flevoland = province["Flevoland"];
                ProvinceRecord gelderland = province["Gelderland"];
                ProvinceRecord utrecht = province["Utrecht (Pr)"];
                ProvinceRecord noordholland = province["Noord-Holland"];
                ProvinceRecord zuidholland = province["Zuid-Holland"];
                ProvinceRecord zeeland = province["Zeeland"];
                ProvinceRecord noordbrabant = province["Noord-Brabant"];
                ProvinceRecord limburg = province["Limburg"];

                chart1.Series[0].Points.Clear();

                chart1.Series["Criminaliteit"].Points.AddXY("Gro", groningen.selectedYear);
                chart1.Series["Criminaliteit"].Points.AddXY("Fri", friesland.selectedYear);
                chart1.Series["Criminaliteit"].Points.AddXY("Dre", drenthe.selectedYear);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        //Form slide toggle
        public void Toggle()
        {
            if (Slided)
            {
                SlideOut(this, 435);
                Slided = false;
            }
            else
            {
                SlideIn(this, 0);
                Slided = true;
            }
        }

        //Form slideout
        private async void SlideOut(Form1 o, int move)
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            while (move > 0)
            {
                await Task.Delay(10);
                int a = move -= 29;
                Location = new Point(workingArea.Right - move, workingArea.Top);
            }
            move = 0;
        }
        //Form slidein
        private async void SlideIn(Form1 o, int move)
        {
            Slided = true;
            Rectangle workingArea = Screen.GetWorkingArea(this);
            while (move < 1000)
            {
                await Task.Delay(10);
                int a = move += 29;
                Location = new Point(workingArea.Right - move, workingArea.Top);
            }
            move = 1000;
        }

        //Hotkey for sliding
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Toggle();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //Toggle slide on clicking the icon
        private void notifyIcon_Click(object sender, EventArgs e)
        {
            Toggle();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int year = trackBar.Value;
            getChartInf(year);
            bottom.Text = year.ToString();
        }
    }
}
