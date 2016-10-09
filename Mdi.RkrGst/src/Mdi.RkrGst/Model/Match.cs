using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mdi.RkrGst.Model
{
  public class Match
  {
    internal Match(int starText, int startPattern, int length)
    {
      this.TextPosition = starText;
      this.PatternPosition = startPattern;
      this.Length = length;
    }

    public int TextPosition { get; private set; }
    public int PatternPosition { get; private set; }
    public int Length { get; private set; }

    public void Swap()
    {
      var tmp = this.TextPosition;
      this.TextPosition = this.PatternPosition;
      this.PatternPosition = tmp;
    }
  }
}
