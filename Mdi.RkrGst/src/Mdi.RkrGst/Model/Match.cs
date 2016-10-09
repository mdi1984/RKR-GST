using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mdi.RkrGst.Model
{
  public class Match
  {
    internal Match(int startA, int startB, int length)
    {
      this.FirstPosition = startA;
      this.SecondPosition = startB;
      this.Length = length;
    }

    public int FirstPosition { get; private set; }
    public int SecondPosition { get; private set; }
    public int Length { get; private set; }
  }
}
