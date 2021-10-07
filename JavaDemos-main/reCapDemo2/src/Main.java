public class Main {

    public static void main(String[] args) {
        double[] myList = {8.2, 9.3, 5.2, 3.4};
        // new'leyerek yazmak arasında bir fark yoktur.
        double total = 0;  // toplamları için
        double max = myList[0]; // en büyük sayı için

        for (double number : myList) {
            if (max < number) {
                //max ile karşılaştırma yapıyoruz eğer max<number 'dan ise
                // o anki number, max dan daha büyük ise
                // o zaman max=number diyoruz yani en büyük sayıyı
                // o anki sayı number olarak max'ı o an ki sayı olarak ata diyoruz

                max = number;
            }
            total = total + number;
            System.out.println(number);
        }
        System.out.println("Toplam=" + total);
        System.out.println("En Büyük=" + max);

    }
}
