public class Main {

    public static void main(String[] args) {
//
//        BaseLogger[] loggers=new BaseLogger[]{new DataBaseLogger(),new FileLogger(),new EmailLogger(),new ConsoleLogger()};
//       for (BaseLogger logger:loggers){
//           logger.Log("Log mesajı");
//       }
        //Tam biçimlilik olduğu yer burasıdır.
       CustomerManager customerManager=new CustomerManager(new FileLogger());
       customerManager.add();
    }
}
