import java.rmi.RemoteException;

import Concrete.CampaignManager;
import Concrete.GameManager;
import Concrete.PlayerManager;
import Entities.Campaign;
import Entities.Game;
import Entities.Player;

public class Main {

	public static void main(String[] args)throws NumberFormatException, RemoteException {
		//Bu kimlik dogrulamasi Türk vatandasi olanlara aittir
		  
		
		Player player= new Player(1,"Cansu","Deðirmen","12345678901",1991);

		Game game= new Game(2,"Angel 2",500);
		
		Campaign campaign= new Campaign (3,"Summer Campaing",20);
		
		
		PlayerManager playerManager= new PlayerManager ();
		playerManager.Add(player);
		
		GameManager gameManager= new GameManager ();
		gameManager.Add(game);
		
		
		
		CampaignManager campaignManager= new CampaignManager ();
		campaignManager.Add(campaign);
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
	}

}
