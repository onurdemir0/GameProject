using System;

namespace GameProject
{
	class Program
	{
		static void Main(string[] args)
		{
			GamerManager gamerManager = new GamerManager(new UserValidationManager());
			gamerManager.Save(new Gamer
			{
				Id = 1,
				FirstName = "Onur",
				LastName = "Demir",
				BirthYear = 1999,
				IdentityNumber = 12345
			});

			CampaignManager campaignManager = new CampaignManager();
			Campaigns blackFriday = new Campaigns();
			blackFriday.Id = 1;
			blackFriday.CampaignName = "Black Friday";
			blackFriday.CampaignDescription = "Is The Biggest Campaign In The Word";
			campaignManager.Add(blackFriday);

			GameSalesManager gameSalesManager = new GameSalesManager();
			gameSalesManager.GameSale(new Gamer
			{
				Id = 2,
				FirstName = "Uğur",
				LastName = "Demir",
				BirthYear = 1997,
				IdentityNumber = 12345
			},blackFriday);
		}
	}
}
