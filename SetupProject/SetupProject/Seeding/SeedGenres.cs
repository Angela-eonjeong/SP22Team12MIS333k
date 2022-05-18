using SetupProject.DAL;
using SetupProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetupProject.Seeding
{
	public static class SeedGenres
	{
		public static void SeedAllGenres(AppDbContext db)
		{
			//Add the list of Genres
			List<Genre> AllGenres = new List<Genre>();

					AllGenres.Add(new Genre {GenreName = "Mystery"});
					AllGenres.Add(new Genre {GenreName = "Historical Fiction"});
					AllGenres.Add(new Genre {GenreName = "Romance"});
					AllGenres.Add(new Genre {GenreName = "Thriller"});
					AllGenres.Add(new Genre {GenreName = "Science Fiction"});
					AllGenres.Add(new Genre {GenreName = "Contemporary Fiction"});
					AllGenres.Add(new Genre {GenreName = "Poetry"});
					AllGenres.Add(new Genre {GenreName = "Suspense"});
					AllGenres.Add(new Genre {GenreName = "Adventure"});
					AllGenres.Add(new Genre {GenreName = "Fantasy"});
					AllGenres.Add(new Genre {GenreName = "Horror"});
					AllGenres.Add(new Genre {GenreName = "Humor"});
					AllGenres.Add(new Genre {GenreName = "Shakespeare"});

					int intGenreID = 0;
					string strGenreName = "Start";
			try
			{
				foreach (Genre seedGenre in AllGenres)
				{
					intGenreID = seedGenre.GenreID;
					strGenreName = seedGenre.GenreName;

					Genre dbGenre = db.Genres.FirstOrDefault(b => b.GenreName == seedGenre.GenreName);
					
					if (dbGenre == null)
					{
						db.Genres.Add(seedGenre);
						db.SaveChanges();
					}
				}
			}
			catch (Exception ex)
			{
				StringBuilder msg = new StringBuilder();
				msg.Append("There was an error adding the ");
				msg.Append(strGenreName);
				msg.Append(" genre (GenreID = ");
				msg.Append(intGenreID);
				msg.Append(")");
				throw new Exception(msg.ToString(), ex);
			}
		}
	}
}
