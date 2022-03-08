## Asynchronous

### Async & Awati
از نسخه ۴٫۵ دات، در زبان سی شارپ (و همینطور زبان VB) دو کلمه کلیدی اضافه شد که اجازه نوشتن کدهای Asynchronous را به شکل دیگری به برنامه نویسان می داد. این دو کلمه کلیدی، کلمات async و await هستند و زمانی که شما در کدهای خود از این دو کلمه کلیدی استفاده می کنید، در زمان کامپایل کدها، کامپایلر کدهایی را برای شما تولید می کند که به صورت بهینه و البته مطمئن کارهای Asynchronous را برای شما انجام می دهند، کدهای تولید شده از کلاس هایی که در فضای نام System.Threading.Tasks قرار دارند استفاده می کنند.


نگاه اولیه با ساختار async و await
زمانی که شما در بخشی از کد خود از کلمه کلیدی async و بر روی متدها، عبارات لامبدا یا متدهای بدون نام استفاده می کنید، در حقیقت می گویید که این قطعه کد به صورت خودکار باید به صورت Asynchronous فراخوانی شود و زمان استفاده از کدی که به صورت async تعریف شده، CLR به صورت خودکار thread جدیدی ایجاد کرده و کد را اجرا می کند. اما زمان فراخوانی کدهایی که به صورت async تعریف شده اند، استفاده از کلمه await این امکان را فراهم می کند که اجرای thread جاری تا زمان تکمیل اجرای کدی که به صورت async تعریف شده، می بایست متوقف شود.