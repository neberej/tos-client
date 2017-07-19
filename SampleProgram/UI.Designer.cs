using System;
using System.Windows.Forms;
using Microsoft.Win32;
using Adapter;
using System.ComponentModel;
using System.Collections;
using System.Linq;

namespace SampleGUI
{
    
    partial class UI
    {
        
        /// Required designer variable.
        private System.ComponentModel.IContainer components = null;


        /// Clean up any resources being used.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.status = new System.Windows.Forms.TextBox();
            this.tickerLabel = new System.Windows.Forms.Label();
            this.topLine = new System.Windows.Forms.Label();
            this.bottomLine = new System.Windows.Forms.Label();
            this.tickerValue = new System.Windows.Forms.TextBox();
            this.getData = new System.Windows.Forms.Button();
            this.closeValue = new System.Windows.Forms.TextBox();
            this.lastLabel = new System.Windows.Forms.Label();
            this.openValue = new System.Windows.Forms.TextBox();
            this.lastValue = new System.Windows.Forms.TextBox();
            this.askValue = new System.Windows.Forms.TextBox();
            this.bidLabel = new System.Windows.Forms.Label();
            this.bidValue = new System.Windows.Forms.TextBox();
            this.closeLabel = new System.Windows.Forms.Label();
            this.openLabel = new System.Windows.Forms.Label();
            this.askLabel = new System.Windows.Forms.Label();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DI = new System.Windows.Forms.Label();
            this.ADX = new System.Windows.Forms.Label();
            this.diValue = new System.Windows.Forms.TextBox();
            this.adxValue = new System.Windows.Forms.TextBox();
            this.line3 = new System.Windows.Forms.Label();
            this.calculateMath = new System.Windows.Forms.Button();
            this.tickerline3 = new System.Windows.Forms.Label();
            this.tickerValue1 = new System.Windows.Forms.TextBox();
            this.tabPage1.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.status);
            this.tabPage1.Controls.Add(this.tickerLabel);
            this.tabPage1.Controls.Add(this.topLine);
            this.tabPage1.Controls.Add(this.bottomLine);
            this.tabPage1.Controls.Add(this.tickerValue);
            this.tabPage1.Controls.Add(this.getData);
            this.tabPage1.Controls.Add(this.closeValue);
            this.tabPage1.Controls.Add(this.lastLabel);
            this.tabPage1.Controls.Add(this.openValue);
            this.tabPage1.Controls.Add(this.lastValue);
            this.tabPage1.Controls.Add(this.askValue);
            this.tabPage1.Controls.Add(this.bidLabel);
            this.tabPage1.Controls.Add(this.bidValue);
            this.tabPage1.Controls.Add(this.closeLabel);
            this.tabPage1.Controls.Add(this.openLabel);
            this.tabPage1.Controls.Add(this.askLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(263, 234);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.Window;
            this.status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.status.Location = new System.Drawing.Point(10, 200);
            this.status.Multiline = true;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Size = new System.Drawing.Size(241, 26);
            this.status.TabIndex = 19;
            this.status.Text = "Ready";
            // 
            // tickerLabel
            // 
            this.tickerLabel.AutoSize = true;
            this.tickerLabel.Location = new System.Drawing.Point(26, 16);
            this.tickerLabel.Name = "tickerLabel";
            this.tickerLabel.Size = new System.Drawing.Size(37, 13);
            this.tickerLabel.TabIndex = 4;
            this.tickerLabel.Text = "Ticker";
            // 
            // topLine
            // 
            this.topLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topLine.Location = new System.Drawing.Point(9, 43);
            this.topLine.Name = "topLine";
            this.topLine.Size = new System.Drawing.Size(250, 2);
            this.topLine.TabIndex = 17;
            // 
            // bottomLine
            // 
            this.bottomLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bottomLine.Location = new System.Drawing.Point(9, 194);
            this.bottomLine.Name = "bottomLine";
            this.bottomLine.Size = new System.Drawing.Size(250, 2);
            this.bottomLine.TabIndex = 18;
            // 
            // tickerValue
            // 
            this.tickerValue.Location = new System.Drawing.Point(69, 13);
            this.tickerValue.Name = "tickerValue";
            this.tickerValue.Size = new System.Drawing.Size(100, 20);
            this.tickerValue.TabIndex = 1;
            this.tickerValue.Text = "SPY";
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(176, 11);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(75, 23);
            this.getData.TabIndex = 0;
            this.getData.Text = "Get Data";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.OnConnectClicked);
            // 
            // closeValue
            // 
            this.closeValue.Location = new System.Drawing.Point(69, 160);
            this.closeValue.Name = "closeValue";
            this.closeValue.Size = new System.Drawing.Size(100, 20);
            this.closeValue.TabIndex = 16;
            // 
            // lastLabel
            // 
            this.lastLabel.AutoSize = true;
            this.lastLabel.Location = new System.Drawing.Point(36, 57);
            this.lastLabel.Name = "lastLabel";
            this.lastLabel.Size = new System.Drawing.Size(27, 13);
            this.lastLabel.TabIndex = 7;
            this.lastLabel.Text = "Last";
            // 
            // openValue
            // 
            this.openValue.Location = new System.Drawing.Point(69, 133);
            this.openValue.Name = "openValue";
            this.openValue.Size = new System.Drawing.Size(100, 20);
            this.openValue.TabIndex = 15;
            // 
            // lastValue
            // 
            this.lastValue.Location = new System.Drawing.Point(69, 53);
            this.lastValue.Name = "lastValue";
            this.lastValue.Size = new System.Drawing.Size(100, 20);
            this.lastValue.TabIndex = 3;
            // 
            // askValue
            // 
            this.askValue.Location = new System.Drawing.Point(69, 107);
            this.askValue.Name = "askValue";
            this.askValue.Size = new System.Drawing.Size(100, 20);
            this.askValue.TabIndex = 14;
            // 
            // bidLabel
            // 
            this.bidLabel.AutoSize = true;
            this.bidLabel.Location = new System.Drawing.Point(41, 81);
            this.bidLabel.Name = "bidLabel";
            this.bidLabel.Size = new System.Drawing.Size(22, 13);
            this.bidLabel.TabIndex = 12;
            this.bidLabel.Text = "Bid";
            // 
            // bidValue
            // 
            this.bidValue.Location = new System.Drawing.Point(69, 81);
            this.bidValue.Name = "bidValue";
            this.bidValue.Size = new System.Drawing.Size(100, 20);
            this.bidValue.TabIndex = 8;
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Location = new System.Drawing.Point(7, 162);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(56, 13);
            this.closeLabel.TabIndex = 9;
            this.closeLabel.Text = "Last Close";
            // 
            // openLabel
            // 
            this.openLabel.AutoSize = true;
            this.openLabel.Location = new System.Drawing.Point(28, 133);
            this.openLabel.Name = "openLabel";
            this.openLabel.Size = new System.Drawing.Size(33, 13);
            this.openLabel.TabIndex = 10;
            this.openLabel.Text = "Open";
            // 
            // askLabel
            // 
            this.askLabel.AutoSize = true;
            this.askLabel.Location = new System.Drawing.Point(36, 107);
            this.askLabel.Name = "askLabel";
            this.askLabel.Size = new System.Drawing.Size(25, 13);
            this.askLabel.TabIndex = 13;
            this.askLabel.Text = "Ask";
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Location = new System.Drawing.Point(1, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(271, 260);
            this.Tabs.TabIndex = 19;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DI);
            this.tabPage2.Controls.Add(this.ADX);
            this.tabPage2.Controls.Add(this.diValue);
            this.tabPage2.Controls.Add(this.adxValue);
            this.tabPage2.Controls.Add(this.line3);
            this.tabPage2.Controls.Add(this.calculateMath);
            this.tabPage2.Controls.Add(this.tickerline3);
            this.tabPage2.Controls.Add(this.tickerValue1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(263, 234);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Strategies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DI
            // 
            this.DI.AutoSize = true;
            this.DI.Location = new System.Drawing.Point(19, 186);
            this.DI.Name = "DI";
            this.DI.Size = new System.Drawing.Size(18, 13);
            this.DI.TabIndex = 23;
            this.DI.Text = "DI";
            // 
            // ADX
            // 
            this.ADX.AutoSize = true;
            this.ADX.Location = new System.Drawing.Point(19, 147);
            this.ADX.Name = "ADX";
            this.ADX.Size = new System.Drawing.Size(29, 13);
            this.ADX.TabIndex = 22;
            this.ADX.Text = "ADX";
            // 
            // diValue
            // 
            this.diValue.Location = new System.Drawing.Point(60, 184);
            this.diValue.Name = "diValue";
            this.diValue.Size = new System.Drawing.Size(100, 20);
            this.diValue.TabIndex = 21;
            // 
            // adxValue
            // 
            this.adxValue.Location = new System.Drawing.Point(60, 144);
            this.adxValue.Name = "adxValue";
            this.adxValue.Size = new System.Drawing.Size(100, 20);
            this.adxValue.TabIndex = 20;
            // 
            // line3
            // 
            this.line3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line3.Location = new System.Drawing.Point(6, 116);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(250, 2);
            this.line3.TabIndex = 19;
            // 
            // calculateMath
            // 
            this.calculateMath.Location = new System.Drawing.Point(60, 70);
            this.calculateMath.Name = "calculateMath";
            this.calculateMath.Size = new System.Drawing.Size(75, 23);
            this.calculateMath.TabIndex = 8;
            this.calculateMath.Text = "Go";
            this.calculateMath.UseVisualStyleBackColor = true;
            this.calculateMath.Click += new System.EventHandler(this.OnConnectClicked);
            // 
            // tickerline3
            // 
            this.tickerline3.AutoSize = true;
            this.tickerline3.Location = new System.Drawing.Point(17, 27);
            this.tickerline3.Name = "tickerline3";
            this.tickerline3.Size = new System.Drawing.Size(37, 13);
            this.tickerline3.TabIndex = 7;
            this.tickerline3.Text = "Ticker";
            // 
            // tickerValue1
            // 
            this.tickerValue1.Location = new System.Drawing.Point(60, 24);
            this.tickerValue1.Name = "tickerValue1";
            this.tickerValue1.Size = new System.Drawing.Size(100, 20);
            this.tickerValue1.TabIndex = 6;
            this.tickerValue1.Text = "SPY";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 259);
            this.Controls.Add(this.Tabs);
            this.Name = "UI";
            this.Text = "Think or Swim Client";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }


        private void OnConnectClicked(object sender, EventArgs e)
        {

            // Start timer
            var watch = System.Diagnostics.Stopwatch.StartNew();
            this.status.Text = "Getting Data .....";

            // Will be run on background thread
            BackgroundWorker worker = new BackgroundWorker();

            // Hold current tab name
            var currentTab = "tab1";
            if (this.Tabs.SelectedTab.Name.ToString() == "tabPage2")
            {
                currentTab = "Tab2";
            }

            worker.DoWork += delegate (object s, DoWorkEventArgs args)
            {
                //Create Client Instance
                int heartbeat = 1;
                var tosClassId = new Guid(Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Tos.RTD\CLSID", "", null).ToString());
                var client = new RtdClient(tosClassId, heartbeat);

                if (currentTab == "tab1")
                {
                    args.Result = this.getStocksData(client);
                }
                else
                {
                    args.Result = this.getStrategies(client);
                }
            };

            worker.RunWorkerCompleted += delegate (object s, RunWorkerCompletedEventArgs args)
            {
                Object result = args.Result;
                string[] arr = ((IEnumerable)result).Cast<object>()
                                 .Select(x => x.ToString())
                                 .ToArray();
                watch.Stop();
                var elapsedMs = watch.Elapsed.TotalSeconds;
                this.displayData(arr);

                //Show elasped time on status bar
                this.status.Text = "\n Done ..... Took " + elapsedMs.ToString("F") + "s";
            };

            worker.RunWorkerAsync();

        }


        private object getStocksData(RtdClient client)
        {

            int count = 5;
            var types = new[] {
                "last",
                "bid",
                "ask",
                "open",
                "close"
            };

            String[] quotes = new String[count];
            for (int i = 0; i < count; i++)
            {
                var value = Client.getQuotes(client, types[i], tickerValue.Text);
                quotes[i] = value.ToString();
            }
            
            return quotes;
        }


        private void displayData(String[] quotes)
        {
            // Array containing all textboxes
            var outputFields = new[] {
                lastValue,
                bidValue,
                askValue,
                openValue,
                closeValue
            };

            for (var i = 0; i < outputFields.Length; i++)
            {
                outputFields[i].Text = quotes[i];
            }

        }



        private object getStrategies(RtdClient client)
        {

            // Array containing all textboxes
            //var outputFields = new[] {
            //    adxValue,
            //    diValue
            //};

            //var typeFields = new[] {
            //    "adx",
            //    "di"
            //};


            //for (int i = 0; i < outputFields.Length; i++)
            //{
            // var value = Client.getQuotes(client, typeFields[i], tickerValue.Text);
            //    outputFields[i].Text ="fill";
            //}


            int count = 2;

            var types = new[] {
                "adx",
                "di"
            };

            String[] quotes = new String[count];

            for (int i = 0; i < count; i++)
            {
                //var value = Client.getQuotes(client, types[i], tickerValue.Text);
                quotes[i] = "77878";
            }
            
            return quotes;
        
        }



        #endregion

        private System.Windows.Forms.Button getData;
        private System.Windows.Forms.TextBox tickerValue;
        private System.Windows.Forms.TextBox lastValue;
        private Label tickerLabel;
        private Label lastLabel;
        private TextBox bidValue;
        private Label closeLabel;
        private Label openLabel;
        private Label bidLabel;
        private Label askLabel;
        private TextBox askValue;
        private TextBox openValue;
        private TextBox closeValue;
        private Label topLine;
        private Label bottomLine;
        private TabControl Tabs;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label tickerline3;
        private TextBox tickerValue1;
        private Button calculateMath;
        private Label DI;
        private Label ADX;
        private TextBox diValue;
        private TextBox adxValue;
        private Label line3;
        private TextBox status;
    }
}

