using SetupProject.DAL;
using SetupProject.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SetupProject.Seeding
{
	public static class SeedReviews
	{
		public static void SeedAllReviews(AppDbContext db)
		{
			Int32 intReviewsAdded = 0;
			String strDescription = "Begin";
			//Add the list of Reviews
			List<Review> Reviews = new List<Review>();
				Review b1 = new Review()
				{
					Rating = 4,
					Description = "This book was aight",
					ApprovalStatus = ApprovalStatus.Yes,
				};
				b1.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222072);
				b1.Author = db.Users.FirstOrDefault(g => g.UserName == "peterstump@hootmail.com");
				Reviews.Add(b1);

				Review b2 = new Review()
				{
					Rating = 5,
					Description = "I have reached enlightenment after reading this book",
					ApprovalStatus = ApprovalStatus.Yes,
				};
				b2.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222125);
				b2.Author = db.Users.FirstOrDefault(g => g.UserName == "jeff@puppy.com");
				Reviews.Add(b2);

				Review b3 = new Review()
				{
					Rating = 2,
					Description = "Not very good",
					ApprovalStatus = ApprovalStatus.Pending,
				};
				b3.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222072);
				b3.Author = db.Users.FirstOrDefault(g => g.UserName == "mgar@puppy.com");
				Reviews.Add(b3);

				Review b4 = new Review()
				{
					Rating = 3,
					Description = "Good read but wasn't the biggest fan",
					ApprovalStatus = ApprovalStatus.No,
				};
				b4.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222125);
				b4.Author = db.Users.FirstOrDefault(g => g.UserName == "tfreeley@puppy.com");
				Reviews.Add(b4);

				Review b5 = new Review()
				{
					Rating = 4,
					Description = "Pretty solid read, didn't think I would be a fan but it was good!",
					ApprovalStatus = ApprovalStatus.Yes,
				};
				b5.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222019);
				b5.Author = db.Users.FirstOrDefault(g => g.UserName == "avelasco@puppy.com");
				Reviews.Add(b5);

				Review b6 = new Review()
				{
					Rating = 1,
					Description = "This book is so bad that it could qualify as an Avengers-level threat",
					ApprovalStatus = ApprovalStatus.Pending,
				};
				b6.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222125);
				b6.Author = db.Users.FirstOrDefault(g => g.UserName == "fd@puppy.com");
				Reviews.Add(b6);

				Review b7 = new Review()
				{
					Rating = 2,
					Description = "No Description",
					ApprovalStatus = ApprovalStatus.No,
				};
				b7.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222248);
				b7.Author = db.Users.FirstOrDefault(g => g.UserName == "444444.Dave@aool.com");
				Reviews.Add(b7);

				Review b8 = new Review()
				{
					Rating = 2,
					Description = "No Description",
					ApprovalStatus = ApprovalStatus.Yes,
				};
				b8.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222019);
				b8.Author = db.Users.FirstOrDefault(g => g.UserName == "nelson.Kelly@puppy.com");
				Reviews.Add(b8);

				Review b9 = new Review()
				{
					Rating = 4,
					Description = "No Description",
					ApprovalStatus = ApprovalStatus.Yes,
				};
				b9.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222248);
				b9.Author = db.Users.FirstOrDefault(g => g.UserName == "limchou@puppy.com");
				Reviews.Add(b9);

				Review b10 = new Review()
				{
					Rating = 4,
					Description = "No Description",
					ApprovalStatus = ApprovalStatus.No,
				};
				b10.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222125);
				b10.Author = db.Users.FirstOrDefault(g => g.UserName == "mclarence@puppy.com");
				Reviews.Add(b10);

				Review b11 = new Review()
				{
					Rating = 1,
					Description = "The book was better used as a fire starter",
					ApprovalStatus = ApprovalStatus.Pending,
				};
				b11.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222218);
				b11.Author = db.Users.FirstOrDefault(g => g.UserName == "megrhodes@freezing.co.uk");
				Reviews.Add(b11);

				Review b12 = new Review()
				{
					Rating = 3,
					Description = "No Description",
					ApprovalStatus = ApprovalStatus.Pending,
				};
				b12.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222143);
				b12.Author = db.Users.FirstOrDefault(g => g.UserName == "jojoe@puppy.com");
				Reviews.Add(b12);

				Review b13 = new Review()
				{
					Rating = 2,
					Description = "No Description",
					ApprovalStatus = ApprovalStatus.Yes,
				};
				b13.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222143);
				b13.Author = db.Users.FirstOrDefault(g => g.UserName == "erynrice@puppy.com");
				Reviews.Add(b13);

				Review b14 = new Review()
				{
					Rating = 2,
					Description = "Yikes...",
					ApprovalStatus = ApprovalStatus.No,
				};
				b14.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222072);
				b14.Author = db.Users.FirstOrDefault(g => g.UserName == "luce_chuck@puppy.com");
				Reviews.Add(b14);

				Review b15 = new Review()
				{
					Rating = 3,
					Description = "No Description",
					ApprovalStatus = ApprovalStatus.Yes,
				};
				b15.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222061);
				b15.Author = db.Users.FirstOrDefault(g => g.UserName == "louielouie@puppy.com");
				Reviews.Add(b15);

				Review b16 = new Review()
				{
					Rating = 4,
					Description = "No Description",
					ApprovalStatus = ApprovalStatus.No,
				};
				b16.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222218);
				b16.Author = db.Users.FirstOrDefault(g => g.UserName == "eric_stuart@puppy.com");
				Reviews.Add(b16);

				Review b17 = new Review()
				{
					Rating = 5,
					Description = "No Description",
					ApprovalStatus = ApprovalStatus.Yes,
				};
				b17.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222218);
				b17.Author = db.Users.FirstOrDefault(g => g.UserName == "victoria@puppy.com");
				Reviews.Add(b17);

				Review b18 = new Review()
				{
					Rating = 5,
					Description = "Book was amazing! Hands down one of the best books I've ever read",
					ApprovalStatus = ApprovalStatus.Yes,
				};
				b18.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222143);
				b18.Author = db.Users.FirstOrDefault(g => g.UserName == "louann@puppy.com");
				Reviews.Add(b18);

				Review b19 = new Review()
				{
					Rating = 1,
					Description = "The publisher must have been blind to allow this book to be published",
					ApprovalStatus = ApprovalStatus.Yes,
				};
				b19.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222143);
				b19.Author = db.Users.FirstOrDefault(g => g.UserName == "elowe@netscrape.net");
				Reviews.Add(b19);

				Review b20 = new Review()
				{
					Rating = 2,
					Description = "No Description",
					ApprovalStatus = ApprovalStatus.No,
				};
				b20.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222125);
				b20.Author = db.Users.FirstOrDefault(g => g.UserName == "taylordjay@puppy.com");
				Reviews.Add(b20);

				Review b21 = new Review()
				{
					Rating = 3,
					Description = "No Description",
					ApprovalStatus = ApprovalStatus.No,
				};
				b21.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222218);
				b21.Author = db.Users.FirstOrDefault(g => g.UserName == "tee_frank@hootmail.com");
				Reviews.Add(b21);

				Review b22 = new Review()
				{
					Rating = 5,
					Description = "No Description",
					ApprovalStatus = ApprovalStatus.No,
				};
				b22.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222143);
				b22.Author = db.Users.FirstOrDefault(g => g.UserName == "orielly@foxnets.com");
				Reviews.Add(b22);

				Review b23 = new Review()
				{
					Rating = 3,
					Description = "No Description",
					ApprovalStatus = ApprovalStatus.Yes,
				};
				b23.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222143);
				b23.Author = db.Users.FirstOrDefault(g => g.UserName == "bradsingram@mall.utexas.edu");
				Reviews.Add(b23);

				Review b24 = new Review()
				{
					Rating = 1,
					Description = "No Description",
					ApprovalStatus = ApprovalStatus.Yes,
				};
				b24.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222125);
				b24.Author = db.Users.FirstOrDefault(g => g.UserName == "liz@puppy.com");
				Reviews.Add(b24);

				Review b25 = new Review()
				{
					Rating = 3,
					Description = "This book is the definition of mid",
					ApprovalStatus = ApprovalStatus.Yes,
				};
				b25.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222061);
				b25.Author = db.Users.FirstOrDefault(g => g.UserName == "tanner@puppy.com");
				Reviews.Add(b25);

				Review b26 = new Review()
				{
					Rating = 2,
					Description = "No Description",
					ApprovalStatus = ApprovalStatus.No,
				};
				b26.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222125);
				b26.Author = db.Users.FirstOrDefault(g => g.UserName == "lraggrhb854.Taylor@aool.com");
				Reviews.Add(b26);

				Review b27 = new Review()
				{
					Rating = 1,
					Description = "No Description",
					ApprovalStatus = ApprovalStatus.No,
				};
				b27.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222248);
				b27.Author = db.Users.FirstOrDefault(g => g.UserName == "o_st-jean@home.com");
				Reviews.Add(b27);

				Review b28 = new Review()
				{
					Rating = 3,
					Description = "No Description",
					ApprovalStatus = ApprovalStatus.Pending,
				};
				b28.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222072);
				b28.Author = db.Users.FirstOrDefault(g => g.UserName == "sheff44@puppy.com");
				Reviews.Add(b28);

				Review b29 = new Review()
				{
					Rating = 3,
					Description = "No Description",
					ApprovalStatus = ApprovalStatus.No,
				};
				b29.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222125);
				b29.Author = db.Users.FirstOrDefault(g => g.UserName == "chaley@thug.com");
				Reviews.Add(b29);

				Review b30 = new Review()
				{
					Rating = 5,
					Description = "This book could probably save my marriage",
					ApprovalStatus = ApprovalStatus.Yes,
				};
				b30.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222248);
				b30.Author = db.Users.FirstOrDefault(g => g.UserName == "wjhearniii@umch.edu");
				Reviews.Add(b30);

				Review b31 = new Review()
				{
					Rating = 2,
					Description = "No Description",
					ApprovalStatus = ApprovalStatus.Yes,
				};
				b31.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222218);
				b31.Author = db.Users.FirstOrDefault(g => g.UserName == "cbaker@freezing.co.uk");
				Reviews.Add(b31);

				Review b32 = new Review()
				{
					Rating = 3,
					Description = "No Description",
					ApprovalStatus = ApprovalStatus.Pending,
				};
				b32.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222218);
				b32.Author = db.Users.FirstOrDefault(g => g.UserName == "johnsmith187@puppy.com");
				Reviews.Add(b32);

				Review b33 = new Review()
				{
					Rating = 4,
					Description = "No Description",
					ApprovalStatus = ApprovalStatus.Yes,
				};
				b33.Book = db.Books.FirstOrDefault(g => g.UniqueNumber ==222248);
				b33.Author = db.Users.FirstOrDefault(g => g.UserName == "father.Ingram@aool.com");
				Reviews.Add(b33);

			try
			{
				foreach (Review ReviewToAdd in Reviews)
				{
					strDescription = ReviewToAdd.Description;
					Review dbReview = db.Reviews.FirstOrDefault(b => b.Description == ReviewToAdd.Description);
					if (dbReview == null)
					{
						db.Reviews.Add(ReviewToAdd);
						db.SaveChanges();
						intReviewsAdded += 1;
					}
					else
					{
						dbReview.Book = ReviewToAdd.Book;
						dbReview.Rating = ReviewToAdd.Rating;
						dbReview.Author = ReviewToAdd.Author;
						dbReview.ApprovalStatus = ReviewToAdd.ApprovalStatus;
						dbReview.Description = ReviewToAdd.Description;
						db.Update(dbReview);
						db.SaveChanges();
						intReviewsAdded += 1;
					}
				}
			}
			catch (Exception ex)
			{
				String msg = "Repositories added:"+ intReviewsAdded +"; Error on "+ strDescription;
				throw new InvalidOperationException(ex.Message + msg);
			}
		}
	}
}
