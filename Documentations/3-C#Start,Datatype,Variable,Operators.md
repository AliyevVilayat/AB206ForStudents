C# nədir
C#(C Sharp) Microsoft tərəfindən .Net texnologiyası üçün inkşaf etdirilən modern, tam obyekt yönümlü(OOP) və type safety xüsusiyyətinə sahib bir proqramlaşdırma dilidir. C#, C ailəsinə daxildir və Java kimi məşhur dillərə yaxındır. Ilk dəfə yanvar 2000-ci ildə elan edilmiş C#, 1.0 versiyası ilə yanvar 2002-də .Net framework’ün bir parçası olaraq istifadəyə buraxılmışdır. Bu dilin C# adlandırılmasının səbəbi C++’ın bir üst versiyası olmasıdır. C++’ın, C dilinin bir üst versiyası olduğunu bildirmək üçün ++ operatorundan istifadə ediblər və beləliklə dilin C++’ın da bir üst versiyası olduğunu bildirmək üçün C#(C Sharp) yazılaraq bu şəkildə adlandırılmışdır. Hal-hazırda ilk zamanlardan fərqli olaraq C#, platform independence(cross platform da deyilir) prinsipi ilə işləyən dildir. Yəni Windows əməliyyat sistemi ilə yanaşı digər əməliyyat sistemlərində və ya platformlarda da işləmək üçün nəzərdə tutulmuşdur.  

Type safety nədir?
Bir proqramlaşdırma dilində type safety, dilin type error’lardan qaçmağına kömək edən abstract bir konstruksiyadır. Hər proqramlaşdırma dili gizli type safety səviyyəsinə malikdir. Beləliklə proqram compile olunan zaman compiler type’ları təsdiqləmək üçün type safety konstruksiyasını tətbiq edəcək və dəyişənə yanlış type təyin etməyə çalışsaq, compile time xəta verəcək. Type safety yalnız compile zamanı yox, həm də runtime işə salınır.


Solution nədir?
Solution daxilində bir və ya bir-birləri ilə əlaqəli olan birdən çox project’in saxlandığı workspace, yəni iş sahəsidir.
Top-Level Statements
C# 9.0 ilə gəlmiş Top-Level Statements anlayışı bizə əvvəllər Program.cs daxilində yazdığımız main method’u yazmadan kodlarımızı yazıb compile edilə bilməsi üçün şərait yaradır. Yalnız Program.cs daxilində Top-Level Statements’dən istifadə edilə bilər. Compile olduqdan sonra özü Assembly səviyyəsində main method yaradıb, bizim yazdığımız kodları onun daxilinə əlavə edərək işlədir. Compile zamanı class adından Program.cs olduğu başa düşüləcək və main method arxa tərəfdə yaranacaq. Top-Level Statements microservices arxitekturasında kodun inkşaf etdirilməsində sürət qazanmaq üçün istifadə edilir.

Variable
Program daxilində hər hansısa bir datanı ramda saxlamaq və onu lazım olan zaman ramdan çağırmaq üçün variable’dan istifadə edilir. Hər bir variable təyin olunarkən hansı type‘da dəyər saxlaya biləcəyi əvvəlcədən datatype‘lar vasitəsi ilə qeyd edilir. C#, qeyd etdiyimiz kimi type-safety language olduğu üçün hər bir dəyişənə verilən type və ona mənimsədilən dəyər uyğun olmalıdır.

Datatype
Datatype‘lar Value type, Reference type və Pointer(unsafed block daxilində) type olaraq ramda saxlanma yerlərinə görə 3 yerə bölünür. Value type variable‘lar dəyəri ilə birlikdə stack yaddaşda, Reference type variable‘larda isə variable’ın referansı stack, dəyəri isə heap yaddaşda saxlanılır.

Value Data Types 
Value type’lara Integral numeric types, Floating-point numeric types, Boolean, Character,Struct(Custom), Nullable, Enum və Tuple(System.ValueTuple) daxildir.

Value Data type ranges (Verilənlərin tiplərinin aralıqları)
Unsigned Integral Numeric Types 
Unsigned yəni işarətsiz value type’lar, işarəli bitlərdən istifadə etmirlər bu səbəbdən işarəli value type’lardan fərqli olaraq daha geniş pozitif dəyər aralığına sahibdirlər.
byte (Yaddaşda tutduğu yer 1 byte)   	 0  to  255
ushort (Yaddaşda tutduğu yer 2 bytes)     0 to  65,535
uint (Yaddaşda tutduğu yer 4 bytes)   	 0  to  4,294,967,295 
ulong (Yaddaşda tutduğu yer 8 bytes)  	 0 to  18,446,744,073,709,551,615

Signed Integral Numeric Types
Signed yəni işarəli value type’lar, dəyərin işarətini bildirmək üçün işarəli bitlərdən istifadə edirlər.
sbyte (Yaddaşda tutduğu yer 1 byte)   	 -128  to  127
short (Yaddaşda tutduğu yer 2 bytes)   	 -32,768 to  32,767
int (Yaddaşda tutduğu yer 4 bytes)   	 -2,147,483,648  to  2,147,483,647
long (Yaddaşda tutduğu yer 8 bytes)  	 -9,223,372,036,854,775,808 to  9,223,372,036,854,775,807 

Floating Point Numeric Types
float(Yaddaşda tutduğu yer 4 bytes) 	  vergüldən sonra 6 və ya 7 rəqəm üçün nəzərdə tutulub
double(Yaddaşda tutduğu yer 8 bytes)     vergüldən sonra 16 rəqəm üçün nəzərdə tutulub

High-precision decimal Floating-point Numeric Type
Decimal type Byte’lardan əmələ gəlmişdir və value type’dır.
Float type variable yaradan zaman dəyərin sonuna F,Double type variable yaradan zaman D və Decimal type variable yaradan zaman isə M yazılmalıdır.

Character Type
char (Yaddaşda tutduğu yer 2 bytes)	   Simvollar və ya onlara uyğun olaraq ASCII kodları

Boolean Type
bool (Yaddaşda tutduğu yer 1 byte) 	   true və ya false

Default Value
Value type variable’ların default dəyəri 0’dır
Char type variable’ın default dəyəri ‘/0’ dır.
Boolean type variable’ın default dəyəri false’dur
Reference type variable’ın default dəyəri null’dır.


Arithmetic operators(Hesab operatorları)
/ - div bölmə adlanır , tam hissə götürülür 
% - mod bölmə adlanır , qalıq hissə götürülür
Increment 🡪 ++ 
Declerement 🡪  -- 

int num = 10;
num++ && num-- 🡪 Postfix increment & decrement adlanır. Burada gedən proses özündən sonraki sətrə yəni əməliyyata  aid olur. Console.WriteLine(num++); yazarsaq ekrana 10 çıxacaq lakin artıq yaddaşda num 11 olaraq qalacaq və daha sonra num dəyişənini ekrana verərsək 11 kimi çıxacaq 
 
++num && --num 🡪   Prefix increment & decrement adlanır. Burada həmin sətr(və ya əməliyyat) daxilində artıq proses getmiş olur. Console.WriteLine(++num); yazarsaq ekrana 11 çıxacaq çünki artıq proses həmin sətrdə getmiş olacaq

Assigment Operators(Mənimsətmə operatorları)
a += b  🡪 a = a + b
a -= b  🡪 a = a - b
a *= b  🡪 a = a * b
a /= b  🡪 a = a / b
a %= b  🡪 a = a % b

Comparison Operators(Müqayisə operatorları)
Müqayisə operatorları bizə true və ya false dəyər qaytarır
== 🡪 bərabərdirmi?
!= 🡪bərabərliyin əksi, bərabər deyilmi yəni not equals
> 🡪 böyükdürmü
< 🡪 kiçikdirmi
>= 🡪böyük bərabərdirmi
<= 🡪kiçik bərabərdirmi
Bu operatorlar bizə boolean dəyər qayatırlar. Və əsasən if şərti daxilində və ya loop’larda istifadə olunurlar.


Logical Operators(Məntiqi operatorlar)
&& 🡪 and(və) deməkdir. Işləndiyi bütün şərtlər true olduğu halda true dəyər qaytarır
|| 🡪 or(və ya) deməkdir. Işləndiyi şərtlərin ən azı 1-I true olduğu halda true dəyər qaytarır
c 🡪 not(əks) deməkdir. Işləndiyi şərt true olarsa false , false olsarda true dəyər qaytarır.


