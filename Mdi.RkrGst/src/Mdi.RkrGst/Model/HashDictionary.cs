using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mdi.RkrGst.Model
{
  public class HashDictionary
  {
    private Dictionary<int, List<int>> dictionary;

    public HashDictionary()
    {
      this.dictionary = new Dictionary<int, List<int>>();
    }

    public void Add(int key, int value)
    {
      if (dictionary.ContainsKey(key))
      {
        dictionary[key].Add(value);
      }
      else
      {
        dictionary.Add(key, new List<int> { value });
      }
    }
  }
}
