using UnityEngine;

namespace CodeBase.PopupComponents
{
  public class LookAtCamera : MonoBehaviour
  {
    private Camera _mainCamera;

    void Start() => 
      _mainCamera = Camera.main;

    void Update()
    {
      Quaternion rotation = _mainCamera.transform.rotation;
      transform.LookAt(transform.position + rotation * Vector3.forward, rotation * Vector3.up);
    }
  }
}