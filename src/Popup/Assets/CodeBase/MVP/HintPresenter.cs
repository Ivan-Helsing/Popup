using System.Collections;
using UnityEngine;

namespace CodeBase.MVP
{
  public class HintPresenter : MonoBehaviour
  {
    public bool isHintVisible = false;
    
    public void Show(GameObject hint)
    {
      hint.GetComponent<HintPanel>().HintAlpha = 0;
      isHintVisible = true;
      StartCoroutine(ShowAnimation(hint));
    }

    private IEnumerator ShowAnimation(GameObject hint)
    {
      while (hint.GetComponent<HintPanel>().HintAlpha < 1)
      {
        hint.GetComponent<HintPanel>().HintAlpha += 0.03f;
        yield return new WaitForSeconds(0.03f);
      }

      StartCoroutine(HideAnimation(hint));
    }
    
    private IEnumerator HideAnimation(GameObject hint)
    {
      yield return new WaitForSeconds(3f);
      
      while (hint.GetComponent<HintPanel>().HintAlpha > 0)
      {
        hint.GetComponent<HintPanel>().HintAlpha -= 0.03f;
        yield return new WaitForSeconds(0.07f);
      }
      isHintVisible = false;
    }

  }
}