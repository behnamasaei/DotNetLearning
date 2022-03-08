
# LINQ

LINQ (Language Integrated Query) is uniform query syntax in C# and VB.NET to retrieve data from different sources and formats. It is integrated in C# or VB, thereby eliminating the mismatch between programming languages and databases, as well as providing a single querying interface for different types of data sources.

![Alt text](https://github.com/behnamasaei/DotNetLearning/blob/master/CSharpIntermediate/LINQ/src/linq-usage.png)

LINQ queries return results as objects. It enables you to uses object-oriented approach on the result set and not to worry about transforming different formats of results into objects.

![Alt text](https://github.com/behnamasaei/DotNetLearning/blob/master/CSharpIntermediate/LINQ/src/linq-execution.png)


### LINQ Query Syntax
There are two basic ways to write a LINQ query to IEnumerable collection or IQueryable data sources.

 1. Query Syntax or Query Expression Syntax
 2. Method Syntax or Method Extension Syntax or Fluent

#### Query Syntax
Query syntax is similar to SQL (Structured Query Language) for the database. It is defined within the C# or VB code.
```
from <range variable> in <IEnumerable<T> or IQueryable<T> Collection>

<Standard Query Operators> <lambda expression>

<select or groupBy operator> <result formation>
```
The LINQ query syntax starts with from keyword and ends with select keyword.

![Alt text](https://github.com/behnamasaei/DotNetLearning/blob/master/CSharpIntermediate/LINQ/src/linq-query-syntax.png)
