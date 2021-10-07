package Concrete;

import java.rmi.RemoteException;

import Abstract.PlayerCheckService;
import Abstract.PlayerService;
import Entities.Player;

public class PlayerManager implements PlayerService {
	
	
	PlayerCheckService playerCheckService;

	@Override
	public void Add(Player player) throws NumberFormatException, RemoteException {
		System.out.println("Oyuncu Eklendi");
		
	}

	@Override
	public void Update(Player player) {
		System.out.println("Oyuncu Güncellendi");
		
	}

	@Override
	public void Delete(Player player) {
		System.out.println("Oyuncu Silindi");
		
	}

	
}
