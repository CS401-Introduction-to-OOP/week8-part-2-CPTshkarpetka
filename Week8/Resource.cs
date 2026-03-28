namespace Week8;

public abstract class Resource
{
    public string Name { get; set; }
    public bool isOpen { get; protected set; }

    protected Resource(string name)
    {
        Name = name;
        isOpen = false;
    }
    
    public abstract void Open();
    public abstract void Close();
}