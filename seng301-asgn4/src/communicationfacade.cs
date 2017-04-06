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
        private HardwareFacade hardwareFacade;
        private BusinessRule businessRule;
       // int button;

        public CommunicationFacade(HardwareFacade hardwareFacade, BusinessRule businessRule)
        {
            this.hardwareFacade = hardwareFacade;
            this.businessRule = businessRule;

            //hardwareFacade.SelectionButtons[button].Pressed += CommunicationFacade_Pressed;

        }

        public void selectionButton(int button)
        {
            hardwareFacade.SelectionButtons[button].Pressed += businessRule.getProduct;
            hardwareFacade.SelectionButtons[button].Press();
        }

        //Used to display the product name to a touch screen or scrolling text bar
        public void getName(string Item)
        {
            //hardwareFacade.Display.Message = Item;
        }
    }
}
