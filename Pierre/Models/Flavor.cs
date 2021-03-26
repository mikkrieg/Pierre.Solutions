using System.Collections.Generic;

namespace Pierre.Models
{
  public class Flavor
  {
    public Flavor()
    {
      JoinEntities = new HashSet<FlavorTreat>();
    }

    public int FlavorId { get; set; }
    public string Name { get; set; }
    public string FlavorProfile { get; set; }
    public virtual ApplicationUser User { get; set; }

    public virtual ICollection<FlavorTreat> JoinEntities { get; set; }
  }

  public enum Profile
  {
    Sweet,
    Salty,
    Bitter,
    Tangy,
    Sour,
    Spicy
  }
}