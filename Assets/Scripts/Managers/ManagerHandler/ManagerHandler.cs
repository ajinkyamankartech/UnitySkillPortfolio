using System.Collections.Generic;
using UnityEngine;

public class ManagerHandler : MonoBehaviour
{
    //Create a singleton of ManagerHandler
    public static ManagerHandler Instance { get; private set; }

    //Create a dictionary of managers
    private Dictionary<string, IManager> _managers = new Dictionary<string, IManager>();

    public void Awake()
    {
        //Set the singleton
        Instance = this;
    }

    public void Start()
    {

    }

    public void Register(IManager manager)
    {
        //Register the manager
        if (!_managers.ContainsKey(manager.ID))
        {
            _managers.Add(manager.ID, manager);
            manager.Init();
        }
    }

    public void Unregister(IManager manager)
    {
        //Unregister the manager
        if (_managers.ContainsKey(manager.ID))
        {
            _managers.Remove(manager.ID);
        }
    }

    public T GetManager<T>() where T : class, IManager
    {
        //Get the manager
        IManager manager = null;
        _managers.TryGetValue(typeof(T).Name, out manager);
        return manager as T;
    }

    public void OnDestroy()
    {
        //Destroy all managers
        foreach (var manager in _managers)
        {
            manager.Value.Destroy();
        }
        _managers.Clear();
    }
}



