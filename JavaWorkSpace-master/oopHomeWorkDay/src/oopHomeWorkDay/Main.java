package oopHomeWorkDay;

public class Main {

	public static void main(String[] args) {
		
		Courses course1= new Courses(0, "Yaz�l�m Geli�tirici Yeti�tirme Kamp� (C# + ANGULAR)", 
				"2 ay s�recek Yaz�l�m Geli�tirici Yeti�tirme Kamp�m�z�n takip, d�k�man ve duyurular�n�"
				, "Engin Demirog",true);
		
		Courses course2= new Courses(1, "Yaz�l�m Geli�tirici Yeti�tirme Kamp� (JAVA + REACT)", 
				"2 ay s�recek Yaz�l�m Geli�tirici Yeti�tirme Kamp�m�z�n takip, d�k�man ve duyurular�n�"
				, "Engin Demirog",true);
		
		Courses course3= new Courses(2, "Programlamaya Giri� i�in Temel Kurs", 
				"PYTHON, JAVA, C# gibi t�m programlama dilleri i�in temel programlama mant���n� anla��l�r"
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


