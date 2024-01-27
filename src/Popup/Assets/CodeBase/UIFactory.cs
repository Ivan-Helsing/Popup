using System.Collections.Generic;
using UnityEngine;

namespace CodeBase
{
  public class UIFactory
  {
    private readonly IAssetProvider _assets;

    public UIFactory(IAssetProvider assets)
    {
      _assets = assets;
    }

    public GameObject CreateHint(List<GameObject> items, Transform transform)
    {
      var parent = Object.Instantiate(_assets.HintContainer(), transform);
      int elementsInHint = 0;
      
      foreach (var gameObject in items)
      {
        Object.Instantiate(gameObject, parent.GetComponentInChildren<Container>().ContainerTransform);
        elementsInHint++;
      }
      
      SetHintSize(parent, elementsInHint);
      
      return parent;
    }

    private void SetHintSize(GameObject parent, int hintSizeX)
    {
      var hintSize = parent.GetComponent<HintPanel>().GetComponent<RectTransform>().sizeDelta;
      
      hintSize = new Vector2(hintSizeX, hintSize.y);
    }
  }
}