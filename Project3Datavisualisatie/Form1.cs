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

namespace Project3Datavisualisatie
{
    public partial class Form1 : MaterialForm
    {
        public struct ProvinceRecord
        {
            public string province;
            public float year2005;
            public float year2006;
            public float year2007;
            public float year2008;
            public float year2009;
            public float year2010;
            public float year2011;
            public float year2012;
            public float year2013;
            public float year2014;
            public float year2015;
            public float year2016;
        }
        private bool Slided;
        public Form1()
        {
            InitializeComponent();
            customForm();

            Slided = false;
            Toggle();
        }

        public void getChartInf(float year)
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
                    ProvinceRecord r;
                    r.province = parts[0];
                    float.TryParse(parts[1], out r.year2005);
                    float.TryParse(parts[2], out r.year2006);
                    float.TryParse(parts[3], out r.year2007);
                    float.TryParse(parts[4], out r.year2008);
                    float.TryParse(parts[5], out r.year2009);
                    float.TryParse(parts[6], out r.year2010);
                    float.TryParse(parts[7], out r.year2011);
                    float.TryParse(parts[8], out r.year2012);
                    float.TryParse(parts[9], out r.year2013);
                    float.TryParse(parts[10], out r.year2014);
                    float.TryParse(parts[11], out r.year2015);
                    float.TryParse(parts[12], out r.year2016);
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


                foreach (ProvinceRecord r in province.Values)
                {
                 
                }

                chart1.Series[0].Points.Clear();


                if (year == 2005)
                {
                    chart1.Series["Criminaliteit"].Points.AddXY("Gro", groningen.year2014);
                    chart1.Series["Criminaliteit"].Points.AddXY("Fri", friesland.year2014);
                    chart1.Series["Criminaliteit"].Points.AddXY("Dre", drenthe.year2014);
                    chart1.Series["Criminaliteit"].Points.AddXY("Over", overijssel.year2014);
                    chart1.Series["Criminaliteit"].Points.AddXY("Flev", flevoland.year2014);
                    chart1.Series["Criminaliteit"].Points.AddXY("Geld", gelderland.year2014);
                    chart1.Series["Criminaliteit"].Points.AddXY("Utre", utrecht.year2014);
                    chart1.Series["Criminaliteit"].Points.AddXY("Noord", noordholland.year2014);
                    chart1.Series["Criminaliteit"].Points.AddXY("Zeela", zuidholland.year2014);
                    chart1.Series["Criminaliteit"].Points.AddXY("Noord", noordbrabant.year2014);
                    chart1.Series["Criminaliteit"].Points.AddXY("Limbu", limburg.year2014);
                }
                if (year == 2006)
                {
                    chart1.Series["Criminaliteit"].Points.AddXY("Gro", groningen.year2015);
                    chart1.Series["Criminaliteit"].Points.AddXY("Fri", friesland.year2015);
                    chart1.Series["Criminaliteit"].Points.AddXY("Dre", drenthe.year2015);
                    chart1.Series["Criminaliteit"].Points.AddXY("Over", overijssel.year2015);
                    chart1.Series["Criminaliteit"].Points.AddXY("Flev", flevoland.year2015);
                    chart1.Series["Criminaliteit"].Points.AddXY("Geld", gelderland.year2015);
                    chart1.Series["Criminaliteit"].Points.AddXY("Utre", utrecht.year2015);
                    chart1.Series["Criminaliteit"].Points.AddXY("Noord", noordholland.year2015);
                    chart1.Series["Criminaliteit"].Points.AddXY("Zeela", zuidholland.year2015);
                    chart1.Series["Criminaliteit"].Points.AddXY("Noord", noordbrabant.year2015);
                    chart1.Series["Criminaliteit"].Points.AddXY("Limbu", limburg.year2015);
                }
                if (year == 2007)
                {
                    chart1.Series["Criminaliteit"].Points.AddXY("Gro", groningen.year2016);
                    chart1.Series["Criminaliteit"].Points.AddXY("Fri", friesland.year2016);
                    chart1.Series["Criminaliteit"].Points.AddXY("Dre", drenthe.year2016);
                    chart1.Series["Criminaliteit"].Points.AddXY("Over", overijssel.year2016);
                    chart1.Series["Criminaliteit"].Points.AddXY("Flev", flevoland.year2016);
                    chart1.Series["Criminaliteit"].Points.AddXY("Geld", gelderland.year2016);
                    chart1.Series["Criminaliteit"].Points.AddXY("Utre", utrecht.year2016);
                    chart1.Series["Criminaliteit"].Points.AddXY("Noord", noordholland.year2016);
                    chart1.Series["Criminaliteit"].Points.AddXY("Zeela", zuidholland.year2016);
                    chart1.Series["Criminaliteit"].Points.AddXY("Noord", noordbrabant.year2016);
                    chart1.Series["Criminaliteit"].Points.AddXY("Limbu", limburg.year2016);
                }
                if (year == 2008)
                {
                    chart1.Series["Criminaliteit"].Points.AddXY("Gro", groningen.year2013);
                    chart1.Series["Criminaliteit"].Points.AddXY("Fri", friesland.year2013);
                    chart1.Series["Criminaliteit"].Points.AddXY("Dre", drenthe.year2013);
                    chart1.Series["Criminaliteit"].Points.AddXY("Over", overijssel.year2013);
                    chart1.Series["Criminaliteit"].Points.AddXY("Flev", flevoland.year2013);
                    chart1.Series["Criminaliteit"].Points.AddXY("Geld", gelderland.year2013);
                    chart1.Series["Criminaliteit"].Points.AddXY("Utre", utrecht.year2013);
                    chart1.Series["Criminaliteit"].Points.AddXY("Noord", noordholland.year2013);
                    chart1.Series["Criminaliteit"].Points.AddXY("Zeela", zuidholland.year2013);
                    chart1.Series["Criminaliteit"].Points.AddXY("Noord", noordbrabant.year2013);
                    chart1.Series["Criminaliteit"].Points.AddXY("Limbu", limburg.year2013);
                }
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
            while (move < 435)
            {
                await Task.Delay(10);
                int a = move += 29;
                Location = new Point(workingArea.Right - move, workingArea.Top);
            }
            move = 435;
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
            float year = trackBar.Value;
            getChartInf(year);
            currentYear.Text = year.ToString();
        }
    }
}
