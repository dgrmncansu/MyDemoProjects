public class Main {

    public static void main(String[] args) {

        // Diziler

        // Öğrenci eklendikçe tek tek yazdırmak gerekecektir.
        String ogrenci1="Cansu";
        String ogrenci2="Engin";
        String ogrenci3="Derin";
        String ogrenci4="Deniz";

        System.out.println(ogrenci1);
        System.out.println(ogrenci2);
        System.out.println(ogrenci3);
        System.out.println(ogrenci4);

        System.out.println("--------------------------");
        //C# ve Java gibi dillerde index'in 0 ile başladığı anlamına gelir. 0.elemanı=Cansu
       //Bu şekilde yapabiliriz:
        String [] ogrenciler= new String[4];

        ogrenciler[0]="Cansu";
        ogrenciler[1]="Engin";
        ogrenciler[2]="Derin";
        ogrenciler[3]="Deniz";
        //ogrenciler[4]="Ali";

        // Burada ise eleman sayısını 1 arttırıp öğrenciyi eklemek yeterlidir.
        for(int i=0; i<ogrenciler.length; i++){
            System.out.println(ogrenciler[i]);

        }
        //for böylede yazılabilir.

        for(String ogrenci : ogrenciler){
            System.out.println(ogrenci);
        }
    }
}