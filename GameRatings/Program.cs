using GameRatings.Domain;
using System;

namespace GameRatings
{
  class Program
  {
    static void Main(string[] args)
    {
      using (ContextGameRatingsDb db = new ContextGameRatingsDb("Server=KVITLICH;Database=GameRatingDb;Trusted_Connection=true;"))
      {
        var first_game = new Game { Name = "FarCry", Discription = "RPG" };
        var second_game = new Game { Name = "Warcraft 3: The Frozen Throne", Discription = "Strategy, kotaoraya shedevr" };


        var first_user = new User { Nickname = "Silvana" };


        var first_rating = new Rating { Grade = 2, Game = first_game, User = first_user };
        var second_rating = new Rating { Grade = 5, Game = second_game, User = first_user };


        db.Games.Add(first_game);
        db.Games.Add(second_game);

        db.Users.Add(first_user);

        db.Ratings.Add(first_rating);
        db.Ratings.Add(second_rating);

        db.SaveChanges();
      }
      using (ContextGameRatingsDb db = new ContextGameRatingsDb("Server=KVITLICH;Database=GameRatingDb;Trusted_Connection=true;"))
      {
        var ratings = db.Ratings;
        foreach (var rating in ratings)
        {
         
            Console.WriteLine($"Name: {rating.Game.Name} | Disc: {rating.Game.Discription} | Rating: {rating.Grade}");

        }
        Console.Read();
      }
    }
  }
}
