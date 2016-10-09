using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mdi.RkrGst.Model
{
  public class Token
  {
    public Token(int value, TokenState state)
    {
      this.Value = value;
      this.State = state;
      this.Hash = -1;
      this.Marked = false;
    }

    public TokenState State { get; private set; }
    public int Value { get; private set; }
    public int Hash { get; set; }
    public bool Marked { get; set; }
  }
}
