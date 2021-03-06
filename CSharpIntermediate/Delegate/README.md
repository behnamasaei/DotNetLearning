## Delegates in C#

A delegate in C# is a reference to the method. A delegate is a reference type variable that holds the reference to a method. The reference can be changed at runtime.

Delegates are especially used for implementing events and the call-back methods. All delegates are implicitly derived from the System.Delegate class.

Let us see how to declare delegates in C#.

delegate \&lt;return type\&gt; \&lt;delegate-name\&gt; \&lt;parameter list\&gt;

Delegate به معنای نماینده است

Delegate ها در واقع اشاره‌گری به متد/متدهایی میتواند باشد که شرایط لازم را دارا هستند. (به زبان ساده‌تر میتوان دلیگیت را خشابی از متدها فرض نمود.) پس یک زمانی که شرایط لازم را داراست، میتواند نماینده متد یا متدهایی باشد.

مهم‌ترین و بهترین استفاده‌ها از Delegate

استفاده به عنوان اجراکننده هر متد که امضای آن برابر با خودDelegate باشد.

استفاده به عنوان یک رویداد در برنامه نویسی(Event CallBack)

دو مفهوم در دلیگیت‌ها وجود دارد که دانستن آنها لازم است. مفهموم single cast delegateبه این اشاره می‌کند که هر می‌تواند فقط به یک متد اشاره کند اما مفهمومmulticast delegateدقیقا با این مفهموم در تضاد است و بیانگر این است که هرdelegate می‌تواند به بیش از یک متد اشاره کند.