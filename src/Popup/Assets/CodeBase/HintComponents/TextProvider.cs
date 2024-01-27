using TMPro;
using UnityEngine;

namespace CodeBase.HintComponents
{
  public class TextProvider : MonoBehaviour
  {
    public TMP_Text TextField()
    {
      TMP_Text text = GetComponent<TMP_Text>();
      
      if (text == null)
        text = GetComponentInChildren<TMP_Text>();
      
      return text;
    }
  }
}