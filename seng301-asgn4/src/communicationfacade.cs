using Frontend4.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seng301_asgn4.src
{
    class CommunicationFacade
    {
        private VendingMachine d;
        private BusinessRule businessRule;
       // int button;

        public CommunicationFacade(VendingMachine vm)
        {
            this.d = vm;

            //hardwareFacade.SelectionButtons[button].Pressed += CommunicationFacade_Pressed;

        }

        public void selectionButton(int button)
        {
            d.Hardware.SelectionButtons[button].Pressed += businessRule.getProduct;
            d.Hardware.SelectionButtons[button].Press();
        }

        //Used to display the product name to a touch screen or scrolling text bar
        public void getName(string Item)
        {
            //hardwareFacade.Display.Message = Item;
        }
    }
}
