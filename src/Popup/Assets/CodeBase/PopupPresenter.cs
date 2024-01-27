using UnityEngine;

namespace CodeBase
{
  public class PopupPresenter : MonoBehaviour
  {
    public GameObject popupRoot;
    public Camera MainCamera;

    private void Update()
    {
      if (Input.GetMouseButtonDown(0))
      {
        Ray ray = MainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
          if (hit.collider.GetComponent<PopupPresenter>() != null)
          {
            
          }
        }
      }
    }
  }
}