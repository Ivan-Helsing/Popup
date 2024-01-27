using System.Collections.Generic;
using CodeBase.HintComponents;
using CodeBase.Services;
using UnityEngine;

namespace CodeBase.MVP
{
  public class HintModel : MonoBehaviour
  {
    public Camera MainCamera;
    private IAssetProvider _assets;
    private UIFactory _factory;

    private void Start()
    {
      _assets = new AssetProvider();
      _factory = new UIFactory(_assets);
    }

    private void Update()
    {
      if (Input.GetMouseButtonDown(0))
      {
        Ray ray = MainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
          if (hit.collider.GetComponent<HintPresenter>() != null)
          {
            HintPresenter presenter = hit.collider.GetComponent<HintPresenter>();
            if(presenter.isHintVisible)
              return;

            List<GameObject> hintList = presenter.GetComponent<StaticData>().HintList;

            var hint = _factory.CreateHint(hintList, presenter.transform);

            presenter.Show(hint);
          }
        }
      }
    }

  }
}