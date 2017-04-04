using Frontend4;
using Frontend4.Hardware;
using seng301_asgn4.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ProductFacade
{
    private HardwareFacade hardware;
    private BusinessRule business;
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
        hardware.ProductRacks[rackNum].DispenseProduct();
    }

    public void loadProducts()

    public string getProductName(int rackNum)
    {
        var name = hardware.ProductKinds[rackNum].Name;
        return name;
    }

    public Cents getProductCost(int rackNum)
    {
        var name = hardware.ProductKinds[rackNum].Cost;
        return name;
    }

    private void Rack_ProductRemoved(object sender, ProductEventArgs e)
    {
        this.released(sender, e);
    }
}

