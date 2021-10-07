package adapters;

import Concrete.Customer;

public interface CustomerCheckService  {
	
	boolean checkIfRealPerson(Customer customer);
	
}
