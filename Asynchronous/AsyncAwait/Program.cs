
public static class Program
{
    public static void Main()
    {

        Console.WriteLine("Before run method with Async");
        using (Message message = new Message())
        {
            message.PrintMessageAsync();
        }
        Console.WriteLine("After run method");
        Console.ReadKey();
    }
}

public class Message : IDisposable
{
    public void Dispose()
    {

    }

    public async Task PrintMessageAsync()
    {

        await Task.Run(async () =>
        {
            for (int i = 0; i < 10; i++)
            {
                // Without await keyword
                // not waiting for return value from GetAge method
                // Output:
                // 0 and Age is System.Threading.Tasks.Task`1[System.Int32]
                Console.WriteLine($"{i} and Age is { GetAge()}");


                // With await keyword
                // wait for return value from GetAge method
                // Output:
                // 0 and Age is 1
                Console.WriteLine($"{i} and Age is {await GetAge()}");
            }
        });
    }


    public async Task<int> GetAge()
    {
        Task.Delay(1000).Wait();
        return 1;

    }
}