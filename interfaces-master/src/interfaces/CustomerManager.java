package interfaces;

public class CustomerManager {  
	
	private Logger[] loggers;
	
	public CustomerManager (Logger[] loggers) {
		this.loggers = loggers;
	}
 	//CustomerManager loglamaya baðýmlý iki tür baðýmlýlýk vardýr
	//loosly(gevþek baðlý)-tightly coupled(katý baðlý)
	
	
	public void Add(Customer customer) {
		System.out.println("Müþteri eklendi "  + customer.getFirstName());
		
		
		Utils.runLogers(loggers, customer.getFirstName());
	
    
	
	}
	public  void Delete(Customer customer) {
		System.out.println("Müþteri silindi "  + customer.getFirstName());
		
		 Utils.runLogers(loggers, customer.getLastName());
	}
}
