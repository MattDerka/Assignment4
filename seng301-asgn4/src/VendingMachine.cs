using System;
using System.Collections.Generic;
using Frontend4;
using Frontend4.Hardware;
using seng301_asgn4.src;

/**
 * Represents vending machines, fully configured and with all software
 * installed.
 * 
 */
public class VendingMachine {

    // private BusinessRule businessRule;

    private HardwareFacade hardwareFacade;
    public HardwareFacade Hardware {
        get {
            return this.hardwareFacade;
        }
    }

    private ProductFacade productFacade;
    public ProductFacade product
    {
        get
        {
            return this.productFacade;
        }
    }


    private CommunicationFacade communicationFacade;
    public CommunicationFacade comm
    {
        get
        {
            return this.communicationFacade;
        }
    }

    private PaymentFacade paymentFacade;
    public PaymentFacade payment
    {
        get
        {
            return this.paymentFacade;
        }
    }

    private BusinessRule businessRule;
    public BusinessRule business
    {
        get
        {
            return this.businessRule;
        }
    }

    /**
     * Creates a standard arrangement for the vending machine. All the
     * components are created and interconnected. The hardware is initially
     * empty. The product kind names and costs are initialized to &quot; &quot;
     * and 1 respectively.
     * 
     * @param coinKinds
     *            The values (in cents) of each kind of coin. The order of the
     *            kinds is maintained. One coin rack is produced for each kind.
     *            Each kind must have a unique, positive value.
     * @param selectionButtonCount
     *            The number of selection buttons on the machine. Must be
     *            positive.
     * @param coinRackCapacity
     *            The maximum capacity of each coin rack in the machine. Must be
     *            positive.
     * @param productRackCapacity
     *            The maximum capacity of each product rack in the machine. Must
     *            be positive.
     * @param receptacleCapacity
     *            The maximum capacity of the coin receptacle, storage bin, and
     *            delivery chute. Must be positive.
     * @throws IllegalArgumentException
     *             If any of the arguments is null, or the size of productCosts
     *             and productNames differ.
     */
    public VendingMachine(Cents[] coinKinds, int selectionButtonCount, int coinRackCapacity, int productRackCapacity, int receptacleCapacity) {
	    this.hardwareFacade = new HardwareFacade(coinKinds, selectionButtonCount, coinRackCapacity, productRackCapacity, receptacleCapacity);
        /* YOU CAN BUILD AND INSTALL THE HARDWARE HERE */
        this.businessRule = new BusinessRule(this);
        this.productFacade = new ProductFacade(this);
        this.paymentFacade = new PaymentFacade(this);
        this.communicationFacade = new CommunicationFacade(this);
    }

    public void Configure(List<ProductKind> productKinds)
    {
        this.hardwareFacade.Configure(productKinds);
    }
}
