Polymorphism 
Polymorphism yunan sözü olub, poly - bir çox sayda və morph - form mənasını verir. Polymorphism eyni adda olan bir çox method’un fərqli formlarda istifadə olunmasına (yəni body’lərinin fərqli olmasına) deyilir. 
Polymorphism, Override(runtime, dynamic) və Overload(compile time, static) olaraq 2 yerə bölünür. Əsasən Polymorphism’in izzahı sadəcə regular Class daxilindəki virtual method və ya Abstract class’lar daxilindəki abstract method’ların Override’ı üzərindən olsa da bu kifayət etmir. Polymorphism, Interface’lər daxilindəki body’si olmayan method’ların implement prosesində, operatorların və method’ların overload’ı prosesində baş verir. 

Override
Base class’ın hər hansısa bir method’nun body’sini, Derived class daxilində özünə uyğun şəkildə dəyişmək override əməliyyatı adlanır. Həmçinin Base class daxilində təyin olunmuş property’lərin get və set method’larını da override edilə bilən hala salmaq olar. Override ilə bağlı diqqət yetirməli olduğumuz müəyyən məqam mövcuddur. Override zamanı Method Signature qorunmalıdır. 
Bir method 3 situasiyada override oluna bilər, override keyword’ü işlənə bilər. Virtual keyword’ü ilə təyin olunmuşdursa, özü override olunmuş bir method’dursa və ya abstract method’dursa. Bu 3 situasiyadan heç olmazsa 1’i ödənmədikdə Override prosesi həyata keçmir, Override keyword yazıla bilmir. Override keyword yazılmadan təyin olunan method 3 şərtdən heç olmasa birini ödəsə belə Override olunmuş sayılmır.

Overload
Bir class daxilində eyni adda olan bir neçə method’un yazılmasına Overload deyilir. Method’ların adının eyni olmasına baxmayaraq bu method’lar Method Signature qorunaraq yazılır.

