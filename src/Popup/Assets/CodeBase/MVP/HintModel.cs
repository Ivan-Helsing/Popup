using CodeBase.Services;
using UnityEngine;

namespace CodeBase.MVP
{
  public class HintModel : MonoBehaviour
  {
    private IAssetProvider _assets;
    private UIFactory _factory;

    private void Awake()
    {
      _assets = new AssetProvider();
      _factory = new UIFactory(_assets);

      ShareDependency(_factory);
    }

    private void ShareDependency(UIFactory factory)
    {
      HintPresenter[] presenters = FindObjectsOfType<HintPresenter>();
      
      foreach (HintPresenter presenter in presenters) 
        presenter.Construct(factory);
    }
  }
}