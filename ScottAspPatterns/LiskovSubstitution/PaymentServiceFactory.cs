using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScottAspPatterns.LiskovSubstitution
{
    public class PaymentServiceFactory
    {
        public static PaymentServiceBase GetPaymentService(PaymentType paymentType)
        {
            switch (paymentType) {
                case PaymentType.Paypal :
                    return new PaypalPayment("XKSDF-PP", "sdlfjksf-PP");
                case PaymentType.WorldPay :
                    return new WorldPayPayment("KJLFKDSJFS-WP", "lkjlfds", "23");
                default:
                    throw new ApplicationException("You've requested a payment type that hasn't been implemented");
            }
        }
    }
}
