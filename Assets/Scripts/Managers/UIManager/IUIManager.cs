using System;

public interface IUIManager : IManager
{
    void ShowScreen(string screenName, Action onShowComplete = null);
    void HideScreen(string screenName, Action onHideComplete = null);

    void RegisterScreen(string screenName, IScreen screen);
    void UnregisterScreen(string screenName);

}
