using UnityEngine;

namespace CodeBase.MVP
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