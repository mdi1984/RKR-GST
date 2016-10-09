using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mdi.RkrGst.Collections;
using Mdi.RkrGst.Model;

namespace Mdi.RkrGst
{
  public class Comparator
  {
    private bool patternAndTextInverted;
    private int mml;
    private ISubmission pattern;
    private ISubmission text;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="minimumMatchLengh">maximal-matches and tiles below this length are ignored.</param>
    /// <param name="pattern"></param>
    /// <param name="text"></param>
    public Comparator(int minimumMatchLengh, ISubmission pattern, ISubmission text)
    {
      if (pattern.Combined != text.Combined)
      {
        throw new InvalidOperationException("Combined flag on pattern and text objects must be identical");
      }

      if (pattern.Size < this.mml || text.Size < this.mml)
      {
        throw new InvalidOperationException("pattern and text size must both be greater than minimumMatchLength");
      }

      if (pattern.Size >= text.Size)
      {
        this.patternAndTextInverted = true;
        this.pattern = text;
        this.text = pattern;
      }
      else
      {
        this.pattern = pattern;
        this.text = text;
      }

      this.mml = minimumMatchLengh;
    }

    public Matches Compare()
    {
      this.text.Reset();
      this.pattern.Reset();
      this.text.CreateHashes(this.mml, false);
      this.pattern.CreateHashes(this.mml, true);
      var tiles = new Matches();
      var maxMatch = this.mml;

      do
      {
        maxMatch = this.mml;
        var matches = new Matches();

        for (int iT = 0; iT < this.text.Size - maxMatch; iT++)
        {
          var patternPositions = this.pattern.Hashes[this.text[iT].Hash];
          if (this.text[iT].Marked || patternPositions == null)
          {
            continue;
          }

          foreach (var patternPos in patternPositions)
          {
            var y = patternPos;
            // if pattern position is already marked or remaining size is smaller than current maxMatch, continue
            if (this.pattern[y].Marked || maxMatch > this.pattern.Size - patternPos)
            {
              continue;
            }

            // compare values
            var j = 0;
            while (!this.text[iT + j].Marked && !this.pattern[y + j].Marked && this.text[iT + j].Value.Equals(this.pattern[y + j].Value))
            {
              j++;
              if (iT + j >= text.Size || y + j >= pattern.Size)
              {
                break;
              }
            }

            if (j == maxMatch)
            {
              matches.AddMatch(iT, y, j);
            }
            else if (j > maxMatch)
            {
              matches.Clear();
              matches.AddMatch(iT, y, j);
              maxMatch = j;
            }
          }
        }

        // mark the matches found in this iteration 
        foreach (var match in matches)
        {
          for (var a = 0; a < maxMatch - 1; a++)
          {
            text[match.FirstPosition + a].Marked = true;
            pattern[match.SecondPosition + a].Marked = true;
          }

          tiles.Add(match);
        }

      } while (maxMatch != mml);

      return tiles;
    }
  }
}
