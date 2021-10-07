package Concrete;

import adapters.CustomerCheckService;

public class StarbucksCustomerManager extends BaseCustomerManager {

	
	
	private CustomerCheckService customerCheckService;
	public StarbucksCustomerManager (CustomerCheckService customerCheckService) { 
		this.customerCheckService= customerCheckService;
	
	}
	

	@Override
   public void saved(Customer customer) throws Exception
    {
        if (customerCheckService.checkIfRealPerson(customer))
        {
        	
          super.saved(customer);
          
            return;
        }
        else
        {
            throw new Exception("Not a valid person");
        }
    
     }
	
}
