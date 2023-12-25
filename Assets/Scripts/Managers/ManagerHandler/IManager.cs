//Create IManager which will be implemented by all managers.They will have their Id, Init and Destroy methods,Register and Unregister methods
public interface IManager
{
    string ID { get; }
    void Init();
    void Destroy();
    void Register();
    void Unregister();
}