using System.Collections;
using System.Collections.Generic;
using CodeBase.Services;
using UnityEngine;

namespace CodeBase.MVP
{
  public class HintPresenter : MonoBehaviour
  {
    private UIFactory _factory;

    private void Start()
    {
      List<GameObject> hintsList = GetComponent<StaticData>().HintList;
      
      var hint = _factory.CreateHint(hintsList, gameObject.transform);

      StartCoroutine(Show(hint));
    }

    public void Construct(UIFactory factory)
    {
      _factory = factory;
    }

    private IEnumerator Show(GameObject hint)
    {
      CanvasGroup hintPanel = hint.GetComponent<HintView>().HintCanvas;
      hintPanel.alpha = 0;

      yield return new WaitForSeconds(2f);
      
      StartCoroutine(ShowAnimation(hint));
    }

    private IEnumerator ShowAnimation(GameObject hint)
    {
      CanvasGroup hintPanel = hint.GetComponent<HintView>().HintCanvas;
      
      while (hintPanel.alpha < 1)
      {
        hintPanel.alpha += 0.03f;
        yield return new WaitForSeconds(0.03f);
      }

      StartCoroutine(HideAnimation(hint));
    }
    
    private IEnumerator HideAnimation(GameObject hint)
    {
      yield return new WaitForSeconds(3f);

      CanvasGroup hintPanel = hint.GetComponent<HintView>().HintCanvas;
      
      while (hintPanel.alpha > 0)
      {
        hintPanel.alpha -= 0.03f;
        yield return new WaitForSeconds(0.07f);
      }
      
      DestroyPanel(hint);
    }

    private void DestroyPanel(GameObject hint) => 
      Destroy(hint);
  }
}