using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class GameSalesManager
	{
		public void GameSale(Gamer gamer, Campaigns campaigns)
		{
			Console.WriteLine(gamer.FirstName + " ... oyununu " +
				campaigns.CampaignName + " kampanyasında başarıyla satın aldınız!");
		}
	}
}
