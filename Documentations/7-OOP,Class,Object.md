OOP(Object Oriented Programming)
OOP, yəni obyekt yönümlü proqramlaşdırma, developerlərin entity’ləri və object’ləri təşkil etməsinə imkan verən müasir proqramlaşdırma dili konseptidir. OOP’in bir sıra mənbələrdə 3 əsas 1 əlavə, bir sıra mənbələrdə isə 4 əsas prinsipin olduğu qeyd olunur.

Encapsulation
Abstraction
Inherientce
Polymorphism

Object
Object, hər hansısa bir class’dan(type) törəyən və daxilində bir neçə data’nı saxlamaq üçün istifadə olunan obyekt’dir. Əlavə olaraq C#’da Object type da mövcuddur. Object reference type’dır və bütün type’lar Object type’dan törəyiblər yəni bütün class’lar Object class’dan implicitly miras almışdır. Bu səbəbdən object, bütün type dəyərləri özündə saxlaya bilir. Object type dəyişənlər dataları RAM’da object type olaraq saxlayır lakin bununla yanaşı data’ların özünə məxsus olan type’larını da özündə saxlayır. Bu da o deməkdir ki object’in daxilində saxladığı variable’ı öz type’ı ilə təkrar əldə edə bilərik.

Class
Class’lar C# typle’larının ən təməlidir. OOP’ni dəstəkləyən proqramlaşdırma dillərində hər hanısa bir object yaratmaq üçün ilk öncə onun strukturunu və davranışı təyin etmək lazımdır, yəni onu modelləşdirmək lazımdır. Struktur və davranış dedikdə, daxilində hər hansısa dəyər(lər) saxlayacaqsa field & property, hər hansısa həyata keçirəcəyi əməliyyat(lar) varsa method, array’lərdə tanış olduğumuz index məntiqi ilə çağrılma olacaqsa indexer başa düşülür. Bunun üçün də Class məntiqindən istifadə edilir. C#’da Class, object’ləri modelləşdirmək üçün istifadə edilən plan(blueprint) və ya şablondur(template). Əlavə olaraq Class’lar yaddaşda(ramda) heç bir yer tutmur. Class OOP’də əsas konseptdir. Hər bir class arxa tərəfdə dilin ən başında duran Object class’dan miras alır. Object’lər, object model olan Class’lardan törəyir, ramda bu object’lər yer tutur. Yaddaşdan asılı olaraq istənilən sayda object yaratmaq olar(instance almaq olar). Class’ın strukturu və davranışı ondan instance alınan bütün object’lərə şamil olunur, lakin hər birinin field & property’ləri fərqli dəyərlər saxlayır.

Class’ların yaranması
Yeni Class’lar yaranan zaman Class deklarasiyasından istifadə edilir. Class deklarasiyası header ilə başlayır. Bu header ardıcıllıqla ilk olaraq attribute və modifier, class keyword, Class’ın adı, başqa bir Class’dan miras alma varsa əgər base Class’ın adı, Interface(lər) implement edəcəksə Interface(lər)’in adı yazılır. Artıq bu class’ın yaranması ilə program üçün yeni bir type təyin olunmuş olur. Class’ları 3 şəkildə yaratmaq olar: Namespace daxilində, namespace xaricində və başqa bir Class’ın daxilində(nested Class). Hər biri üçün bilməli olduğumuz vacib ortaq xüsusiyyətlərindən biri eyni namespace daxilində eyni adda başqa bir class’ın yaradıla bilməməsidir. Class yaranan zaman daxilində static olaraq təyin etmədiyimiz member’lər(field, property, constructor, method) hər biri heap yaddaşda saxlanılacaq. Class’dan törəyən object’lər özlərinə type olaraq Class’ın adını götürəcək və new keyword’ü ilə constructor’u işə salınaraq törəyəcək.
