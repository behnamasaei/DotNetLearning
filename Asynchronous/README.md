## Asynchronous

### Async & Await
از نسخه ۴٫۵ دات، در زبان سی شارپ (و همینطور زبان VB) دو کلمه کلیدی اضافه شد که اجازه نوشتن کدهای Asynchronous را به شکل دیگری به برنامه نویسان می داد. این دو کلمه کلیدی، کلمات async و await هستند و زمانی که شما در کدهای خود از این دو کلمه کلیدی استفاده می کنید، در زمان کامپایل کدها، کامپایلر کدهایی را برای شما تولید می کند که به صورت بهینه و البته مطمئن کارهای Asynchronous را برای شما انجام می دهند، کدهای تولید شده از کلاس هایی که در فضای نام System.Threading.Tasks قرار دارند استفاده می کنند.


نگاه اولیه با ساختار async و await
زمانی که شما در بخشی از کد خود از کلمه کلیدی async و بر روی متدها، عبارات لامبدا یا متدهای بدون نام استفاده می کنید، در حقیقت می گویید که این قطعه کد به صورت خودکار باید به صورت Asynchronous فراخوانی شود و زمان استفاده از کدی که به صورت async تعریف شده، CLR به صورت خودکار thread جدیدی ایجاد کرده و کد را اجرا می کند. اما زمان فراخوانی کدهایی که به صورت async تعریف شده اند، استفاده از کلمه await این امکان را فراهم می کند که اجرای thread جاری تا زمان تکمیل اجرای کدی که به صورت async تعریف شده، می بایست متوقف شود.



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


