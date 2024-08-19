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
            if (PrincipleAmount == null)
            {
               throw new Exception("Enter the Principle Amount");
            } 
            if (RateOfInterest == null)
            {
               throw new Exception("Enter the Rate Of Interest");
            } 
            if (YearsOfInvestment == null)
            {
               throw new Exception("Enter the Years Of Investment");
            }
            SimpleInterest = (PrincipleAmount * RateOfInterest * YearsOfInvestment) / 100;
        }
    }
}
