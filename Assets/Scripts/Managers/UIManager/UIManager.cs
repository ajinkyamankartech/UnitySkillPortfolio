using System;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : ManagerBase
{
    private Dictionary<string, IScreen> _screens = new Dictionary<string, IScreen>();

    public void ShowScreen(string screenName, Action onShowComplete = null)
    {
        if (_screens.ContainsKey(screenName))
        {
            _screens[screenName].Show(onShowComplete);
        }
        else
        {
            Debug.LogError("Screen with name " + screenName + " not found");
        }
    }

    public void HideScreen(string screenName, Action onHideComplete = null)
    {
        if (_screens.ContainsKey(screenName))
        {
            _screens[screenName].Hide(onHideComplete);
        }
        else
        {
            Debug.LogError("Screen with name " + screenName + " not found");
        }
    }

    public void RegisterScreen(string screenName, IScreen screen)
    {
        if (!_screens.ContainsKey(screenName))
        {
            _screens.Add(screenName, screen);
        }
        else
        {
            Debug.LogError("Screen with name " + screenName + " already registered");
        }
    }

    public void UnregisterScreen(string screenName)
    {
        if (_screens.ContainsKey(screenName))
        {
            _screens.Remove(screenName);
        }
        else
        {
            Debug.LogError("Screen with name " + screenName + " not found");
        }
    }
}