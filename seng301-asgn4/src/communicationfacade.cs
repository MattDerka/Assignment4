using Frontend4.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seng301_asgn4.src
{
    public class CommunicationFacade
    {
        private VendingMachine d;
        // int button;
        private Dictionary<SelectionButton, int> buttonIndexs;
        public CommunicationFacade(VendingMachine vm)
        {
            this.d = vm;
            this.buttonIndexs = new Dictionary<SelectionButton, int>();
            for(int b = 0; b < d.Hardware.SelectionButtons.Length; b++)
            {
                d.Hardware.SelectionButtons[b].Pressed += new EventHandler(selectionButton);
                buttonIndexs[d.Hardware.SelectionButtons[b]] = b;
            }
        }


        public void selectionButton(object sender, EventArgs e)
        {
            int i = buttonIndexs[(SelectionButton)sender];
            var kind = d.Hardware.ProductKinds[i];
            int cost = kind.Cost.Value;
            d.business.selectionMade(i, kind, cost, d.Hardware.CoinRacks);
        }


        //Used to display the product name and price to a touch screen or scrolling text bar
        public void getName(string item)
        {
            d.Hardware.Display.DisplayMessage(item);
        }

        public void getPrice(int cost)
        {
            d.Hardware.Display.DisplayMessage(cost.ToString());
        }
    }
}
