using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mdi.RkrGst.Model;

namespace Mdi.RkrGst.Collections
{
  public class Matches : List<Match>
  {
    public void AddMatch(int startA, int startB, int length)
    {
      this.AddMatch(new Match(startA, startB, length));
    }

    public void AddMatch(Match match)
    {
      // check overlap in first element
      if (this.Any(m =>
        Math.Max(m.FirstPosition + m.Length, match.FirstPosition + m.Length) - Math.Min(m.FirstPosition, match.FirstPosition) < (m.Length + match.Length)
      ))
      {
        return;
      }

      // check overlap in second element
      if (this.Any(m =>
        Math.Max(m.SecondPosition + m.Length, match.SecondPosition + m.Length) - Math.Min(m.SecondPosition, match.SecondPosition) < (m.Length + match.Length)
      ))
      {
        return;
      }

      base.Add(match);
    }
  }
}
