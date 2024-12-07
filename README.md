# BeautyBooking

تطبيق ويب لحجز مواعيد العناية بالجمال للشعر والأظافر والسبا وما إلى ذلك. :calendar: :nail_care:

:dart: مشروعي لدورة ASP.NET Core في SoftUni. (أبريل 2023)

## :information_source: كيف يعمل

- الزوار الضيوف:
- تصفح فئات خدمات التجميل؛
- عرض الصالونات مع خدماتها؛
- قراءة منشورات المدونة.
- المستخدمون المسجلون:
- حجز المواعيد باستخدام أداة تحديد التاريخ التفاعلية؛
- يمكنهم إلغاء المواعيد؛
- يمكنهم تقييم الصالونات التي أكدوا مواعيدهم السابقة فيها.
- مدير الصالون (دور المستخدم):
- يؤكد/يرفض مواعيد المستخدمين لصالون معين؛
- يتحكم في الخدمات المتاحة للحجز في الصالون.
- المسؤول:
- ينشئ/يحذف منشورات المدونة والفئات والصالونات والخدمات؛
- يمكنه مراجعة سجل المواعيد.

## :hammer_and_pick: تم إنشاؤه باستخدام
- ASP.NET Core 3.1
- Entity Framework (EF) Core 3.1
- Microsoft SQL Server Express
- ASP.NET Identity System
- MVC Areas with Multiple Layouts
- Razor Pages, Sections, Partial Views
- View Components
- Repository Pattern
- Auto Мapping
- Dependency Injection
- Status Code Pages Middleware
- Exception Handling Middleware
- Sorting, Filtering, and Paging with EF Core
- Data Validation, both Client-side and Server-side
- Data Validation in the Models and Input View Models
- Custom Validation Attributes
- Responsive Design
- CloudinaryDotNet
- Bootstrap
- jQuery

## :gear: تكوينات التطبيق

### 1. سلسلة الاتصال
توجد في `appsettings.json`. إذا كنت لا تستخدم SQLEXPRESS، فيجب استبدال `Server=.\\SQLEXPRESS;` بـ `Server=.;`

### 2. عمليات نقل قاعدة البيانات
ستُطبق عند تشغيل التطبيق، نظرًا لأن `ASPNETCORE-ENVIRONMENT` مضبوط على `Development`. إذا قمت بتغييره، فيجب عليك تطبيق عمليات النقل بنفسك.

### 3. سيتم نشر بيانات العينة
بمجرد تشغيل التطبيق، بما في ذلك حسابات الاختبار:
- المستخدم: user@user.com / كلمة المرور: 123456
- مدير الصالون: manager@manager.com / كلمة المرور: 123456
- المسؤول: admin@admin.com / كلمة المرور: 123456

### 4. إعداد Cloudinary - اختياريًا
#### التشغيل بدونه:
لن تحصل على خطأ بسبب فقدان بيانات اعتماد Cloudinary - يتم التعامل مع ذلك باستخدام صورة محددة مسبقًا (تم تحميلها بالفعل)، عندما يكون تكوين Cloudinary مفقودًا. لذا عند إنشاء محتوى في لوحة المسؤول، سيتم إضافته ولكن ليس بالصورة التي اخترتها.
#### إذا كنت تريد تحميل الصور فعليًا، فيجب عليك:
1. إضافة بيانات اعتماد Cloudinary في `appsettings.json` بالتنسيق:
```json
"Cloudinary": {
"CloudName": "",
"ApiKey": "",
"ApiSecret": "",
"EnvironmentVariable": ""
}
```
2. تحديث جزء إعداد Cloudinary من طريقة `ConfigureServices` في `Startup.cs` على النحو التالي:
```csharp
// إعداد Cloudinary
Cloudinary cloudinary = new Cloudinary(new Account(
this.configuration["Cloudinary:CloudName"],
this.configuration["Cloudinary:ApiKey"],
this.configuration["Cloudinary:ApiSecret"]));
services.AddSingleton(cloudinary);
```
## License

This project is licensed under the [MIT License](LICENSE).

## Acknowledgments

#### Using [ASP.NET-MVC-Template](https://github.com/F-BAJBYR/ASP.NET-MVC-Template) developed by:
- [Fatimah Bajbyr](https://github.com/F-BAJBYR)

