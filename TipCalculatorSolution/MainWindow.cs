using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.btnCalculate.Click += new EventHandler(btnCalculate_Click);
            this.btnClear.Click += new EventHandler(btnClear_Click);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            { 
            //Covert BillTotal to Decimal
            Decimal decBillTotal = Decimal.Parse(BillTotal.Text);
            //Covert TipPercentage to Decimal
            Decimal decTipPercentage = Decimal.Parse(TipPercentage.Text);
            //BillTotal * (TipPercentage / 100) = TotalTip
            Decimal decTotalTip = (decBillTotal * (decTipPercentage / 100));
            decTotalTip.ToString();
            //BillTotal + TotalTip = BillPlusTip
            Decimal decBillPlusTip = decBillTotal + decTotalTip;
            //Convert TotalTip to Text
            TotalTip.Text = decTotalTip.ToString("C");
            //Convert BillPlusTip to Text
            BillPlusTip.Text = decBillPlusTip.ToString("C");
            }
            catch
            {
                MessageBox.Show("Please Enter Number(s)");
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears all Text Boxes
            BillTotal.Text = String.Empty;
            TipPercentage.Text = String.Empty;
            TotalTip.Text = String.Empty;
            BillPlusTip.Text = String.Empty;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
