using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace eInvoiceQR
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string base64Val = ZatcaQRUtility.Generator.GenerateBase64(txtSellerName.Text, txtTaxNum.Text, txtInvoiceDate.Text, txtTotal.Text, txtTaxAmount.Text);
          
            txtCode.Text = base64Val;
            pictureBox1.Image = ZatcaQRUtility.Generator.GenerateQR(base64Val);
        }
    }
}
