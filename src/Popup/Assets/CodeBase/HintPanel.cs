using UnityEngine;

namespace CodeBase
{
  public class HintPanel : MonoBehaviour
  {
    public float Alpha() => 
      GetComponent<CanvasGroup>().alpha;
  }
}