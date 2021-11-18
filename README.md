# eInvoiceQRGenerator
This is an example of how to generate an eInvoice QR required by ZATCA using .NET written in C#.

## Usage
```C#
QRData data = new QRData
{
      SellerName = "Abdu",
      TaxNumber = "1234567890",
      InvoiceTimeStamp = "1637239384.1874",
      InvoiceTotal = "100.00",
      TaxAmount = "15.00"
};

string base64Val = ZatcaQRUtility.Generator.GenerateBase64(data);

// ex. base64: AQRBYmR1AgoxMjM0NTY3ODkxAw8xNjM3MjM5Mzg0LjE4NzQEAzEwMAUCMTU=
```

You can use the generated base64 value to generate the required QR.
Also, the project [ZatcaQRUtility] contains a method that generate a QR image which use the Nuget package **[QRCoder](https://github.com/codebude/QRCoder/)**

```C#
Image qrImage = Generator.GenerateQR(base64Val);
```
