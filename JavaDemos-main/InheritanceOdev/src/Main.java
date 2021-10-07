public class Main {

    public static void main(String[] args) {
	Student student=new Student();
	Instructor engin=new Instructor();
	engin.setId(15);
	student.setId(52);

	UserManager userManager=new UserManager();
	User []  users={engin,student};
	UserManager.addMultiple(users);
    }
}
