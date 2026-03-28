namespace Week8;

public class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name){}

    public override void Open()
    {
        if (isOpen) return;
        isOpen = true;
        Console.WriteLine($"{Name} is opened");
    }
    
    public override void Close()
    {
        if (!isOpen) return;
        isOpen = false;
        Console.WriteLine($"{Name} is closed");
    }
    public void Dispose()
    {
        Console.WriteLine($"{Name} is disposed");
        Close();
    }

}