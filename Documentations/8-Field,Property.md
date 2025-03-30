Field
Field, Class’dan törəyən object(lər)’in daxilində dəyər saxlamaq üçün istifadə olunan, Class’ın scope’ları daxilində təyin olunan variable’ların adıdır. Field’lar təyin olunan zaman heç bir dəyər set olunmazsa öz type’na uyğun olaraq default value avtomatik olaraq set olunar. Bu yalnız Field’lara xas xüsusiyyətdir, method daxilində təyin olunan dəyişənlərdə default value set olunmur.

Property
Property’lər isə get və set method’u olan Field’lardır. Property’lərin adları təmsil etdikləri Field’ın adının baş hərfi böyük olan şəkildə yazılır, və təmsil etdikləri Field’ın type’nı alır. Yazılışdaki fərqləri Property’in adından sonra scope daxilində get və set yazılır, gedişata uyğun olaraq get və set üçün də ayrıca scope açılıb hər biri müəyyən əməliyyat yerinə yetirilə bilər.  Property’lər compile olan zaman onlar üçün ayrıca get və set method’lar yaranır.
Class’ın hər hansısa Field’ın access modifier’ı private olub onun üçün bir Property yaradılarsa və get olunan zaman geriyə private olan Field’ın dəyərini qaytarıb, set olunan zaman gələn dəyəri value keyword’ü ilə tutub field’a mənimsədərsə bu Property Full Property adlanır.
Full property’lərə misal göstərsək
private int _num - Field
public int Num {get{return _num;} set{_num = value;}} - Property
