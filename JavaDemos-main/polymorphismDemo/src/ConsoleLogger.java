public class ConsoleLogger extends  BaseLogger {

    public  void Log(String message){
        //plug and play:tak çalıştır
        System.out.println("Logger to console : " + message);
    }
}
