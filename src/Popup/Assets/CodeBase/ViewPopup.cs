using UnityEngine;

namespace CodeBase
{
  public class ViewPopup : MonoBehaviour
  {
    private void Update()
    {
      if (Input.GetMouseButtonDown(0))
      {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
          if (hit.collider.GetComponent<Popup>() != null)
          {
            Popup popup = hit.collider.GetComponent<Popup>();
            popup.CreatePopup();
          }
        }
      }
    }
  }
}