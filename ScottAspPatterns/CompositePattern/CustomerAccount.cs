using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.CompositePattern
{
    public class CustomerAccount
    {
        private ISpecification<CustomerAccount> _hasReachedRentalThreshold;
        private ISpecification<CustomerAccount> _customerAccountActive;
        private ISpecification<CustomerAccount> _customerAccountHasLateFees;
       public CustomerAccount()
        {
            _hasReachedRentalThreshold = new HasReachedRentalThresholdSpecification();
            _customerAccountActive = new CustomerAccountStillActive();
            _customerAccountHasLateFees = new CustomersAccountHasLateFees();
        }
       public decimal NumberOfRentalsThisMonth { get; set; }
       public bool AccountActive { get; set; }
       public decimal LateFees { get; set; }

       public bool CanRent()
       {
           ISpecification<CustomerAccount> canRent =
               _customerAccountActive.And(_hasReachedRentalThreshold.Not()).And(_customerAccountHasLateFees.Not());
           return canRent.IsSatisfied(this);
       }
    }
}