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


        public CommunicationFacade(HardwareFacade hardwareFacade, BusinessRule businessRule)
        {
            this.hardwareFacade = hardwareFacade;
            this.businessRule = businessRule;
        }

        public void selectionButton(int button)
        {
            hardwareFacade.SelectionButtons[button].Press();
        }
    }
}
