using System.Collections.Generic;
using UnityEngine;

namespace CodeBase.Extensions
{
  public static class Extensions
  {
    public static void RemoveRedundantListElements(this List<GameObject> list)
    {
      if(list.Count <= 3) 
        return;
      
      int startIndex = 2;
      int redundant = list.Count - startIndex;
      
      list.RemoveRange(startIndex, redundant);
    }
  }
}