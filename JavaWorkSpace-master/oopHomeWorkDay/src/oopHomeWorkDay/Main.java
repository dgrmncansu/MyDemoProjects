package oopHomeWorkDay;

public class Main {

	public static void main(String[] args) {
		
		Courses course1= new Courses(0, "Yazýlým Geliþtirici Yetiþtirme Kampý (C# + ANGULAR)", 
				"2 ay sürecek Yazýlým Geliþtirici Yetiþtirme Kampýmýzýn takip, döküman ve duyurularýný"
				, "Engin Demirog",true);
		
		Courses course2= new Courses(1, "Yazýlým Geliþtirici Yetiþtirme Kampý (JAVA + REACT)", 
				"2 ay sürecek Yazýlým Geliþtirici Yetiþtirme Kampýmýzýn takip, döküman ve duyurularýný"
				, "Engin Demirog",true);
		
		Courses course3= new Courses(2, "Programlamaya Giriþ için Temel Kurs", 
				"PYTHON, JAVA, C# gibi tüm programlama dilleri için temel programlama mantýðýný anlaþýlýr"
				, "Engin Demirog",false);
	
		Courses[] courses= {course1,course2,course3};
	
		for(Courses course:courses) {
			System.out.println(course.title);
			System.out.println(course.details);
			System.out.println(course.teacher); 

			CheckStatus checkStatus=new CheckStatus();
			checkStatus.checkStatus(course);
			
		}
		
		
		
	}




	}


