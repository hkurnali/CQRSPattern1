namespace CQRSPattern1.CQRSPattern.Results
{
    public class GetProductQueryResult
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public int ProductStoct { get; set; }
        public decimal ProductPrice { get; set; }
        public bool ProductStatus { get; set; }
    }
}
