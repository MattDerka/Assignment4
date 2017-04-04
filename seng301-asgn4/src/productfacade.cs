using Frontend4.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ProductFacade
{
    private HardwareFacade hardware;
    public event EventHandler<ProductEventArgs> released;

    public ProductFacade(HardwareFacade hardwarefacade)
    {
        hardware = hardwarefacade;
        foreach(var rack in hardware.ProductRacks)
        {
            rack.ProductRemoved += Rack_ProductRemoved;
        }
    }

    public void despenseProduct(int rackNum)
    {
        var num = hardware.ProductRacks[rackNum].Count;
        if (num == 0)
        {
            throw new Exception("No products left in rack");
        }
        hardware.ProductRacks[rackNum].DispenseProduct();
    }


    private void Rack_ProductRemoved(object sender, ProductEventArgs e)
    {
        this.released(sender, e);
    }
}

