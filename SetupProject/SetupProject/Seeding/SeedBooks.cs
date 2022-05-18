using SetupProject.DAL;
using SetupProject.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SetupProject.Seeding
{
	public static class SeedBooks
	{
		public static void SeedAllBooks(AppDbContext db)
		{
			Int32 intBooksAdded = 0;
			String strBookTitle = "Begin";
			//Add the list of books
			List<Book> Books = new List<Book>();
			Book b1 = new Book()
			{
				PublishedDate = new DateTime(2016, 5, 7),
				UniqueNumber = 222001,
				Title = "Robert B. Parker's Slow Burn",
				Author = "Ace Atkins",
				Description = "Spenser is back, leaving a trail of antagonism as he investigates a series of suspicious Boston fires.",
				Price = 22.99m,
				InitialSellingPrice = 22.99m,
				Cost = 10.58m,
				InitialCost = 10.58m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 2,
				InitialInventory = 2,
				Discontinued = false,
			};
			b1.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b1);

			Book b2 = new Book()
			{
				PublishedDate = new DateTime(2015, 10, 17),
				UniqueNumber = 222002,
				Title = "All The Stars In The Heavens",
				Author = "Adriana Trigiani",
				Description = "A fictional treatment of the life of the actress Loretta Young focuses on her rumored affair with the married Clark Gable and her subsequent pregnancy.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 19.94m,
				InitialCost = 19.94m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 4,
				InitialInventory = 4,
				Discontinued = false,
			};
			b2.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b2);

			Book b3 = new Book()
			{
				PublishedDate = new DateTime(2013, 11, 30),
				UniqueNumber = 222003,
				Title = "The Supreme Macaroni Company",
				Author = "Adriana Trigiani",
				Description = "Tensions arise when Valentine Roncalli, a Greenwich Village shoe designer, marries a handsome Italian, and the two must balance careers, countries and families. The final book in the Valentine trilogy.",
				Price = 34.99m,
				InitialSellingPrice = 34.99m,
				Cost = 7m,
				InitialCost = 7m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b3.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b3);

			Book b4 = new Book()
			{
				PublishedDate = new DateTime(2018, 2, 3),
				UniqueNumber = 222004,
				Title = "The Grave's A Fine And Private Place",
				Author = "Alan Bradley",
				Description = "Flavia de Luce, a young British sleuth, gets involved in solving a murder after experiencing a family tragedy.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 21.83m,
				InitialCost = 21.83m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 5,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b4.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b4);

			Book b5 = new Book()
			{
				PublishedDate = new DateTime(2012, 6, 16),
				UniqueNumber = 222005,
				Title = "Mission To Paris",
				Author = "Alan Furst",
				Description = "In Paris in 1938, an actor stumbles into the clutches of Nazi conspirators who want to exploit his celebrity.",
				Price = 27m,
				InitialSellingPrice = 27m,
				Cost = 19.17m,
				InitialCost = 19.17m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b5.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b5);

			Book b6 = new Book()
			{
				PublishedDate = new DateTime(2014, 2, 15),
				UniqueNumber = 222006,
				Title = "The Counterfeit Agent",
				Author = "Alex Berenson",
				Description = "John Wells is sent on a mission to find the truth about a mysterious Iranian package said to be bound for the United States.",
				Price = 16.99m,
				InitialSellingPrice = 16.99m,
				Cost = 9.68m,
				InitialCost = 9.68m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b6.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
			Books.Add(b6);

			Book b7 = new Book()
			{
				PublishedDate = new DateTime(2010, 2, 13),
				UniqueNumber = 222007,
				Title = "The Midnight House",
				Author = "Alex Berenson",
				Description = "Who is killing members of a secret unit that interrogated terrorists? The C.I.A. agent John Wells is on the case.",
				Price = 25.95m,
				InitialSellingPrice = 25.95m,
				Cost = 3.11m,
				InitialCost = 3.11m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 5,
				Inventory = 5,
				InitialInventory = 5,
				Discontinued = false,
			};
			b7.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
			Books.Add(b7);

			Book b8 = new Book()
			{
				PublishedDate = new DateTime(2013, 2, 16),
				UniqueNumber = 222008,
				Title = "The Night Ranger",
				Author = "Alex Berenson",
				Description = "The former C.I.A. operative John Wells pitches in when four young Americans who work at a refugee camp in Somalia are hijacked by bandits.",
				Price = 27.95m,
				InitialSellingPrice = 27.95m,
				Cost = 6.71m,
				InitialCost = 6.71m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 4,
				InitialInventory = 4,
				Discontinued = false,
			};
			b8.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
			Books.Add(b8);

			Book b9 = new Book()
			{
				PublishedDate = new DateTime(2015, 2, 14),
				UniqueNumber = 222009,
				Title = "Twelve Days",
				Author = "Alex Berenson",
				Description = "The former C.I.A. operative John Wells discovers a plot to trick the president into invading Iran.",
				Price = 25m,
				InitialSellingPrice = 25m,
				Cost = 18.5m,
				InitialCost = 18.5m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b9.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
			Books.Add(b9);

			Book b10 = new Book()
			{
				PublishedDate = new DateTime(2016, 12, 24),
				UniqueNumber = 222010,
				Title = "Rogue One: A Star Wars Story",
				Author = "Alexander Freed",
				Description = "A novelization of the new movie, including additional scenes.",
				Price = 33.95m,
				InitialSellingPrice = 33.95m,
				Cost = 23.77m,
				InitialCost = 23.77m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b10.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
			Books.Add(b10);

			Book b11 = new Book()
			{
				PublishedDate = new DateTime(2014, 11, 1),
				UniqueNumber = 222011,
				Title = "The Handsome Man's De Luxe Café",
				Author = "Alexander McCall Smith",
				Description = "The 15th book in the No. 1 Ladies’ Detective Agency series.",
				Price = 25.95m,
				InitialSellingPrice = 25.95m,
				Cost = 17.91m,
				InitialCost = 17.91m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b11.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b11);

			Book b12 = new Book()
			{
				PublishedDate = new DateTime(2017, 11, 11),
				UniqueNumber = 222012,
				Title = "The House Of Unexpected Sisters",
				Author = "Alexander McCall Smith",
				Description = "During an investigation, Precious Ramotswe encounters a man from her past and a nurse who has her last name.",
				Price = 29.95m,
				InitialSellingPrice = 29.95m,
				Cost = 16.47m,
				InitialCost = 16.47m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 1,
				InitialInventory = 1,
				Discontinued = false,
			};
			b12.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b12);

			Book b13 = new Book()
			{
				PublishedDate = new DateTime(2011, 4, 23),
				UniqueNumber = 222013,
				Title = "Quicksilver",
				Author = "Amanda Quick",
				Description = "In this Arcane Society novel set in Victorian London, two paranormal talents must find a murderer before they become the next victims.",
				Price = 25.95m,
				InitialSellingPrice = 25.95m,
				Cost = 23.1m,
				InitialCost = 23.1m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 0,
				InitialInventory = 0,
				Discontinued = false,
			};
			b13.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b13);

			Book b14 = new Book()
			{
				PublishedDate = new DateTime(2008, 8, 9),
				UniqueNumber = 222014,
				Title = "The Gargoyle",
				Author = "Andrew Davidson",
				Description = "A hideously burned man is cared for by a sculptress who claims they were lovers seven centuries ago.",
				Price = 25.95m,
				InitialSellingPrice = 25.95m,
				Cost = 16.09m,
				InitialCost = 16.09m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 5,
				InitialInventory = 5,
				Discontinued = true,
			};
			b14.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b14);

			Book b15 = new Book()
			{
				PublishedDate = new DateTime(2010, 5, 1),
				UniqueNumber = 222015,
				Title = "Reckless",
				Author = "Andrew Gross",
				Description = "A close friend from the investigator Ty Hauck's past has been brutally murdered, and he will risk everything he loves to avenge her death.",
				Price = 22m,
				InitialSellingPrice = 22m,
				Cost = 9.46m,
				InitialCost = 9.46m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b15.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
			Books.Add(b15);

			Book b16 = new Book()
			{
				PublishedDate = new DateTime(2017, 11, 18),
				UniqueNumber = 222016,
				Title = "Artemis",
				Author = "Andy Weir",
				Description = "A small-time smuggler living in a lunar colony schemes to pay off an old debt by pulling off a challenging heist.",
				Price = 31m,
				InitialSellingPrice = 31m,
				Cost = 18.91m,
				InitialCost = 18.91m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b16.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
			Books.Add(b16);

			Book b17 = new Book()
			{
				PublishedDate = new DateTime(2017, 4, 15),
				UniqueNumber = 222017,
				Title = "Song Of The Lion",
				Author = "Anne Hillerman",
				Description = "The third Southwestern mystery featuring the Navajo police officer Bernadette Manuelito and her husband, Jim Chee.",
				Price = 31.99m,
				InitialSellingPrice = 31.99m,
				Cost = 24.63m,
				InitialCost = 24.63m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b17.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b17);

			Book b18 = new Book()
			{
				PublishedDate = new DateTime(2012, 9, 1),
				UniqueNumber = 222018,
				Title = "A Sunless Sea",
				Author = "Anne Perry",
				Description = "A murder case for William Monk of the Thames River Police culminates in a government minister’s corruption trial.",
				Price = 26m,
				InitialSellingPrice = 26m,
				Cost = 22.62m,
				InitialCost = 22.62m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 2,
				InitialInventory = 2,
				Discontinued = false,
			};
			b18.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b18);

			Book b19 = new Book()
			{
				PublishedDate = new DateTime(2015, 2, 14),
				UniqueNumber = 222019,
				Title = "A Spool Of Blue Thread",
				Author = "Anne Tyler",
				Description = "Four generations of a family are drawn to a house in the Baltimore suburbs.",
				Price = 15.95m,
				InitialSellingPrice = 15.95m,
				Cost = 1.75m,
				InitialCost = 1.75m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b19.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b19);

			Book b20 = new Book()
			{
				PublishedDate = new DateTime(2014, 5, 10),
				UniqueNumber = 222020,
				Title = "All The Light We Cannot See",
				Author = "Anthony Doerr",
				Description = "The lives of a blind French girl and a gadget-obsessed German boy before and during World War II, when their paths eventually cross.",
				Price = 23.95m,
				InitialSellingPrice = 23.95m,
				Cost = 10.3m,
				InitialCost = 10.3m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b20.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b20);

			Book b21 = new Book()
			{
				PublishedDate = new DateTime(2008, 8, 23),
				UniqueNumber = 222021,
				Title = "Being Elizabeth",
				Author = "Barbara Taylor Bradford",
				Description = "A 25-year-old newly in control of her family’s corporate empire faces tough choices in business and in love.",
				Price = 27.95m,
				InitialSellingPrice = 27.95m,
				Cost = 21.8m,
				InitialCost = 21.8m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 5,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b21.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b21);

			Book b22 = new Book()
			{
				PublishedDate = new DateTime(2014, 4, 5),
				UniqueNumber = 222022,
				Title = "Cavendon Hall",
				Author = "Barbara Taylor Bradford",
				Description = "In Edwardian England, an aristocratic family and the family who serve them share an ancestral home.",
				Price = 26m,
				InitialSellingPrice = 26m,
				Cost = 8.06m,
				InitialCost = 8.06m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 5,
				InitialInventory = 5,
				Discontinued = false,
			};
			b22.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b22);

			Book b23 = new Book()
			{
				PublishedDate = new DateTime(2013, 10, 26),
				UniqueNumber = 222023,
				Title = "Aimless Love",
				Author = "Billy Collins",
				Description = "More than 50 new poems as well as selections from previous books from the two-term poet laureate of the Untied States.",
				Price = 30.99m,
				InitialSellingPrice = 30.99m,
				Cost = 25.41m,
				InitialCost = 25.41m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b23.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Poetry");
			Books.Add(b23);

			Book b24 = new Book()
			{
				PublishedDate = new DateTime(2011, 1, 15),
				UniqueNumber = 222024,
				Title = "The Inner Circle",
				Author = "Brad Meltzer",
				Description = "An archivist discovers a book that once belonged to George Washington and conceals a deadly secret.",
				Price = 26.99m,
				InitialSellingPrice = 26.99m,
				Cost = 11.61m,
				InitialCost = 11.61m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b24.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b24);

			Book b25 = new Book()
			{
				PublishedDate = new DateTime(2017, 1, 14),
				UniqueNumber = 222025,
				Title = "Ring Of Fire",
				Author = "Brad Taylor",
				Description = "Pike Logan, a member of a secret counterterrorist unit called the Taskforce, investigates a Saudi-backed Moroccan terrorist cell.",
				Price = 22m,
				InitialSellingPrice = 22m,
				Cost = 19.58m,
				InitialCost = 19.58m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b25.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b25);

			Book b26 = new Book()
			{
				PublishedDate = new DateTime(2011, 7, 30),
				UniqueNumber = 222026,
				Title = "Full Black",
				Author = "Brad Thor",
				Description = "The covert counterterrorism operative Scot Harvath has a plan to stop a terrorist group that wants to take down the United States.",
				Price = 26.99m,
				InitialSellingPrice = 26.99m,
				Cost = 5.67m,
				InitialCost = 5.67m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 1,
				InitialInventory = 1,
				Discontinued = false,
			};
			b26.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b26);

			Book b27 = new Book()
			{
				PublishedDate = new DateTime(2011, 8, 6),
				UniqueNumber = 222027,
				Title = "Back Of Beyond",
				Author = "C J Box",
				Description = "Cody Hoyt, a brilliant cop and an alcoholic struggling with two months of sobriety, is determined to find his mentor’s killer.",
				Price = 25.99m,
				InitialSellingPrice = 25.99m,
				Cost = 24.69m,
				InitialCost = 24.69m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b27.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b27);

			Book b28 = new Book()
			{
				PublishedDate = new DateTime(2008, 9, 27),
				UniqueNumber = 222028,
				Title = "One Fifth Avenue",
				Author = "Candace Bushnell",
				Description = "The worlds of gossip, theater and hedge funds have one address in common.",
				Price = 25.95m,
				InitialSellingPrice = 25.95m,
				Cost = 17.65m,
				InitialCost = 17.65m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 2,
				InitialInventory = 2,
				Discontinued = false,
			};
			b28.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b28);

			Book b29 = new Book()
			{
				PublishedDate = new DateTime(2010, 4, 17),
				UniqueNumber = 222029,
				Title = "Wrecked",
				Author = "Carol Higgins Clark",
				Description = "In the 13th mystery in this series, the suspicious disappearance of a neighbor interrupts a romantic weekend on Cape Cod for the P.I. Regan Reilly and her husband.",
				Price = 25m,
				InitialSellingPrice = 25m,
				Cost = 18m,
				InitialCost = 18m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b29.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b29);

			Book b30 = new Book()
			{
				PublishedDate = new DateTime(2017, 9, 16),
				UniqueNumber = 222030,
				Title = "Little Fires Everywhere",
				Author = "Celeste Ng",
				Description = "An artist with a mysterious past and a disregard for the status quo upends a quiet town outside Cleveland.",
				Price = 16m,
				InitialSellingPrice = 16m,
				Cost = 12m,
				InitialCost = 12m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b30.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b30);

			Book b31 = new Book()
			{
				PublishedDate = new DateTime(2009, 5, 9),
				UniqueNumber = 222031,
				Title = "Dead And Gone",
				Author = "Charlaine Harris",
				Description = "Sookie Stackhouse searches for the killer of a werepanther.",
				Price = 25.95m,
				InitialSellingPrice = 25.95m,
				Cost = 24.65m,
				InitialCost = 24.65m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 5,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b31.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b31);

			Book b32 = new Book()
			{
				PublishedDate = new DateTime(2011, 10, 1),
				UniqueNumber = 222032,
				Title = "Nightwoods",
				Author = "Charles Frazier",
				Description = "When a young woman inherits her murdered sister’s troubled twins, her solitary life becomes filled with mystery and action.",
				Price = 26m,
				InitialSellingPrice = 26m,
				Cost = 10.92m,
				InitialCost = 10.92m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b32.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b32);

			Book b33 = new Book()
			{
				PublishedDate = new DateTime(2014, 1, 25),
				UniqueNumber = 222033,
				Title = "Hunting Shadows",
				Author = "Charles Todd",
				Description = "In the aftermath of World War I, a Scotland Yard detective with a heavy burden of guilt, investigates two murders in Cambridgeshire that may be linked.",
				Price = 32.99m,
				InitialSellingPrice = 32.99m,
				Cost = 18.47m,
				InitialCost = 18.47m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b33.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b33);

			Book b34 = new Book()
			{
				PublishedDate = new DateTime(2018, 1, 13),
				UniqueNumber = 222034,
				Title = "The Immortalists",
				Author = "Chloe Benjamin",
				Description = "Four adolescents learn the dates of their deaths from a psychic and their lives go on different courses.",
				Price = 31m,
				InitialSellingPrice = 31m,
				Cost = 22.32m,
				InitialCost = 22.32m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b34.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b34);

			Book b35 = new Book()
			{
				PublishedDate = new DateTime(2016, 6, 4),
				UniqueNumber = 222035,
				Title = "The Emperor's Revenge",
				Author = "Clive Cussler and Boyd Morrison",
				Description = "Juan Cabrillo teams up with a former C.I.A. colleague to thwart a plan involving the death of millions and international economic meltdown.",
				Price = 27.99m,
				InitialSellingPrice = 27.99m,
				Cost = 20.43m,
				InitialCost = 20.43m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 3,
				InitialInventory = 3,
				Discontinued = false,
			};
			b35.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b35);

			Book b36 = new Book()
			{
				PublishedDate = new DateTime(2010, 11, 20),
				UniqueNumber = 222036,
				Title = "Crescent Dawn",
				Author = "Clive Cussler and Dirk Cussler",
				Description = "Dirk Pitt seeks a tie between a trove of ancient Roman artifacts and a series of mosque explosions.",
				Price = 27.95m,
				InitialSellingPrice = 27.95m,
				Cost = 20.12m,
				InitialCost = 20.12m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 5,
				InitialInventory = 5,
				Discontinued = false,
			};
			b36.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure");
			Books.Add(b36);

			Book b37 = new Book()
			{
				PublishedDate = new DateTime(2017, 6, 3),
				UniqueNumber = 222037,
				Title = "Nighthawk",
				Author = "Clive Cussler and Graham Brown",
				Description = "The NUMA crew races the Russians and Chinese in a hunt for a missing American aircraft.",
				Price = 30m,
				InitialSellingPrice = 30m,
				Cost = 21.6m,
				InitialCost = 21.6m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b37.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
			Books.Add(b37);

			Book b38 = new Book()
			{
				PublishedDate = new DateTime(2015, 11, 21),
				UniqueNumber = 222038,
				Title = "The Pharaoh's Secret",
				Author = "Clive Cussler and Graham Brown",
				Description = "Kurt Austin and Joe Zavala must save the NUMA crew from a mysterious toxin deployed by a villain who wants to build a new Egyptian empire.",
				Price = 31.95m,
				InitialSellingPrice = 31.95m,
				Cost = 12.46m,
				InitialCost = 12.46m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 3,
				InitialInventory = 3,
				Discontinued = false,
			};
			b38.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
			Books.Add(b38);

			Book b39 = new Book()
			{
				PublishedDate = new DateTime(2013, 6, 1),
				UniqueNumber = 222039,
				Title = "Zero Hour",
				Author = "Clive Cussler and Graham Brown",
				Description = "Kurt Austin, Joe Zavala and the rest of the Numa team search for a physicist's machine, buried in an ocean trench, that can cause deadly earthquakes in the 11th Numa Files novel.",
				Price = 28.95m,
				InitialSellingPrice = 28.95m,
				Cost = 25.19m,
				InitialCost = 25.19m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b39.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
			Books.Add(b39);

			Book b40 = new Book()
			{
				PublishedDate = new DateTime(2016, 3, 5),
				UniqueNumber = 222040,
				Title = "The Gangster",
				Author = "Clive Cussler and Justin Scott",
				Description = "n the ninth book in this series, set in 1906, the New York detective Isaac Bell contends with a crime boss passing as a respectable businessman and a tycoon’s plot against President Theodore Roosevelt.",
				Price = 30.95m,
				InitialSellingPrice = 30.95m,
				Cost = 7.12m,
				InitialCost = 7.12m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 13,
				InitialInventory = 13,
				Discontinued = false,
			};
			b40.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
			Books.Add(b40);

			Book b41 = new Book()
			{
				PublishedDate = new DateTime(2015, 9, 5),
				UniqueNumber = 222041,
				Title = "The Solomon Curse",
				Author = "Clive Cussler and Russell Blake",
				Description = "The wealthy couple Sam and Remi Fargo investigate a dangerous legend in the Solomon Islands.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 18.06m,
				InitialCost = 18.06m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b41.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
			Books.Add(b41);

			Book b42 = new Book()
			{
				PublishedDate = new DateTime(2009, 5, 9),
				UniqueNumber = 222042,
				Title = "Brooklyn",
				Author = "Colm Toibin",
				Description = "An unsophisticated young Irishwoman leaves her home for New York in the 1950s. Originally published in 2009 and the basis of the 2015 movie.",
				Price = 18.95m,
				InitialSellingPrice = 18.95m,
				Cost = 3.6m,
				InitialCost = 3.6m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 1,
				InitialInventory = 1,
				Discontinued = false,
			};
			b42.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b42);

			Book b43 = new Book()
			{
				PublishedDate = new DateTime(2014, 10, 11),
				UniqueNumber = 222043,
				Title = "Nora Webster",
				Author = "Colm Toibin",
				Description = "In the 1970s, an Irish widow struggles to find her identity.",
				Price = 30.99m,
				InitialSellingPrice = 30.99m,
				Cost = 4.65m,
				InitialCost = 4.65m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 3,
				InitialInventory = 3,
				Discontinued = false,
			};
			b43.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b43);

			Book b44 = new Book()
			{
				PublishedDate = new DateTime(2016, 8, 6),
				UniqueNumber = 222044,
				Title = "The Underground Railroad",
				Author = "Colson Whitehead",
				Description = "A slave girl heads toward freedom on the network, envisioned as actual tracks and tunnels.",
				Price = 32m,
				InitialSellingPrice = 32m,
				Cost = 3.2m,
				InitialCost = 3.2m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 12,
				InitialInventory = 12,
				Discontinued = false,
			};
			b44.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b44);

			Book b45 = new Book()
			{
				PublishedDate = new DateTime(2013, 6, 29),
				UniqueNumber = 222045,
				Title = "Sisterland",
				Author = "Curtis Sittenfeld",
				Description = "Twins with psychic abilities share a devastating secret.",
				Price = 27.99m,
				InitialSellingPrice = 27.99m,
				Cost = 20.71m,
				InitialCost = 20.71m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b45.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b45);

			Book b46 = new Book()
			{
				PublishedDate = new DateTime(2010, 5, 15),
				UniqueNumber = 222046,
				Title = "Executive Intent",
				Author = "Dale Brown",
				Description = "With the United States unleashing a missile-launching satellite that can strike anywhere in seconds, China and Russia respond swiftly and brutally.",
				Price = 27.95m,
				InitialSellingPrice = 27.95m,
				Cost = 22.64m,
				InitialCost = 22.64m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b46.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
			Books.Add(b46);

			Book b47 = new Book()
			{
				PublishedDate = new DateTime(2017, 7, 15),
				UniqueNumber = 222047,
				Title = "House Of Spies",
				Author = "Daniel Silva",
				Description = "Gabriel Allon, the Israeli art restorer and spy, now the head of Israel’s secret intelligence service, pursues an ISIS mastermind.",
				Price = 33.95m,
				InitialSellingPrice = 33.95m,
				Cost = 17.31m,
				InitialCost = 17.31m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 5,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b47.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b47);

			Book b48 = new Book()
			{
				PublishedDate = new DateTime(2013, 7, 20),
				UniqueNumber = 222048,
				Title = "The English Girl",
				Author = "Daniel Silva",
				Description = "Gabriel Allon, an art restorer and occasional spy for the Israeli secret service, steps in to help the British prime minister, whose lover has been kidnapped.",
				Price = 17.95m,
				InitialSellingPrice = 17.95m,
				Cost = 2.33m,
				InitialCost = 2.33m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 1,
				InitialInventory = 1,
				Discontinued = false,
			};
			b48.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b48);

			Book b49 = new Book()
			{
				PublishedDate = new DateTime(2008, 11, 1),
				UniqueNumber = 222049,
				Title = "A Good Woman",
				Author = "Danielle Steel",
				Description = "An American society girl who made a new life as a doctor in World War I France returns to New York.",
				Price = 27m,
				InitialSellingPrice = 27m,
				Cost = 10.53m,
				InitialCost = 10.53m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b49.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b49);

			Book b50 = new Book()
			{
				PublishedDate = new DateTime(2010, 10, 2),
				UniqueNumber = 222050,
				Title = "Legacy",
				Author = "Danielle Steel",
				Description = "A writer’s stunning family discovery leads to Paris, the French aristocracy and a mysterious Sioux ancestor.",
				Price = 28m,
				InitialSellingPrice = 28m,
				Cost = 6.44m,
				InitialCost = 6.44m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 3,
				InitialInventory = 3,
				Discontinued = false,
			};
			b50.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b50);

			Book b51 = new Book()
			{
				PublishedDate = new DateTime(2015, 2, 28),
				UniqueNumber = 222051,
				Title = "Prodigal Son",
				Author = "Danielle Steel",
				Description = "Twins, one good and one bad, reunite after 20 years when one of them returns to their hometown. But it is no longer clear who the good and who the bad one is.",
				Price = 18.95m,
				InitialSellingPrice = 18.95m,
				Cost = 9.1m,
				InitialCost = 9.1m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 3,
				InitialInventory = 3,
				Discontinued = false,
			};
			b51.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b51);

			Book b52 = new Book()
			{
				PublishedDate = new DateTime(2018, 5, 19),
				UniqueNumber = 222052,
				Title = "The Cast",
				Author = "Danielle Steel",
				Description = "A magazine columnist meets an array of Hollywood professionals when a producer turns a story about her grandmother into a TV series.",
				Price = 21.95m,
				InitialSellingPrice = 21.95m,
				Cost = 12.95m,
				InitialCost = 12.95m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 15,
				InitialInventory = 15,
				Discontinued = false,
			};
			b52.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b52);

			Book b53 = new Book()
			{
				PublishedDate = new DateTime(2017, 1, 7),
				UniqueNumber = 222053,
				Title = "The Mistress",
				Author = "Danielle Steel",
				Description = "The beautiful mistress of a Russian oligarch falls in love with an artist and yearns for freedom.",
				Price = 36.95m,
				InitialSellingPrice = 36.95m,
				Cost = 15.52m,
				InitialCost = 15.52m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b53.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b53);

			Book b54 = new Book()
			{
				PublishedDate = new DateTime(2011, 6, 18),
				UniqueNumber = 222054,
				Title = "One Summer",
				Author = "David Baldacci",
				Description = "As Christmas nears, a terminally ill man is preparing his family for his death when another tragedy strikes.",
				Price = 25.99m,
				InitialSellingPrice = 25.99m,
				Cost = 20.01m,
				InitialCost = 20.01m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 4,
				InitialInventory = 4,
				Discontinued = false,
			};
			b54.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b54);

			Book b55 = new Book()
			{
				PublishedDate = new DateTime(2015, 11, 21),
				UniqueNumber = 222055,
				Title = "The Guilty",
				Author = "David Baldacci",
				Description = "The government hit man Will Robie investigates murder charges against his estranged father in their Mississippi hometown.",
				Price = 19.95m,
				InitialSellingPrice = 19.95m,
				Cost = 17.16m,
				InitialCost = 17.16m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 3,
				InitialInventory = 3,
				Discontinued = false,
			};
			b55.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b55);

			Book b56 = new Book()
			{
				PublishedDate = new DateTime(2011, 4, 23),
				UniqueNumber = 222056,
				Title = "The Sixth Man",
				Author = "David Baldacci",
				Description = "The lawyer for an alleged serial killer is murdered, and two former Secret Service agents are on the case.",
				Price = 27.99m,
				InitialSellingPrice = 27.99m,
				Cost = 20.15m,
				InitialCost = 20.15m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 2,
				InitialInventory = 2,
				Discontinued = false,
			};
			b56.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b56);

			Book b57 = new Book()
			{
				PublishedDate = new DateTime(2011, 11, 5),
				UniqueNumber = 222057,
				Title = "Zero Day",
				Author = "David Baldacci",
				Description = "A military investigator uncovers a conspiracy.",
				Price = 27.99m,
				InitialSellingPrice = 27.99m,
				Cost = 18.47m,
				InitialCost = 18.47m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 12,
				InitialInventory = 12,
				Discontinued = false,
			};
			b57.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b57);

			Book b58 = new Book()
			{
				PublishedDate = new DateTime(2015, 2, 14),
				UniqueNumber = 222058,
				Title = "Holy Cow",
				Author = "David Duchovny",
				Description = "A light-hearted fable by the actor.",
				Price = 19.99m,
				InitialSellingPrice = 19.99m,
				Cost = 11.79m,
				InitialCost = 11.79m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 5,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b58.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Humor");
			Books.Add(b58);

			Book b59 = new Book()
			{
				PublishedDate = new DateTime(2010, 7, 3),
				UniqueNumber = 222059,
				Title = "The Thousand Autumns Of Jacob De Zoet",
				Author = "David Mitchell",
				Description = "Forbidden love in Edo-era Japan.",
				Price = 26m,
				InitialSellingPrice = 26m,
				Cost = 9.62m,
				InitialCost = 9.62m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 15,
				InitialInventory = 15,
				Discontinued = false,
			};
			b59.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b59);

			Book b60 = new Book()
			{
				PublishedDate = new DateTime(2011, 9, 17),
				UniqueNumber = 222060,
				Title = "How Firm A Foundation",
				Author = "David Weber",
				Description = "The island empire of Charis fights to survive.",
				Price = 27.99m,
				InitialSellingPrice = 27.99m,
				Cost = 23.79m,
				InitialCost = 23.79m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 12,
				InitialInventory = 12,
				Discontinued = false,
			};
			b60.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
			Books.Add(b60);

			Book b61 = new Book()
			{
				PublishedDate = new DateTime(2014, 2, 22),
				UniqueNumber = 222061,
				Title = "Like A Mighty Army",
				Author = "David Weber",
				Description = "In Book 7 of the Safehold science fiction series, the empire of Charis fights for self-determination.",
				Price = 22m,
				InitialSellingPrice = 22m,
				Cost = 17.6m,
				InitialCost = 17.6m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b61.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
			Books.Add(b61);

			Book b62 = new Book()
			{
				PublishedDate = new DateTime(2012, 9, 22),
				UniqueNumber = 222062,
				Title = "Midst Toil And Tribulation",
				Author = "David Weber",
				Description = "In Book 6 of the Safehold science fiction series, the republic of Siddamark descends into chaos.",
				Price = 27.99m,
				InitialSellingPrice = 27.99m,
				Cost = 10.08m,
				InitialCost = 10.08m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b62.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
			Books.Add(b62);

			Book b63 = new Book()
			{
				PublishedDate = new DateTime(2010, 6, 26),
				UniqueNumber = 222063,
				Title = "Mission Of Honor",
				Author = "David Weber",
				Description = "Honor Harrington defends the Star Kingdom of Manticore as it is besieged by many enemies.",
				Price = 27m,
				InitialSellingPrice = 27m,
				Cost = 6.75m,
				InitialCost = 6.75m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 3,
				InitialInventory = 3,
				Discontinued = false,
			};
			b63.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
			Books.Add(b63);

			Book b64 = new Book()
			{
				PublishedDate = new DateTime(2011, 12, 31),
				UniqueNumber = 222064,
				Title = "77 Shadow Street",
				Author = "Dean Koontz",
				Description = "A 19th-century tycoon’s mansion has been turned into luxury apartments, but it remains in the grip of evil forces.",
				Price = 28m,
				InitialSellingPrice = 28m,
				Cost = 14.56m,
				InitialCost = 14.56m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 5,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b64.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Horror");
			Books.Add(b64);

			Book b65 = new Book()
			{
				PublishedDate = new DateTime(2013, 12, 14),
				UniqueNumber = 222065,
				Title = "Innocence",
				Author = "Dean Koontz",
				Description = "A grotesque man living in exile beneath the city encounters a teenage girl hiding from dangerous enemies.",
				Price = 21m,
				InitialSellingPrice = 21m,
				Cost = 13.44m,
				InitialCost = 13.44m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b65.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Horror");
			Books.Add(b65);

			Book b66 = new Book()
			{
				PublishedDate = new DateTime(2012, 8, 4),
				UniqueNumber = 222066,
				Title = "Odd Apocalypse",
				Author = "Dean Koontz",
				Description = "Odd Thomas, who can communicate with the dead, explores the mysteries of an old estate now owned by a billionaire.",
				Price = 28m,
				InitialSellingPrice = 28m,
				Cost = 14.28m,
				InitialCost = 14.28m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 1,
				InitialInventory = 1,
				Discontinued = false,
			};
			b66.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Horror");
			Books.Add(b66);

			Book b67 = new Book()
			{
				PublishedDate = new DateTime(2008, 10, 4),
				UniqueNumber = 222067,
				Title = "A Cedar Cove Christmas",
				Author = "Debbie Macomber",
				Description = "A pregnant woman shows up in Cedar Cove on Christmas Eve and goes into labor in a room above a stable.",
				Price = 16.95m,
				InitialSellingPrice = 16.95m,
				Cost = 4.75m,
				InitialCost = 4.75m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b67.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b67);

			Book b68 = new Book()
			{
				PublishedDate = new DateTime(2010, 10, 2),
				UniqueNumber = 222068,
				Title = "Call Me Mrs. Miracle",
				Author = "Debbie Macomber",
				Description = "Working in the toy section of a department store, Emily Merkle is called upon to engineer some Christmas miracles.",
				Price = 16.95m,
				InitialSellingPrice = 16.95m,
				Cost = 8.31m,
				InitialCost = 8.31m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b68.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b68);

			Book b69 = new Book()
			{
				PublishedDate = new DateTime(2015, 3, 14),
				UniqueNumber = 222069,
				Title = "Last One Home",
				Author = "Debbie Macomber",
				Description = "Three estranged sisters work to resolve their differences",
				Price = 20m,
				InitialSellingPrice = 20m,
				Cost = 15.6m,
				InitialCost = 15.6m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 5,
				Inventory = 5,
				InitialInventory = 5,
				Discontinued = false,
			};
			b69.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b69);

			Book b70 = new Book()
			{
				PublishedDate = new DateTime(2013, 10, 12),
				UniqueNumber = 222070,
				Title = "Starry Night",
				Author = "Debbie Macomber",
				Description = "At Christmastime, a big-city columnist sets out to interview a reclusive author in Alaska.",
				Price = 24.95m,
				InitialSellingPrice = 24.95m,
				Cost = 17.96m,
				InitialCost = 17.96m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 15,
				InitialInventory = 15,
				Discontinued = false,
			};
			b70.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b70);

			Book b71 = new Book()
			{
				PublishedDate = new DateTime(2009, 5, 2),
				UniqueNumber = 222071,
				Title = "Summer On Blossom Street",
				Author = "Debbie Macomber",
				Description = "More stories of life and love from a Seattle knitting class.",
				Price = 24.95m,
				InitialSellingPrice = 24.95m,
				Cost = 7.24m,
				InitialCost = 7.24m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b71.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b71);

			Book b72 = new Book()
			{
				PublishedDate = new DateTime(2012, 8, 18),
				UniqueNumber = 222072,
				Title = "The Inn At Rose Harbor",
				Author = "Debbie Macomber",
				Description = "A young widow buys a bed-and-breakfast.",
				Price = 26m,
				InitialSellingPrice = 26m,
				Cost = 24.18m,
				InitialCost = 24.18m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 5,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b72.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b72);

			Book b73 = new Book()
			{
				PublishedDate = new DateTime(2016, 10, 8),
				UniqueNumber = 222073,
				Title = "Twelve Days Of Christmas",
				Author = "Debbie Macomber",
				Description = "A woman starts a blog about her attempt to reach out to a grumpy neighbor at Christmastime, and finds herself falling for him.",
				Price = 25.99m,
				InitialSellingPrice = 25.99m,
				Cost = 23.13m,
				InitialCost = 23.13m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b73.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b73);

			Book b74 = new Book()
			{
				PublishedDate = new DateTime(2011, 2, 12),
				UniqueNumber = 222074,
				Title = "A Discovery Of Witches",
				Author = "Deborah Harkness",
				Description = "The recovery of a lost ancient manuscript in a library at Oxford sets a fantastical underworld stirring.",
				Price = 28.95m,
				InitialSellingPrice = 28.95m,
				Cost = 3.76m,
				InitialCost = 3.76m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b74.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b74);

			Book b75 = new Book()
			{
				PublishedDate = new DateTime(2012, 7, 14),
				UniqueNumber = 222075,
				Title = "Shadow Of Night",
				Author = "Deborah Harkness",
				Description = "An Oxford scholar/witch and a vampire geneticist pursue history, secrets and each other in Elizabethan London.",
				Price = 28.95m,
				InitialSellingPrice = 28.95m,
				Cost = 21.13m,
				InitialCost = 21.13m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 15,
				InitialInventory = 15,
				Discontinued = false,
			};
			b75.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b75);

			Book b76 = new Book()
			{
				PublishedDate = new DateTime(2014, 7, 19),
				UniqueNumber = 222076,
				Title = "The Book Of Life",
				Author = "Deborah Harkness",
				Description = "In the conclusion to the All Souls trilogy, the Oxford scholar/witch Diana Bishop and the vampire geneticist Matthew Clairmont return from Elizabethan London to the present.",
				Price = 27.95m,
				InitialSellingPrice = 27.95m,
				Cost = 8.66m,
				InitialCost = 8.66m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b76.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b76);

			Book b77 = new Book()
			{
				PublishedDate = new DateTime(2008, 9, 27),
				UniqueNumber = 222077,
				Title = "The Given Day",
				Author = "Dennis Lehane",
				Description = "A policman, a fugitive and their families persevere in the turbulence of Boston at the end of World War I.",
				Price = 27.95m,
				InitialSellingPrice = 27.95m,
				Cost = 6.99m,
				InitialCost = 6.99m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b77.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b77);

			Book b78 = new Book()
			{
				PublishedDate = new DateTime(2011, 12, 3),
				UniqueNumber = 222078,
				Title = "The Scottish Prisoner",
				Author = "Diana Gabaldon",
				Description = "Jamie Fraser, a paroled Jacobite prisoner, and Lord John Grey collaborate uneasily on a mission to Ireland.",
				Price = 28m,
				InitialSellingPrice = 28m,
				Cost = 24.92m,
				InitialCost = 24.92m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b78.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b78);

			Book b79 = new Book()
			{
				PublishedDate = new DateTime(2009, 5, 30),
				UniqueNumber = 222079,
				Title = "Heartless",
				Author = "Diana Palmer",
				Description = "A woman‘s secret makes it hard for her to accept her stepbrother‘s love.",
				Price = 24.95m,
				InitialSellingPrice = 24.95m,
				Cost = 21.46m,
				InitialCost = 21.46m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 4,
				InitialInventory = 4,
				Discontinued = false,
			};
			b79.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b79);

			Book b80 = new Book()
			{
				PublishedDate = new DateTime(2011, 4, 9),
				UniqueNumber = 222080,
				Title = "Crunch Time",
				Author = "Diane Mott Davidson",
				Description = "The caterer and sleuth Goldy Schulz tries to help a friend whose rental house has been destroyed by arson.",
				Price = 26.99m,
				InitialSellingPrice = 26.99m,
				Cost = 3.78m,
				InitialCost = 3.78m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 4,
				InitialInventory = 4,
				Discontinued = false,
			};
			b80.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b80);

			Book b81 = new Book()
			{
				PublishedDate = new DateTime(2009, 4, 11),
				UniqueNumber = 222081,
				Title = "Fatally Flaky",
				Author = "Diane Mott Davidson",
				Description = "The caterer Goldy Schulz tries to outwit a killer on the grounds of an Aspen spa.",
				Price = 25.99m,
				InitialSellingPrice = 25.99m,
				Cost = 22.09m,
				InitialCost = 22.09m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 5,
				InitialInventory = 5,
				Discontinued = false,
			};
			b81.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b81);

			Book b82 = new Book()
			{
				PublishedDate = new DateTime(2016, 5, 7),
				UniqueNumber = 222082,
				Title = "Zero K",
				Author = "Don DeLillo",
				Description = "A billionaire and his son meet at a remote desert compound dedicated to preserving bodies until they can be returned to life in the future.",
				Price = 20m,
				InitialSellingPrice = 20m,
				Cost = 15.2m,
				InitialCost = 15.2m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b82.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
			Books.Add(b82);

			Book b83 = new Book()
			{
				PublishedDate = new DateTime(2009, 7, 4),
				UniqueNumber = 222083,
				Title = "Return To Sullivans Island",
				Author = "Dorothea Benton Frank",
				Description = "A recent college graduate returns to her family’s home on an island in the South Carolina Lowcountry and wrestles with tragedy and betrayal in the company of her appealing relatives.",
				Price = 25.99m,
				InitialSellingPrice = 25.99m,
				Cost = 13.25m,
				InitialCost = 13.25m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 13,
				InitialInventory = 13,
				Discontinued = false,
			};
			b83.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b83);

			Book b84 = new Book()
			{
				PublishedDate = new DateTime(2014, 6, 7),
				UniqueNumber = 222084,
				Title = "The Hurricane Sisters",
				Author = "Dorothea Benton Frank",
				Description = "Three generations of women endure a stormy summer in South Carolina's Lowcountry.",
				Price = 16m,
				InitialSellingPrice = 16m,
				Cost = 9.6m,
				InitialCost = 9.6m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 5,
				InitialInventory = 5,
				Discontinued = false,
			};
			b84.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b84);

			Book b85 = new Book()
			{
				PublishedDate = new DateTime(2014, 5, 17),
				UniqueNumber = 222085,
				Title = "The Kraken Project",
				Author = "Douglas Preston",
				Description = "The former C.I.A. agent Wyman Ford must stop Dorothy, a powerful artificial intelligence that has gone rogue.",
				Price = 35m,
				InitialSellingPrice = 35m,
				Cost = 28m,
				InitialCost = 28m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 14,
				InitialInventory = 14,
				Discontinued = false,
			};
			b85.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
			Books.Add(b85);

			Book b86 = new Book()
			{
				PublishedDate = new DateTime(2011, 2, 26),
				UniqueNumber = 222086,
				Title = "Gideon’s Sword",
				Author = "Douglas Preston and Lincoln Child",
				Description = "Gideon Crew avenges his father’s death and is sent on a mission by a government contractor.",
				Price = 26.99m,
				InitialSellingPrice = 26.99m,
				Cost = 19.7m,
				InitialCost = 19.7m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b86.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b86);

			Book b87 = new Book()
			{
				PublishedDate = new DateTime(2016, 10, 22),
				UniqueNumber = 222087,
				Title = "The Obsidian Chamber",
				Author = "Douglas Preston and Lincoln Child",
				Description = "While the F.B.I. agent Aloysius Pendergast is believed dead, his ward is kidnapped.",
				Price = 17m,
				InitialSellingPrice = 17m,
				Cost = 3.57m,
				InitialCost = 3.57m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 13,
				InitialInventory = 13,
				Discontinued = false,
			};
			b87.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b87);

			Book b88 = new Book()
			{
				PublishedDate = new DateTime(2012, 12, 15),
				UniqueNumber = 222088,
				Title = "Two Graves",
				Author = "Douglas Preston and Lincoln Child",
				Description = "Special Agent Aloysius Pendergast pursues a serial killer as well as his abducted wife.",
				Price = 26.99m,
				InitialSellingPrice = 26.99m,
				Cost = 13.23m,
				InitialCost = 13.23m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b88.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b88);

			Book b89 = new Book()
			{
				PublishedDate = new DateTime(2017, 7, 22),
				UniqueNumber = 222089,
				Title = "Meddling Kids",
				Author = "Edgar Cantero",
				Description = "Four old friends return to the site of their teenage adventures.",
				Price = 30.95m,
				InitialSellingPrice = 30.95m,
				Cost = 3.71m,
				InitialCost = 3.71m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 4,
				InitialInventory = 4,
				Discontinued = false,
			};
			b89.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b89);

			Book b90 = new Book()
			{
				PublishedDate = new DateTime(2013, 3, 16),
				UniqueNumber = 222090,
				Title = "The Supremes At Earl's All-You-Can-Eat",
				Author = "Edward Kelsey Moore",
				Description = "Four decades in the friendship of three middle-class black women in a small southern Indiana town.",
				Price = 24.95m,
				InitialSellingPrice = 24.95m,
				Cost = 7.49m,
				InitialCost = 7.49m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b90.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Humor");
			Books.Add(b90);

			Book b91 = new Book()
			{
				PublishedDate = new DateTime(2016, 6, 18),
				UniqueNumber = 222091,
				Title = "Here's To Us",
				Author = "Elin Hilderbrand",
				Description = "Sparks fly as a celebrity chef’s ex-wives pile into a small cabin in Nantucket to join his widow for the reading of his will.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 8.62m,
				InitialCost = 8.62m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 13,
				InitialInventory = 13,
				Discontinued = false,
			};
			b91.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b91);

			Book b92 = new Book()
			{
				PublishedDate = new DateTime(2009, 7, 11),
				UniqueNumber = 222092,
				Title = "The Castaways",
				Author = "Elin Hilderbrand",
				Description = "A Nantucket couple drowns, raising questions and precipitating conflicts among their group of friends.",
				Price = 24.99m,
				InitialSellingPrice = 24.99m,
				Cost = 16.99m,
				InitialCost = 16.99m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b92.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b92);

			Book b93 = new Book()
			{
				PublishedDate = new DateTime(2017, 6, 17),
				UniqueNumber = 222093,
				Title = "The Identicals",
				Author = "Elin Hilderbrand",
				Description = "Complications in the lives of identical twins who were raised by their divorced parents, one on Nantucket, one on Martha’s Vineyard.",
				Price = 33.95m,
				InitialSellingPrice = 33.95m,
				Cost = 4.41m,
				InitialCost = 4.41m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 14,
				InitialInventory = 14,
				Discontinued = false,
			};
			b93.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b93);

			Book b94 = new Book()
			{
				PublishedDate = new DateTime(2014, 6, 14),
				UniqueNumber = 222094,
				Title = "The Matchmaker",
				Author = "Elin Hilderbrand",
				Description = "A Nantucket resident’s life is shaken by a diagnosis and the return to the island of her high school sweetheart.",
				Price = 25m,
				InitialSellingPrice = 25m,
				Cost = 11m,
				InitialCost = 11m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 4,
				InitialInventory = 4,
				Discontinued = false,
			};
			b94.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b94);

			Book b95 = new Book()
			{
				PublishedDate = new DateTime(2016, 10, 8),
				UniqueNumber = 222095,
				Title = "Winter Storms",
				Author = "Elin Hilderbrand",
				Description = "In the final book of the Winter Street trilogy, a huge snowstorm bearing down on Nantucket threatens the Quinn family’s Christmas, after a year of significant events.",
				Price = 29m,
				InitialSellingPrice = 29m,
				Cost = 24.94m,
				InitialCost = 24.94m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b95.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b95);

			Book b96 = new Book()
			{
				PublishedDate = new DateTime(2014, 10, 18),
				UniqueNumber = 222096,
				Title = "Winter Street",
				Author = "Elin Hilderbrand",
				Description = "Complications ensue when the owner of Nantucket’s Winter Street Inn gathers his four children and their families for Christmas.",
				Price = 20.95m,
				InitialSellingPrice = 20.95m,
				Cost = 2.3m,
				InitialCost = 2.3m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b96.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b96);

			Book b97 = new Book()
			{
				PublishedDate = new DateTime(2010, 5, 15),
				UniqueNumber = 222097,
				Title = "Heart Of The Matter",
				Author = "Emily Giffin",
				Description = "The lives of two women — one married to a pediatric plastic surgeon, the other a lawyer and single mother — converge after an accident involving the lawyer’s son.",
				Price = 26.99m,
				InitialSellingPrice = 26.99m,
				Cost = 6.21m,
				InitialCost = 6.21m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 1,
				InitialInventory = 1,
				Discontinued = true,
			};
			b97.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b97);

			Book b98 = new Book()
			{
				PublishedDate = new DateTime(2012, 7, 28),
				UniqueNumber = 222098,
				Title = "Where We Belong",
				Author = "Emily Giffin",
				Description = "A woman’s successful life is disrupted by the appearance of an 18-year-old girl with a link to her past.",
				Price = 27.99m,
				InitialSellingPrice = 27.99m,
				Cost = 8.12m,
				InitialCost = 8.12m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b98.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b98);

			Book b99 = new Book()
			{
				PublishedDate = new DateTime(2014, 4, 5),
				UniqueNumber = 222099,
				Title = "Frog Music",
				Author = "Emma Donoghue",
				Description = "A murder mystery set in San Francisco in 1876, when the city is in the grip of a smallpox epidemic and a heat wave.",
				Price = 16.95m,
				InitialSellingPrice = 16.95m,
				Cost = 4.92m,
				InitialCost = 4.92m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 5,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b99.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b99);

			Book b100 = new Book()
			{
				PublishedDate = new DateTime(2014, 5, 31),
				UniqueNumber = 222100,
				Title = "The Vacationers",
				Author = "Emma Straub",
				Description = "Well-heeled New Yorkers and their friends spend two weeks in Majorca, a time when rivalries and secrets come to light.",
				Price = 33m,
				InitialSellingPrice = 33m,
				Cost = 5.94m,
				InitialCost = 5.94m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 14,
				InitialInventory = 14,
				Discontinued = false,
			};
			b100.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b100);

			Book b101 = new Book()
			{
				PublishedDate = new DateTime(2009, 8, 29),
				UniqueNumber = 222101,
				Title = "Resurrecting Midnight",
				Author = "Eric Jerome Dickey",
				Description = "Gideon, an international assassin, travels to Argentina in pursuit of a dangerous assignment.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 14.55m,
				InitialCost = 14.55m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 3,
				InitialInventory = 3,
				Discontinued = false,
			};
			b101.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b101);

			Book b102 = new Book()
			{
				PublishedDate = new DateTime(2016, 12, 3),
				UniqueNumber = 222102,
				Title = "The Whole Town's Talking",
				Author = "Fannie Flagg",
				Description = "A century of life in small-town Elmwood Springs, Mo.",
				Price = 31.99m,
				InitialSellingPrice = 31.99m,
				Cost = 21.11m,
				InitialCost = 21.11m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 2,
				InitialInventory = 2,
				Discontinued = false,
			};
			b102.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b102);

			Book b103 = new Book()
			{
				PublishedDate = new DateTime(2013, 8, 24),
				UniqueNumber = 222103,
				Title = "The Kill List",
				Author = "Frederick Forsyth",
				Description = "An Arabic-speaking Marine major known as the Tracker pursues a terrorist who radicalizes young Muslims living abroad.",
				Price = 23.95m,
				InitialSellingPrice = 23.95m,
				Cost = 10.78m,
				InitialCost = 10.78m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b103.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b103);

			Book b104 = new Book()
			{
				PublishedDate = new DateTime(2008, 5, 24),
				UniqueNumber = 222104,
				Title = "The Art Of Racing In The Rain",
				Author = "Garth Stein",
				Description = "A Lab-terrier mix with great insight into the human condition helps his owner, a struggling race car driver.",
				Price = 23.95m,
				InitialSellingPrice = 23.95m,
				Cost = 10.3m,
				InitialCost = 10.3m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 2,
				InitialInventory = 2,
				Discontinued = false,
			};
			b104.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b104);

			Book b105 = new Book()
			{
				PublishedDate = new DateTime(2010, 9, 25),
				UniqueNumber = 222105,
				Title = "The Fall",
				Author = "Guillermo del Toro and Chuck Hogan",
				Description = "A war erupts between Old and New World vampires. Book 2 of the Strain trilogy.",
				Price = 26.99m,
				InitialSellingPrice = 26.99m,
				Cost = 13.23m,
				InitialCost = 13.23m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b105.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b105);

			Book b106 = new Book()
			{
				PublishedDate = new DateTime(2016, 3, 26),
				UniqueNumber = 222106,
				Title = "Fool Me Once",
				Author = "Harlan Coben",
				Description = "A retired Army helicopter pilot faces combat-related nightmares and mysteries concerning the deaths of her husband and sister.",
				Price = 24.95m,
				InitialSellingPrice = 24.95m,
				Cost = 12.72m,
				InitialCost = 12.72m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b106.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b106);

			Book b107 = new Book()
			{
				PublishedDate = new DateTime(2011, 3, 26),
				UniqueNumber = 222107,
				Title = "Live Wire",
				Author = "Harlan Coben",
				Description = "Myron Bolitar’s search for a missing rock star leads to questions about his own missing brother.",
				Price = 27.95m,
				InitialSellingPrice = 27.95m,
				Cost = 13.98m,
				InitialCost = 13.98m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b107.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b107);

			Book b108 = new Book()
			{
				PublishedDate = new DateTime(2013, 10, 19),
				UniqueNumber = 222108,
				Title = "Bridget Jones: Mad About The Boy",
				Author = "Helen Fielding",
				Description = "Bridget, now 51 and a mother and widow, is once again looking for love.",
				Price = 29.95m,
				InitialSellingPrice = 29.95m,
				Cost = 18.57m,
				InitialCost = 18.57m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b108.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b108);

			Book b109 = new Book()
			{
				PublishedDate = new DateTime(2012, 11, 17),
				UniqueNumber = 222109,
				Title = "Sweet Tooth",
				Author = "Ian McEwan",
				Description = "A British woman working for MI5 in 1972 falls in love with a writer the service is clandestinely supporting.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 16.17m,
				InitialCost = 16.17m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b109.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b109);

			Book b110 = new Book()
			{
				PublishedDate = new DateTime(2014, 8, 2),
				UniqueNumber = 222110,
				Title = "Magic Breaks",
				Author = "Ilona Andrews",
				Description = "In the seventh Kate Daniels novel, Kate deals with paranormal politics in Atlanta as she prepares the Pack for an attack.",
				Price = 32m,
				InitialSellingPrice = 32m,
				Cost = 16.96m,
				InitialCost = 16.96m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 4,
				InitialInventory = 4,
				Discontinued = false,
			};
			b110.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b110);

			Book b111 = new Book()
			{
				PublishedDate = new DateTime(2011, 10, 22),
				UniqueNumber = 222111,
				Title = "Bonnie",
				Author = "Iris Johansen",
				Description = "The forensic sculptor Eve Duncan learns more about her daughter’s disappearance and the girl’s father‘s possible involvement.",
				Price = 27.99m,
				InitialSellingPrice = 27.99m,
				Cost = 24.07m,
				InitialCost = 24.07m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 13,
				InitialInventory = 13,
				Discontinued = false,
			};
			b111.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b111);

			Book b112 = new Book()
			{
				PublishedDate = new DateTime(2013, 7, 20),
				UniqueNumber = 222112,
				Title = "Hunting Eve",
				Author = "Iris Johansen",
				Description = "In the second book of a trilogy, the forensic sculptor Eve Duncan struggles to outwit a kidnapper in the Colorado wilderness.",
				Price = 35.99m,
				InitialSellingPrice = 35.99m,
				Cost = 28.07m,
				InitialCost = 28.07m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 5,
				InitialInventory = 5,
				Discontinued = false,
			};
			b112.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b112);

			Book b113 = new Book()
			{
				PublishedDate = new DateTime(2014, 5, 3),
				UniqueNumber = 222113,
				Title = "Live To See Tomorrow",
				Author = "Iris Johansen",
				Description = "The C.I.A. operative Catherine Ling must spearhead the rescue of an American journalist kidnapped in Tibet.",
				Price = 34m,
				InitialSellingPrice = 34m,
				Cost = 6.46m,
				InitialCost = 6.46m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 5,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b113.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b113);

			Book b114 = new Book()
			{
				PublishedDate = new DateTime(2013, 10, 5),
				UniqueNumber = 222114,
				Title = "Silencing Eve",
				Author = "Iris Johansen",
				Description = "The final book of a trilogy about the forensic sculptor Eve Duncan.",
				Price = 19m,
				InitialSellingPrice = 19m,
				Cost = 7.03m,
				InitialCost = 7.03m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b114.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b114);

			Book b115 = new Book()
			{
				PublishedDate = new DateTime(2012, 10, 20),
				UniqueNumber = 222115,
				Title = "Sleep No More",
				Author = "Iris Johansen",
				Description = "The forensic sculptor Eve Duncan investigates when her mother’s friend disappears from a mental hospital.",
				Price = 27.99m,
				InitialSellingPrice = 27.99m,
				Cost = 4.48m,
				InitialCost = 4.48m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 4,
				InitialInventory = 4,
				Discontinued = false,
			};
			b115.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b115);

			Book b116 = new Book()
			{
				PublishedDate = new DateTime(2015, 11, 7),
				UniqueNumber = 222116,
				Title = "The Japanese Lover",
				Author = "Isabel Allende",
				Description = "A young refugee from the Nazis and the son of her family’s Japanese gardener must hide their love, although it lasts a lifetime.",
				Price = 33.99m,
				InitialSellingPrice = 33.99m,
				Cost = 8.16m,
				InitialCost = 8.16m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b116.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b116);

			Book b117 = new Book()
			{
				PublishedDate = new DateTime(2012, 7, 28),
				UniqueNumber = 222117,
				Title = "Judgment Call",
				Author = "J A Jance",
				Description = "Joanna Brady, an Arizona sheriff, must function as both a law officer and a mother when her daughter’s high school principal is murdered.",
				Price = 25.99m,
				InitialSellingPrice = 25.99m,
				Cost = 8.84m,
				InitialCost = 8.84m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b117.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b117);

			Book b118 = new Book()
			{
				PublishedDate = new DateTime(2012, 2, 11),
				UniqueNumber = 222118,
				Title = "Left For Dead",
				Author = "J A Jance",
				Description = "Ali Reynolds seeks justice for an old friend and an unidentified woman, both victims of brutal attacks.",
				Price = 25.99m,
				InitialSellingPrice = 25.99m,
				Cost = 20.01m,
				InitialCost = 20.01m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 13,
				InitialInventory = 13,
				Discontinued = false,
			};
			b118.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b118);

			Book b119 = new Book()
			{
				PublishedDate = new DateTime(2011, 2, 26),
				UniqueNumber = 222119,
				Title = "Treachery In Death",
				Author = "J D Robb",
				Description = "Eve Dallas and her partner, Peabody, investigate a grocer’s murder.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 5.93m,
				InitialCost = 5.93m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 5,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b119.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b119);

			Book b120 = new Book()
			{
				PublishedDate = new DateTime(2013, 3, 30),
				UniqueNumber = 222120,
				Title = "Lover At Last",
				Author = "J R Ward",
				Description = "Book 11 of the Black Dagger Brotherhood series.",
				Price = 27.95m,
				InitialSellingPrice = 27.95m,
				Cost = 12.86m,
				InitialCost = 12.86m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 12,
				InitialInventory = 12,
				Discontinued = false,
			};
			b120.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b120);

			Book b121 = new Book()
			{
				PublishedDate = new DateTime(2009, 1, 31),
				UniqueNumber = 222121,
				Title = "A Darker Place",
				Author = "Jack Higgins",
				Description = "A Russian defector becomes a counterspy.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 11.86m,
				InitialCost = 11.86m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b121.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b121);

			Book b122 = new Book()
			{
				PublishedDate = new DateTime(2014, 2, 8),
				UniqueNumber = 222122,
				Title = "Confessions Of A Wild Child",
				Author = "Jackie Collins",
				Description = "The early years of Collins’s recurring character Lucky Santangelo.",
				Price = 30.95m,
				InitialSellingPrice = 30.95m,
				Cost = 17.95m,
				InitialCost = 17.95m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b122.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b122);

			Book b123 = new Book()
			{
				PublishedDate = new DateTime(2010, 2, 13),
				UniqueNumber = 222123,
				Title = "Poor Little Bitch Girl",
				Author = "Jackie Collins",
				Description = "Hollywood murder, three beautiful 20-something high school friends, a hot New York club owner.",
				Price = 26.99m,
				InitialSellingPrice = 26.99m,
				Cost = 17.54m,
				InitialCost = 17.54m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 1,
				InitialInventory = 1,
				Discontinued = false,
			};
			b123.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b123);

			Book b124 = new Book()
			{
				PublishedDate = new DateTime(2011, 3, 26),
				UniqueNumber = 222124,
				Title = "A Lesson In Secrets",
				Author = "Jacqueline Winspear",
				Description = "In the summer of 1932, Maisie Dobbs’s first assignment for the British secret service takes her undercover to Cambridge as a professor.",
				Price = 25.99m,
				InitialSellingPrice = 25.99m,
				Cost = 12.22m,
				InitialCost = 12.22m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 1,
				InitialInventory = 1,
				Discontinued = false,
			};
			b124.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b124);

			Book b125 = new Book()
			{
				PublishedDate = new DateTime(2013, 3, 30),
				UniqueNumber = 222125,
				Title = "Leaving Everything Most Loved",
				Author = "Jacqueline Winspear",
				Description = "In 1933, the private investigator Maisie Dobbs helps an Indian man whose sister’s murder has been ignored by Scotland Yard.",
				Price = 26.99m,
				InitialSellingPrice = 26.99m,
				Cost = 2.97m,
				InitialCost = 2.97m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 14,
				InitialInventory = 14,
				Discontinued = false,
			};
			b125.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b125);

			Book b126 = new Book()
			{
				PublishedDate = new DateTime(2018, 3, 31),
				UniqueNumber = 222126,
				Title = "To Die But Once",
				Author = "Jacqueline Winspear",
				Description = "In 1940, months after Britain declared war on Germany, Maisie Dobbs investigates the disappearance of an apprentice working on a government contract.",
				Price = 24.95m,
				InitialSellingPrice = 24.95m,
				Cost = 19.21m,
				InitialCost = 19.21m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 5,
				InitialInventory = 5,
				Discontinued = false,
			};
			b126.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b126);

			Book b127 = new Book()
			{
				PublishedDate = new DateTime(2016, 8, 13),
				UniqueNumber = 222127,
				Title = "Another Brooklyn",
				Author = "Jacqueline Woodson",
				Description = "An adult novel by an award-winning children's book author centers on memories of growing up and the close friendship of four girls.",
				Price = 36m,
				InitialSellingPrice = 36m,
				Cost = 9.72m,
				InitialCost = 9.72m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 12,
				InitialInventory = 12,
				Discontinued = false,
			};
			b127.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b127);

			Book b128 = new Book()
			{
				PublishedDate = new DateTime(2013, 7, 27),
				UniqueNumber = 222128,
				Title = "Light Of The World",
				Author = "James Lee Burke",
				Description = "A savage killer follows the detective Dave Robicheaux and his family to a Montana ranch.",
				Price = 32m,
				InitialSellingPrice = 32m,
				Cost = 10.88m,
				InitialCost = 10.88m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 5,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b128.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
			Books.Add(b128);

			Book b129 = new Book()
			{
				PublishedDate = new DateTime(2009, 7, 18),
				UniqueNumber = 222129,
				Title = "Rain Gods",
				Author = "James Lee Burke",
				Description = "A Texas sheriff investigates a mass murder of illegal aliens and tries to find the young Iraq war veteran who may have been involved — before the F.B.I. can.",
				Price = 25.99m,
				InitialSellingPrice = 25.99m,
				Cost = 21.05m,
				InitialCost = 21.05m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b129.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
			Books.Add(b129);

			Book b130 = new Book()
			{
				PublishedDate = new DateTime(2018, 1, 6),
				UniqueNumber = 222130,
				Title = "Robicheaux",
				Author = "James Lee Burke",
				Description = "A bereaved detective confronts his past and works to clear his name when he becomes a suspect during an investigation into the murder of the man who killed his wife.",
				Price = 17.95m,
				InitialSellingPrice = 17.95m,
				Cost = 15.98m,
				InitialCost = 15.98m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 5,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b130.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
			Books.Add(b130);

			Book b131 = new Book()
			{
				PublishedDate = new DateTime(2014, 11, 29),
				UniqueNumber = 222131,
				Title = "Hope To Die",
				Author = "James Patterson",
				Description = "Detective Alex Cross’s family is kidnapped by a madman who wants to turn Cross into a perfect killer.",
				Price = 31.95m,
				InitialSellingPrice = 31.95m,
				Cost = 3.51m,
				InitialCost = 3.51m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 12,
				InitialInventory = 12,
				Discontinued = false,
			};
			b131.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b131);

			Book b132 = new Book()
			{
				PublishedDate = new DateTime(2012, 11, 17),
				UniqueNumber = 222132,
				Title = "Merry Christmas, Alex Cross",
				Author = "James Patterson",
				Description = "Detective Alex Cross confronts both a hostage situation and a terrorist act at Christmas.",
				Price = 28.99m,
				InitialSellingPrice = 28.99m,
				Cost = 8.99m,
				InitialCost = 8.99m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b132.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b132);

			Book b133 = new Book()
			{
				PublishedDate = new DateTime(2018, 2, 24),
				UniqueNumber = 222133,
				Title = "Fifty Fifty",
				Author = "James Patterson and Candice Fox",
				Description = "Detective Harriet Blue tries to clear her brother's name and save a small Australian town from being massacred.",
				Price = 35.99m,
				InitialSellingPrice = 35.99m,
				Cost = 28.07m,
				InitialCost = 28.07m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 12,
				InitialInventory = 12,
				Discontinued = false,
			};
			b133.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b133);

			Book b134 = new Book()
			{
				PublishedDate = new DateTime(2015, 10, 3),
				UniqueNumber = 222134,
				Title = "The Murder House",
				Author = "James Patterson and David Ellis",
				Description = "When bodies are found at a Hamptons estate where a series of grisly murders once occurred, a local detective and former New York City cop investigates.",
				Price = 23.95m,
				InitialSellingPrice = 23.95m,
				Cost = 17.72m,
				InitialCost = 17.72m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b134.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b134);

			Book b135 = new Book()
			{
				PublishedDate = new DateTime(2015, 5, 9),
				UniqueNumber = 222135,
				Title = "14Th Deadly Sin",
				Author = "James Patterson and Maxine Paetro",
				Description = "A video of a shocking crime surfaces, casting suspicion on a San Francisco detective's colleagues.",
				Price = 24.99m,
				InitialSellingPrice = 24.99m,
				Cost = 6.25m,
				InitialCost = 6.25m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b135.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b135);

			Book b136 = new Book()
			{
				PublishedDate = new DateTime(2015, 1, 31),
				UniqueNumber = 222136,
				Title = "Private Vegas",
				Author = "James Patterson and Maxine Paetro",
				Description = "Jack Morgan, the head of an investigative firm, uncovers a murder ring in Las Vegas.",
				Price = 32m,
				InitialSellingPrice = 32m,
				Cost = 25.92m,
				InitialCost = 25.92m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b136.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b136);

			Book b137 = new Book()
			{
				PublishedDate = new DateTime(2011, 7, 2),
				UniqueNumber = 222137,
				Title = "Now You See Her",
				Author = "James Patterson and Michael Ledwidge",
				Description = "Nina Bloom, who years ago changed her identity to save her life, is forced to confront the past and the killer she thought she had escaped.",
				Price = 27.99m,
				InitialSellingPrice = 27.99m,
				Cost = 8.4m,
				InitialCost = 8.4m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 2,
				InitialInventory = 2,
				Discontinued = false,
			};
			b137.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b137);

			Book b138 = new Book()
			{
				PublishedDate = new DateTime(2011, 10, 22),
				UniqueNumber = 222138,
				Title = "The Christmas Wedding",
				Author = "James Patterson and Richard DiLallo",
				Description = "A widow keeps the identity of the new man she is about to marry a secret as her children gather for Christmas.",
				Price = 25.99m,
				InitialSellingPrice = 25.99m,
				Cost = 23.65m,
				InitialCost = 23.65m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 3,
				InitialInventory = 3,
				Discontinued = false,
			};
			b138.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b138);

			Book b139 = new Book()
			{
				PublishedDate = new DateTime(2017, 8, 19),
				UniqueNumber = 222139,
				Title = "The Store",
				Author = "James Patterson and Richard DiLallo",
				Description = "Two New York writers go undercover to expose the secrets of a powerful retailer.",
				Price = 31m,
				InitialSellingPrice = 31m,
				Cost = 15.19m,
				InitialCost = 15.19m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 2,
				InitialInventory = 2,
				Discontinued = false,
			};
			b139.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
			Books.Add(b139);

			Book b140 = new Book()
			{
				PublishedDate = new DateTime(2010, 1, 2),
				UniqueNumber = 222140,
				Title = "Altar Of Eden",
				Author = "James Rollins",
				Description = "A Louisiana veterinarian discovers a wrecked fishing trawler filled with genetically altered animals.",
				Price = 27.99m,
				InitialSellingPrice = 27.99m,
				Cost = 25.75m,
				InitialCost = 25.75m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 1,
				InitialInventory = 1,
				Discontinued = false,
			};
			b140.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
			Books.Add(b140);

			Book b141 = new Book()
			{
				PublishedDate = new DateTime(2013, 4, 6),
				UniqueNumber = 222141,
				Title = "All That Is",
				Author = "James Salter",
				Description = "A veteran makes a career in publishing in postwar New York and struggles to achieve romantic success.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 14.01m,
				InitialCost = 14.01m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b141.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b141);

			Book b142 = new Book()
			{
				PublishedDate = new DateTime(2013, 9, 14),
				UniqueNumber = 222142,
				Title = "Songs Of Willow Frost",
				Author = "Jamie Ford",
				Description = "A 12-year-old Seattle orphan during the Depression becomes convinced that a movie star is really his vanished mother.",
				Price = 18m,
				InitialSellingPrice = 18m,
				Cost = 6.3m,
				InitialCost = 6.3m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b142.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b142);

			Book b143 = new Book()
			{
				PublishedDate = new DateTime(2012, 3, 17),
				UniqueNumber = 222143,
				Title = "Another Piece Of My Heart",
				Author = "Jane Green",
				Description = "A woman in her late 30s marries the man of her dreams and reaches out to his daughters by his previous marriage, but one of them is determined to destroy her.",
				Price = 25.99m,
				InitialSellingPrice = 25.99m,
				Cost = 20.27m,
				InitialCost = 20.27m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b143.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b143);

			Book b144 = new Book()
			{
				PublishedDate = new DateTime(2017, 7, 22),
				UniqueNumber = 222144,
				Title = "Watch Me Disappear",
				Author = "Janelle Brown",
				Description = "When a Berkeley woman vanishes after a hiking trip, her husband and daughter discover disturbing secrets.",
				Price = 32.95m,
				InitialSellingPrice = 32.95m,
				Cost = 30.64m,
				InitialCost = 30.64m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 4,
				InitialInventory = 4,
				Discontinued = false,
			};
			b144.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b144);

			Book b145 = new Book()
			{
				PublishedDate = new DateTime(2009, 6, 27),
				UniqueNumber = 222145,
				Title = "Finger Lickin’ Fifteen",
				Author = "Janet Evanovich",
				Description = "The bounty hunter Stephanie Plum hunts a celebrity chef’s killer.",
				Price = 27.95m,
				InitialSellingPrice = 27.95m,
				Cost = 3.63m,
				InitialCost = 3.63m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b145.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b145);

			Book b146 = new Book()
			{
				PublishedDate = new DateTime(2010, 6, 26),
				UniqueNumber = 222146,
				Title = "Sizzling Sixteen",
				Author = "Janet Evanovich",
				Description = "The bounty hunter Stephanie Plum comes to the aid of a cousin with gambling debts.",
				Price = 27.99m,
				InitialSellingPrice = 27.99m,
				Cost = 12.32m,
				InitialCost = 12.32m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 2,
				InitialInventory = 2,
				Discontinued = false,
			};
			b146.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b146);

			Book b147 = new Book()
			{
				PublishedDate = new DateTime(2012, 1, 7),
				UniqueNumber = 222147,
				Title = "Love In A Nutshell",
				Author = "Janet Evanovich and Dorien Kelly",
				Description = "A former magazine editor attempts to turn her parents’ summer house into a bed-and-breakfast.",
				Price = 27.99m,
				InitialSellingPrice = 27.99m,
				Cost = 22.95m,
				InitialCost = 22.95m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 3,
				InitialInventory = 3,
				Discontinued = false,
			};
			b147.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b147);

			Book b148 = new Book()
			{
				PublishedDate = new DateTime(2013, 1, 12),
				UniqueNumber = 222148,
				Title = "The Husband List",
				Author = "Janet Evanovich and Dorien Kelly",
				Description = "In New York City in 1894, a wealthy young woman yearns for adventure and the love of an Irish-American with new money, rather than the titled Britons to whom her mother hopes to marry her off.",
				Price = 27.99m,
				InitialSellingPrice = 27.99m,
				Cost = 23.51m,
				InitialCost = 23.51m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b148.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b148);

			Book b149 = new Book()
			{
				PublishedDate = new DateTime(2014, 11, 22),
				UniqueNumber = 222149,
				Title = "The Job",
				Author = "Janet Evanovich and Lee Goldberg",
				Description = "The F.B.I. special agent Kate O’Hare works with Nicolas Fox, a handsome con man, to pursue a drug kingpin.",
				Price = 28.95m,
				InitialSellingPrice = 28.95m,
				Cost = 20.27m,
				InitialCost = 20.27m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 14,
				InitialInventory = 14,
				Discontinued = false,
			};
			b149.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b149);

			Book b150 = new Book()
			{
				PublishedDate = new DateTime(2016, 6, 25),
				UniqueNumber = 222150,
				Title = "The Pursuit",
				Author = "Janet Evanovich and Lee Goldberg",
				Description = "The F.B.I. agent Kate O’Hare and her con man partner, Nick Fox, face off against a dangerous ex-Serbian military officer.",
				Price = 25.99m,
				InitialSellingPrice = 25.99m,
				Cost = 18.45m,
				InitialCost = 18.45m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 5,
				Inventory = 1,
				InitialInventory = 1,
				Discontinued = false,
			};
			b150.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b150);

			Book b151 = new Book()
			{
				PublishedDate = new DateTime(2018, 3, 10),
				UniqueNumber = 222151,
				Title = "Star Wars: The Last Jedi",
				Author = "Jason Fry",
				Description = "An adaptation of the film, written with input from its director, Rian Johnson, which includes scenes from alternate versions of the script.",
				Price = 28.99m,
				InitialSellingPrice = 28.99m,
				Cost = 24.64m,
				InitialCost = 24.64m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 4,
				InitialInventory = 4,
				Discontinued = false,
			};
			b151.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
			Books.Add(b151);

			Book b152 = new Book()
			{
				PublishedDate = new DateTime(2013, 6, 8),
				UniqueNumber = 222152,
				Title = "Red Sparrow",
				Author = "Jason Matthews",
				Description = "A Russian intelligence officer trained in the art of seduction becomes entangled with a young C.I.A. officer.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 11.59m,
				InitialCost = 11.59m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b152.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b152);

			Book b153 = new Book()
			{
				PublishedDate = new DateTime(2012, 1, 14),
				UniqueNumber = 222153,
				Title = "Copper Beach",
				Author = "Jayne Ann Krentz",
				Description = "Amy Radwell, whose psychic talent enables her to understand the paranormal secrets in rare books, becomes the target of a blackmailer. The first book in a new series about rare books and psychic codes.",
				Price = 25.95m,
				InitialSellingPrice = 25.95m,
				Cost = 16.09m,
				InitialCost = 16.09m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 5,
				Inventory = 5,
				InitialInventory = 5,
				Discontinued = false,
			};
			b153.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b153);

			Book b154 = new Book()
			{
				PublishedDate = new DateTime(2015, 1, 10),
				UniqueNumber = 222154,
				Title = "Trust No One",
				Author = "Jayne Ann Krentz",
				Description = "A woman who is being stalked is aided by an unlikely ally.",
				Price = 17.95m,
				InitialSellingPrice = 17.95m,
				Cost = 12.39m,
				InitialCost = 12.39m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b154.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b154);

			Book b155 = new Book()
			{
				PublishedDate = new DateTime(2013, 6, 15),
				UniqueNumber = 222155,
				Title = "The Silver Star",
				Author = "Jeannette Walls",
				Description = "When their irresponsible mother takes off, a 12-year-old California girl and her sister join the rest of their family in Virginia.",
				Price = 23.95m,
				InitialSellingPrice = 23.95m,
				Cost = 8.38m,
				InitialCost = 8.38m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 12,
				InitialInventory = 12,
				Discontinued = false,
			};
			b155.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b155);

			Book b156 = new Book()
			{
				PublishedDate = new DateTime(2009, 9, 12),
				UniqueNumber = 222156,
				Title = "Dexter By Design",
				Author = "Jeff Lindsay",
				Description = "A serial killer who arranges victims in artful poses challenges the Miami Police Department and its blood splatter analyst, Dexter.",
				Price = 25m,
				InitialSellingPrice = 25m,
				Cost = 2.75m,
				InitialCost = 2.75m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 13,
				InitialInventory = 13,
				Discontinued = false,
			};
			b156.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b156);

			Book b157 = new Book()
			{
				PublishedDate = new DateTime(2009, 11, 7),
				UniqueNumber = 222157,
				Title = "No Less Than Victory",
				Author = "Jeff Shaara",
				Description = "The final volume of a trilogy of novels about World War II focuses on the final years of the war, including the Battle of the Bulge and the American sweep through Germany.",
				Price = 28m,
				InitialSellingPrice = 28m,
				Cost = 20.72m,
				InitialCost = 20.72m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 3,
				InitialInventory = 3,
				Discontinued = false,
			};
			b157.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b157);

			Book b158 = new Book()
			{
				PublishedDate = new DateTime(2015, 6, 6),
				UniqueNumber = 222158,
				Title = "The Fateful Lightning",
				Author = "Jeff Shaara",
				Description = "The fourth and final volume in a series of Civil War novels describes the war's last months through multiple perspectives.",
				Price = 28.95m,
				InitialSellingPrice = 28.95m,
				Cost = 5.5m,
				InitialCost = 5.5m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 13,
				InitialInventory = 13,
				Discontinued = false,
			};
			b158.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b158);

			Book b159 = new Book()
			{
				PublishedDate = new DateTime(2009, 6, 13),
				UniqueNumber = 222159,
				Title = "Roadside Crosses",
				Author = "Jeffery Deaver",
				Description = "A California kinesics expert pursues a killer who stalks victims using information they’ve posted online.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 7.82m,
				InitialCost = 7.82m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 13,
				InitialInventory = 13,
				Discontinued = false,
			};
			b159.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b159);

			Book b160 = new Book()
			{
				PublishedDate = new DateTime(2017, 4, 15),
				UniqueNumber = 222160,
				Title = "The Burial Hour",
				Author = "Jeffery Deaver",
				Description = "Lincoln Rhyme travels to Italy to investigate a case.",
				Price = 16m,
				InitialSellingPrice = 16m,
				Cost = 1.6m,
				InitialCost = 1.6m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 5,
				Inventory = 5,
				InitialInventory = 5,
				Discontinued = false,
			};
			b160.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b160);

			Book b161 = new Book()
			{
				PublishedDate = new DateTime(2009, 11, 28),
				UniqueNumber = 222161,
				Title = "First Lord’S Fury",
				Author = "Jim Butcher",
				Description = "With their survival at stake, Alerans prepare for a final battle in the sixth book of the Alera fantasy cycle.",
				Price = 25.95m,
				InitialSellingPrice = 25.95m,
				Cost = 13.23m,
				InitialCost = 13.23m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 4,
				InitialInventory = 4,
				Discontinued = false,
			};
			b161.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b161);

			Book b162 = new Book()
			{
				PublishedDate = new DateTime(2011, 7, 30),
				UniqueNumber = 222162,
				Title = "Ghost Story",
				Author = "Jim Butcher",
				Description = "Harry Dresden, the wizard detective in Chicago, has been murdered. But that doesn’t stop him when his friends are in danger.",
				Price = 27.95m,
				InitialSellingPrice = 27.95m,
				Cost = 12.02m,
				InitialCost = 12.02m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 13,
				InitialInventory = 13,
				Discontinued = false,
			};
			b162.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b162);

			Book b163 = new Book()
			{
				PublishedDate = new DateTime(2009, 4, 11),
				UniqueNumber = 222163,
				Title = "Turn Coat",
				Author = "Jim Butcher",
				Description = "Book 11 of the Dresden Files series about a wizard detective in Chicago.",
				Price = 25.95m,
				InitialSellingPrice = 25.95m,
				Cost = 9.34m,
				InitialCost = 9.34m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b163.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b163);

			Book b164 = new Book()
			{
				PublishedDate = new DateTime(2018, 4, 14),
				UniqueNumber = 222164,
				Title = "Macbeth",
				Author = "Jo Nesbo",
				Description = "In this adaptation of Shakespeare's tragedy, police in a 1970s industrial town take on a pair of drug lords.",
				Price = 28.95m,
				InitialSellingPrice = 28.95m,
				Cost = 7.53m,
				InitialCost = 7.53m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 12,
				InitialInventory = 12,
				Discontinued = false,
			};
			b164.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Shakespeare");
			Books.Add(b164);

			Book b165 = new Book()
			{
				PublishedDate = new DateTime(2017, 3, 4),
				UniqueNumber = 222165,
				Title = "Banana Cream Pie Murder",
				Author = "Joanne Fluke",
				Description = "Hannah Swensen, the bakery owner and amateur sleuth of Lake Eden, Minn., returns from her honeymoon to confront an actress’s mysterious death.",
				Price = 36.95m,
				InitialSellingPrice = 36.95m,
				Cost = 14.41m,
				InitialCost = 14.41m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 5,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b165.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b165);

			Book b166 = new Book()
			{
				PublishedDate = new DateTime(2016, 2, 27),
				UniqueNumber = 222166,
				Title = "Wedding Cake Murder",
				Author = "Joanne Fluke",
				Description = "The Lake Eden, Minn., baker Hannah Swensen is about to get married, but first she must solve the murder of a visiting celebrity chef. Recipes included.",
				Price = 23.95m,
				InitialSellingPrice = 23.95m,
				Cost = 17.72m,
				InitialCost = 17.72m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 14,
				InitialInventory = 14,
				Discontinued = false,
			};
			b166.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b166);

			Book b167 = new Book()
			{
				PublishedDate = new DateTime(2013, 5, 4),
				UniqueNumber = 222167,
				Title = "Nos4A2",
				Author = "Joe Hill",
				Description = "In a creepy battle between real and imaginary worlds, a brave biker chick is pitted against a ghoulish villain who lures children to a place where it is always Christmas.",
				Price = 34m,
				InitialSellingPrice = 34m,
				Cost = 28.56m,
				InitialCost = 28.56m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 14,
				InitialInventory = 14,
				Discontinued = false,
			};
			b167.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b167);

			Book b168 = new Book()
			{
				PublishedDate = new DateTime(2017, 3, 18),
				UniqueNumber = 222168,
				Title = "Without Warning",
				Author = "Joel C Rosenberg",
				Description = "A journalist pursues the head of ISIS after an attack on the Capitol when the administration fails to take action.",
				Price = 27.95m,
				InitialSellingPrice = 27.95m,
				Cost = 12.02m,
				InitialCost = 12.02m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b168.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b168);

			Book b169 = new Book()
			{
				PublishedDate = new DateTime(2010, 6, 19),
				UniqueNumber = 222169,
				Title = "That Perfect Someone",
				Author = "Johanna Lindsey",
				Description = "To avoid falling into a ruthless nobleman's trap, an heiress enters into a risky, intimate charade with a man she was once bound to wed.",
				Price = 25m,
				InitialSellingPrice = 25m,
				Cost = 18.25m,
				InitialCost = 18.25m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b169.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b169);

			Book b170 = new Book()
			{
				PublishedDate = new DateTime(2009, 11, 7),
				UniqueNumber = 222170,
				Title = "Ford County",
				Author = "John Grisham",
				Description = "Stories set in rural Mississippi.",
				Price = 24m,
				InitialSellingPrice = 24m,
				Cost = 14.88m,
				InitialCost = 14.88m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 12,
				InitialInventory = 12,
				Discontinued = false,
			};
			b170.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b170);

			Book b171 = new Book()
			{
				PublishedDate = new DateTime(2016, 10, 29),
				UniqueNumber = 222171,
				Title = "The Whistler",
				Author = "John Grisham",
				Description = "A whistleblower alerts a Florida investigator to judicial corruption involving the Mob and Indian casinos.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 13.48m,
				InitialCost = 13.48m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 13,
				InitialInventory = 13,
				Discontinued = false,
			};
			b171.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b171);

			Book b172 = new Book()
			{
				PublishedDate = new DateTime(2009, 5, 16),
				UniqueNumber = 222172,
				Title = "The Last Child",
				Author = "John Hart",
				Description = "A teenager searches for his inexplicably vanished twin sister.",
				Price = 24.95m,
				InitialSellingPrice = 24.95m,
				Cost = 15.72m,
				InitialCost = 15.72m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 5,
				InitialInventory = 5,
				Discontinued = false,
			};
			b172.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b172);

			Book b173 = new Book()
			{
				PublishedDate = new DateTime(2011, 1, 8),
				UniqueNumber = 222173,
				Title = "Damage",
				Author = "John Lescroart",
				Description = "The San Francisco detective Abe Glitsky faces a scion of wealth who’s seeking revenge against those who sent him to prison a decade ago.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 24.26m,
				InitialCost = 24.26m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b173.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b173);

			Book b174 = new Book()
			{
				PublishedDate = new DateTime(2012, 1, 7),
				UniqueNumber = 222174,
				Title = "The Hunter",
				Author = "John Lescroart",
				Description = "A San Francisco private investigator discovers chilling facts about his birth family.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 5.66m,
				InitialCost = 5.66m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b174.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b174);

			Book b175 = new Book()
			{
				PublishedDate = new DateTime(2016, 10, 22),
				UniqueNumber = 222175,
				Title = "Escape Clause",
				Author = "John Sandford",
				Description = "Virgil Flowers of the Minnesota Bureau of Criminal Apprehension must deal with the theft of tigers from the local zoo.",
				Price = 35.95m,
				InitialSellingPrice = 35.95m,
				Cost = 7.19m,
				InitialCost = 7.19m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 5,
				InitialInventory = 5,
				Discontinued = false,
			};
			b175.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b175);

			Book b176 = new Book()
			{
				PublishedDate = new DateTime(2008, 10, 25),
				UniqueNumber = 222176,
				Title = "Bones",
				Author = "Jonathan Kellerman",
				Description = "The psychologist-detective Alex Delaware is called in when women’s bodies keep turning up in a Los Angeles marsh.",
				Price = 27m,
				InitialSellingPrice = 27m,
				Cost = 14.85m,
				InitialCost = 14.85m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b176.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b176);

			Book b177 = new Book()
			{
				PublishedDate = new DateTime(2012, 3, 3),
				UniqueNumber = 222177,
				Title = "Victims",
				Author = "Jonathan Kellerman",
				Description = "The Los Angeles psychologist-detective Alex Delaware and the detective Milo Sturgis track down a homicidal maniac.",
				Price = 28m,
				InitialSellingPrice = 28m,
				Cost = 16.52m,
				InitialCost = 16.52m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 5,
				InitialInventory = 5,
				Discontinued = false,
			};
			b177.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b177);

			Book b178 = new Book()
			{
				PublishedDate = new DateTime(2018, 1, 13),
				UniqueNumber = 222178,
				Title = "Blood Fury",
				Author = "JR Ward",
				Description = "The third book in the Black Dagger Legacy series.",
				Price = 30.95m,
				InitialSellingPrice = 30.95m,
				Cost = 21.05m,
				InitialCost = 21.05m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 13,
				InitialInventory = 13,
				Discontinued = false,
			};
			b178.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b178);

			Book b179 = new Book()
			{
				PublishedDate = new DateTime(2015, 6, 6),
				UniqueNumber = 222179,
				Title = "In The Unlikely Event",
				Author = "Judy Blume",
				Description = "Secrets are revealed and love stories play out against the backdrop of a series of panic-inducing plane crashes in 1950s New Jersey.",
				Price = 18.95m,
				InitialSellingPrice = 18.95m,
				Cost = 16.87m,
				InitialCost = 16.87m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 12,
				InitialInventory = 12,
				Discontinued = false,
			};
			b179.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b179);

			Book b180 = new Book()
			{
				PublishedDate = new DateTime(2009, 8, 22),
				UniqueNumber = 222180,
				Title = "Dreamfever",
				Author = "Karen Marie Moning",
				Description = "MacKlaya finds herself under the erotic spell of a Fae master.",
				Price = 26m,
				InitialSellingPrice = 26m,
				Cost = 21.06m,
				InitialCost = 21.06m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b180.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b180);

			Book b181 = new Book()
			{
				PublishedDate = new DateTime(2011, 1, 22),
				UniqueNumber = 222181,
				Title = "Shadowfever",
				Author = "Karen Marie Moning",
				Description = "Hunting for her sister’s murderer, MacKayla Lane is caught up in the struggle between humans and the Fae.",
				Price = 26m,
				InitialSellingPrice = 26m,
				Cost = 13.78m,
				InitialCost = 13.78m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 13,
				InitialInventory = 13,
				Discontinued = false,
			};
			b181.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b181);

			Book b182 = new Book()
			{
				PublishedDate = new DateTime(2016, 9, 24),
				UniqueNumber = 222182,
				Title = "The Kept Woman",
				Author = "Karin Slaughter",
				Description = "Will Trent of the Georgia Bureau of Investigation and his lover, the medical examiner Sara Linton, pursue a case involving a dirty Atlanta cop.",
				Price = 16.95m,
				InitialSellingPrice = 16.95m,
				Cost = 15.26m,
				InitialCost = 15.26m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 2,
				InitialInventory = 2,
				Discontinued = false,
			};
			b182.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b182);

			Book b183 = new Book()
			{
				PublishedDate = new DateTime(2009, 7, 18),
				UniqueNumber = 222183,
				Title = "Undone",
				Author = "Karin Slaughter",
				Description = "Dr. Sara Linton works with agents of the Georgia Bureau of Investigation to stop a killer who tortures his victims.",
				Price = 26m,
				InitialSellingPrice = 26m,
				Cost = 7.28m,
				InitialCost = 7.28m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 4,
				InitialInventory = 4,
				Discontinued = false,
			};
			b183.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b183);

			Book b184 = new Book()
			{
				PublishedDate = new DateTime(2015, 10, 24),
				UniqueNumber = 222184,
				Title = "The Lake House",
				Author = "Kate Morton",
				Description = "A London detective investigating a missing-persons case becomes curious about an unsolved 1933 kidnapping in Cornwall.",
				Price = 16.95m,
				InitialSellingPrice = 16.95m,
				Cost = 10.17m,
				InitialCost = 10.17m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 12,
				InitialInventory = 12,
				Discontinued = false,
			};
			b184.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b184);

			Book b185 = new Book()
			{
				PublishedDate = new DateTime(2014, 9, 27),
				UniqueNumber = 222185,
				Title = "Bones Never Lie",
				Author = "Kathy Reichs",
				Description = "A child murderer who eluded capture years ago has resurfaced, giving the forensic anthropologist Temperance Brennan another chance to stop her.",
				Price = 14.95m,
				InitialSellingPrice = 14.95m,
				Cost = 9.42m,
				InitialCost = 9.42m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 12,
				InitialInventory = 12,
				Discontinued = false,
			};
			b185.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b185);

			Book b186 = new Book()
			{
				PublishedDate = new DateTime(2017, 7, 15),
				UniqueNumber = 222186,
				Title = "Two Nights",
				Author = "Kathy Reichs",
				Description = "Sunday Night, the heroine of a new series from the creator of Temperance Brennan, searches for a girl who may have been kidnapped by a cult.",
				Price = 17.95m,
				InitialSellingPrice = 17.95m,
				Cost = 15.98m,
				InitialCost = 15.98m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b186.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b186);

			Book b187 = new Book()
			{
				PublishedDate = new DateTime(2010, 1, 30),
				UniqueNumber = 222187,
				Title = "Blood Ties",
				Author = "Kay Hooper",
				Description = "The F.B.I. agent Noah Bishop and his special crimes unit pursue a brutal enemy.",
				Price = 26m,
				InitialSellingPrice = 26m,
				Cost = 5.2m,
				InitialCost = 5.2m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b187.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b187);

			Book b188 = new Book()
			{
				PublishedDate = new DateTime(2012, 8, 4),
				UniqueNumber = 222188,
				Title = "Haven",
				Author = "Kay Hooper",
				Description = "The F.B.I. agent Noah Bishop and his special crimes unit help two sisters probe the secrets of a North Carolina town.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 14.82m,
				InitialCost = 14.82m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 3,
				InitialInventory = 3,
				Discontinued = false,
			};
			b188.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b188);

			Book b189 = new Book()
			{
				PublishedDate = new DateTime(2014, 8, 9),
				UniqueNumber = 222189,
				Title = "Dark Skye",
				Author = "Kresley Cole",
				Description = "Will a scarred warrior and the beautiful sorceress with the power to heal him overcome the challenges of their warring families and the chaotic battles around them? Book 15 in the Immortals After Dark series.",
				Price = 20m,
				InitialSellingPrice = 20m,
				Cost = 4m,
				InitialCost = 4m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 0,
				InitialInventory = 0,
				Discontinued = false,
			};
			b189.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b189);

			Book b190 = new Book()
			{
				PublishedDate = new DateTime(2017, 9, 9),
				UniqueNumber = 222190,
				Title = "Enemy Of The State",
				Author = "Kyle Mills",
				Description = "Vince Flynn's character Mitch Rapp leaves the C.I.A. to go on a manhunt when the nephew of a Saudi King finances a terrorist group.",
				Price = 20.95m,
				InitialSellingPrice = 20.95m,
				Cost = 4.19m,
				InitialCost = 4.19m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 13,
				InitialInventory = 13,
				Discontinued = false,
			};
			b190.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b190);

			Book b191 = new Book()
			{
				PublishedDate = new DateTime(2016, 10, 15),
				UniqueNumber = 222191,
				Title = "Vince Flynn: Order To Kill",
				Author = "Kyle Mills",
				Description = "Flynn’s character, the C.I.A. operative Mitch Rapp, uncovers a dangerous Russian plot. Flynn died in 2013.",
				Price = 16.95m,
				InitialSellingPrice = 16.95m,
				Cost = 13.73m,
				InitialCost = 13.73m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b191.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b191);

			Book b192 = new Book()
			{
				PublishedDate = new DateTime(2013, 3, 9),
				UniqueNumber = 222192,
				Title = "Sweet Tea Revenge",
				Author = "Laura Childs",
				Description = "Theodosia Browning, owner of Indigo Tea Shop, is a bridesmaid in her friend's wedding. But the bridegroom is found dead on the big day.",
				Price = 29m,
				InitialSellingPrice = 29m,
				Cost = 13.92m,
				InitialCost = 13.92m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b192.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b192);

			Book b193 = new Book()
			{
				PublishedDate = new DateTime(2016, 10, 15),
				UniqueNumber = 222193,
				Title = "Crimson Death",
				Author = "Laurell K Hamilton",
				Description = "The vampire hunter Anita Blake, her friend Edward and her servant Damian travel to Ireland to battle an unusual vampire infestation.",
				Price = 16.99m,
				InitialSellingPrice = 16.99m,
				Cost = 7.65m,
				InitialCost = 7.65m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 14,
				InitialInventory = 14,
				Discontinued = false,
			};
			b193.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b193);

			Book b194 = new Book()
			{
				PublishedDate = new DateTime(2009, 6, 6),
				UniqueNumber = 222194,
				Title = "Skin Trade",
				Author = "Laurell K Hamilton",
				Description = "Investigating some killings in Las Vegas, the vampire hunter Anita Blake must contend with the power of the weretigers.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 2.7m,
				InitialCost = 2.7m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b194.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b194);

			Book b195 = new Book()
			{
				PublishedDate = new DateTime(2011, 10, 1),
				UniqueNumber = 222195,
				Title = "The Affair",
				Author = "Lee Child",
				Description = "For Jack Reacher, an elite military police officer, it all started in 1997. A lonely railroad track. A crime scene. A cover-up.",
				Price = 28m,
				InitialSellingPrice = 28m,
				Cost = 8.68m,
				InitialCost = 8.68m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b195.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b195);

			Book b196 = new Book()
			{
				PublishedDate = new DateTime(2010, 1, 16),
				UniqueNumber = 222196,
				Title = "Roses",
				Author = "Leila Meacham",
				Description = "Three generations in a small East Texas town.",
				Price = 24.99m,
				InitialSellingPrice = 24.99m,
				Cost = 20.99m,
				InitialCost = 20.99m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 12,
				InitialInventory = 12,
				Discontinued = false,
			};
			b196.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b196);

			Book b197 = new Book()
			{
				PublishedDate = new DateTime(2014, 8, 9),
				UniqueNumber = 222197,
				Title = "The Magician's Land",
				Author = "Lev Grossman",
				Description = "Quentin, an exiled magician, tries a risky heist in the final installment of a trilogy.",
				Price = 28.95m,
				InitialSellingPrice = 28.95m,
				Cost = 5.5m,
				InitialCost = 5.5m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b197.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b197);

			Book b198 = new Book()
			{
				PublishedDate = new DateTime(2014, 8, 2),
				UniqueNumber = 222198,
				Title = "Big Little Lies",
				Author = "Liane Moriarty",
				Description = "Who will end up dead, and how, when three mothers with children in the same school become friends?",
				Price = 17m,
				InitialSellingPrice = 17m,
				Cost = 5.1m,
				InitialCost = 5.1m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b198.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b198);

			Book b199 = new Book()
			{
				PublishedDate = new DateTime(2016, 7, 30),
				UniqueNumber = 222199,
				Title = "Truly Madly Guilty",
				Author = "Liane Moriarty",
				Description = "Tense turning points for three couples at a backyard barbecue gone wrong.",
				Price = 14.99m,
				InitialSellingPrice = 14.99m,
				Cost = 10.04m,
				InitialCost = 10.04m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b199.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b199);

			Book b200 = new Book()
			{
				PublishedDate = new DateTime(2016, 7, 16),
				UniqueNumber = 222200,
				Title = "Among The Wicked",
				Author = "Linda Castillo",
				Description = "Chief of Police Kate Burkholder goes undercover as a widow in a reclusive Amish community to investigate a girl's death.",
				Price = 24m,
				InitialSellingPrice = 24m,
				Cost = 6.72m,
				InitialCost = 6.72m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b200.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b200);

			Book b201 = new Book()
			{
				PublishedDate = new DateTime(2014, 6, 21),
				UniqueNumber = 222201,
				Title = "Terminal City",
				Author = "Linda Fairstein",
				Description = "Alexandra Cooper, a Manhattan assistant district attorney, hunts for a killer in Grand Central’s underground tunnels.",
				Price = 32.95m,
				InitialSellingPrice = 32.95m,
				Cost = 16.48m,
				InitialCost = 16.48m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 12,
				InitialInventory = 12,
				Discontinued = false,
			};
			b201.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b201);

			Book b202 = new Book()
			{
				PublishedDate = new DateTime(2011, 10, 1),
				UniqueNumber = 222202,
				Title = "A Lawman's Christmas",
				Author = "Linda Lael Miller",
				Description = "The death of the town marshal leaves Blue River, Texas, without a lawman, and Dara Rose Nolan without a husband. Clay McKettrick steps in, and when he and Dara Rose agree to a marriage of convenience, the temporary lawman’s Christmas wish is to make her his permanent wife.",
				Price = 28m,
				InitialSellingPrice = 28m,
				Cost = 15.96m,
				InitialCost = 15.96m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 5,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b202.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b202);

			Book b203 = new Book()
			{
				PublishedDate = new DateTime(2016, 2, 13),
				UniqueNumber = 222203,
				Title = "Find Her",
				Author = "Lisa Gardner",
				Description = "The Boston detective D.D. Warren hunts for a missing woman who was kidnapped and abused as a college student and may have become a vigilante.",
				Price = 28.95m,
				InitialSellingPrice = 28.95m,
				Cost = 10.71m,
				InitialCost = 10.71m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 4,
				InitialInventory = 4,
				Discontinued = false,
			};
			b203.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b203);

			Book b204 = new Book()
			{
				PublishedDate = new DateTime(2008, 7, 19),
				UniqueNumber = 222204,
				Title = "Say Goodbye",
				Author = "Lisa Gardner",
				Description = "An F.B.I. agent tracks a serial killer who uses spiders as a weapon.",
				Price = 25m,
				InitialSellingPrice = 25m,
				Cost = 11.25m,
				InitialCost = 11.25m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 5,
				InitialInventory = 5,
				Discontinued = false,
			};
			b204.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b204);

			Book b205 = new Book()
			{
				PublishedDate = new DateTime(2010, 4, 3),
				UniqueNumber = 222205,
				Title = "Without Mercy",
				Author = "Lisa Jackson",
				Description = "Students are dying at an Oregon boarding school for wayward kids, and the concerned new teacher may be the next target.",
				Price = 25m,
				InitialSellingPrice = 25m,
				Cost = 4.25m,
				InitialCost = 4.25m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b205.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b205);

			Book b206 = new Book()
			{
				PublishedDate = new DateTime(2011, 4, 16),
				UniqueNumber = 222206,
				Title = "Save Me",
				Author = "Lisa Scottoline",
				Description = "A mother’s action during a school emergency causes an uproar in a Philadelphia suburb.",
				Price = 27.99m,
				InitialSellingPrice = 27.99m,
				Cost = 11.2m,
				InitialCost = 11.2m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b206.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b206);

			Book b207 = new Book()
			{
				PublishedDate = new DateTime(2010, 3, 20),
				UniqueNumber = 222207,
				Title = "Think Twice",
				Author = "Lisa Scottoline",
				Description = "A woman takes over her twin sister’s life.",
				Price = 26.99m,
				InitialSellingPrice = 26.99m,
				Cost = 21.86m,
				InitialCost = 21.86m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b207.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b207);

			Book b208 = new Book()
			{
				PublishedDate = new DateTime(2009, 5, 30),
				UniqueNumber = 222208,
				Title = "Shanghai Girls",
				Author = "Lisa See",
				Description = "Two Chinese sisters in the 1930s are sold as wives to men from California, and leave their war-torn country to join them.",
				Price = 25m,
				InitialSellingPrice = 25m,
				Cost = 2.5m,
				InitialCost = 2.5m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 4,
				InitialInventory = 4,
				Discontinued = false,
			};
			b208.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b208);

			Book b209 = new Book()
			{
				PublishedDate = new DateTime(2017, 11, 4),
				UniqueNumber = 222209,
				Title = "Twin Peaks: The Final Dossier",
				Author = "Mark Frost",
				Description = "Updated profiles on the residents of Twin Peaks are assembled by special agent Tamara Preston.",
				Price = 27.95m,
				InitialSellingPrice = 27.95m,
				Cost = 8.66m,
				InitialCost = 8.66m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 0,
				InitialInventory = 0,
				Discontinued = false,
			};
			b209.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b209);

			Book b210 = new Book()
			{
				PublishedDate = new DateTime(2017, 2, 18),
				UniqueNumber = 222210,
				Title = "Gunmetal Gray",
				Author = "Mark Greaney",
				Description = "Court Gentry, now working for the C.I.A., pursues a Chinese hacker who is on the run.",
				Price = 21.95m,
				InitialSellingPrice = 21.95m,
				Cost = 16.24m,
				InitialCost = 16.24m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 13,
				InitialInventory = 13,
				Discontinued = false,
			};
			b210.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b210);

			Book b211 = new Book()
			{
				PublishedDate = new DateTime(2013, 11, 16),
				UniqueNumber = 222211,
				Title = "Tatiana",
				Author = "Martin Cruz Smith",
				Description = "A dead translator’s coded notebook may hold the key to the murders of a muckraking journalist and an oligarch in the former Soviet Union. Arkady Renko, a senior investigator in the Moscow prosecutor’s office, is on the case.",
				Price = 20.99m,
				InitialSellingPrice = 20.99m,
				Cost = 18.68m,
				InitialCost = 18.68m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 2,
				InitialInventory = 2,
				Discontinued = false,
			};
			b211.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b211);

			Book b212 = new Book()
			{
				PublishedDate = new DateTime(2018, 5, 26),
				UniqueNumber = 222212,
				Title = "Beach House Reunion",
				Author = "Mary Alice Monroe",
				Description = "Three generations of a family gather one summer in South Carolina.",
				Price = 32.95m,
				InitialSellingPrice = 32.95m,
				Cost = 6.59m,
				InitialCost = 6.59m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b212.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b212);

			Book b213 = new Book()
			{
				PublishedDate = new DateTime(2011, 4, 9),
				UniqueNumber = 222213,
				Title = "I’Ll Walk Alone",
				Author = "Mary Higgins Clark",
				Description = "A woman haunted by the disappearance of her young son discovers that someone has stolen her identity.",
				Price = 25.99m,
				InitialSellingPrice = 25.99m,
				Cost = 3.9m,
				InitialCost = 3.9m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 14,
				InitialInventory = 14,
				Discontinued = false,
			};
			b213.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b213);

			Book b214 = new Book()
			{
				PublishedDate = new DateTime(2014, 11, 22),
				UniqueNumber = 222214,
				Title = "The Cinderella Murder",
				Author = "Mary Higgins Clark and Alafair Burke",
				Description = "A TV producer plans a show about a cold case — the murder of a U.C.L.A. student who was found with one shoe missing.",
				Price = 25.95m,
				InitialSellingPrice = 25.95m,
				Cost = 5.97m,
				InitialCost = 5.97m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 4,
				InitialInventory = 4,
				Discontinued = false,
			};
			b214.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b214);

			Book b215 = new Book()
			{
				PublishedDate = new DateTime(2011, 6, 11),
				UniqueNumber = 222215,
				Title = "Summer Rental",
				Author = "Mary Kay Andrews",
				Description = "Three friends in their mid-30s spend a month on North Carolina’s Outer Banks.",
				Price = 25.99m,
				InitialSellingPrice = 25.99m,
				Cost = 9.62m,
				InitialCost = 9.62m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b215.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b215);

			Book b216 = new Book()
			{
				PublishedDate = new DateTime(2018, 5, 12),
				UniqueNumber = 222216,
				Title = "The High Tide Club",
				Author = "Mary Kay Andrews",
				Description = "An eccentric millionaire enlists the attorney Brooke Trappnell to fix old wrongs, which sets up a potential scandal and murder.",
				Price = 23.95m,
				InitialSellingPrice = 23.95m,
				Cost = 14.13m,
				InitialCost = 14.13m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 14,
				InitialInventory = 14,
				Discontinued = false,
			};
			b216.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b216);

			Book b217 = new Book()
			{
				PublishedDate = new DateTime(2016, 5, 21),
				UniqueNumber = 222217,
				Title = "The Weekenders",
				Author = "Mary Kay Andrews",
				Description = "On the North Carolina island of Belle Isle, a woman investigates her husband’s shady financial affairs after his mysterious death.",
				Price = 20.95m,
				InitialSellingPrice = 20.95m,
				Cost = 12.78m,
				InitialCost = 12.78m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 13,
				InitialInventory = 13,
				Discontinued = false,
			};
			b217.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b217);

			Book b218 = new Book()
			{
				PublishedDate = new DateTime(2012, 9, 15),
				UniqueNumber = 222218,
				Title = "Telegraph Avenue",
				Author = "Michael Chabon",
				Description = "Fathers and sons in Berkeley and Oakland, Calif.",
				Price = 27.99m,
				InitialSellingPrice = 27.99m,
				Cost = 11.2m,
				InitialCost = 11.2m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 13,
				InitialInventory = 13,
				Discontinued = false,
			};
			b218.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b218);

			Book b219 = new Book()
			{
				PublishedDate = new DateTime(2014, 11, 8),
				UniqueNumber = 222219,
				Title = "The Burning Room",
				Author = "Michael Connelly",
				Description = "The Los Angeles detective Harry Bosch and his new partner investigate two long-unsolved cases.",
				Price = 36.99m,
				InitialSellingPrice = 36.99m,
				Cost = 17.39m,
				InitialCost = 17.39m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b219.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b219);

			Book b220 = new Book()
			{
				PublishedDate = new DateTime(2011, 4, 9),
				UniqueNumber = 222220,
				Title = "The Fifth Witness",
				Author = "Michael Connelly",
				Description = "The defense lawyer Mickey Haller represents a woman facing home foreclosure who is accused of killing a banker.",
				Price = 27.99m,
				InitialSellingPrice = 27.99m,
				Cost = 6.16m,
				InitialCost = 6.16m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 4,
				InitialInventory = 4,
				Discontinued = false,
			};
			b220.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b220);

			Book b221 = new Book()
			{
				PublishedDate = new DateTime(2018, 5, 12),
				UniqueNumber = 222221,
				Title = "Warlight",
				Author = "Michael Ondaatje",
				Description = "In Britain after World War II, a pair of teenage siblings are taken under the tutelage of a mysterious man and his cronies who served during the war.",
				Price = 26m,
				InitialSellingPrice = 26m,
				Cost = 20.28m,
				InitialCost = 20.28m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b221.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b221);

			Book b222 = new Book()
			{
				PublishedDate = new DateTime(2010, 8, 14),
				UniqueNumber = 222222,
				Title = "Death On The D-List",
				Author = "Nancy Grace",
				Description = "Fading celebrities who appear on Hailey Dean’s TV show are being murdered.",
				Price = 25.99m,
				InitialSellingPrice = 25.99m,
				Cost = 5.98m,
				InitialCost = 5.98m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 0,
				InitialInventory = 0,
				Discontinued = false,
			};
			b222.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b222);

			Book b223 = new Book()
			{
				PublishedDate = new DateTime(2011, 9, 24),
				UniqueNumber = 222223,
				Title = "Reamde",
				Author = "Neal Stephenson",
				Description = "A virus invades a multiplayer online role-playing game and sets off a violent struggle.",
				Price = 35m,
				InitialSellingPrice = 35m,
				Cost = 14.7m,
				InitialCost = 14.7m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 12,
				InitialInventory = 12,
				Discontinued = false,
			};
			b223.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
			Books.Add(b223);

			Book b224 = new Book()
			{
				PublishedDate = new DateTime(2015, 2, 7),
				UniqueNumber = 222224,
				Title = "Trigger Warning",
				Author = "Neil Gaiman",
				Description = "Stories and poems about the power of imagination.",
				Price = 17.95m,
				InitialSellingPrice = 17.95m,
				Cost = 10.41m,
				InitialCost = 10.41m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 5,
				InitialInventory = 5,
				Discontinued = false,
			};
			b224.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Poetry");
			Books.Add(b224);

			Book b225 = new Book()
			{
				PublishedDate = new DateTime(2009, 4, 11),
				UniqueNumber = 222225,
				Title = "Borderline",
				Author = "Nevada Barr",
				Description = "Off duty and on vacation in Big Bend National Park, Anna Pigeon rescues a baby and is drawn into cross-border intrigue.",
				Price = 25.95m,
				InitialSellingPrice = 25.95m,
				Cost = 3.11m,
				InitialCost = 3.11m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b225.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b225);

			Book b226 = new Book()
			{
				PublishedDate = new DateTime(2014, 4, 5),
				UniqueNumber = 222226,
				Title = "Destroyer Angel",
				Author = "Nevada Barr",
				Description = "The National Park Service Ranger Anna Pigeon must rescue friends who are kidnapped while camping in Minnesota.",
				Price = 32m,
				InitialSellingPrice = 32m,
				Cost = 3.52m,
				InitialCost = 3.52m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 5,
				InitialInventory = 5,
				Discontinued = false,
			};
			b226.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b226);

			Book b227 = new Book()
			{
				PublishedDate = new DateTime(2015, 7, 4),
				UniqueNumber = 222227,
				Title = "The Little Paris Bookshop",
				Author = "Nina George",
				Description = "A bookseller with a knack for finding just the right book for making others feel better embarks on a journey in pursuit of his own happiness.",
				Price = 34m,
				InitialSellingPrice = 34m,
				Cost = 5.78m,
				InitialCost = 5.78m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b227.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b227);

			Book b228 = new Book()
			{
				PublishedDate = new DateTime(2010, 7, 10),
				UniqueNumber = 222228,
				Title = "The Search",
				Author = "Nora Roberts",
				Description = "The only survivor of a serial killer has found peace in the Pacific Northwest, but her life is shaken by the appearance of a new man and a copycat murderer.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 8.62m,
				InitialCost = 8.62m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b228.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b228);

			Book b229 = new Book()
			{
				PublishedDate = new DateTime(2017, 3, 11),
				UniqueNumber = 222229,
				Title = "Silence Fallen",
				Author = "Patricia Briggs",
				Description = "The shape-shifter Mercy Thompson finds herself in the clutches of the world’s most powerful vampire.",
				Price = 36m,
				InitialSellingPrice = 36m,
				Cost = 10.08m,
				InitialCost = 10.08m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b229.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b229);

			Book b230 = new Book()
			{
				PublishedDate = new DateTime(2013, 11, 16),
				UniqueNumber = 222230,
				Title = "Dust",
				Author = "Patricia Cornwell",
				Description = "The murder of a computer engineer at M.I.T. leads the Massachusetts Chief Medical Examiner Kay Scarpetta in unexpected directions.",
				Price = 23.99m,
				InitialSellingPrice = 23.99m,
				Cost = 18.23m,
				InitialCost = 18.23m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 4,
				InitialInventory = 4,
				Discontinued = false,
			};
			b230.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b230);

			Book b231 = new Book()
			{
				PublishedDate = new DateTime(2008, 12, 6),
				UniqueNumber = 222231,
				Title = "Scarpetta",
				Author = "Patricia Cornwell",
				Description = "The forensic pathologist Kay Scarpetta takes an assignment in New York City.",
				Price = 27.95m,
				InitialSellingPrice = 27.95m,
				Cost = 13.14m,
				InitialCost = 13.14m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b231.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b231);

			Book b232 = new Book()
			{
				PublishedDate = new DateTime(2017, 2, 4),
				UniqueNumber = 222232,
				Title = "4 3 2 1",
				Author = "Paul Auster",
				Description = "Four versions of the formative years of a Jewish boy born in Newark in 1947.",
				Price = 20.95m,
				InitialSellingPrice = 20.95m,
				Cost = 5.87m,
				InitialCost = 5.87m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b232.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b232);

			Book b233 = new Book()
			{
				PublishedDate = new DateTime(2012, 2, 18),
				UniqueNumber = 222233,
				Title = "Robert Ludlum’S The Janson Command",
				Author = "Paul Garrison",
				Description = "A former American operative builds a network to help him resolve crises without torture or civilian casualties.",
				Price = 27.99m,
				InitialSellingPrice = 27.99m,
				Cost = 7.28m,
				InitialCost = 7.28m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 13,
				InitialInventory = 13,
				Discontinued = false,
			};
			b233.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b233);

			Book b234 = new Book()
			{
				PublishedDate = new DateTime(2015, 4, 11),
				UniqueNumber = 222234,
				Title = "The Lady From Zagreb",
				Author = "Philip Kerr",
				Description = "The former Berlin homicide detective Bernie Gunther is sent to Croatia by Joseph Goebbels to persuade a film star to appear in a movie.",
				Price = 20.95m,
				InitialSellingPrice = 20.95m,
				Cost = 19.27m,
				InitialCost = 19.27m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b234.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b234);

			Book b235 = new Book()
			{
				PublishedDate = new DateTime(2013, 6, 1),
				UniqueNumber = 222235,
				Title = "The Son",
				Author = "Philipp Meyer",
				Description = "More than 150 years in a Texas family, from Comanche raids to the present, and its rise to money and power in the cattle and oil industries.",
				Price = 22m,
				InitialSellingPrice = 22m,
				Cost = 19.58m,
				InitialCost = 19.58m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 3,
				InitialInventory = 3,
				Discontinued = false,
			};
			b235.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b235);

			Book b236 = new Book()
			{
				PublishedDate = new DateTime(2014, 9, 13),
				UniqueNumber = 222236,
				Title = "The King's Curse",
				Author = "Philippa Gregory",
				Description = "As chief lady-in-waiting to Katherine of Aragon, Margaret Pole is torn between the queen and her husband, Henry VIII.",
				Price = 18.99m,
				InitialSellingPrice = 18.99m,
				Cost = 3.99m,
				InitialCost = 3.99m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 14,
				InitialInventory = 14,
				Discontinued = false,
			};
			b236.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b236);

			Book b237 = new Book()
			{
				PublishedDate = new DateTime(2008, 9, 20),
				UniqueNumber = 222237,
				Title = "The Other Queen",
				Author = "Philippa Gregory",
				Description = "The story of Mary, Queen of Scots, in captivity under Queen Elizabeth.",
				Price = 25.95m,
				InitialSellingPrice = 25.95m,
				Cost = 23.61m,
				InitialCost = 23.61m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b237.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b237);

			Book b238 = new Book()
			{
				PublishedDate = new DateTime(2013, 3, 9),
				UniqueNumber = 222238,
				Title = "The Last Threshold",
				Author = "R A Salvatore",
				Description = "Book 4 of the fantasy Neverwinter Saga.",
				Price = 27.95m,
				InitialSellingPrice = 27.95m,
				Cost = 2.8m,
				InitialCost = 2.8m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 15,
				InitialInventory = 15,
				Discontinued = false,
			};
			b238.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b238);

			Book b239 = new Book()
			{
				PublishedDate = new DateTime(2008, 10, 11),
				UniqueNumber = 222239,
				Title = "The Pirate King",
				Author = "R A Salvatore",
				Description = "In Book 2 of the Transitions fantasy series, Drizzt returns to Luskan, a city dominated by dangerous pirates.",
				Price = 27.95m,
				InitialSellingPrice = 27.95m,
				Cost = 14.25m,
				InitialCost = 14.25m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 5,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b239.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b239);

			Book b240 = new Book()
			{
				PublishedDate = new DateTime(2014, 7, 12),
				UniqueNumber = 222240,
				Title = "Landline",
				Author = "Rainbow Rowell",
				Description = "A woman in a troubled marriage finds a way to communicate with her husband in the past.",
				Price = 29m,
				InitialSellingPrice = 29m,
				Cost = 5.8m,
				InitialCost = 5.8m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 13,
				InitialInventory = 13,
				Discontinued = false,
			};
			b240.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b240);

			Book b241 = new Book()
			{
				PublishedDate = new DateTime(2018, 3, 17),
				UniqueNumber = 222241,
				Title = "Caribbean Rim",
				Author = "Randy Wayne White",
				Description = "The 25th book in the Doc Ford series. The marine biologist searches for a state agency official and rare Spanish coins.",
				Price = 15m,
				InitialSellingPrice = 15m,
				Cost = 9.45m,
				InitialCost = 9.45m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b241.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b241);

			Book b242 = new Book()
			{
				PublishedDate = new DateTime(2010, 3, 13),
				UniqueNumber = 222242,
				Title = "Deep Shadow",
				Author = "Randy Wayne White",
				Description = "Murderers want Doc Ford to help them dive for the remains of a wrecked plane supposedly laden with Cuban gold.",
				Price = 25.95m,
				InitialSellingPrice = 25.95m,
				Cost = 5.45m,
				InitialCost = 5.45m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 5,
				InitialInventory = 5,
				Discontinued = false,
			};
			b242.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b242);

			Book b243 = new Book()
			{
				PublishedDate = new DateTime(2013, 9, 21),
				UniqueNumber = 222243,
				Title = "Deadly Heat",
				Author = "Richard Castle",
				Description = "The N.Y.P.D. homicide detective Nikki Heat and the journalist Jameson Rook search for the former C.I.A. station chief who ordered her mother’s execution.\nThe N.Y.P.D. homicide detective Nikki Heat and the journalist Jameson Rook search for the former C.I.A. station chief who ordered her mother’s execution.",
				Price = 16m,
				InitialSellingPrice = 16m,
				Cost = 3.36m,
				InitialCost = 3.36m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 2,
				InitialInventory = 2,
				Discontinued = false,
			};
			b243.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b243);

			Book b244 = new Book()
			{
				PublishedDate = new DateTime(2014, 10, 18),
				UniqueNumber = 222244,
				Title = "The Narrow Road To The Deep North",
				Author = "Richard Flanagan",
				Description = "The hero of the Man Booker Prize-winning novel about love, good and evil is a P.O.W. working on the Thai-Burma Death Railway during World War II.",
				Price = 34m,
				InitialSellingPrice = 34m,
				Cost = 20.74m,
				InitialCost = 20.74m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b244.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Historical Fiction");
			Books.Add(b244);

			Book b245 = new Book()
			{
				PublishedDate = new DateTime(2010, 10, 9),
				UniqueNumber = 222245,
				Title = "Promise Me",
				Author = "Richard Paul Evans",
				Description = "On Christmas Day, a woman with family problems meets a handsome, mysterious stranger.",
				Price = 19.99m,
				InitialSellingPrice = 19.99m,
				Cost = 10.79m,
				InitialCost = 10.79m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 2,
				InitialInventory = 2,
				Discontinued = false,
			};
			b245.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b245);

			Book b246 = new Book()
			{
				PublishedDate = new DateTime(2015, 11, 21),
				UniqueNumber = 222246,
				Title = "The Mistletoe Inn",
				Author = "Richard Paul Evans",
				Description = "An aspiring romance writer with a broken heart meets a complicated man at a Christmas writers’ retreat.",
				Price = 36.95m,
				InitialSellingPrice = 36.95m,
				Cost = 11.09m,
				InitialCost = 11.09m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b246.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b246);

			Book b247 = new Book()
			{
				PublishedDate = new DateTime(2014, 11, 22),
				UniqueNumber = 222247,
				Title = "The Mistletoe Promise",
				Author = "Richard Paul Evans",
				Description = "A divorced woman enters into a contract with a strange man to pretend to be a couple until Christmas.",
				Price = 23.99m,
				InitialSellingPrice = 23.99m,
				Cost = 12.23m,
				InitialCost = 12.23m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b247.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b247);

			Book b248 = new Book()
			{
				PublishedDate = new DateTime(2008, 10, 25),
				UniqueNumber = 222248,
				Title = "Rough Weather",
				Author = "Robert B Parker",
				Description = "The Boston private eye Spenser gets involved when a gunman kidnaps the bride from her wedding on a private island.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 20.75m,
				InitialCost = 20.75m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b248.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b248);

			Book b249 = new Book()
			{
				PublishedDate = new DateTime(2009, 10, 10),
				UniqueNumber = 222249,
				Title = "The Professional",
				Author = "Robert B Parker",
				Description = "Rich women are turning up dead, and the Boston P.I. Spenser investigates.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 7.01m,
				InitialCost = 7.01m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b249.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b249);

			Book b250 = new Book()
			{
				PublishedDate = new DateTime(2008, 7, 5),
				UniqueNumber = 222250,
				Title = "Chasing Darkness",
				Author = "Robert Crais",
				Description = "The Los Angeles private eye Elvis Cole responsible for the release of a serial killer?",
				Price = 25.95m,
				InitialSellingPrice = 25.95m,
				Cost = 9.08m,
				InitialCost = 9.08m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b250.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b250);

			Book b251 = new Book()
			{
				PublishedDate = new DateTime(2015, 11, 14),
				UniqueNumber = 222251,
				Title = "The Promise",
				Author = "Robert Crais",
				Description = "The Los Angeles P.I. Elvis Cole joins forces with the K-9 officer Scott James of the L.A.P.D. and his German shepherd, Maggie, as well as his partner, Joe Pike, to foil a criminal mastermind.",
				Price = 27.95m,
				InitialSellingPrice = 27.95m,
				Cost = 18.73m,
				InitialCost = 18.73m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b251.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b251);

			Book b252 = new Book()
			{
				PublishedDate = new DateTime(2008, 8, 9),
				UniqueNumber = 222252,
				Title = "Foreign Body",
				Author = "Robin Cook",
				Description = "A medical student investigates a rising number of deaths among medical tourists at foreign hospitals.",
				Price = 25.95m,
				InitialSellingPrice = 25.95m,
				Cost = 24.65m,
				InitialCost = 24.65m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b252.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
			Books.Add(b252);

			Book b253 = new Book()
			{
				PublishedDate = new DateTime(2016, 7, 23),
				UniqueNumber = 222253,
				Title = "The Woman In Cabin 10",
				Author = "Ruth Ware",
				Description = "A travel writer on a cruise is certain she has heard a body thrown overboard, but no one believes her.",
				Price = 32m,
				InitialSellingPrice = 32m,
				Cost = 3.52m,
				InitialCost = 3.52m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b253.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
			Books.Add(b253);

			Book b254 = new Book()
			{
				PublishedDate = new DateTime(2011, 6, 18),
				UniqueNumber = 222254,
				Title = "Before I Go To Sleep",
				Author = "S J Watson",
				Description = "After a mysterious accident, an amnesiac cannot remember her past or form new memories.",
				Price = 14.99m,
				InitialSellingPrice = 14.99m,
				Cost = 6m,
				InitialCost = 6m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 5,
				InitialInventory = 5,
				Discontinued = false,
			};
			b254.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b254);

			Book b255 = new Book()
			{
				PublishedDate = new DateTime(2013, 9, 28),
				UniqueNumber = 222255,
				Title = "Deadline",
				Author = "Sandra Brown",
				Description = "A journalist who pursues a story about a former marine, the son of terrorists from 40 years ago,becomes a suspect in the death of his ex-wife.",
				Price = 16m,
				InitialSellingPrice = 16m,
				Cost = 4.48m,
				InitialCost = 4.48m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b255.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b255);

			Book b256 = new Book()
			{
				PublishedDate = new DateTime(2015, 8, 22),
				UniqueNumber = 222256,
				Title = "Friction",
				Author = "Sandra Brown",
				Description = "A Texas Ranger fights for custody of his daughter amid complications stemming from his attraction to the judge.",
				Price = 18.99m,
				InitialSellingPrice = 18.99m,
				Cost = 2.85m,
				InitialCost = 2.85m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b256.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b256);

			Book b257 = new Book()
			{
				PublishedDate = new DateTime(2014, 8, 23),
				UniqueNumber = 222257,
				Title = "Mean Streak",
				Author = "Sandra Brown",
				Description = "A North Carolina pediatrician is held captive by a mysterious man who forces her to question her life.",
				Price = 29.95m,
				InitialSellingPrice = 29.95m,
				Cost = 26.66m,
				InitialCost = 26.66m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b257.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b257);

			Book b258 = new Book()
			{
				PublishedDate = new DateTime(2016, 8, 20),
				UniqueNumber = 222258,
				Title = "Sting",
				Author = "Sandra Brown",
				Description = "A hired killer and a woman he kidnapped join forces to elude the F.B.I. agents and others who are searching for her corrupt brother.",
				Price = 27m,
				InitialSellingPrice = 27m,
				Cost = 8.91m,
				InitialCost = 8.91m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b258.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b258);

			Book b259 = new Book()
			{
				PublishedDate = new DateTime(2010, 3, 20),
				UniqueNumber = 222259,
				Title = "The Girl Who Chased The Moon",
				Author = "Sarah Addison Allen",
				Description = "Mysteries and magic in a quirky North Carolina town.",
				Price = 25m,
				InitialSellingPrice = 25m,
				Cost = 11.25m,
				InitialCost = 11.25m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b259.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b259);

			Book b260 = new Book()
			{
				PublishedDate = new DateTime(2008, 8, 9),
				UniqueNumber = 222260,
				Title = "Acheron",
				Author = "Sherrilyn Kenyon",
				Description = "Book 12 of the Dark-Hunter paranormal series.",
				Price = 24.95m,
				InitialSellingPrice = 24.95m,
				Cost = 13.72m,
				InitialCost = 13.72m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 2,
				InitialInventory = 2,
				Discontinued = false,
			};
			b260.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b260);

			Book b261 = new Book()
			{
				PublishedDate = new DateTime(2016, 8, 6),
				UniqueNumber = 222261,
				Title = "Dragonmark",
				Author = "Sherrilyn Kenyon",
				Description = "The first book of a new trilogy featuring Illarion, a dragon made into a human against his will. A Dark-Hunter novel.",
				Price = 29.95m,
				InitialSellingPrice = 29.95m,
				Cost = 3.29m,
				InitialCost = 3.29m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b261.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b261);

			Book b262 = new Book()
			{
				PublishedDate = new DateTime(2010, 9, 11),
				UniqueNumber = 222262,
				Title = "No Mercy",
				Author = "Sherrilyn Kenyon",
				Description = "Book 19 of the Dark-Hunter paranormal series.",
				Price = 24.99m,
				InitialSellingPrice = 24.99m,
				Cost = 5.25m,
				InitialCost = 5.25m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 12,
				InitialInventory = 12,
				Discontinued = false,
			};
			b262.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b262);

			Book b263 = new Book()
			{
				PublishedDate = new DateTime(2008, 11, 8),
				UniqueNumber = 222263,
				Title = "Midnight",
				Author = "Sister Souljah",
				Description = "A boy from Sudan struggles to protect his mother and sister and remain true to his Islamic principles in a Brooklyn housing project.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 21.29m,
				InitialCost = 21.29m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b263.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b263);

			Book b264 = new Book()
			{
				PublishedDate = new DateTime(2013, 1, 19),
				UniqueNumber = 222264,
				Title = "The Third Bullet",
				Author = "Stephen Hunter",
				Description = "The veteran sniper Bob Lee Swagger investigates the assassination of John F. Kennedy.",
				Price = 26.99m,
				InitialSellingPrice = 26.99m,
				Cost = 15.11m,
				InitialCost = 15.11m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b264.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller");
			Books.Add(b264);

			Book b265 = new Book()
			{
				PublishedDate = new DateTime(2013, 10, 19),
				UniqueNumber = 222265,
				Title = "The Last Dark",
				Author = "Stephen R Donaldson",
				Description = "The 10th and final installment of the sprawling fantasy series about Thomas Covenant the Unbeliever.",
				Price = 16m,
				InitialSellingPrice = 16m,
				Cost = 10.88m,
				InitialCost = 10.88m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b265.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b265);

			Book b266 = new Book()
			{
				PublishedDate = new DateTime(2008, 5, 24),
				UniqueNumber = 222266,
				Title = "The Host",
				Author = "Stephenie Meyer",
				Description = "Aliens have taken control of the minds and bodies of most humans, but one woman won’t surrender.",
				Price = 25.99m,
				InitialSellingPrice = 25.99m,
				Cost = 13.25m,
				InitialCost = 13.25m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b266.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
			Books.Add(b266);

			Book b267 = new Book()
			{
				PublishedDate = new DateTime(2011, 5, 21),
				UniqueNumber = 222267,
				Title = "The Jefferson Key",
				Author = "Steve Berry",
				Description = "The former government operative Cotton Malone foils an assassination attempt on the president and finds himself at dangerous odds with a secret society.",
				Price = 26m,
				InitialSellingPrice = 26m,
				Cost = 18.2m,
				InitialCost = 18.2m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b267.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b267);

			Book b268 = new Book()
			{
				PublishedDate = new DateTime(2016, 5, 21),
				UniqueNumber = 222268,
				Title = "The Second Life Of Nick Mason",
				Author = "Steve Hamilton",
				Description = "A deal with a fellow inmate, a crime boss, springs Nick Mason from prison, but he must become an assassin.",
				Price = 19.99m,
				InitialSellingPrice = 19.99m,
				Cost = 3.2m,
				InitialCost = 3.2m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 5,
				InitialInventory = 5,
				Discontinued = false,
			};
			b268.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b268);

			Book b269 = new Book()
			{
				PublishedDate = new DateTime(2010, 11, 27),
				UniqueNumber = 222269,
				Title = "An Object Of Beauty",
				Author = "Steve Martin",
				Description = "A young, beautiful and ambitious woman ruthlessly ascends the heights of the Manhattan art world.",
				Price = 26.99m,
				InitialSellingPrice = 26.99m,
				Cost = 8.91m,
				InitialCost = 8.91m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b269.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b269);

			Book b270 = new Book()
			{
				PublishedDate = new DateTime(2009, 7, 18),
				UniqueNumber = 222270,
				Title = "Guardian Of Lies",
				Author = "Steve Martini",
				Description = "The lawyer Paul Madriani unravels a mystery involving gold coins, the C.I.A., and a weapon forgotten since the Cuban missile crisis.",
				Price = 26.99m,
				InitialSellingPrice = 26.99m,
				Cost = 18.62m,
				InitialCost = 18.62m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b270.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b270);

			Book b271 = new Book()
			{
				PublishedDate = new DateTime(2013, 1, 12),
				UniqueNumber = 222271,
				Title = "Collateral Damage",
				Author = "Stuart Woods",
				Description = "Back in New York, the lawyer Stone Barrington joins his former partner Holly Barker in pursuing a dangerous case.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 19.4m,
				InitialCost = 19.4m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 15,
				InitialInventory = 15,
				Discontinued = false,
			};
			b271.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b271);

			Book b272 = new Book()
			{
				PublishedDate = new DateTime(2018, 6, 9),
				UniqueNumber = 222272,
				Title = "Turbulence",
				Author = "Stuart Woods",
				Description = "The 46th book in the Stone Barrington series.",
				Price = 15.95m,
				InitialSellingPrice = 15.95m,
				Cost = 6.06m,
				InitialCost = 6.06m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 13,
				InitialInventory = 13,
				Discontinued = false,
			};
			b272.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b272);

			Book b273 = new Book()
			{
				PublishedDate = new DateTime(2018, 1, 6),
				UniqueNumber = 222273,
				Title = "Unbound",
				Author = "Stuart Woods",
				Description = "The 44th book in the Stone Barrington series.",
				Price = 16m,
				InitialSellingPrice = 16m,
				Cost = 11.36m,
				InitialCost = 11.36m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b273.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b273);

			Book b274 = new Book()
			{
				PublishedDate = new DateTime(2013, 4, 13),
				UniqueNumber = 222274,
				Title = "Unintended Consequences",
				Author = "Stuart Woods",
				Description = "The New York lawyer Stone Barrington discovers a shadowy network beneath the world of European wealth.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 11.32m,
				InitialCost = 11.32m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b274.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b274);

			Book b275 = new Book()
			{
				PublishedDate = new DateTime(2012, 4, 21),
				UniqueNumber = 222275,
				Title = "Unnatural Acts",
				Author = "Stuart Woods",
				Description = "The New York lawyer Stone Barrington becomes involved in the family problems of a billionaire hedge fund manager.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 16.71m,
				InitialCost = 16.71m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b275.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b275);

			Book b276 = new Book()
			{
				PublishedDate = new DateTime(2013, 1, 12),
				UniqueNumber = 222276,
				Title = "Kinsey And Me",
				Author = "Sue Grafton",
				Description = "Stories about Grafton’s character Kinsey Millhone as well as explorations of Grafton’s own past.",
				Price = 27.95m,
				InitialSellingPrice = 27.95m,
				Cost = 25.43m,
				InitialCost = 25.43m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b276.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b276);

			Book b277 = new Book()
			{
				PublishedDate = new DateTime(2013, 9, 14),
				UniqueNumber = 222277,
				Title = "W Is For Wasted",
				Author = "Sue Grafton",
				Description = "A homeless man inexplicably leaves $600,000 to Kinsey Millhone.",
				Price = 16m,
				InitialSellingPrice = 16m,
				Cost = 7.04m,
				InitialCost = 7.04m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = true,
			};
			b277.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b277);

			Book b278 = new Book()
			{
				PublishedDate = new DateTime(2011, 1, 22),
				UniqueNumber = 222278,
				Title = "Call Me Irresistible",
				Author = "Susan Elizabeth Phillips",
				Description = "In a small town in Texas, characters from Phillips’s earlier novels reappear as a woman persuades a friend to call off her wedding to the town’s popular mayor.",
				Price = 25.99m,
				InitialSellingPrice = 25.99m,
				Cost = 11.44m,
				InitialCost = 11.44m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 4,
				InitialInventory = 4,
				Discontinued = false,
			};
			b278.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b278);

			Book b279 = new Book()
			{
				PublishedDate = new DateTime(2008, 8, 30),
				UniqueNumber = 222279,
				Title = "Just Breathe",
				Author = "Susan Wiggs",
				Description = "Her marriage broken, the author of a syndicated comic strip flees to California, where romance and surprise await.",
				Price = 25.95m,
				InitialSellingPrice = 25.95m,
				Cost = 5.45m,
				InitialCost = 5.45m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b279.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance");
			Books.Add(b279);

			Book b280 = new Book()
			{
				PublishedDate = new DateTime(2010, 1, 2),
				UniqueNumber = 222280,
				Title = "Deeper Than The Dead",
				Author = "Tami Hoag",
				Description = "An F.B.I. investigator and a teacher track a series of murders in California in 1985.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 9.7m,
				InitialCost = 9.7m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 9,
				InitialInventory = 9,
				Discontinued = false,
			};
			b280.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b280);

			Book b281 = new Book()
			{
				PublishedDate = new DateTime(2012, 7, 28),
				UniqueNumber = 222281,
				Title = "Broken Harbor",
				Author = "Tana French",
				Description = "In French’s fourth Dublin murder squad novel, a detective’s investigation of a crime in a seaside town evokes memories of his disturbing childhood there.",
				Price = 27.95m,
				InitialSellingPrice = 27.95m,
				Cost = 24.04m,
				InitialCost = 24.04m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 4,
				InitialInventory = 4,
				Discontinued = false,
			};
			b281.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b281);

			Book b282 = new Book()
			{
				PublishedDate = new DateTime(2018, 2, 10),
				UniqueNumber = 222282,
				Title = "An American Marriage",
				Author = "Tayari Jones",
				Description = "A newlywed couple's relationship is tested when the husband is sentenced to 12 years in prison.",
				Price = 22.95m,
				InitialSellingPrice = 22.95m,
				Cost = 12.16m,
				InitialCost = 12.16m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 11,
				InitialInventory = 11,
				Discontinued = false,
			};
			b282.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b282);

			Book b283 = new Book()
			{
				PublishedDate = new DateTime(2014, 4, 5),
				UniqueNumber = 222283,
				Title = "Warriors",
				Author = "Ted Bell",
				Description = "The counterspy Alex Hawke must rescue a kidnapped scientist.",
				Price = 33.99m,
				InitialSellingPrice = 33.99m,
				Cost = 5.44m,
				InitialCost = 5.44m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 12,
				InitialInventory = 12,
				Discontinued = false,
			};
			b283.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b283);

			Book b284 = new Book()
			{
				PublishedDate = new DateTime(2008, 8, 30),
				UniqueNumber = 222284,
				Title = "The Gypsy Morph",
				Author = "Terry Brooks",
				Description = "In the third volume of the Genesis of Shannara series, champions of the Word and the Void clash.",
				Price = 27m,
				InitialSellingPrice = 27m,
				Cost = 6.75m,
				InitialCost = 6.75m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b284.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b284);

			Book b285 = new Book()
			{
				PublishedDate = new DateTime(2011, 8, 27),
				UniqueNumber = 222285,
				Title = "The Measure Of The Magic",
				Author = "Terry Brooks",
				Description = "With the land on edge, Panterra is destined to confront a menace who seeks to claim the last black staff, and the life of the one who wields it.",
				Price = 27m,
				InitialSellingPrice = 27m,
				Cost = 15.39m,
				InitialCost = 15.39m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 7,
				InitialInventory = 7,
				Discontinued = false,
			};
			b285.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b285);

			Book b286 = new Book()
			{
				PublishedDate = new DateTime(2012, 8, 25),
				UniqueNumber = 222286,
				Title = "Wards Of Faerie",
				Author = "Terry Brooks",
				Description = "In the first book of a new fantasy series, the Dark Legacy of Shannara, Druids, Elves and humans unite to try to capture the Elfstones and rescue the troubled Four Lands.",
				Price = 28m,
				InitialSellingPrice = 28m,
				Cost = 4.2m,
				InitialCost = 4.2m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 1,
				Inventory = 5,
				InitialInventory = 5,
				Discontinued = false,
			};
			b286.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b286);

			Book b287 = new Book()
			{
				PublishedDate = new DateTime(2017, 1, 28),
				UniqueNumber = 222287,
				Title = "Death's Mistress",
				Author = "Terry Goodkind",
				Description = "The first book of a new series, the Nicci Chronicles, centers on a character from the Sword of Truth fantasy series.",
				Price = 20m,
				InitialSellingPrice = 20m,
				Cost = 12m,
				InitialCost = 12m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b287.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b287);

			Book b288 = new Book()
			{
				PublishedDate = new DateTime(2011, 8, 20),
				UniqueNumber = 222288,
				Title = "The Omen Machine",
				Author = "Terry Goodkind",
				Description = "A return to the lives of Richard Rahl and Kahlan Amnell, in a tale of a new threat to their world.",
				Price = 29.99m,
				InitialSellingPrice = 29.99m,
				Cost = 17.69m,
				InitialCost = 17.69m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 7,
				Inventory = 12,
				InitialInventory = 12,
				Discontinued = true,
			};
			b288.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b288);

			Book b289 = new Book()
			{
				PublishedDate = new DateTime(2009, 10, 10),
				UniqueNumber = 222289,
				Title = "The Unseen Academicals",
				Author = "Terry Pratchett",
				Description = "In this Discworld fantasy, the benevolent tyrant of Ankh-Morpork suggests that Unseen University put together a football team.",
				Price = 25.99m,
				InitialSellingPrice = 25.99m,
				Cost = 3.12m,
				InitialCost = 3.12m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 14,
				InitialInventory = 14,
				Discontinued = false,
			};
			b289.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy");
			Books.Add(b289);

			Book b290 = new Book()
			{
				PublishedDate = new DateTime(2017, 8, 19),
				UniqueNumber = 222290,
				Title = "I Know A Secret",
				Author = "Tess Gerritsen",
				Description = "Rizzoli and Isles investigate two separate homicides and uncover other dangerous mysteries.",
				Price = 32.95m,
				InitialSellingPrice = 32.95m,
				Cost = 26.36m,
				InitialCost = 26.36m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b290.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b290);

			Book b291 = new Book()
			{
				PublishedDate = new DateTime(2012, 9, 1),
				UniqueNumber = 222291,
				Title = "Last To Die",
				Author = "Tess Gerritsen",
				Description = "The detective Jane Rizzoli and the medical examiner Maura Isles protect a boy whose family and foster family have all been murdered.",
				Price = 27m,
				InitialSellingPrice = 27m,
				Cost = 9.99m,
				InitialCost = 9.99m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 5,
				Inventory = 6,
				InitialInventory = 6,
				Discontinued = false,
			};
			b291.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b291);

			Book b292 = new Book()
			{
				PublishedDate = new DateTime(2010, 12, 11),
				UniqueNumber = 222292,
				Title = "Dead Or Alive",
				Author = "Tom Clancy with Grant Blackwood",
				Description = "Many characters from Clancy’s previous novels make an appearance as an intelligence group tracks a vicious terrorist called the Emir.",
				Price = 28.95m,
				InitialSellingPrice = 28.95m,
				Cost = 24.03m,
				InitialCost = 24.03m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b292.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b292);

			Book b293 = new Book()
			{
				PublishedDate = new DateTime(2012, 12, 8),
				UniqueNumber = 222293,
				Title = "Threat Vector",
				Author = "Tom Clancy with Mark Greaney",
				Description = "As China threatens to invade Taiwan, the covert intelligence expert Jack Ryan Jr. aids his father’s administration — but his agency is no longer secret.",
				Price = 28.95m,
				InitialSellingPrice = 28.95m,
				Cost = 10.71m,
				InitialCost = 10.71m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 9,
				Inventory = 12,
				InitialInventory = 12,
				Discontinued = false,
			};
			b293.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b293);

			Book b294 = new Book()
			{
				PublishedDate = new DateTime(2008, 10, 25),
				UniqueNumber = 222294,
				Title = "Extreme Measures",
				Author = "Vince Flynn",
				Description = "Mitch Rapp teams up with a C.I.A. colleague to fight a terrorist cell — and the politicians who would rein them in.",
				Price = 27.95m,
				InitialSellingPrice = 27.95m,
				Cost = 15.09m,
				InitialCost = 15.09m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 2,
				Inventory = 4,
				InitialInventory = 4,
				Discontinued = false,
			};
			b294.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b294);

			Book b295 = new Book()
			{
				PublishedDate = new DateTime(2009, 10, 17),
				UniqueNumber = 222295,
				Title = "Pursuit Of Honor",
				Author = "Vince Flynn",
				Description = "The counterterrorism operative Mitch Rapp must teach politicians about national security following a new Qaeda attack.",
				Price = 27.99m,
				InitialSellingPrice = 27.99m,
				Cost = 5.04m,
				InitialCost = 5.04m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 4,
				InitialInventory = 4,
				Discontinued = false,
			};
			b295.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b295);

			Book b296 = new Book()
			{
				PublishedDate = new DateTime(2009, 11, 14),
				UniqueNumber = 222296,
				Title = "Wishin' And Hopin'",
				Author = "Wally Lamb",
				Description = "A fifth-grader in 1964 gets ready for Christmas.",
				Price = 15m,
				InitialSellingPrice = 15m,
				Cost = 13.95m,
				InitialCost = 13.95m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 3,
				Inventory = 3,
				InitialInventory = 3,
				Discontinued = false,
			};
			b296.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Humor");
			Books.Add(b296);

			Book b297 = new Book()
			{
				PublishedDate = new DateTime(2011, 5, 14),
				UniqueNumber = 222297,
				Title = "Those In Peril",
				Author = "Wilbur Smith",
				Description = "A private security agent battles pirates who have kidnapped a woman from a yacht in the Indian Ocean.",
				Price = 27.99m,
				InitialSellingPrice = 27.99m,
				Cost = 16.23m,
				InitialCost = 16.23m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 8,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b297.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Suspense");
			Books.Add(b297);

			Book b298 = new Book()
			{
				PublishedDate = new DateTime(2017, 8, 26),
				UniqueNumber = 222298,
				Title = "Sulfur Springs",
				Author = "William Kent Krueger",
				Description = "A newly married couple search for the wife's missing son, which leads them to a border town in the middle of a drug war.",
				Price = 32.95m,
				InitialSellingPrice = 32.95m,
				Cost = 17.79m,
				InitialCost = 17.79m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 10,
				Inventory = 15,
				InitialInventory = 15,
				Discontinued = false,
			};
			b298.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery");
			Books.Add(b298);

			Book b299 = new Book()
			{
				PublishedDate = new DateTime(2015, 9, 19),
				UniqueNumber = 222299,
				Title = "One Year After",
				Author = "William R Forstchen",
				Description = "A New Regime imposes tyranny in the aftermath of a nuclear attack.",
				Price = 23.95m,
				InitialSellingPrice = 23.95m,
				Cost = 3.59m,
				InitialCost = 3.59m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 6,
				Inventory = 10,
				InitialInventory = 10,
				Discontinued = false,
			};
			b299.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction");
			Books.Add(b299);

			Book b300 = new Book()
			{
				PublishedDate = new DateTime(2016, 6, 11),
				UniqueNumber = 222300,
				Title = "Homegoing",
				Author = "Yaa Gyasi",
				Description = "This Ghanaian-American writer’s first novel traces the lives in West Africa and America of seven generations of the descendants of two half sisters.",
				Price = 26.95m,
				InitialSellingPrice = 26.95m,
				Cost = 2.7m,
				InitialCost = 2.7m,
				LastOrdered = new DateTime(2018, 10, 1),
				ReplenishMinimum = 4,
				Inventory = 8,
				InitialInventory = 8,
				Discontinued = false,
			};
			b300.Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Contemporary Fiction");
			Books.Add(b300);

			try
			{
				foreach (Book bookToAdd in Books)
				{
					strBookTitle = bookToAdd.Title;
					Book dbBook = db.Books.FirstOrDefault(b => b.Title == bookToAdd.Title);
					if (dbBook == null)
					{
						db.Books.Add(bookToAdd);
						db.SaveChanges();
						intBooksAdded += 1;
					}
					else
					{
						dbBook.Title = bookToAdd.Title;
						dbBook.Author = bookToAdd.Author;
						dbBook.PublishedDate = bookToAdd.PublishedDate;
						dbBook.Description = bookToAdd.Description;
						dbBook.Price = bookToAdd.Price;
						dbBook.InitialSellingPrice = bookToAdd.InitialSellingPrice;
						dbBook.Cost = bookToAdd.Cost;
						dbBook.InitialCost = bookToAdd.InitialCost;
						dbBook.LastOrdered = bookToAdd.LastOrdered;
						dbBook.ReplenishMinimum = bookToAdd.ReplenishMinimum;
						dbBook.Inventory = bookToAdd.Inventory;
						dbBook.InitialInventory = bookToAdd.InitialInventory;
						dbBook.Discontinued = bookToAdd.Discontinued;
						dbBook.Genre = bookToAdd.Genre;
						db.Update(dbBook);
						db.SaveChanges();
						intBooksAdded += 1;
					}
				}
			}
			catch (Exception ex)
			{
				String msg = "Repositories added:" + intBooksAdded + "; Error on " + strBookTitle;
				throw new InvalidOperationException(ex.Message + msg);
			}
		}
	}
}


