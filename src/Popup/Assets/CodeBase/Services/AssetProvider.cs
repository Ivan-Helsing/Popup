using UnityEngine;

namespace CodeBase.Services
{
  public class AssetProvider : IAssetProvider
  {
    private const string HintContainerPath = "UI/Hint";

    public GameObject HintContainer() => Load(HintContainerPath);

    private GameObject Load(string path) => Resources.Load<GameObject>(path);
  }
}