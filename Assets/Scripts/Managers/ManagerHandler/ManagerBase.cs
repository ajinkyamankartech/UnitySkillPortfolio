//ManagerBase implements IManager interface and provides basic functionality for all managers

using UnityEngine;

public class ManagerBase : MonoBehaviour, IManager
{

    public string ID { get; private set; }


    private void Start()
    {
        Register();
    }
    public virtual void Init()
    {
        // ID = this.GetType().Name;

    }

    public virtual void Destroy()
    {
        Unregister();
    }

    public virtual void Register()
    {
        ManagerHandler.Instance.Register(this);
    }

    public virtual void Unregister()
    {
        ManagerHandler.Instance.Unregister(this);
    }
}