using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace ZatcaQRUtility
{
    public class QRGenerator
    {
        public static string GenerateBase64(string sellerName, string taxNumber, string invoiceTimeStamp, string invoiceTotal, string taxAmount)
        {
            List<byte[]> tlv = new List<byte[]>
            {
                Encoding.UTF8.GetBytes(sellerName), //tag:1
                Encoding.UTF8.GetBytes(taxNumber), //tag:2
                Encoding.UTF8.GetBytes(invoiceTimeStamp), //tag:3
                Encoding.UTF8.GetBytes(invoiceTotal), //tag:4
                Encoding.UTF8.GetBytes(taxAmount) //tag:5

                //future:> tag:6,tag:7,tag:8,tag:9
            };

            //encode data as TLV [ generating byte array]
            byte[] bytes;
            using (var memory = new MemoryStream())
            {
                using (var writer = new BinaryWriter(memory))
                {
                    uint tag = 1;
                    for (int i = 0; i < tlv.Count; i++)
                    {
                        writer.Write(Convert.ToByte(tag++));
                        writer.Write(Convert.ToByte(tlv[i].Length));
                        writer.Write(tlv[i]);
                    }

                    writer.Flush();
                }

                bytes = memory.ToArray();
            }

            string base64String = Convert.ToBase64String(bytes);
            return base64String;
        }

        /// <summary>
        /// Generate QR Image using nuget package QRCoder
        /// </summary>
        /// <param name="base64Value"></param>
        /// <returns></returns>
        public static Image GenerateQR(string base64Value)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(base64Value, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            return qrCodeImage;
        }
    }
}
