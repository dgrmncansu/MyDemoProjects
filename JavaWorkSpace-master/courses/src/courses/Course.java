package courses;

public class Course {
	
	
	public Course() {
		
	}
	
	int Id;
	
	double ViewRate;
	
	public String courseName;

	public double Rateofview; //viewRate

	
	public Course(int id, String courseName, double viewRate, String courseName2, double rateofview) {
		super();
		Id = id;
		this.courseName = courseName;
		this.ViewRate = viewRate;
		courseName = courseName2;
		Rateofview = rateofview;
	}


	public Course(int Id,String courseName,double ViewRate) {
		
		this.Id=Id;
		this.courseName = courseName;
		this.ViewRate=ViewRate;
		
		
		
	}
}
