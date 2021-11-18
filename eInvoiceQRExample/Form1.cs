using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ZatcaQRUtility;

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
            QRData data = new QRData
            {
                SellerName = txtSellerName.Text,
                TaxNumber = txtTaxNum.Text,
                InvoiceTimeStamp = txtInvoiceDate.Text,
                InvoiceTotal = txtTotal.Text,
                TaxAmount = txtTaxAmount.Text
            };

            string base64Val = ZatcaQRUtility.Generator.GenerateBase64(data);

            txtCode.Text = base64Val;
            pictureBox1.Image = ZatcaQRUtility.Generator.GenerateQR(base64Val);
        }
    }
}
