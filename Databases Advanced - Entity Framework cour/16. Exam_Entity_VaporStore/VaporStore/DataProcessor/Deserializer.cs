namespace VaporStore.DataProcessor
{
	using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using Newtonsoft.Json;
    using VaporStore.Data.Models;
    using VaporStore.Data.Models.Enums;
    using VaporStore.DataProcessor.Dto.Import;

    public static class Deserializer
	{
		public static string ImportGames(VaporStoreDbContext context, string jsonString)
		{
			StringBuilder sb = new StringBuilder();

			ImportGamesDto[] games = JsonConvert.DeserializeObject<ImportGamesDto[]>(jsonString);

			List<Game> validGame = new List<Game>();
			List<Developer> validDeveloper = new List<Developer>();
			List<Genre> validGenre = new List<Genre>();
			List<Tag> validTag = new List<Tag>();


			//"Name": "Dota 2",
			//"Price": 0,
			//"ReleaseDate": "2013-07-09",
			//"Developer": "Valve",
			//"Genre": "Action",
			//"Tags": [

			foreach (var game in games)
			{

				//if (game.Price<0&&game.Name == null && game.ReleaseDate == null && game.Developer == null && game.Genre == null)
				//{
				//	sb.AppendLine("Invalid Data");
				//	continue;
				//}

				if (!IsValid(game))
				{
					sb.AppendLine("Invalid Data");
						continue;
				}

				bool isGameDateValid = DateTime.TryParseExact
				 (game.ReleaseDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime gameReleaseDate);

				if (!isGameDateValid)
				{
					sb.AppendLine("Invalid Data");
					continue;
				}

				var currentDeveloper = validDeveloper.FirstOrDefault(x => x.Name == game.Developer);

				if (currentDeveloper==null)
				{
					Developer developer = new Developer()
					{
						Name = game.Developer
					};

					validDeveloper.Add(developer);
					currentDeveloper = developer;
				
				}

				var currentGanre = validGenre.FirstOrDefault(x => x.Name == game.Genre);

				if (currentGanre==null)
				{
					Genre genre = new Genre()
					{
						Name = game.Genre
					};

					validGenre.Add(genre);

					currentGanre = genre;
				}
				

				

				List<GameTag> gametags = new List<GameTag>();

				foreach (var tag in game.Tags)
				{
					var currentTag = validTag.FirstOrDefault(x => x.Name == tag);

					if (currentTag==null)
					{
						Tag newTag = new Tag()
						{
							Name = tag
						};

						validTag.Add(newTag);

						currentTag = newTag;
					}
					
					

					GameTag gameTag = new GameTag()
					{
						Tag=currentTag,					
					};

					if (!gametags. Contains(gameTag))
					{
						gametags.Add(gameTag);
					}
				}

				Game currentGame = new Game()
				{
					Name = game.Name,
					Price = game.Price,
					ReleaseDate = gameReleaseDate,
					Developer = currentDeveloper,
					Genre = currentGanre,
					GameTags = gametags

					//        Game
					//•	Id – integer, Primary Key
					//•	Name – text(required)
					//•	Price – decimal (non-negative, minimum value: 0) (required)
					//•	ReleaseDate – Date(required)
					//•	DeveloperId – integer, foreign key(required)
					//•	Developer – the game’s developer(required)
					//•	GenreId – integer, foreign key(required)
					//•	Genre – the game’s genre(required)
					//•	Purchases - collection of type Purchase
					//•	GameTags - collection of type GameTag.Each game must have at least one tag.

				};

				validGame.Add(currentGame);
				sb.AppendLine($"Added {currentGame.Name} ({currentGame.Genre.Name}) with {currentGame.GameTags.Count} tags");

			}

			context.Games.AddRange(validGame);
			//context.Developers.AddRange(validDeveloper);
			//context.Genres.AddRange(validGenre);
			//context.Tags.AddRange(validTag);

			context.SaveChanges();

			return sb.ToString().TrimEnd();

		}

		public static string ImportUsers(VaporStoreDbContext context, string jsonString)
		{
			StringBuilder sb = new StringBuilder();

			ImportUsersAndCards[] usersDto = JsonConvert.DeserializeObject<ImportUsersAndCards[]>(jsonString);

			List<User> validUser = new List<User>();

			foreach (var user in usersDto)
			{
				List<Card> validCards = new List<Card>();


				if (!IsValid(user))
				{
					sb.AppendLine("Invalid Data");
					continue;
				}

				foreach (var card in user.Cards)
				{
					//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
					bool isValidCardType = Enum.TryParse<CardType>(card.Type, out CardType cardType);

					if (!IsValid(card) && !isValidCardType)
					{
						sb.AppendLine("Invalid Data");
						continue;
					}
									

					Card currentCard = new Card()
					{
						Number = card.Number,
						Cvc = card.CVC,
						Type =cardType

					};

					validCards.Add(currentCard);

					

				}


				User currentUser = new User()
				{
					FullName = user.FullName,
					Username = user.Username,
					Email = user.Email,
					Age = user.Age,
					Cards=validCards
									
				};

				validUser.Add(currentUser);

				sb.AppendLine($"Imported {currentUser.Username} with {currentUser.Cards.Count} cards"!);
				//"FullName": "",
				//"Username": "invalid",
				//"Email": "invalid@invalid.com",
				//"Age": 20,
				//"Cards": [
				//	{
				//		"Number": "1111 1111 1111 1111",
				//		"CVC": "111",
				//		"Type": "Debit"
				//	}
				//]
			}

			context.AddRange(validUser);

			context.SaveChanges();

			return sb.ToString().TrimEnd();

		}

		public static string ImportPurchases(VaporStoreDbContext context, string xmlString)
		{
			StringBuilder sb = new StringBuilder();

			XmlRootAttribute xmlRoot = new XmlRootAttribute("Purchases");

			XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportPurchases[]), xmlRoot);

			using StringReader sr = new StringReader(xmlString);

			ImportPurchases[] purchasesDto = (ImportPurchases[])xmlSerializer.Deserialize(sr);

			HashSet<Purchase> validPurchases = new HashSet<Purchase>();

			foreach (var purchase in purchasesDto)
			{
				
				//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
				bool isValidCType = Enum.TryParse<PurchaseType>(purchase.Type, out PurchaseType purchaseType);

				bool isDateValid = DateTime.TryParseExact
				 (purchase.Date, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime validDate);

				var card = context.Cards.FirstOrDefault(x => x.Number == purchase.Card);

				var game = context.Games.FirstOrDefault(x => x.Name == purchase.Title);

				if (!IsValid(purchase) && !isValidCType && !isDateValid &&card==null&&game==null)
				{
					sb.AppendLine("Invalid Data");
					continue;
				}

		
				Purchase currentPurchase = new Purchase()
				{
				Type= purchaseType,
				ProductKey=purchase.Key,
				Date=validDate,
				Card=card,
				Game=game
				};

				validPurchases.Add(currentPurchase);

				var username = context.Users.FirstOrDefault(x => x.Cards.Any(a => a.Number == card.Number));

				sb.AppendLine($"Imported {purchase.Title} for {username.Username}");
				  //      <Purchases>
				  //<Purchase
				  //title = "Dungeon Warfare 2" >

				//  < Type > Digital </ Type >

				//  < Key > ZTZ3 - 0D2S-G4TJ</Key>

				//  <Card>1833 5024 0553 6211</Card>

				//  <Date>07/12/2016 05:49</Date>
				//</Purchase>
			}

			context.AddRange(validPurchases);

			context.SaveChanges();

			return sb.ToString().TrimEnd();
		}

		private static bool IsValid(object dto)
		{
			var validationContext = new ValidationContext(dto);
			var validationResult = new List<ValidationResult>();

			return Validator.TryValidateObject(dto, validationContext, validationResult, true);
		}
	}
}