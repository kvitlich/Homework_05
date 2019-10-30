using System;
using System.Collections.Generic;
using System.Text;

namespace GameRatings.Domain
{
  public class Rating : Entity
  {
    public int Grade {get;set;  }
    public User User { get; set; }

    public Game Game { get; set; }
  }

}
