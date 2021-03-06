﻿using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

// hello it's me
//Test jaap
//test 2 jaap
namespace Project3Datavisualisatie
{
    public partial class Form1 : MaterialForm
    {
        private bool Slided;
        private string selectedCrimeChartInfoType = "crimeratio";

        public Form1()
        {
            InitializeComponent();
            customForm();

            drawNewCrimeChart(2006);
            drawNewEconomyChart(2010);

            crimeRatio.Checked = true;

            Slided = false;
            Toggle();
        }

        //begin van vraagje vrime
        //
        //
        private void drawNewCrimeChart(int year)
        {
            //Database connection
            SqlConnection connection;
            string connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["Project3Datavisualisatie.Properties.Settings.Database1ConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);

            //Open connection to run dat query
            connection.Open();

            //Query to get the population total, crime total per year per province
            string selectedPopYear = "b" + year;
            string selectedCrimeYear = "m" + year;
            SqlDataAdapter data = new SqlDataAdapter("(SELECT Province, " + selectedPopYear + ",b2005," + selectedCrimeYear + ",m2005 FROM Crime)", connection);

            //Query is done, close connection
            connection.Close();

            //Store query result in datatable for later use
            DataTable misdrijf = new DataTable();
            data.Fill(misdrijf);

            //Empty the crimechart
            chart1.Series[0].Points.Clear();
            //TODO: needs to be done in the desinger
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            //Loop through the data to calculate the crime ratio and show it in the crimechart
            foreach (DataRow row in misdrijf.Rows)
            {
                string provincie = row[0].ToString();
                int popIncrease = Convert.ToInt32(row[1]) - Convert.ToInt32(row[2]);
                int crimeIncrease = Convert.ToInt32(row[3]) - Convert.ToInt32(row[4]);
                int crimeRatio = (popIncrease / crimeIncrease);

                if (selectedCrimeChartInfoType == "pop")
                {
                    chart1.ChartAreas[0].AxisY.Maximum = 200000;
                    chart1.ChartAreas[0].AxisY.Minimum = -25000;
                    chart1.Series["Criminaliteit"].Points.AddXY(provincie, popIncrease);
                }
                else if (selectedCrimeChartInfoType == "crime")
                {
                    chart1.ChartAreas[0].AxisY.Maximum = 5000;
                    chart1.ChartAreas[0].AxisY.Minimum = -100000;
                    chart1.Series["Criminaliteit"].Points.AddXY(provincie, crimeIncrease);
                }
                else if (selectedCrimeChartInfoType == "crimeratio")
                {
                    chart1.ChartAreas[0].AxisY.Maximum = 14;
                    chart1.ChartAreas[0].AxisY.Minimum = -45;
                    chart1.Series["Criminaliteit"].Points.AddXY(provincie, crimeRatio);
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int year = crimeTrackbar.Value;
            drawNewCrimeChart(year);
            currentYear.Text = year.ToString();
        }
        //Set crimechart type to populution increase
        private void popIncrease_CheckedChanged(object sender, EventArgs e)
        {
            selectedCrimeChartInfoType = "pop";
            drawNewCrimeChart(crimeTrackbar.Value);
            chartTypeExplain.Text = "Popululation change since 2005";
        }

        //Set crimechart  to crime increase
        private void crimeIncrease_CheckedChanged(object sender, EventArgs e)
        {
            selectedCrimeChartInfoType = "crime";
            drawNewCrimeChart(crimeTrackbar.Value);
            chartTypeExplain.Text = "Crime change since 2005";
        }

        //Set crimechart type to ratio
        private void ratio_CheckedChanged(object sender, EventArgs e)
        {
            selectedCrimeChartInfoType = "crimeratio";
            drawNewCrimeChart(crimeTrackbar.Value);
            chartTypeExplain.Text = "pop/crime ratio. The change of population total and crime total since 2005.";
        }
        //
        //                       
        //einde van vraagje crime

        //begin van vraagje economy
        //
        //
        private void drawNewEconomyChart(int year)
        {
            //Database connection
            SqlConnection connection;
            string connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["Project3Datavisualisatie.Properties.Settings.Database1ConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);

            //Open connection to run dat query
            connection.Open();

            //Query to get the population total, crime total per year per province
            string selectedHYear = "h" + year;
            SqlDataAdapter data2 = new SqlDataAdapter("(SELECT province, "+selectedHYear+" FROM Economy)", connection);

            //Query is done, close connection
            connection.Close();

            //Store query result in datatable for later use
            DataTable economy = new DataTable();
            data2.Fill(economy);

            //Empty the crimechart
            chart2.Series[0].Points.Clear();
            //TODO: needs to be done in the desinger
            chart2.ChartAreas[0].AxisX.Interval = 1;
            chart2.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart2.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            //max en min hoogte van de grafiek
            chart2.ChartAreas[0].AxisY.Maximum = 500;
            chart2.ChartAreas[0].AxisY.Minimum = -100;

            //Loop through the data to calculate the crime ratio and show it in the crimechart
            foreach (DataRow row in economy.Rows)
            {
                string province = row[0].ToString();
                int dinges = Convert.ToInt32(row[1]);
                chart2.Series["Economy"].Points.AddXY(province, dinges);
            }
        }

        //vraag economy trackbar
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int year = economyTrackbar.Value;
            drawNewEconomyChart(year);
            currentYear2.Text = year.ToString();
        }
        //
        //
        //einde van vraagje economy

        //begin van vraagje natuur
        //
        //

        //
        //
        //einde van vraagje economy

        //Form slide toggle
        public void Toggle()
        {
            if (Slided)
            {
                SlideOut(this, 835);
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
            while (move < 835)
            {
                await Task.Delay(10);
                int a = move += 29;
                Location = new Point(workingArea.Right - move, workingArea.Top);
            }
            move = 835;
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

    }
}
