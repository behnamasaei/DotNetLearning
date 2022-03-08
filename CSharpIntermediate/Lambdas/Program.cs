
List<int> numbers = new List<int> { 10, 2, 8, 7, 5, 6, 4, 3, 1, 9};

// Using lambda expression
// to calculate square of
// each value in the list
var square = numbers.Select(x => x * x);

// Using Lambda expression to
// find all numbers in the list
// divisible by 3
var divBy3 = numbers.FindAll(x => (x % 3 == 0));


// To sort the details list
// based on name of student
// in ascending order
var asceding = numbers.OrderBy(x => x);


System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
Console.WriteLine(e);
// Output:
// x => (x * x)