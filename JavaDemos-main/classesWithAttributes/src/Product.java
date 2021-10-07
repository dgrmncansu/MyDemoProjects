public class Product {

    //6 Parametreli Constructor'ı var demektir.

    public  Product(int id,String  name,String description,double price,int stockAmount,String color,String code){
        System.out.println("Yapıcı blok çalıştı");
        this.id=id;
        this.setName(name);
        this.setPrice(price);  //Bu olaya Overloding:Aşırı yükleme denir.
        this.setDescription(description);
        this.setStockAmount(stockAmount);
        this.setColor(color);
        this.setCode(code);

    }
    public  Product(){//Parametresiz

    }
    //attribute -field
    private int id;
    private String name;
    private String description;
    private double price;
    private int stockAmount;
    private String color;
    private String code;


    //getter
    public int getId() {
        return id;
    }

    //setter
    public void setId(int id) {
        this.id = id;

    }


    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public int getStockAmount() {
        return stockAmount;
    }

    public void setStockAmount(int stockAmount) {
        this.stockAmount = stockAmount;
    }

    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color;
    }

    public String getCode() {
        return this.getName().substring(0,1) + id;
    }

    public void setCode(String code) {
        this.code = code;
    }
}
