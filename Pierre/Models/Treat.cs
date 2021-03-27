using System.Collections.Generic;

namespace Pierre.Models
{
  public class Treat
  {
    public Treat()
    {
      JoinEntities = new HashSet<FlavorTreat>();
    }

    public int TreatId { get; set; }
    public string Name { get; set; }
    public int Amount { get; set; }
    public virtual ApplicationUser User { get; set; }

    public virtual ICollection<FlavorTreat>JoinEntities { get; set; }
  }
}