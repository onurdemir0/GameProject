using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class GamerManager : IGamerService
	{
		IUserValidationService _userValidationService;

		public GamerManager(IUserValidationService userValidationService)
		{
			_userValidationService = userValidationService;
		}

		public void Delete(Gamer gamer)
		{
			Console.WriteLine("Gamer Deleted");
		}
		public void Save(Gamer gamer)
		{
			if (_userValidationService.Validate(gamer) == true)
			{
				Console.WriteLine("Gamer Added");
			}
			else
			{
				Console.WriteLine("Validation failed");
			}
		}
		public void Update(Gamer gamer)
		{
			Console.WriteLine("Gamer Updated");
		}
	}
}
