package courses;


public class Main {

	public static void main(String[] args) {
		
		
		Course course1 = new Course(1, "Yazılım Geliştirici Yazılım Kursu C#  +  Angular", 0);
		Course course2= new Course(2, "Yazılım Geliştirici Yazılım Kursu Java  +  React" , 0);
		Instructors instructor=new Instructors("Engin Demiroğ" ,1);
		
		Course[] courses=new Course[]{course1,course2};
		
		for (Course course : courses) {
			System.out.println(course.courseName);
			
			
		}
		
		//System.out.print(courses.length); //dizideki ekrana elemanların sayısını gösterir
		
		CourseManager coursesManager =new CourseManager();
		coursesManager.UpdateCourse(course1);
		
		//coursesManager.addToCart(course1);
		coursesManager.addToCart(course2);
		
		 
		InstructorsManager instructorManager=new InstructorsManager();
		instructorManager.addToCartInstructor(instructor);
				
		
	}

}
