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
    private VendingMachine d;


    public ProductFacade(VendingMachine vm)
    {
        this.d = vm;
    }

    public void despenseProduct(int rackNum)
    {
        
        d.Hardware.ProductRacks[rackNum].DispenseProduct();
    }

    public string getProductName(int rackNum)
    {
        var name = d.Hardware.ProductKinds[rackNum].Name;
        return name;
    }

    public Cents getProductCost(int rackNum)
    {
        var name = d.Hardware.ProductKinds[rackNum].Cost;
        return name;
    }

}

