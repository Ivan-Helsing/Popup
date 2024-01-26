using System.Collections.Generic;
using UnityEngine;

namespace CodeBase
{
  public class Popup : MonoBehaviour
  {
    public GameObject popupRoot;
    public List<GameObject> objects = new();
    
    public void CreatePopup()
    {
      UIFactory uiFactory = new UIFactory();
      uiFactory.CreatePopup(objects, popupRoot, gameObject.transform);
    }
  }
}