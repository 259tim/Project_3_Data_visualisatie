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
        private bool Slided;
        public Form1()
        {
            InitializeComponent();
            customForm();

            Slided = false;
            Toggle();

            //this.chart1.Series["Criminaliteit"].Points.AddXY("rotterdam", 123);
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
            string year = trackBar.Value.ToString();
            currentYear.Text = year;
            if (year == "2005") {
            this.chart1.Series["Criminaliteit"].Points.Clear();
            this.chart1.Series["Criminaliteit"].Points.AddXY("rotterdam", 123);
            this.chart1.Series["Criminaliteit"].Points.AddXY("jemoeder", 69);
            }
            if (year == "2006")
            {
                this.chart1.Series["Criminaliteit"].Points.Clear();
                this.chart1.Series["Criminaliteit"].Points.AddXY("rotterdam", 23);
                this.chart1.Series["Criminaliteit"].Points.AddXY("jemoeder", 12);
            }
            if (year == "2007")
            {
                this.chart1.Series["Criminaliteit"].Points.Clear();
                this.chart1.Series["Criminaliteit"].Points.AddXY("rotterdam", 210);
                this.chart1.Series["Criminaliteit"].Points.AddXY("jemoeder", 69);
            }
            if (year == "2008")
            {
                this.chart1.Series["Criminaliteit"].Points.Clear();
                this.chart1.Series["Criminaliteit"].Points.AddXY("rotterdam", 50);
                this.chart1.Series["Criminaliteit"].Points.AddXY("jemoeder", 20);
            }
            if (year == "2009")
            {
                this.chart1.Series["Criminaliteit"].Points.Clear();
                this.chart1.Series["Criminaliteit"].Points.AddXY("rotterdam", 123);
                this.chart1.Series["Criminaliteit"].Points.AddXY("jemoeder", 69);
            }
            if (year == "20010")
            {
                this.chart1.Series["Criminaliteit"].Points.Clear();
                this.chart1.Series["Criminaliteit"].Points.AddXY("rotterdam", 20);
                this.chart1.Series["Criminaliteit"].Points.AddXY("jemoeder", 40);
            }
        }
    }
}
