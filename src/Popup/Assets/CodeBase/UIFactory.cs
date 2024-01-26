using System.Collections.Generic;
using UnityEngine;

namespace CodeBase
{
  public class UIFactory
  {
    public void CreatePopup(List<GameObject> items, GameObject popup, Transform transform)
    {
      var parent = Object.Instantiate(popup, transform);
      
      foreach (var gameObject in items)
      {
        Object.Instantiate(gameObject, parent.GetComponentInChildren<Container>().ContainerTransform());
      }
      parent.GetComponent<SetSelfSize>().SetSize(items);
    }
  }
}