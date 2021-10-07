package Concrete;

import adapters.CustomerService;

public abstract class BaseCustomerManager implements CustomerService {

	@Override
	 public void saved(Customer customer) throws Exception
     {
		 
        System.out.println("Saved to db  : "  + customer.getFirstName() +" " +customer.getLastName() + "  " +customer.getId() + "  " +customer.getDatetimeOfBirth());

     }
}
