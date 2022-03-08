
### PLINQ
PLINQ یک موتور اجرای پرس و جو (query) است ،هر پرس و جوی LINQ-to-Objects یا LINQ-to-XML را می‌پذیرد و بصورت خودکار از چندین پردازشگر یا هسته که برای اجرا در دسترس هستند ، استفاده میکند .

استفاده از PLINQ دقیقا همانند استفاده از LINQ-to-Objects و LINQ-to-XML است . شما از تمام Operatorهایی که در  3.0 #C یا کلاس System.Linq.Enumerable ، شاملOrderBy, Join, Select,Where هستند ، میتوانید استفاده کنید . 

متد AsParallel  ، درگاهی است به PLINQ .رشته ای از داده ها را به ParallelQuery تبدیل می‌کند . موتور LINQ استفاده از ParallelQuery در queryها را تشخیص میدهد و بصورت خودکار آن را به PLINQ تبدیل میکند . شما در هر بار استفاده از PLINQ به احتمال زیاد باید از متد AsParallel هم استفاده کنید . 

<br>

### Compare performance LINQ and PLINQ

![](https://github.com/behnamasaei/DotNetLearning/blob/master/Asynchronous/PLINQ/image/plinqseqparallel_40B54A83.png)

You can see that LINQ uses resources of one CPU and it is therefore a little bit slower in our example. PLINQ uses both CPU-s at same time and performs faster. If you compare times you should get results similar to mine. Take a look at the following screenshot – click on it to resize it. Your results may be different and it depends on hardware of your computer (I expect you don’t have many background processes running).


![](https://github.com/behnamasaei/DotNetLearning/blob/master/Asynchronous/PLINQ/image/plinqperfboth_thumb_4E47BAF1.png)


When we put the results on chart we can see that there is not hard differences between LINQ and PLINQ when we don’t have much processing to do. But when our processes grow and need more resources then PLINQ performs very well.

![](https://github.com/behnamasaei/DotNetLearning/blob/master/Asynchronous/PLINQ/image/plinqperfchart_66C73274.png)

Horizontal axis shows the maximum number we are walking to when finding prime numbers. Vertical axis shows time in milliseconds that LINQ (serial) and PLINQ (parallel) need to find prime numbers in this range.

