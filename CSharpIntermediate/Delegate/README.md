## **Delegates in C#**

A delegate in C# is a reference to the method. A delegate is a reference type variable that holds the reference to a method. The reference can be changed at runtime.

Delegates are especially used for implementing events and the call-back methods. All delegates are implicitly derived from the System.Delegate class.

Let us see how to declare delegates in C#.

delegate <return type> <delegate-name> <parameter list>

![](Aspose.Words.4cb45bc4-b979-449a-87d5-de83509899da.001.png)

-----
به معنای نماینده است Delegate

Delegate ها در واقع اشاره‌گری به متد/متدهایی میتواند باشد که شرایط لازم را دارا هستند. (به زبان ساده‌تر میتوان دلیگیت را خشابی از متدها فرض نمود.) پس یک زمانی که شرایط لازم را داراست، میتواند نماینده متد یا متدهایی باشد.

Delegate مهم‌ترین و بهترین استفاده‌ها از

استفاده به عنوان اجراکننده هر متد که امضای آن برابر با خود Delegate باشد.

استفاده به عنوان یک رویداد در برنامه نویسی (Event CallBack)

دو مفهوم در دلیگیت‌ها وجود دارد که دانستن آنها لازم است. مفهموم single cast delegateبه این اشاره می‌کند که هر می‌تواند فقط به یک متد اشاره کند اما مفهموم multicast delegateدقیقا با این مفهموم در تضاد است و بیانگر این است که هر delegateمی‌تواند به بیش از یک متد اشاره کند.
