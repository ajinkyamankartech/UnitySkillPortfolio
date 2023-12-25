using System;

public interface IScreen
{

    string ScreenName { get; }
    void Show(Action onShowComplete = null);
    void Hide(Action onHideComplete = null);
}