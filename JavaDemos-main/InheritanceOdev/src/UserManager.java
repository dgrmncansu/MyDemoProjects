public class UserManager {
    public static void  Update(User user){
        System.out.println(user.getId() + "Numaralı kullanıcı eklenmiştir.");
    }
    //bulk insert
    public static void addMultiple(User[] users){
        for (User user:users){
            Update(user);
        }
    }

}
