# eInvoiceQRGenerator
An example of generating eInvoice QR using .NET (C#)
This is an example of how to generate an eInvoice QR required by ZATCA using .NET (C#)

**Usage**
```C#
QRData data = new QRData
{
      SellerName = txtSellerName.Text,
      TaxNumber = txtTaxNum.Text,
      InvoiceTimeStamp = txtInvoiceDate.Text,
      InvoiceTotal = txtTotal.Text,
      TaxAmount = txtTaxAmount.Text
};

string base64Val = ZatcaQRUtility.Generator.GenerateBase64(data);
```

You can user the generated base64 value to generate the required QR.
