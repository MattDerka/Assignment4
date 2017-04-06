using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frontend4;
using Frontend4.Hardware;

namespace seng301_asgn4.src
{
    public class PaymentFacade
    {
        private VendingMachine d;


        public PaymentFacade(VendingMachine vm)
        {
            this.d = vm;
            
            d.Hardware.CoinReceptacle.CoinAdded += new EventHandler<CoinEventArgs>(addCoin);

            //Do the same for business rule

        }

        public void addCoin(object sender, CoinEventArgs e)
        {
            d.business.addCoins(e.Coin);
        }

        public void addCredit(object sender, CoinEventArgs e)
        {
            d.business.addCredit(e.Coin.Value.Value);
        }

        public void dispenseChange(List<int> coins)
        {
            //Dispense the change here        
        }

        
    }

}
