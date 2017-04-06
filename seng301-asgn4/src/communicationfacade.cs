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

        public CommunicationFacade(VendingMachine vm)
        {
            this.d = vm;

        }

        public void selectionButton(int button)
        {
            //d.Hardware.SelectionButtons[button].Pressed += d.business.getProduct;
            d.Hardware.SelectionButtons[button].Press();
           
        }

        //Used to display the product name to a touch screen or scrolling text bar
        public void getName(string Item)
        {
            //hardwareFacade.Display.Message = Item;
        }
    }
}
