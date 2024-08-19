namespace MVC.Models
{
    public class DepreciationModel
    {

        public decimal? PurchaseValue { get; set; }
        public decimal? YearsOfService { get; set; }
        public decimal? DepreciationAmount { get; set; }
        public decimal? SalvageValue => PurchaseValue - (YearsOfService * DepreciationAmount) ;

    }
}
