using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frontend4;
using Frontend4.Hardware;

namespace seng301_asgn4.src
{
    class PaymentFacade
    {
        private HardwareFacade hardwareFacade;
        private BusinessRule businessRule;
        

        public PaymentFacade(HardwareFacade hardwareFacade, BusinessRule businessRule)
        {
            this.hardwareFacade = hardwareFacade;
            this.businessRule = businessRule;

            this.hardwareFacade.CoinReceptacle.CoinAdded += new EventHandler<CoinEventArgs>(addCoin);

            //Do the same for business rule

        }

        public void addCoin(object sender, CoinEventArgs e)
        {
            businessRule.addCoins(e.Coin);
        }

        public void addCredit(object sender, CoinEventArgs e)
        {
            businessRule.addCredit(e.Coin.Value.Value);
        }

        public void dispenseChange(List<int> coins)
        {
            //Dispense the change here        
        }

        
    }

}
