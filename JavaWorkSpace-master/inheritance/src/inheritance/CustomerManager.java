package inheritance;

public class CustomerManager {
	
public void Add( Customer customer) {
	System.out.println(customer.customerNumber + "kaydedildi.");
}

//bulk insert
public void AddMultiple(Customer[]customers) {
	for(Customer customer : customers) {
		Add(customer);
      }
     }
   }
//SOLÝD-Open Closed Principle