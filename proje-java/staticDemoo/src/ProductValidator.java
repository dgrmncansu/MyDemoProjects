public class ProductValidator {

    static {System.out.println("Static Yapıcı blok çalıştı");


    }
    public ProductValidator(){
        System.out.println("Yapıcı blok çalıştı");
    }
    public static  boolean isVolid(Product product){
//! değilse demektir
        if(product.price>0&& ! product.name.isEmpty()){
            return true;

        }else {
            return false;
        }
    }
    public  void bisey(){

    }
}
