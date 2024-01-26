using System.Collections.Generic;
using UnityEngine;

namespace CodeBase
{
  public class SetSelfSize : MonoBehaviour
  {
    public void SetSize(List<GameObject> objects)
    {
      GetComponent<RectTransform>().sizeDelta = 
        new Vector2(objects.Count, GetComponent<RectTransform>().sizeDelta.y);
    }
  }
}