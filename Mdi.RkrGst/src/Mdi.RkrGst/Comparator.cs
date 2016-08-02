using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mdi.RkrGst.Model;

namespace Mdi.RkrGst
{
  public class Comparator
  {
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
      if (this.pattern.Combined != this.text.Combined)
      {
        throw new InvalidOperationException("Combined flag on pattern and text objects must be identical");
      }

      this.mml = minimumMatchLengh;
      this.pattern = pattern;
      this.text = text;
    }

    public void Compare()
    {
      // TODO
    }
  }
}
