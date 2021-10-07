public class StudentManager extends UserManager {
    public  void  Add(Student student){
        System.out.println(student.getId() + "Numaralı kullanıcı eklenmiştir.");
    }
    //bulk insert
    public void AddMultiple(Student []students){
        for (Student student:students){
            Add(student);
        }
    }
}
