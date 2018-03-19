using MaterialSkin;
using Project3Datavisualisatie.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace Project3Datavisualisatie
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.TabCriminaliteit = new System.Windows.Forms.TabPage();
            this.chartTypeExplain = new System.Windows.Forms.TextBox();
            this.crimeRatio = new MaterialSkin.Controls.MaterialRadioButton();
            this.crimeIncrease = new MaterialSkin.Controls.MaterialRadioButton();
            this.popIncrease = new MaterialSkin.Controls.MaterialRadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.currentYear = new System.Windows.Forms.TextBox();
            this.crimeTrackbar = new System.Windows.Forms.TrackBar();
            this.TabEconomie = new System.Windows.Forms.TabPage();
            this.TabEnergie = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.economyTrackbar = new System.Windows.Forms.TrackBar();
            this.currentYear2 = new System.Windows.Forms.TextBox();
            this.materialTabControl1.SuspendLayout();
            this.TabCriminaliteit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimeTrackbar)).BeginInit();
            this.TabEconomie.SuspendLayout();
            this.TabEnergie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.economyTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TabCriminaliteit);
            this.materialTabControl1.Controls.Add(this.TabEconomie);
            this.materialTabControl1.Controls.Add(this.TabEnergie);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-2, 61);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1689, 923);
            this.materialTabControl1.TabIndex = 0;
            // 
            // TabCriminaliteit
            // 
            this.TabCriminaliteit.Controls.Add(this.chartTypeExplain);
            this.TabCriminaliteit.Controls.Add(this.crimeRatio);
            this.TabCriminaliteit.Controls.Add(this.crimeIncrease);
            this.TabCriminaliteit.Controls.Add(this.popIncrease);
            this.TabCriminaliteit.Controls.Add(this.chart1);
            this.TabCriminaliteit.Controls.Add(this.currentYear);
            this.TabCriminaliteit.Controls.Add(this.crimeTrackbar);
            this.TabCriminaliteit.Location = new System.Drawing.Point(4, 22);
            this.TabCriminaliteit.Name = "TabCriminaliteit";
            this.TabCriminaliteit.Padding = new System.Windows.Forms.Padding(3);
            this.TabCriminaliteit.Size = new System.Drawing.Size(1681, 897);
            this.TabCriminaliteit.TabIndex = 0;
            this.TabCriminaliteit.Text = "Criminaliteit";
            this.TabCriminaliteit.UseVisualStyleBackColor = true;
            // 
            // chartTypeExplain
            // 
            this.chartTypeExplain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.chartTypeExplain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chartTypeExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartTypeExplain.ForeColor = System.Drawing.Color.White;
            this.chartTypeExplain.Location = new System.Drawing.Point(23, 30);
            this.chartTypeExplain.Multiline = true;
            this.chartTypeExplain.Name = "chartTypeExplain";
            this.chartTypeExplain.Size = new System.Drawing.Size(492, 30);
            this.chartTypeExplain.TabIndex = 7;
            this.chartTypeExplain.Text = "pop/crime ratio. The change of population total and crime total since 2005.";
            // 
            // crimeRatio
            // 
            this.crimeRatio.AutoSize = true;
            this.crimeRatio.Depth = 0;
            this.crimeRatio.Font = new System.Drawing.Font("Roboto", 10F);
            this.crimeRatio.Location = new System.Drawing.Point(525, 150);
            this.crimeRatio.Margin = new System.Windows.Forms.Padding(0);
            this.crimeRatio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.crimeRatio.MouseState = MaterialSkin.MouseState.HOVER;
            this.crimeRatio.Name = "crimeRatio";
            this.crimeRatio.Ripple = true;
            this.crimeRatio.Size = new System.Drawing.Size(124, 30);
            this.crimeRatio.TabIndex = 6;
            this.crimeRatio.TabStop = true;
            this.crimeRatio.Text = "pop/crime ratio";
            this.crimeRatio.UseVisualStyleBackColor = true;
            this.crimeRatio.CheckedChanged += new System.EventHandler(this.ratio_CheckedChanged);
            // 
            // crimeIncrease
            // 
            this.crimeIncrease.AutoSize = true;
            this.crimeIncrease.Depth = 0;
            this.crimeIncrease.Font = new System.Drawing.Font("Roboto", 10F);
            this.crimeIncrease.Location = new System.Drawing.Point(525, 116);
            this.crimeIncrease.Margin = new System.Windows.Forms.Padding(0);
            this.crimeIncrease.MouseLocation = new System.Drawing.Point(-1, -1);
            this.crimeIncrease.MouseState = MaterialSkin.MouseState.HOVER;
            this.crimeIncrease.Name = "crimeIncrease";
            this.crimeIncrease.Ripple = true;
            this.crimeIncrease.Size = new System.Drawing.Size(112, 30);
            this.crimeIncrease.TabIndex = 5;
            this.crimeIncrease.TabStop = true;
            this.crimeIncrease.Text = "crime change";
            this.crimeIncrease.UseVisualStyleBackColor = true;
            this.crimeIncrease.CheckedChanged += new System.EventHandler(this.crimeIncrease_CheckedChanged);
            // 
            // popIncrease
            // 
            this.popIncrease.AutoSize = true;
            this.popIncrease.Depth = 0;
            this.popIncrease.Font = new System.Drawing.Font("Roboto", 10F);
            this.popIncrease.Location = new System.Drawing.Point(525, 82);
            this.popIncrease.Margin = new System.Windows.Forms.Padding(0);
            this.popIncrease.MouseLocation = new System.Drawing.Point(-1, -1);
            this.popIncrease.MouseState = MaterialSkin.MouseState.HOVER;
            this.popIncrease.Name = "popIncrease";
            this.popIncrease.Ripple = true;
            this.popIncrease.Size = new System.Drawing.Size(143, 30);
            this.popIncrease.TabIndex = 4;
            this.popIncrease.TabStop = true;
            this.popIncrease.Text = "population change";
            this.popIncrease.UseVisualStyleBackColor = true;
            this.popIncrease.CheckedChanged += new System.EventHandler(this.popIncrease_CheckedChanged);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.chart1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 57);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Criminaliteit";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(509, 689);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Criminaliteit chart";
            // 
            // currentYear
            // 
            this.currentYear.Location = new System.Drawing.Point(770, 31);
            this.currentYear.Name = "currentYear";
            this.currentYear.Size = new System.Drawing.Size(50, 20);
            this.currentYear.TabIndex = 3;
            this.currentYear.Text = "2005";
            // 
            // crimeTrackbar
            // 
            this.crimeTrackbar.Location = new System.Drawing.Point(525, 31);
            this.crimeTrackbar.Maximum = 2016;
            this.crimeTrackbar.Minimum = 2006;
            this.crimeTrackbar.Name = "crimeTrackbar";
            this.crimeTrackbar.Size = new System.Drawing.Size(239, 45);
            this.crimeTrackbar.TabIndex = 2;
            this.crimeTrackbar.Value = 2006;
            this.crimeTrackbar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // TabEconomie
            // 
            this.TabEconomie.Controls.Add(this.currentYear2);
            this.TabEconomie.Controls.Add(this.economyTrackbar);
            this.TabEconomie.Controls.Add(this.chart2);
            this.TabEconomie.Location = new System.Drawing.Point(4, 22);
            this.TabEconomie.Name = "TabEconomie";
            this.TabEconomie.Padding = new System.Windows.Forms.Padding(3);
            this.TabEconomie.Size = new System.Drawing.Size(1681, 897);
            this.TabEconomie.TabIndex = 1;
            this.TabEconomie.Text = "Lokale Economie";
            this.TabEconomie.UseVisualStyleBackColor = true;
            // 
            // TabEnergie
            // 
            this.TabEnergie.Controls.Add(this.button3);
            this.TabEnergie.Location = new System.Drawing.Point(4, 22);
            this.TabEnergie.Name = "TabEnergie";
            this.TabEnergie.Padding = new System.Windows.Forms.Padding(3);
            this.TabEnergie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabEnergie.Size = new System.Drawing.Size(1681, 897);
            this.TabEnergie.TabIndex = 2;
            this.TabEnergie.Text = "Groene energie";
            this.TabEnergie.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(75, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-2, 24);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1344, 40);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Henk";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(10, 6);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Economy";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(454, 551);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // economyTrackbar
            // 
            this.economyTrackbar.Location = new System.Drawing.Point(505, 42);
            this.economyTrackbar.Maximum = 2014;
            this.economyTrackbar.Minimum = 2010;
            this.economyTrackbar.Name = "economyTrackbar";
            this.economyTrackbar.Size = new System.Drawing.Size(239, 45);
            this.economyTrackbar.TabIndex = 3;
            this.economyTrackbar.Value = 2010;
            this.economyTrackbar.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // currentYear2
            // 
            this.currentYear2.Location = new System.Drawing.Point(767, 42);
            this.currentYear2.Name = "currentYear2";
            this.currentYear2.Size = new System.Drawing.Size(50, 20);
            this.currentYear2.TabIndex = 4;
            this.currentYear2.Text = "2005";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 792);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.TopMost = true;
            this.materialTabControl1.ResumeLayout(false);
            this.TabCriminaliteit.ResumeLayout(false);
            this.TabCriminaliteit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimeTrackbar)).EndInit();
            this.TabEconomie.ResumeLayout(false);
            this.TabEconomie.PerformLayout();
            this.TabEnergie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.economyTrackbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void customForm()
        {
            //custom form properties
            Rectangle workingArea = Screen.GetWorkingArea(this);
            Location = new Point(workingArea.Right - 435, workingArea.Top);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Width = 835;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            //materialskin
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK; //LightBlue200
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.Blue800, Primary.BlueGrey500, Accent.Blue700, TextShade.WHITE);
        }

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage TabCriminaliteit;
        private System.Windows.Forms.TabPage TabEconomie;
        private System.Windows.Forms.TabPage TabEnergie;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private NotifyIcon notifyIcon;
        private Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TrackBar crimeTrackbar;
        private TextBox currentYear;
        private MaterialSkin.Controls.MaterialRadioButton crimeRatio;
        private MaterialSkin.Controls.MaterialRadioButton crimeIncrease;
        private MaterialSkin.Controls.MaterialRadioButton popIncrease;
        private TextBox chartTypeExplain;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private TrackBar economyTrackbar;
        private TextBox currentYear2;
    }
}

