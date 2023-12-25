using UnityEngine;

public class ScreenBase : MonoBehaviour, IScreen
{
    // [SerializeField]
    public string ScreenName { get; private set; }

    public virtual void Show(System.Action onShowComplete = null)
    {
        gameObject.SetActive(true);
        onShowComplete?.Invoke();
    }

    public virtual void Hide(System.Action onHideComplete = null)
    {
        gameObject.SetActive(false);
        onHideComplete?.Invoke();
    }

    public void Initialize(string screenName)
    {
        ScreenName = screenName;
    }
}