namespace TipCalculator
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.BillTotal = new System.Windows.Forms.TextBox();
            this.BillTotalLabel = new System.Windows.Forms.Label();
            this.TipPercentageLabel = new System.Windows.Forms.Label();
            this.TipPercentage = new System.Windows.Forms.TextBox();
            this.TipTotalLabel = new System.Windows.Forms.Label();
            this.TotalTip = new System.Windows.Forms.TextBox();
            this.BillplusTipLabel = new System.Windows.Forms.Label();
            this.BillPlusTip = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BillTotal
            // 
            this.BillTotal.Location = new System.Drawing.Point(277, 4);
            this.BillTotal.Name = "BillTotal";
            this.BillTotal.Size = new System.Drawing.Size(141, 22);
            this.BillTotal.TabIndex = 0;
            // 
            // BillTotalLabel
            // 
            this.BillTotalLabel.AutoSize = true;
            this.BillTotalLabel.Location = new System.Drawing.Point(12, 9);
            this.BillTotalLabel.Name = "BillTotalLabel";
            this.BillTotalLabel.Size = new System.Drawing.Size(66, 17);
            this.BillTotalLabel.TabIndex = 1;
            this.BillTotalLabel.Text = "Bill Total ";
            // 
            // TipPercentageLabel
            // 
            this.TipPercentageLabel.AutoSize = true;
            this.TipPercentageLabel.Location = new System.Drawing.Point(12, 35);
            this.TipPercentageLabel.Name = "TipPercentageLabel";
            this.TipPercentageLabel.Size = new System.Drawing.Size(196, 17);
            this.TipPercentageLabel.TabIndex = 3;
            this.TipPercentageLabel.Text = "Tip Percentage (Example: 20)";
            this.TipPercentageLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // TipPercentage
            // 
            this.TipPercentage.Location = new System.Drawing.Point(277, 32);
            this.TipPercentage.Name = "TipPercentage";
            this.TipPercentage.Size = new System.Drawing.Size(141, 22);
            this.TipPercentage.TabIndex = 2;
            // 
            // TipTotalLabel
            // 
            this.TipTotalLabel.AutoSize = true;
            this.TipTotalLabel.Location = new System.Drawing.Point(12, 64);
            this.TipTotalLabel.Name = "TipTotalLabel";
            this.TipTotalLabel.Size = new System.Drawing.Size(64, 17);
            this.TipTotalLabel.TabIndex = 7;
            this.TipTotalLabel.Text = "Tip Total";
            this.TipTotalLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // TotalTip
            // 
            this.TotalTip.Enabled = false;
            this.TotalTip.Location = new System.Drawing.Point(277, 59);
            this.TotalTip.Name = "TotalTip";
            this.TotalTip.Size = new System.Drawing.Size(141, 22);
            this.TotalTip.TabIndex = 6;
            // 
            // BillplusTipLabel
            // 
            this.BillplusTipLabel.AutoSize = true;
            this.BillplusTipLabel.Location = new System.Drawing.Point(12, 92);
            this.BillplusTipLabel.Name = "BillplusTipLabel";
            this.BillplusTipLabel.Size = new System.Drawing.Size(80, 17);
            this.BillplusTipLabel.TabIndex = 5;
            this.BillplusTipLabel.Text = "Bill plus Tip";
            this.BillplusTipLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // BillPlusTip
            // 
            this.BillPlusTip.Enabled = false;
            this.BillPlusTip.Location = new System.Drawing.Point(277, 87);
            this.BillPlusTip.Name = "BillPlusTip";
            this.BillPlusTip.Size = new System.Drawing.Size(141, 22);
            this.BillPlusTip.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 144);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(403, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 115);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(403, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 179);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.TipTotalLabel);
            this.Controls.Add(this.TotalTip);
            this.Controls.Add(this.BillplusTipLabel);
            this.Controls.Add(this.BillPlusTip);
            this.Controls.Add(this.TipPercentageLabel);
            this.Controls.Add(this.TipPercentage);
            this.Controls.Add(this.BillTotalLabel);
            this.Controls.Add(this.BillTotal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Tip Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BillTotal;
        private System.Windows.Forms.Label BillTotalLabel;
        private System.Windows.Forms.Label TipPercentageLabel;
        private System.Windows.Forms.TextBox TipPercentage;
        private System.Windows.Forms.Label TipTotalLabel;
        private System.Windows.Forms.TextBox TotalTip;
        private System.Windows.Forms.Label BillplusTipLabel;
        private System.Windows.Forms.TextBox BillPlusTip;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
    }
}

