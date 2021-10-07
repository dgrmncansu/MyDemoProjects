import java.awt.desktop.SystemSleepEvent;

public class Main {

    public static void main(String[] args) {
        // if bloklarına göre switch blokları çok daha az kullanılır! genellikle
        // suistimal edilir.

        // switch blokları ile dallandırma yapılır!

    char grade='B';

    switch (grade){


        case 'A':
            System.out.println("Mükemmel : Geçtiniz");
         break;
        case 'B':
            System.out.println("Çok Güzel : Geçtiniz");
            break;
        case 'C':
            System.out.println("İyi : Geçtiniz");
            break;
        case 'D':
            System.out.println("Fena Değil: Geçtiniz");
            break;
        case 'F':
            System.out.println("Malesef: Kaldınız");
            break;
        default:
            System.out.println("Geçersiz Not Girdiniz");


      }
    }
}
