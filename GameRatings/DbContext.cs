using GameRatings.Domain;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameRatings
{
  public class ContextGameRatingsDb : DbContext
  {
   
    public ContextGameRatingsDb(string connString) 
    {
      ConnectionString = connString;
      Database.EnsureCreated();
    }

    public virtual DbSet<Game> Games { get; set; } 
    public virtual DbSet<Rating> Ratings { get; set; }
    public virtual DbSet<User> Users { get; set; }

    public string ConnectionString { get; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(ConnectionString);
    }
  }
}
