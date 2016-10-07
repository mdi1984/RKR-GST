using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mdi.RkrGst.Model;

namespace Mdi.RkrGst.Test
{
  public class SimpleSubmission : ISubmission
  {
    private List<Token> tokens;

    public SimpleSubmission(int[] tokens)
    {
      this.tokens = tokens.Select(t => new Token(t, TokenState.Valid)).ToList();
      var last = this.tokens.Last();
      this.tokens.RemoveAt(tokens.Length - 1);
      this.tokens.Add(new Token(last.Value, TokenState.EndOfSubmission));
    }

    public Token this[int index]
    {
      get
      {
        return this.tokens[index];
      }
    }

    public bool Combined
    {
      get { return true; }
    }

    public int Size
    {
      get { return this.tokens.Count; }
    }

    public HashDictionary CreateHashes(int hashLength)
    {
      throw new NotImplementedException();
    }
  }
}
