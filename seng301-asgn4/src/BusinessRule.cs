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


        private VendingMachine d;

        private int paymentInserted = 0;
        private List<Coin> inserted = new List<Coin>();

        public BusinessRule(VendingMachine vm)
        {
            this.d = vm;
        }

        public void addCoins(Coin coin)
        {
            inserted.Add(coin);
            int value = coin.Value.Value;
            paymentInserted += value;
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

    }
}
