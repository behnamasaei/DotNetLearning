using System.Diagnostics;

var source = Enumerable.Range(1, 10_000_000);

// Opt in to PLINQ with AsParallel.
Stopwatch st = new Stopwatch();
st.Start();
// call MakeSome method...
var evenNums = from num in source
               where num % 2 == 0
               select Math.Pow(num,100);

st.Stop();



Stopwatch stt = new Stopwatch();
stt.Start();
// call MakeSome method...
var ovenNums = from num in source.AsParallel()
               where num % 2 == 0
               select Awati();
stt.Stop();


Console.WriteLine("Without PLINQ:"+st.ElapsedMilliseconds);
Console.WriteLine("With PLINQ:"+stt.ElapsedMilliseconds);

 static int Awati()
{
    Thread.Sleep(50000);
    return 1;
}

Console.WriteLine("{0} even numbers out of {1} total",
                  evenNums.Count(), source.Count());
// The example displays the following output:
//       5000 even numbers out of 10000 total