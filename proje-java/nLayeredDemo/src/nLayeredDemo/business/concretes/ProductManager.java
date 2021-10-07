package nLayeredDemo.business.concretes;
import nLayeredDemo.business.concretes.ProductManager;
import nLayeredDemo.dataAccess.concretes.HibernateProductDao;
import nLayeredDemo.entities.concrete.Product;

import java.util.List;

import nLayeredDemo.business.abstracts.ProductService;
import nLayeredDemo.dataAccess.abstracts.ProductDao;
import nLayeredDemo.dataAccess.concretes.HibernateProductDao;
import nLayeredDemo.entities.concrete.Product;

public class ProductManager implements ProductService {
	
	private ProductDao productDao;

	public ProductManager(ProductDao productDao) {
		super();
		this.productDao = productDao;
	}

	@Override
	public void add(Product product) {
		//iþ kodlarý
		
		
		if (product.getCategoryId()==1) {
			System.out.println("Bu kategoride ürün kabul edilmiyor");
			return;
		}
		
		HibernateProductDao dao = new HibernateProductDao();
		dao.add(product);
		
		this.productDao.add(product);
		
	 
	}

	@Override
	public List<Product> getAll() {
		// TODO Auto-generated method stub
		return null;
	}

}
