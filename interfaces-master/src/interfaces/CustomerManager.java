package interfaces;

public class CustomerManager {  
	
	private Logger[] loggers;
	
	public CustomerManager (Logger[] loggers) {
		this.loggers = loggers;
	}
 	//CustomerManager loglamaya ba��ml� iki t�r ba��ml�l�k vard�r
	//loosly(gev�ek ba�l�)-tightly coupled(kat� ba�l�)
	
	
	public void Add(Customer customer) {
		System.out.println("M��teri eklendi "  + customer.getFirstName());
		
		
		Utils.runLogers(loggers, customer.getFirstName());
	
    
	
	}
	public  void Delete(Customer customer) {
		System.out.println("M��teri silindi "  + customer.getFirstName());
		
		 Utils.runLogers(loggers, customer.getLastName());
	}
}
