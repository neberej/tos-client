using System;
using System.Windows.Forms;
using Microsoft.Win32;
using Adapter;
using System.ComponentModel;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

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
            this.plValue = new System.Windows.Forms.TextBox();
            this.plLabel = new System.Windows.Forms.Label();
            this.line3 = new System.Windows.Forms.Label();
            this.calculateMath = new System.Windows.Forms.Button();
            this.tickerline3 = new System.Windows.Forms.Label();
            this.tickerValue1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.startStreaming = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tickerValue2 = new System.Windows.Forms.TextBox();
            this.streamValue = new System.Windows.Forms.RichTextBox();
            this.tabPage1.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.getData.Click += new System.EventHandler(this.OnGetDataClicked);
            // 
            // closeValue
            // 
            this.closeValue.Location = new System.Drawing.Point(69, 160);
            this.closeValue.Name = "closeValue";
            this.closeValue.Size = new System.Drawing.Size(100, 20);
            this.closeValue.TabIndex = 16;
            this.closeValue.Tag = "close";
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
            this.openValue.Tag = "open";
            // 
            // lastValue
            // 
            this.lastValue.Location = new System.Drawing.Point(69, 53);
            this.lastValue.Name = "lastValue";
            this.lastValue.Size = new System.Drawing.Size(100, 20);
            this.lastValue.TabIndex = 3;
            this.lastValue.Tag = "last";
            // 
            // askValue
            // 
            this.askValue.Location = new System.Drawing.Point(69, 107);
            this.askValue.Name = "askValue";
            this.askValue.Size = new System.Drawing.Size(100, 20);
            this.askValue.TabIndex = 14;
            this.askValue.Tag = "ask";
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
            this.bidValue.Tag = "bid";
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
            this.Tabs.Controls.Add(this.tabPage3);
            this.Tabs.Location = new System.Drawing.Point(1, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(271, 260);
            this.Tabs.TabIndex = 19;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.plValue);
            this.tabPage2.Controls.Add(this.plLabel);
            this.tabPage2.Controls.Add(this.line3);
            this.tabPage2.Controls.Add(this.calculateMath);
            this.tabPage2.Controls.Add(this.tickerline3);
            this.tabPage2.Controls.Add(this.tickerValue1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(263, 234);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Portfolio";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // plValue
            // 
            this.plValue.Location = new System.Drawing.Point(95, 158);
            this.plValue.Name = "plValue";
            this.plValue.Size = new System.Drawing.Size(100, 20);
            this.plValue.TabIndex = 24;
            this.plValue.Tag = "P_L_YTD";
            // 
            // plLabel
            // 
            this.plLabel.Location = new System.Drawing.Point(7, 161);
            this.plLabel.Name = "plLabel";
            this.plLabel.Size = new System.Drawing.Size(82, 20);
            this.plLabel.TabIndex = 22;
            this.plLabel.Text = "P/L YTD";
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
            this.calculateMath.Location = new System.Drawing.Point(95, 55);
            this.calculateMath.Name = "calculateMath";
            this.calculateMath.Size = new System.Drawing.Size(75, 23);
            this.calculateMath.TabIndex = 8;
            this.calculateMath.Text = "Go";
            this.calculateMath.UseVisualStyleBackColor = true;
            this.calculateMath.Click += new System.EventHandler(this.OnPLClicked);
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
            this.tickerValue1.Location = new System.Drawing.Point(95, 24);
            this.tickerValue1.Name = "tickerValue1";
            this.tickerValue1.Size = new System.Drawing.Size(75, 20);
            this.tickerValue1.TabIndex = 6;
            this.tickerValue1.Text = "SPY";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.streamValue);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.startStreaming);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.tickerValue2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(263, 234);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Stream";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 2);
            this.label2.TabIndex = 20;
            // 
            // startStreaming
            // 
            this.startStreaming.Location = new System.Drawing.Point(152, 9);
            this.startStreaming.Name = "startStreaming";
            this.startStreaming.Size = new System.Drawing.Size(100, 23);
            this.startStreaming.TabIndex = 11;
            this.startStreaming.Text = "Start Streaming";
            this.startStreaming.UseVisualStyleBackColor = true;
            this.startStreaming.Click += new System.EventHandler(this.OnstartStreamingClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ticker";
            // 
            // tickerValue2
            // 
            this.tickerValue2.Location = new System.Drawing.Point(61, 11);
            this.tickerValue2.Name = "tickerValue2";
            this.tickerValue2.Size = new System.Drawing.Size(75, 20);
            this.tickerValue2.TabIndex = 9;
            this.tickerValue2.Text = "/CL";
            // 
            // streamValue
            // 
            this.streamValue.Location = new System.Drawing.Point(16, 63);
            this.streamValue.Name = "streamValue";
            this.streamValue.Size = new System.Drawing.Size(236, 162);
            this.streamValue.TabIndex = 22;
            this.streamValue.Text = "";
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }


        private void OnGetDataClicked(object sender, EventArgs e)
        {
            
            var outputFields = new[] {
                lastValue,
                bidValue,
                askValue,
                openValue,
                closeValue
            };

            String[] quotes = new String[outputFields.Length];

            /* Storing types on textbox's tag attribute */
            for (int i = 0; i < 5; i++)
            {
                this.displayData(outputFields[i], this.GetQuotesData(outputFields[i].Tag.ToString(), tickerValue.Text));
            }
            
        }

        private void OnPLClicked(object sender, EventArgs e)
        {

            this.displayData(plValue, this.GetQuotesData(plValue.Tag.ToString(), tickerValue1.Text));

        }

        private void OnstartStreamingClicked(object sender, EventArgs e)
        {
            var quoteType = "BID";
            var quote = this.GetQuotesData(quoteType, tickerValue2.Text);
            streamValue.Text += quoteType + " : " + quote + Environment.NewLine;

        }

        


        private String GetQuotesData(String type, String ticker)
        {
           
            int heartbeat = 1;
            var tosClassId = new Guid(Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Tos.RTD\CLSID", "", null).ToString());
            var client = new RtdClient(tosClassId, heartbeat);
            
            // Get quotes (RTD Server)
            var value = Client.getQuotes(client, type, ticker);
            
            this.status.Text = "Done";

            return value.ToString();
        }

        private void displayData(TextBox textfield, String value)
        {
            
            textfield.Text = value;
  
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
        private Label plLabel;
        private TextBox plValue;
        private Label line3;
        private TextBox status;
        private TabPage tabPage3;
        private Label label2;
        private Button startStreaming;
        private Label label1;
        private TextBox tickerValue2;
        private RichTextBox streamValue;
    }
}

