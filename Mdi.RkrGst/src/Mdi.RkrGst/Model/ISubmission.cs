using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mdi.RkrGst.Model
{
  public interface ISubmission
  {
    bool Combined { get; }
    Token this[int index] { get; }
    int Size { get; }
    HashDictionary CreateHashes(int hashLength);
  }
}
