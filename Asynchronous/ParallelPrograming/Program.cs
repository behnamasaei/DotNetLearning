using System;
using System.Collections.Concurrent;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 999_999_999);

        Stopwatch st = new Stopwatch();
        st.Start();
        // call MakeSome method...
        Parallel.ForEach(numbers, number =>
        {
            if (number % 2 == 0)
            {
                // some code
            }
        });
        st.Stop();



        Stopwatch stt = new Stopwatch();
        stt.Start();
        // call MakeSome method...
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                // some code
            }
        }
        stt.Stop();

        Console.WriteLine("Parllel: " + st.ElapsedMilliseconds);
        Console.WriteLine("Concurrency: " + stt.ElapsedMilliseconds);

    }
}