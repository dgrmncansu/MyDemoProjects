package Concrete;

import Abstract.Entity;

public class Customer implements Entity{
	
	private int id;
	private String  FirstName;
	private String LastName;
	private int DatetimeOfBirth;
	private String nationalIdentity;
	
	
	
	
	public Customer() {
		
	}
	
	
	
	public Customer(int id, String firstName, String lastName, int datetimeOfBirth, String nationalIdentity) {
		super();
		this.id = id;
		FirstName = firstName;
		LastName = lastName;
		DatetimeOfBirth = datetimeOfBirth;
		this.nationalIdentity = nationalIdentity;
	}
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getFirstName() {
		return FirstName;
	}
	public void setFirstName(String firstName) {
		FirstName = firstName;
	}
	public String getLastName() {
		return LastName;
	}
	public void setLastName(String lastName) {
		LastName = lastName;
	}
	public int getDatetimeOfBirth() {
		return DatetimeOfBirth;
	}
	public void setDatetimeOfBirth(int datetimeOfBirth) {
		DatetimeOfBirth = datetimeOfBirth;
	}
	public String getNationality() {
		return nationalIdentity;
	}
	public void setNationality(String nationality) {
		this.nationalIdentity = nationality;
	}
	
	

}
