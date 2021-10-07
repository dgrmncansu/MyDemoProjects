public class Main {

    public static void main(String[] args) {

        sayiBulmaca();


    }
    //fonksiyon isimleri -camel casing
    //class isimleri - Pascal casing
     public static void sayiBulmaca() {


         int[] sayilar = new int[]{1, 2, 5, 7, 9, 0};
         int aranacakSayi = 5;
         boolean varMi = false;

         for (int sayi : sayilar) {
             if (sayi == aranacakSayi) {
                 varMi = true;
                 break;

             }
         }

         String mesaj="";
         if (varMi) {
            mesaj= "Sayı mevcuttur:  "+ aranacakSayi;
            mesajVer(mesaj);
         } else {
             mesajVer("Sayı mevcut değildir: " + aranacakSayi);
         }

     }

     //parametreli method
     public static void mesajVer(String mesaj){
         System.out.println(mesaj);

     }
    }

