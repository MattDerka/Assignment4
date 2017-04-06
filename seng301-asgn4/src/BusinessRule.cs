using Frontend4;
using Frontend4.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seng301_asgn4.src
{
    public class BusinessRule
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

        public void addCredit(int amount)
        {
            this.paymentInserted += amount;
            //Do something with Communication Facade
        }



        public void selectionMade(int index, ProductKind productKind, int cost, CoinRack[] coinRacks)
        {
            //Dispense the product
            d.product.despenseProduct(index);
            //Calculate Change 

            //Dispense change if applicable 
        }

    }
}
