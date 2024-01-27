using UnityEngine;
using UnityEngine.UIElements;

namespace CodeBase.PopupComponents
{
  public class SpriteProvider : MonoBehaviour
  {
    public Sprite ImageSprite()
    {
      Sprite sprite = GetComponent<Image>().sprite;
      
      if (sprite == null)
        sprite = GetComponentInChildren<Image>().sprite;

      return sprite;
    }
  }
}