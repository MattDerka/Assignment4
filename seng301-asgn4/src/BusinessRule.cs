using Frontend4;
using Frontend4.Hardware;
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
        private List<Coin> inserted = new List<Coin>();

        public BusinessRule(CommunicationFacade communicationFacade, PaymentFacade paymentFacade, ProductFacade productFacade)
        {
            this.commFacade = communicationFacade;
            this.paymentFacade = paymentFacade;
            this.productFacade = productFacade;
        }

        public void addCoins(Coin coin)
        {
            inserted.Add(coin);
            int value = coin.Value.Value;
            paymentInserted += value;
        }

        public void addCredit(int amount)
        {
            this.paymentInserted += amount;
            //Do something with Communication Facade
        }

        public void getProduct(object sender, EventArgs e)
        {
           // int id = e.ToString.paymentFacade.
          //  string name = productFacade.getProductName(rackNum);

           // if(paymentInserted >= price)
           // {
            //    productFacade.despenseProduct(rackNum)
           // }
        }

        public void selectionMade(int vmIndex, ProductKind productKind, int cost, CoinRack[] coinRacks)
        {
            //Dispense the product

            //Calculate Change 

            //Dispense change if applicable 
        }

    }
}
