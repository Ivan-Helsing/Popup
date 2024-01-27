using UnityEngine;

namespace CodeBase
{
  public class HintPanel : MonoBehaviour
  {
    public float HintAlpha
    {
      get => GetComponent<CanvasGroup>().alpha;
      set => GetComponent<CanvasGroup>().alpha = value;
    }
  }
}