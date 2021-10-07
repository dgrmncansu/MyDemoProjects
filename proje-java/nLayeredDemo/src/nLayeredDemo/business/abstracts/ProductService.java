package nLayeredDemo.business.abstracts;


import java.util.List;
import nLayeredDemo.entities.concrete.Product;
import nLayeredDemo.entities.concrete.Product;

public interface ProductService {

	void add(Product product);
	List<Product> getAll();
	
}
