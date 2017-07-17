using System;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using Adapter;

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
            this.getData = new System.Windows.Forms.Button();
            this.tickerValue = new System.Windows.Forms.TextBox();
            this.tickerLabel = new System.Windows.Forms.Label();


            this.lastValue = new System.Windows.Forms.TextBox();
            this.lastLabel = new System.Windows.Forms.Label();
            this.bidValue = new System.Windows.Forms.TextBox();
            this.closeLabel = new System.Windows.Forms.Label();
            this.openLabel = new System.Windows.Forms.Label();
            this.bidLabel = new System.Windows.Forms.Label();
            this.askLabel = new System.Windows.Forms.Label();
            this.askValue = new System.Windows.Forms.TextBox();
            this.openValue = new System.Windows.Forms.TextBox();
            this.closeValue = new System.Windows.Forms.TextBox();
            this.topLine = new System.Windows.Forms.Label();
            this.bottomLine = new System.Windows.Forms.Label();
            this.SuspendLayout();


            /* -------------------- Data Fields ------------------------ */
            // Get Data (Button)
            this.getData.Location = new System.Drawing.Point(197, 36);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(75, 23);
            this.getData.TabIndex = 0;
            this.getData.Text = "Get Data";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.OnConnectClicked);

            // Ticker (Value)
            this.tickerValue.Location = new System.Drawing.Point(82, 38);
            this.tickerValue.Name = "SPY";
            this.tickerValue.Size = new System.Drawing.Size(100, 20);
            this.tickerValue.TabIndex = 1;
            this.tickerValue.Text = "SPY";

            // tickerValue (Label)
            this.tickerLabel.AutoSize = true;
            this.tickerLabel.Location = new System.Drawing.Point(21, 41);
            this.tickerLabel.Name = "tickerLabel";
            this.tickerLabel.Size = new System.Drawing.Size(37, 13);
            this.tickerLabel.TabIndex = 4;
            this.tickerLabel.Text = "Ticker";


            // Last (Label)
            this.lastLabel.AutoSize = true;
            this.lastLabel.Location = new System.Drawing.Point(21, 91);
            this.lastLabel.Name = "lastLabel";
            this.lastLabel.Size = new System.Drawing.Size(27, 13);
            this.lastLabel.TabIndex = 7;
            this.lastLabel.Text = "Last";
            

            // Close (Label)
            this.closeLabel.AutoSize = true;
            this.closeLabel.Location = new System.Drawing.Point(21, 192);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(56, 13);
            this.closeLabel.TabIndex = 9;
            this.closeLabel.Text = "Last Close";


            // Open (Label)
            this.openLabel.AutoSize = true;
            this.openLabel.Location = new System.Drawing.Point(21, 165);
            this.openLabel.Name = "openLabel";
            this.openLabel.Size = new System.Drawing.Size(33, 13);
            this.openLabel.TabIndex = 10;
            this.openLabel.Text = "Open";

            // Bid (Label)
            this.bidLabel.AutoSize = true;
            this.bidLabel.Location = new System.Drawing.Point(22, 114);
            this.bidLabel.Name = "bid";
            this.bidLabel.Size = new System.Drawing.Size(22, 13);
            this.bidLabel.TabIndex = 12;
            this.bidLabel.Text = "Bid";

            
            // Ask (Label)
            this.askLabel.AutoSize = true;
            this.askLabel.Location = new System.Drawing.Point(22, 139);
            this.askLabel.Name = "ask";
            this.askLabel.Size = new System.Drawing.Size(25, 13);
            this.askLabel.TabIndex = 13;
            this.askLabel.Text = "Ask";


            // Last (Value)
            this.lastValue.Location = new System.Drawing.Point(83, 87);
            this.lastValue.Name = "last";
            this.lastValue.Size = new System.Drawing.Size(100, 20);
            this.lastValue.TabIndex = 3;


            // Bid (Value)
            this.bidValue.Location = new System.Drawing.Point(83, 112);
            this.bidValue.Name = "bid";
            this.bidValue.Size = new System.Drawing.Size(100, 20);
            this.bidValue.TabIndex = 8;


            // Ask (Value)
            this.askValue.Location = new System.Drawing.Point(83, 137);
            this.askValue.Name = "ask";
            this.askValue.Size = new System.Drawing.Size(100, 20);
            this.askValue.TabIndex = 14;


            // Open (Value)
            this.openValue.Location = new System.Drawing.Point(83, 163);
            this.openValue.Name = "open";
            this.openValue.Size = new System.Drawing.Size(100, 20);
            this.openValue.TabIndex = 15;

            
            // Close (Value)
            this.closeValue.Location = new System.Drawing.Point(83, 189);
            this.closeValue.Name = "close";
            this.closeValue.Size = new System.Drawing.Size(100, 20);
            this.closeValue.TabIndex = 16;


            // line 1
            this.topLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topLine.Location = new System.Drawing.Point(17, 73);
            this.topLine.Name = "topLine";
            this.topLine.Size = new System.Drawing.Size(250, 2);
            this.topLine.TabIndex = 17;


            // line 2
            this.bottomLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bottomLine.Location = new System.Drawing.Point(23, 225);
            this.bottomLine.Name = "bottomLine";
            this.bottomLine.Size = new System.Drawing.Size(250, 2);
            this.bottomLine.TabIndex = 18;

            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bottomLine);
            this.Controls.Add(this.topLine);
            this.Controls.Add(this.closeValue);
            this.Controls.Add(this.openValue);
            this.Controls.Add(this.askValue);
            this.Controls.Add(this.askLabel);
            this.Controls.Add(this.bidLabel);
            this.Controls.Add(this.openLabel);
            this.Controls.Add(this.closeLabel);
            this.Controls.Add(this.bidValue);
            this.Controls.Add(this.lastLabel);
            this.Controls.Add(this.tickerLabel);
            this.Controls.Add(this.lastValue);
            this.Controls.Add(this.tickerValue);
            this.Controls.Add(this.getData);
            this.Name = "UI";
            this.Text = "Think or Swim Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void OnConnectClicked(object sender, EventArgs e)
        {
            //Create Client Instance
            var tosClassId = new Guid(Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Tos.RTD\CLSID", "", null).ToString());
            var client = new RtdClient(tosClassId);

            this.updateData(client);
        }


        private void updateData(RtdClient client)
        {
            
            // Array containing all textboxes
            var outputFields = new[] {
                lastValue,
                bidValue,
                askValue,
                openValue,
                closeValue
            };


            for (int i = 0 ; i < outputFields.Length; i++)
            {
                var value = Client.getQuotes(client, outputFields[i].Name.ToString(), tickerValue.Text);
                outputFields[i].Text = value.ToString();
            } 
            
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
    }
}

