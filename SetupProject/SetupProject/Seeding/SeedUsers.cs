using SetupProject.DAL;
using SetupProject.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SetupProject.Utilities;
namespace SetupProject.Seeding
{
	public static class SeedUsers
	{
		public async static Task<IdentityResult> SeedAllUsers(UserManager<AppUser> userManager, AppDbContext context)
		{
			//Add the list of AppUsers
			List<AddUserModel> AllUsers = new List<AddUserModel>();
			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Todd",
					LastName = "Jacobs",
					UserName = "jacobs@bevosbooks.com",
					Email = "jacobs@bevosbooks.com",
					Address = "48764 Howard Forge Apt. 421",
					Zip = "19763",
					PhoneNumber = "8176663948",
					Birthday = new DateTime(1978, 1, 29),
					State = "PA",
					City = "Vanessaside",
				},
				Password = "tj2245",
				RoleName = "Employee",
				
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Eryn",
					LastName = "Rice",
					UserName = "rice@bevosbooks.com",
					Email = "rice@bevosbooks.com",
					Address = "15781 Hamilton Ridge Apt. 877",
					Zip = "12726",
					PhoneNumber = "2148545987",
					Birthday = new DateTime(2003, 6, 11),
					State = "AL",
					City = "Bryanside",
				},
				Password = "ricearoni",
				RoleName = "Employee",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "John",
					LastName = "Ingram",
					UserName = "ingram@bevosbooks.com",
					Email = "ingram@bevosbooks.com",
					Address = "097 Sanchez Islands Apt. 393",
					Zip = "59217",
					PhoneNumber = "5127049017",
					Birthday = new DateTime(1980, 6, 25),
					State = "ND",
					City = "Port Tammy",
				},
				Password = "ingram68",
				RoleName = "Employee",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Paul",
					LastName = "Martinez",
					UserName = "martinez@bevosbooks.com",
					Email = "martinez@bevosbooks.com",
					Address = "58714 Mann Plaza",
					Zip = "72227",
					PhoneNumber = "2105859369",
					Birthday = new DateTime(1969, 6, 25),
					State = "PA",
					City = "Lisaside",
				},
				Password = "party1",
				RoleName = "Employee",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Jared",
					LastName = "Tanner",
					UserName = "tanner@bevosbooks.com",
					Email = "tanner@bevosbooks.com",
					Address = "1965 Kelly Field Apt. 094",
					Zip = "05565",
					PhoneNumber = "5129527803",
					Birthday = new DateTime(1979, 6, 2),
					State = "FL",
					City = "Jonesberg",
				},
				Password = "sandman",
				RoleName = "Employee",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Lauren",
					LastName = "Chung",
					UserName = "chung@bevosbooks.com",
					Email = "chung@bevosbooks.com",
					Address = "868 Boyd Freeway",
					Zip = "36573",
					PhoneNumber = "2107053952",
					Birthday = new DateTime(1976, 3, 24),
					State = "OR",
					City = "Lake Brittany",
				},
				Password = "listen",
				RoleName = "Employee",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Wandavison",
					LastName = "Loter",
					UserName = "loter@bevosbooks.com",
					Email = "loter@bevosbooks.com",
					Address = "5159 Tom Roads Suite 330",
					Zip = "22846",
					PhoneNumber = "5124650249",
					Birthday = new DateTime(1966, 9, 23),
					State = "WY",
					City = "Davebury",
				},
				Password = "pottery",
				RoleName = "Employee",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Heather",
					LastName = "Morales",
					UserName = "morales@bevosbooks.com",
					Email = "morales@bevosbooks.com",
					Address = "0123 Lisa Roads Apt. 013",
					Zip = "03336",
					PhoneNumber = "8177529019",
					Birthday = new DateTime(1971, 1, 16),
					State = "PA",
					City = "South Christopherville",
				},
				Password = "heckin",
				RoleName = "Employee",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Martin",
					LastName = "Rankin",
					UserName = "rankin@bevosbooks.com",
					Email = "rankin@bevosbooks.com",
					Address = "17300 Oliver Village",
					Zip = "46414",
					PhoneNumber = "5122997370",
					Birthday = new DateTime(1961, 5, 16),
					State = "ME",
					City = "Chadland",
				},
				Password = "rankmark",
				RoleName = "Employee",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Garth",
					LastName = "Gonzalez",
					UserName = "gonzalez@bevosbooks.com",
					Email = "gonzalez@bevosbooks.com",
					Address = "08709 Holly Lock Apt. 457",
					Zip = "89132",
					PhoneNumber = "2142415970",
					Birthday = new DateTime(1993, 12, 10),
					State = "AR",
					City = "Lake Emily",
				},
				Password = "gg2017",
				RoleName = "Employee",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Albert",
					LastName = "Taylor",
					UserName = "taylor@bevosbooks.com",
					Email = "taylor@bevosbooks.com",
					Address = "8419 Wade Bridge",
					Zip = "41322",
					PhoneNumber = "2149036025",
					Birthday = new DateTime(1954, 8, 14),
					State = "NY",
					City = "Maldonadoshire",
				},
				Password = "TRY563",
				RoleName = "Admin",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Molly",
					LastName = "Sheffield",
					UserName = "sheffield@bevosbooks.com",
					Email = "sheffield@bevosbooks.com",
					Address = "4280 Harmon Isle Apt. 842",
					Zip = "38233",
					PhoneNumber = "5124749225",
					Birthday = new DateTime(1986, 8, 27),
					State = "RI",
					City = "Port Stephanie",
				},
				Password = "longsnores",
				RoleName = "Admin",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Jenny",
					LastName = "MacLeod",
					UserName = "macleod@bevosbooks.com",
					Email = "macleod@bevosbooks.com",
					Address = "924 Goodman Village Apt. 093",
					Zip = "50131",
					PhoneNumber = "5124723769",
					Birthday = new DateTime(1984, 12, 5),
					State = "NV",
					City = "Ernestbury",
				},
				Password = "kittys",
				RoleName = "Admin",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Michelle",
					LastName = "Rhodes",
					UserName = "rhodes@bevosbooks.com",
					Email = "rhodes@bevosbooks.com",
					Address = "69602 Brown Squares Apt. 787",
					Zip = "07035",
					PhoneNumber = "2102520380",
					Birthday = new DateTime(1972, 7, 2),
					State = "NH",
					City = "North Troyport",
				},
				Password = "puppies",
				RoleName = "Admin",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Evan",
					LastName = "Stuart",
					UserName = "stuart@bevosbooks.com",
					Email = "stuart@bevosbooks.com",
					Address = "81206 Stewart Forest Apt. 089",
					Zip = "37198",
					PhoneNumber = "2105415031",
					Birthday = new DateTime(1984, 4, 17),
					State = "ME",
					City = "East Davidborough",
				},
				Password = "coolboi",
				RoleName = "Admin",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Ron",
					LastName = "Swanson",
					UserName = "swanson@bevosbooks.com",
					Email = "swanson@bevosbooks.com",
					Address = "76104 Marsh Crescent",
					Zip = "85034",
					PhoneNumber = "5124818542",
					Birthday = new DateTime(1991, 7, 25),
					State = "SD",
					City = "Dennishaven",
				},
				Password = "swanbong",
				RoleName = "Admin",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Jabriel",
					LastName = "White",
					UserName = "white@bevosbooks.com",
					Email = "white@bevosbooks.com",
					Address = "24000 Erin Point Suite 590",
					Zip = "49318",
					PhoneNumber = "8175025605",
					Birthday = new DateTime(1986, 3, 17),
					State = "NE",
					City = "Josephmouth",
				},
				Password = "456789",
				RoleName = "Admin",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Washington",
					LastName = "Montgomery",
					UserName = "montgomery@bevosbooks.com",
					Email = "montgomery@bevosbooks.com",
					Address = "69402 Joseph Junction",
					Zip = "05175",
					PhoneNumber = "8178817122",
					Birthday = new DateTime(1961, 5, 4),
					State = "RI",
					City = "Jennifermouth",
				},
				Password = "python4",
				RoleName = "Admin",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Lisa",
					LastName = "Walker",
					UserName = "walker@bevosbooks.com",
					Email = "walker@bevosbooks.com",
					Address = "2294 Foster Plaza",
					Zip = "06826",
					PhoneNumber = "2143196301",
					Birthday = new DateTime(2003, 4, 18),
					State = "IA",
					City = "West Danny",
				},
				Password = "walkameter",
				RoleName = "Admin",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Gregory",
					LastName = "Chang",
					UserName = "chang@bevosbooks.com",
					Email = "chang@bevosbooks.com",
					Address = "81465 Perry Courts Suite 755",
					Zip = "40072",
					PhoneNumber = "2103521329",
					Birthday = new DateTime(1958, 4, 26),
					State = "AZ",
					City = "South Darrenfort",
				},
				Password = "pupgang",
				RoleName = "Admin",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Derek",
					LastName = "Dreibrodt",
					UserName = "derek@bevosbooks.com",
					Email = "derek@bevosbooks.com",
					Address = "229 Drake Route Apt. 113",
					Zip = "73439",
					PhoneNumber = "5125556789",
					Birthday = new DateTime(2001, 1, 1),
					State = "MO",
					City = "North Paul",
				},
				Password = "2cool4u",
				RoleName = "Admin",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Amy",
					LastName = "Rester",
					UserName = "rester@bevosbooks.com",
					Email = "rester@bevosbooks.com",
					Address = "7936 Micheal Green Apt. 635",
					Zip = "59694",
					PhoneNumber = "2103521329",
					Birthday = new DateTime(2000, 1, 1),
					State = "NC",
					City = "North Lynntown",
				},
				Password = "KIzGreat",
				RoleName = "Admin",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Christopher",
					LastName = "Baker",
					UserName = "cbaker@freezing.co.uk",
					Email = "cbaker@freezing.co.uk",
					Address = "76430 Cindy Cove",
					Zip = "14230",
					PhoneNumber = "5125595133",
					Birthday = new DateTime(1968, 11, 28),
					State = "FL",
					City = "South Nicholas",
				},
				Password = "hellothere",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Michelle",
					LastName = "Bradicus",
					UserName = "mb@puppy.com",
					Email = "mb@puppy.com",
					Address = "96687 Bass Parks Apt. 893",
					Zip = "05149",
					PhoneNumber = "2102702860",
					Birthday = new DateTime(1988, 2, 7),
					State = "MD",
					City = "West Janicemouth",
				},
				Password = "555533",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Franco",
					LastName = "Broccoli",
					UserName = "fd@puppy.com",
					Email = "fd@puppy.com",
					Address = "9269 Robbins Valley",
					Zip = "09198",
					PhoneNumber = "8175683686",
					Birthday = new DateTime(1999, 11, 7),
					State = "AZ",
					City = "Jonesland",
				},
				Password = "666645",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Wendy",
					LastName = "Charile",
					UserName = "wendy@puppy.com",
					Email = "wendy@puppy.com",
					Address = "04075 Lauren Ways",
					Zip = "66355",
					PhoneNumber = "5125967209",
					Birthday = new DateTime(1992, 10, 27),
					State = "NC",
					City = "Schmitthaven",
				},
				Password = "Kansas",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Lim",
					LastName = "Chou",
					UserName = "limchou@puppy.com",
					Email = "limchou@puppy.com",
					Address = "189 Julie Throughway",
					Zip = "63705",
					PhoneNumber = "2107748586",
					Birthday = new DateTime(1961, 11, 11),
					State = "MT",
					City = "West Amanda",
				},
				Password = "Rockwall",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Shan",
					LastName = "Dave",
					UserName = "444444.Dave@aool.com",
					Email = "444444.Dave@aool.com",
					Address = "930 Joy Hollow Suite 517",
					Zip = "50853",
					PhoneNumber = "2142667242",
					Birthday = new DateTime(1972, 12, 19),
					State = "MT",
					City = "Sherriport",
				},
				Password = "444444",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Lou Ann",
					LastName = "Feeley",
					UserName = "louann@puppy.com",
					Email = "louann@puppy.com",
					Address = "22345 Sheri Orchard Suite 279",
					Zip = "80687",
					PhoneNumber = "8172580736",
					Birthday = new DateTime(1958, 8, 1),
					State = "AZ",
					City = "Lake Hollystad",
				},
				Password = "longhorns",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Tesa",
					LastName = "Freeley",
					UserName = "tfreeley@puppy.com",
					Email = "tfreeley@puppy.com",
					Address = "7017 Andrew Rapid Apt. 518",
					Zip = "80470",
					PhoneNumber = "8173279674",
					Birthday = new DateTime(2001, 7, 12),
					State = "AR",
					City = "Jamesfort",
				},
				Password = "puppies",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Margaret",
					LastName = "Garcia",
					UserName = "mgar@puppy.com",
					Email = "mgar@puppy.com",
					Address = "519 Kramer Crossroad Suite 418",
					Zip = "99672",
					PhoneNumber = "8176617531",
					Birthday = new DateTime(1956, 11, 17),
					State = "MN",
					City = "North Kimberly",
				},
				Password = "horses",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Charles",
					LastName = "Harley",
					UserName = "chaley@thug.com",
					Email = "chaley@thug.com",
					Address = "5100 Scott Burg",
					Zip = "66353",
					PhoneNumber = "2148499570",
					Birthday = new DateTime(1998, 5, 29),
					State = "SC",
					City = "East Clayton",
				},
				Password = "mycats",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Jeffrey",
					LastName = "Stark",
					UserName = "jeff@puppy.com",
					Email = "jeff@puppy.com",
					Address = "412 Snow Manors Apt. 161",
					Zip = "57004",
					PhoneNumber = "5127002600",
					Birthday = new DateTime(1974, 5, 2),
					State = "NV",
					City = "South Kimtown",
				},
				Password = "jeffery",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "John",
					LastName = "Hearn",
					UserName = "wjhearniii@umch.edu",
					Email = "wjhearniii@umch.edu",
					Address = "75415 David Square Apt. 552",
					Zip = "19282",
					PhoneNumber = "2148989608",
					Birthday = new DateTime(1983, 12, 29),
					State = "PA",
					City = "Port Terristad",
				},
				Password = "posicles",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Mark",
					LastName = "Hicks",
					UserName = "hicks43@puppy.com",
					Email = "hicks43@puppy.com",
					Address = "31045 Sarah Fort",
					Zip = "93231",
					PhoneNumber = "2105812952",
					Birthday = new DateTime(1989, 12, 16),
					State = "MI",
					City = "East Shawn",
				},
				Password = "guac45",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Brad",
					LastName = "Ingram",
					UserName = "bradsingram@mall.utexas.edu",
					Email = "bradsingram@mall.utexas.edu",
					Address = "03557 Phillips Wells Suite 291",
					Zip = "16915",
					PhoneNumber = "5124702808",
					Birthday = new DateTime(1958, 9, 18),
					State = "FL",
					City = "New Beverlyburgh",
				},
				Password = "father",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Todd",
					LastName = "Jacobs",
					UserName = "father.Ingram@aool.com",
					Email = "father.Ingram@aool.com",
					Address = "8332 Watson Shore",
					Zip = "92535",
					PhoneNumber = "5124677352",
					Birthday = new DateTime(1975, 12, 9),
					State = "CA",
					City = "Port Davidtown",
				},
				Password = "555897",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Victoria",
					LastName = "Lawrence",
					UserName = "victoria@puppy.com",
					Email = "victoria@puppy.com",
					Address = "64862 Evans Knoll",
					Zip = "08084",
					PhoneNumber = "5129481386",
					Birthday = new DateTime(1981, 5, 29),
					State = "NC",
					City = "East Seanstad",
				},
				Password = "something",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Brad",
					LastName = "Lineback",
					UserName = "lineback@flush.net",
					Email = "lineback@flush.net",
					Address = "0657 Nathan Mountains Apt. 214",
					Zip = "58980",
					PhoneNumber = "2102473963",
					Birthday = new DateTime(1973, 5, 19),
					State = "UT",
					City = "New Catherineberg",
				},
				Password = "treelover",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Evan",
					LastName = "Lowe",
					UserName = "elowe@netscrape.net",
					Email = "elowe@netscrape.net",
					Address = "66237 Giles Divide Suite 717",
					Zip = "81599",
					PhoneNumber = "2105368614",
					Birthday = new DateTime(1993, 6, 7),
					State = "NV",
					City = "West Aaron",
				},
				Password = "headear",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Chuck",
					LastName = "Luce",
					UserName = "luce_chuck@puppy.com",
					Email = "luce_chuck@puppy.com",
					Address = "34148 Roger Terrace Suite 173",
					Zip = "88121",
					PhoneNumber = "2107007535",
					Birthday = new DateTime(1995, 6, 11),
					State = "KY",
					City = "Ramireztown",
				},
				Password = "gooseyloosey",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Jennifer",
					LastName = "MacLeod",
					UserName = "mackcloud@pimpdaddy.com",
					Email = "mackcloud@pimpdaddy.com",
					Address = "46896 Garcia Glen",
					Zip = "05147",
					PhoneNumber = "5124772125",
					Birthday = new DateTime(1965, 10, 11),
					State = "CO",
					City = "Justinborough",
				},
				Password = "rainyday",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Elizabeth",
					LastName = "Markham",
					UserName = "liz@puppy.com",
					Email = "liz@puppy.com",
					Address = "4851 Pamela Track",
					Zip = "68636",
					PhoneNumber = "5124603832",
					Birthday = new DateTime(1989, 6, 18),
					State = "LA",
					City = "North Robert",
				},
				Password = "ember22",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Clarence",
					LastName = "Martin",
					UserName = "mclarence@puppy.com",
					Email = "mclarence@puppy.com",
					Address = "838 Robert Roads",
					Zip = "49234",
					PhoneNumber = "8174979188",
					Birthday = new DateTime(1984, 4, 28),
					State = "NV",
					City = "Figueroaview",
				},
				Password = "lamemartin",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Gregory",
					LastName = "Martinez",
					UserName = "lamemartin.Martin@aool.com",
					Email = "lamemartin.Martin@aool.com",
					Address = "11669 Taylor Skyway",
					Zip = "29076",
					PhoneNumber = "8178770705",
					Birthday = new DateTime(1981, 12, 27),
					State = "MT",
					City = "Michaelfort",
				},
				Password = "gregory",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Charles",
					LastName = "Miller",
					UserName = "cmiller@mapster.com",
					Email = "cmiller@mapster.com",
					Address = "8570 Evans Summit Suite 093",
					Zip = "09211",
					PhoneNumber = "8177482602",
					Birthday = new DateTime(1987, 5, 5),
					State = "NC",
					City = "West Thomastown",
				},
				Password = "mucky44",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Kelly",
					LastName = "Nelson",
					UserName = "nelson.Kelly@puppy.com",
					Email = "nelson.Kelly@puppy.com",
					Address = "605 Darren Alley",
					Zip = "18940",
					PhoneNumber = "5122950953",
					Birthday = new DateTime(1969, 8, 3),
					State = "IN",
					City = "Morganport",
				},
				Password = "Tree34",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Joe",
					LastName = "Nguyen",
					UserName = "jojoe@puppy.com",
					Email = "jojoe@puppy.com",
					Address = "16756 Mark Rue Suite 272",
					Zip = "51471",
					PhoneNumber = "2143149884",
					Birthday = new DateTime(1956, 2, 6),
					State = "MI",
					City = "Davidburgh",
				},
				Password = "jvb485bg",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Bill",
					LastName = "O'Reilly",
					UserName = "orielly@foxnets.com",
					Email = "orielly@foxnets.com",
					Address = "6337 Brenda Causeway Suite 031",
					Zip = "23225",
					PhoneNumber = "2103474912",
					Birthday = new DateTime(1989, 3, 14),
					State = "TX",
					City = "West Brian",
				},
				Password = "Bobbygirl",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Anka",
					LastName = "Radkovich",
					UserName = "or@puppy.com",
					Email = "or@puppy.com",
					Address = "491 Wise Knoll",
					Zip = "72221",
					PhoneNumber = "2142369553",
					Birthday = new DateTime(1952, 10, 26),
					State = "SD",
					City = "Ellishaven",
				},
				Password = "radioactive",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Megan",
					LastName = "Rhodes",
					UserName = "megrhodes@freezing.co.uk",
					Email = "megrhodes@freezing.co.uk",
					Address = "774 Lewis Grove Apt. 002",
					Zip = "56566",
					PhoneNumber = "5123768733",
					Birthday = new DateTime(1958, 3, 18),
					State = "CA",
					City = "Adamtown",
				},
				Password = "gopigs",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Eryn",
					LastName = "Rice",
					UserName = "erynrice@puppy.com",
					Email = "erynrice@puppy.com",
					Address = "683 Lee Rest",
					Zip = "60236",
					PhoneNumber = "5123900644",
					Birthday = new DateTime(2000, 11, 2),
					State = "ND",
					City = "New Nicolemouth",
				},
				Password = "iloveme",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Jorge",
					LastName = "Rodriguez",
					UserName = "jorge@hootmail.com",
					Email = "jorge@hootmail.com",
					Address = "0803 Miller Ways Suite 334",
					Zip = "45581",
					PhoneNumber = "8178928361",
					Birthday = new DateTime(1979, 1, 1),
					State = "NJ",
					City = "Larryfurt",
				},
				Password = "565656",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Allen",
					LastName = "Rogers",
					UserName = "ra@aoo.com",
					Email = "ra@aoo.com",
					Address = "48107 Hardy Causeway",
					Zip = "11722",
					PhoneNumber = "5128776930",
					Birthday = new DateTime(2000, 3, 12),
					State = "DE",
					City = "Wernermouth",
				},
				Password = "treeman",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Olivier",
					LastName = "Saint-Jean",
					UserName = "o_st-jean@home.com",
					Email = "o_st-jean@home.com",
					Address = "12637 Lisa Points",
					Zip = "29343",
					PhoneNumber = "2104169665",
					Birthday = new DateTime(1997, 5, 1),
					State = "NM",
					City = "Williamsburgh",
				},
				Password = "55htrq",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Sarah",
					LastName = "Saunders",
					UserName = "ss34@puppy.com",
					Email = "ss34@puppy.com",
					Address = "5561 Bishop Turnpike",
					Zip = "79756",
					PhoneNumber = "5123521797",
					Birthday = new DateTime(1994, 5, 31),
					State = "NY",
					City = "Lake Kenneth",
				},
				Password = "leaves",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "William",
					LastName = "Sewell",
					UserName = "willsheff@email.com",
					Email = "willsheff@email.com",
					Address = "443 David Tunnel Apt. 263",
					Zip = "97746",
					PhoneNumber = "5124534071",
					Birthday = new DateTime(1951, 12, 10),
					State = "AL",
					City = "West Nichole",
				},
				Password = "borbj44",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Martin",
					LastName = "Sheffield",
					UserName = "sheff44@puppy.com",
					Email = "sheff44@puppy.com",
					Address = "16419 Hall Stravenue Suite 331",
					Zip = "63450",
					PhoneNumber = "5125503154",
					Birthday = new DateTime(1993, 7, 2),
					State = "SC",
					City = "Emilybury",
				},
				Password = "ldiul485",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "John",
					LastName = "Smith",
					UserName = "johnsmith187@puppy.com",
					Email = "johnsmith187@puppy.com",
					Address = "220 Richardson Roads Apt. 262",
					Zip = "27567",
					PhoneNumber = "2108345875",
					Birthday = new DateTime(1985, 6, 13),
					State = "WV",
					City = "New Vickie",
				},
				Password = "kribv75",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Dustin",
					LastName = "Stroud",
					UserName = "dustroud@mail.com",
					Email = "dustroud@mail.com",
					Address = "332 Kathleen Knoll Apt. 719",
					Zip = "02157",
					PhoneNumber = "2142370654",
					Birthday = new DateTime(1974, 7, 14),
					State = "ME",
					City = "New Caitlinfort",
				},
				Password = "klavjkb48",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Eric",
					LastName = "Stuart",
					UserName = "eric_stuart@puppy.com",
					Email = "eric_stuart@puppy.com",
					Address = "277 Padilla Common",
					Zip = "41974",
					PhoneNumber = "5128202322",
					Birthday = new DateTime(1968, 6, 17),
					State = "ID",
					City = "Derrickfurt",
				},
				Password = "vkb451",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Peter",
					LastName = "Stump",
					UserName = "peterstump@hootmail.com",
					Email = "peterstump@hootmail.com",
					Address = "0305 Matthew Mill Apt. 452",
					Zip = "96486",
					PhoneNumber = "8174584890",
					Birthday = new DateTime(2001, 7, 23),
					State = "AR",
					City = "Andreshire",
				},
				Password = "kdsiu4",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Jeremy",
					LastName = "Tanner",
					UserName = "tanner@puppy.com",
					Email = "tanner@puppy.com",
					Address = "0700 Brady Fork",
					Zip = "55898",
					PhoneNumber = "8174614916",
					Birthday = new DateTime(1973, 12, 28),
					State = "TN",
					City = "Carlton",
				},
				Password = "klrfbj45",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Allison",
					LastName = "Taylor",
					UserName = "taylordjay@puppy.com",
					Email = "taylordjay@puppy.com",
					Address = "76254 Debra Stream",
					Zip = "70454",
					PhoneNumber = "5124772439",
					Birthday = new DateTime(1999, 9, 30),
					State = "KS",
					City = "Reyeschester",
				},
				Password = "lraggrhb854",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Rachel",
					LastName = "Taylor",
					UserName = "lraggrhb854.Taylor@aool.com",
					Email = "lraggrhb854.Taylor@aool.com",
					Address = "91662 Vincent Road Apt. 153",
					Zip = "97862",
					PhoneNumber = "5124536618",
					Birthday = new DateTime(1956, 2, 24),
					State = "GA",
					City = "East Sonya",
				},
				Password = "alsuib95",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Frank",
					LastName = "Tee",
					UserName = "tee_frank@hootmail.com",
					Email = "tee_frank@hootmail.com",
					Address = "169 Christine Mount",
					Zip = "97234",
					PhoneNumber = "8178789530",
					Birthday = new DateTime(1964, 11, 11),
					State = "MA",
					City = "New Carolyn",
				},
				Password = "kd1734",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Clent",
					LastName = "Tucker",
					UserName = "tuck33@puppy.com",
					Email = "tuck33@puppy.com",
					Address = "07154 Stephen Parkways Suite 265",
					Zip = "70013",
					PhoneNumber = "2148495141",
					Birthday = new DateTime(1990, 6, 25),
					State = "ME",
					City = "Lindafurt",
				},
				Password = "kjdb983",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Allen",
					LastName = "Velasco",
					UserName = "avelasco@puppy.com",
					Email = "avelasco@puppy.com",
					Address = "708 Villa Camp Suite 616",
					Zip = "04993",
					PhoneNumber = "2144009625",
					Birthday = new DateTime(1966, 12, 13),
					State = "WA",
					City = "Tylertown",
				},
				Password = "odrb02",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Jake",
					LastName = "West",
					UserName = "westj@pioneer.net",
					Email = "westj@pioneer.net",
					Address = "943 Hughes Village Suite 319",
					Zip = "94883",
					PhoneNumber = "2148499231",
					Birthday = new DateTime(1968, 2, 6),
					State = "TX",
					City = "Lindabury",
				},
				Password = "kndl847",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Louis",
					LastName = "Winthorpe",
					UserName = "louielouie@puppy.com",
					Email = "louielouie@puppy.com",
					Address = "25090 Stephanie Lake Suite 457",
					Zip = "18950",
					PhoneNumber = "2145674085",
					Birthday = new DateTime(1961, 7, 23),
					State = "WY",
					City = "Burkeburgh",
				},
				Password = "lb2394",
				RoleName = "Customer",
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					FirstName = "Reagan",
					LastName = "Wood",
					UserName = "rwood@voyager.net",
					Email = "rwood@voyager.net",
					Address = "2507 Burgess Field",
					Zip = "69907",
					PhoneNumber = "5124569229",
					Birthday = new DateTime(1988, 10, 24),
					State = "HI",
					City = "New Sharonview",
				},
				Password = "drai494",
				RoleName = "Customer",
			});
			String errorFlag = "Start";
			IdentityResult result = new IdentityResult();
			try
			{
				foreach (AddUserModel aum in AllUsers)
				{
					errorFlag = aum.User.Email;
					result = await Utilities.AddUser.AddUserWithRoleAsync(aum, userManager, context);
				}
			}
			catch (Exception ex)
			{
				throw new Exception("There was a problem adding the user with email: "
					+ errorFlag, ex);
			}
			return result;
		}
	}
}
