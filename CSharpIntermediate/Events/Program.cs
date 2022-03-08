
public delegate void Notify();  // delegate

public class ProcessBusinessLogic
{
    public event Notify ProcessCompleted; // event

    public void StartProcess()
    {
        Console.WriteLine("Process is start...");
        // some code here
        OnProcessCompleted();

    }

    protected virtual void OnProcessCompleted()
    {
        //if ProcessCompleted is not null, then call delegate
        ProcessCompleted?.Invoke();
    }
}

public static class Program
{
    public static void Main()
    {
        ProcessBusinessLogic pbl = new ProcessBusinessLogic();
        pbl.ProcessCompleted += bl_ProcessCompleted;
        pbl.StartProcess();
    }

    // event handler
    public static void bl_ProcessCompleted()
    {
        Console.WriteLine("Process Completed!");
    }
}
