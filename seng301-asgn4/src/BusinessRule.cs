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
        private Boolean creditFlag = false;


        public BusinessRule(VendingMachine vm)
        {
            this.d = vm;
        }

        public void addCoins(Coin coin)
        {
            inserted.Add(coin);
            int value = coin.Value.Value;
            paymentInserted += value;
            creditFlag = false;
        }

        public void addCredit(int amount)
        {
            this.paymentInserted += amount;
            creditFlag = true;
        }


        //Dispenses product and calculates the change if needed. If the user pays with credit card then there is no need for change and a credit flag is set
        public void selectionMade(int index, ProductKind productKind, int cost, CoinRack[] coinRacks)
        {
            if(paymentInserted >= cost)
            {
                d.Hardware.CoinReceptacle.StoreCoins();
                d.product.despenseProduct(index);
                int changeNeeded = paymentInserted - cost;

                List<int> b = new List<int>();
                int length = d.Hardware.CoinRacks.Length;

                for (int i = 0; i < length; i++)
                {
                    b.Add(d.Hardware.GetCoinKindForCoinRack(i).Value);
                }

                b.Sort();
                for (int i = b.Count - 1; i >= 0; i--)
                {
                    int jk = b[i];
                    while (changeNeeded % jk == 0 && changeNeeded != 0 && d.Hardware.CoinRacks[i].Count != 0)
                    {
                        Cents releasedcoin = new Cents(jk);
                        d.Hardware.GetCoinRackForCoinKind(releasedcoin).ReleaseCoin();

                        changeNeeded -= jk;
                    }

                    while (changeNeeded % jk != 0 && changeNeeded > jk && d.Hardware.CoinRacks[i].Count != 0)
                    {
                        Cents releasedcoin = new Cents(jk);

                        d.Hardware.GetCoinRackForCoinKind(releasedcoin).ReleaseCoin();
                        changeNeeded -= jk;
                    }
                }

                paymentInserted = changeNeeded;

            }
           
        }



    }
}
