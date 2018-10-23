using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButtonClicked(object sender, EventArgs e)
        {
            int price;
            bool successOfChangingType = int.TryParse(this.priceBox.Text, out price);
            if (successOfChangingType)
            {
                int taxPrice = (int)(price * 1.08);
                this.TaxPriceBox.Text = taxPrice.ToString();
            }
            else
            {
                MessageBox.Show("Input price in the correct form.");
            }
        }
    }
}
