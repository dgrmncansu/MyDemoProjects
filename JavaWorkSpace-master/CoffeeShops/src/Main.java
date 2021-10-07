import Concrete.BaseCustomerManager;
import Concrete.Customer;
import Concrete.StarbucksCustomerManager;
import adapters.MernisServiceAdapter;

public class Main {

	public static void main(String[] args) throws Exception {
		BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
        customerManager.saved(new Customer(1, "Cansu","Deðirmen",1991,"1234567490"));
	}

}
