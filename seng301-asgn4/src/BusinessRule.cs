using Frontend4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seng301_asgn4.src
{
    class BusinessRule
    {
        private CommunicationFacade commFacade;
        private PaymentFacade paymentFacade;
        private ProductFacade productFacade;

        private int paymentInserted = 0;
        private List<Coin> inseted = new List<Coin>();

        public BusinessRule(CommunicationFacade communicationFacade, PaymentFacade paymentFacade, ProductFacade productFacade)
        {
            this.commFacade = communicationFacade;
            this.paymentFacade = paymentFacade;
            this.productFacade = productFacade;
        }

    }
}
