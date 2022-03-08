Events are user actions such as key press, clicks, mouse movements, etc.
, or some occurrence such as system generated notifications.
Applications need to respond to events when they occur.
For example, interrupts. Events are used for inter-process communication.
also
An event is a notification sent by an object to signal the occurrence of an action.
Events in .NET follow the observer design pattern.

در زبان‌های برنامه‌نویسی مختلف یک رویداد و یا Event در واقعیت یک پیغام است که توسط یک Object در زمان رخ دادن یک اتفاق ارسال می‌شود. برخی از اتفاقاتی که می‌توانند باعث ایجاد شدن یک Event بگردند شامل User Interaction و یا تعامل کاربر با برنامه شبیه کلیک کردن بر روی یک دکمه و یا انجام قسمتی از خود برنامه برای مثال تغییر دادن مقدار درون یک Property است. بهتر است در رابطه با برخی از واژگان خاص حوزه کار کردن با Event ها نیز آشنا بشوید. Object و یا موجودیتی که یک Event را اصطلاحاً Raise و یا ایجاد می کند، تحت عنوان Event Sender شناخته می‌شود. در واقع در زمان Raise کردن یک Event این Event Sender هیچ نمی‌داند که چه Object و یا متدی از یک Object آن Event ایجاد شده را دریافت و یا اصطلاحاً Handle خواهد نمود. رویداد و یا Event مورد نظر که توسط یک Event Sender اصطلاحاً Raise می‌گردد، یک Member و یا یک عضو از کلاس آن Event Sender می باشد. برای مثال رویداد کلیک عضوی از کلاس Button است.

