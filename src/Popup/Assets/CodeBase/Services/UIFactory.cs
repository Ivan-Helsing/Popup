using System.Collections.Generic;
using CodeBase.Extensions;
using UnityEngine;

namespace CodeBase.Services
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
      var hint = Object.Instantiate(_assets.HintContainer(), transform);
      int elementsInHint = 0;

      items.RemoveRedundantListElements();

      for(int i = 0; i < items.Count; i++)
      {
        var gameObject = items[i];
        Object.Instantiate(gameObject, hint.GetComponentInChildren<Container>().ContainerTransform);
        elementsInHint += 1;
      }

      SetHintSize(hint, elementsInHint);

      return hint;
    }

    private void SetHintSize(GameObject parent, int hintSizeX)
    {
      var hintSize = parent.GetComponent<RectTransform>().sizeDelta;

      parent.GetComponent<RectTransform>().sizeDelta = new Vector2(
        hintSizeX, 
        hintSize.y);
    }
  }
}