public class Main {

    public static void main(String[] args) {
        //bug= Uygulamadaki mantıksal veya sistemsel hatalara denir.
        //Açıklara bug denir.
        // bug olduğu için 1'e de asal sayı diyor çünkü 1 for'a hiç girmiyor. bu yüzden ilk iki if bloğu yazıldı.

        int number = 1;
        int remainder = number % 2;
       // System.out.println(remainder);
        boolean isPrime = true; // isPrime asal sayı mı demektir.

        if(number==1){
            System.out.println("Sayı asal değildir");
            return;// Gerisini işletmemesini engeller yani diğer bloklara geçmesini engeller.
            // Geçersiz salayılar için for üzerinde return ile biten if blokları yazılabilir.




        }

        if(number<1) {
            System.out.println("Geçersiz Sayı");
        }

        for (int i = 2; i < number; i++) {

            if (number % i == 0) {

                isPrime = false;
            }

        }


        if (isPrime){  // isPrime == true ile aynı şey

            System.out.println("Sayı asaldır");

        }else{
            System.out.println("Sayı asal değildir");
        }

    }


}
