public class Main {

    public static void main(String[] args) {
        String message = " Bugün hava çok güzel.";
        System.out.println(message);

        /*System.out.println("Eleman sayısı:" + message.length());
        //charAt:genellikle bir metinde belli bir karakterdeki değeri belirler
        //Bir kişinin tc si istanbulda oturanların 1,
        //Bir kişinin tc si izmirde oturanların 2, gibi düşünülebilir
        //boşlukta bir karakterdir

        System.out.println("5.eleman : " + message.charAt(4));//
        System.out.println(message.concat(" Yaşasın!"));//concat:Stringleri birleştirmek
        System.out.println(message.startsWith(""));// ile başlar demek 'B' ile başlıyorsa true döndürür
        System.out.println(message.endsWith("l")); //ile biter demek 'l' ile bitiyor
        char[] characters = new char[5];
        message.getChars(0, 5, characters, 0);//Karakterleri al demek yani karakterlere ata. message da 0 dan 5 e kadar okur karakterlerr dizisine atar
        System.out.println(characters);
        System.out.println(message.indexOf("av"));//aramaya soldan başlar
        System.out.println(message.lastIndexOf("a"));//aramaya sağdan başlar*/


        String newMessage=message.replace(' ','-');//boşluğa getir
         System.out.println(newMessage);
         System.out.println(message.substring(2,5));//Bir metnin içerisinden parça almaktır.

        for(String word :message.split("  ")){ //Alt alta yazar
               System.out.println(word);

               System.out.println(message.toLowerCase());  //mesajı küçük harfe çevirir.
                System.out.println(message.toUpperCase()); //mesajı büyük harfe çevirir.
                System.out.println(message.trim()); //boşluk


        }

    }
}
