using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mdi.RkrGst.Collections;
using Mdi.RkrGst.Model;

namespace Mdi.RkrGst.Model
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

    public HashDictionary Hashes { get; set; }

    public void CreateHashes(int hashLength, bool makeTable)
    {
      if (this.Hashes != null)
      {
        return;
      }

      this.Hashes = new HashDictionary();
      var buffer = new RingBuffer<int>(hashLength);
      for (int i = 0; i < tokens.Count; i++)
      {
        var token = tokens[i];

        if (token.State == TokenState.EndOfFile)
        {
          buffer.Clear();
          continue;
        }

        buffer.Add(token.Value);

        if (buffer.Count == buffer.Capacity)
        {
          var hash = buffer.GetHashCode();
          if (makeTable)
          {
            this.Hashes.Add(hash, i - hashLength + 1);
          }

          tokens[i - hashLength + 1].Hash = hash;
        }
      }
    }

    public void Reset()
    {
      foreach(var token in this.tokens)
      {
        token.Marked = false;
      }
    }
  }
}
