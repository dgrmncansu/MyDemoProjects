package Concrete;

import Abstract.CampaignService;
import Entities.Campaign;

public class CampaignManager implements CampaignService {

	
	


	@Override
	public void Add(Campaign campaign) {
		System.out.println(campaign + "Kay�t eklendi");
		
	}

	@Override
	public void Update(Campaign campaign) {
		System.out.println(campaign + "Kay�t g�ncellendi");
		
	}

	@Override
	public void Delete(Campaign campaign) {
		System.out.println(campaign + "Kay�t silindi");		
	}
	
}	 

	