using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mdi.RkrGst.Model;

namespace Mdi.RkrGst.Collections
{
  public class Matches : List<Match>
  {
    public void AddMatch(int startText, int startPattern, int length)
    {
      this.AddMatch(new Match(startText, startPattern, length));
    }

    public void AddMatch(Match match)
    {
      // check overlap in first element
      if (this.Any(m =>
        Math.Max(m.TextPosition + m.Length, match.TextPosition + m.Length) - Math.Min(m.TextPosition, match.TextPosition) < (m.Length + match.Length)
      ))
      {
        return;
      }

      // check overlap in second element
      if (this.Any(m =>
        Math.Max(m.PatternPosition + m.Length, match.PatternPosition + m.Length) - Math.Min(m.PatternPosition, match.PatternPosition) < (m.Length + match.Length)
      ))
      {
        return;
      }

      base.Add(match);
    }
  }
}
