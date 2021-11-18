namespace ZatcaQRUtility
{
    public class QRData
    {
        public string SellerName { get; set; }
        public string TaxNumber { get; set; }
        public string InvoiceTimeStamp { get; set; }
        public string InvoiceTotal { get; set; }
        public string TaxAmount { get; set; }
        public string InvoiceXmlHash { get; set; }

        public string Signature { get; set; }
        public string PublicKey { get; set; }
    }
}
