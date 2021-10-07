public class Main {

    public static void main(String[] args) {
        //Döngüler

        //for
        for (int i = 2; i < 10; i += 2) {
            System.out.println(i);

        }
        System.out.println("For Döngüsü bitti");
        //While
        int i = 2;
        while (i < 10) {

            System.out.println(i);
            i += 2;
            //infinite loop sonsuz döngü
        }
        System.out.println("While Döngüsü Bitti");

        //o döngünün çalıştığına dair,
        // o döngünün test edildiğine dair,
        // o döngünün girildiğine dair
        // loglandı kim hangi operasyonu ne zaman ne şekilde çağırdı


        //Do-While şart sağlanmadığı zaman bile şart satırına gelene kadar 1 kere çalışır.
        // şart sağlanmasa da döngüye girildiğine dair log'lama yapmak istersek kullanılabilir.


        int j = 1;
        do {
            System.out.println("Loglandı");

            System.out.println(j);
            j += 2;
        } while (j < 10);


        System.out.println("Do-While Döngüsü Bitti");
    }


}

