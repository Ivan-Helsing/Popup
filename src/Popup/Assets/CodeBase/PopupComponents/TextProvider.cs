using TMPro;
using UnityEngine;

namespace CodeBase.PopupComponents
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