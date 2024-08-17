using Microsoft.AspNetCore.Mvc;

namespace MVC.Models
{
    public class SimpleInterestModel 
    {
        public decimal? PrincipleAmount { get; set; }
        public decimal? RateOfInterest { get; set; }
        public decimal? YearsOfInvestment { get; set; }
        public decimal?  SimpleInterest { get; set; }
        
        public SimpleInterestModel() { }
        public void SimpleIntersest() {
            SimpleInterest = (PrincipleAmount * RateOfInterest * YearsOfInvestment) / 100;
        }
    }
}
