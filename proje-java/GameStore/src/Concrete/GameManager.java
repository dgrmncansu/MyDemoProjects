package Concrete;

import Abstract.GameService;
import Entities.Game;

public class GameManager implements GameService {

	@Override
	public void Add(Game game) {
		System.out.println("Oyun Sisteme Eklendi");
		
	}

	@Override
	public void Update(Game game) {
		System.out.println("Oyun Sisteme Güncellendi");
		
	}

	@Override
	public void Delete(Game game) {
		System.out.println("Oyun Sistem'den Silindi");
		
	}
	

}