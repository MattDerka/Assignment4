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
            dbusinessRule.addCoins(e.Coin);
        }


        
    }

}
