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


Condition
If Statements
If(condition) {
	Statement;
}
Statement2;
Bu ifadəyə if-then ifadəsi deyilir. Əgər verilən şərt doğru olarsa if daxilindəki ifadə yerinə yetirilir və daha sonra 2-ci ifadə yerinə yetirilir. Əks təqdirdə sadəcə 2-ci ifadə yerinə yetirilir.

If(condition) {
	Statement;
} else{
	Statement2;
}
Bu ifadəyə if-then-else ifadəsi deyilir. Əgər verilən şərt doğru olarsa sadəcə if daxilindəki ifadə yerinə yetirilir əks təqdirdə sadəcə 2-ci ifadə yerinə yetirilir.

if(condition) {
	Statement;
} else if(condition2){
	Statement2;
} else if(condition3){
	Statement3;
} else{
	StatementN;
}
Else-if ifadəsi müəyyən bir şərt ödənmədikdə verilə biləcək digər şərtə uyğun prosesin işə salınması üçün istifadə edilir





Loop Statements
Loop(dövr) qarşıya qoyulmuş məsələni müəyyən şərt daxilində müəyyən say qədər yerinə yetirmək üçün istifadə edilir.

While
while(condition) {

	Statement;
}
Şərtimiz doğru olduğu müddətcə blok daxilindəki ifadə yerinə yetiriləcək. Bu da o deməkdir ki ilk olaraq hər dəfə gedib şərt yoxlanılacaq və true dəyər qayıdarsa prosess yerinə yetiriləcək.Bu səbəbdən While’a həm də ön şərtli dövr operatoru deyilir.

Do While
do{
	Statement;
}while(condition)
Do while ilə while’ın fərqi odur ki, do while zamanı şərt yoxlanılmadan ilk başda proses 1 dəfə yerinə yetirilir daha sonra şərt yoxlanılır. Bu da o deməkdir ki verilən condition false olsa, while loop’da proses heç vaxt yerinə yetirilməyəcək amma do while’da isə proses 1 dəfə yerinə yetiriləcək.  Bu səbəbdən Do While’a həm də son şərtli dövr operatoru deyilir.

For
for(dataType variable; condition; process1){
	Process2;
}
For loop’u 3 hissəyə bölünür 1-ci hissə dəyişən təyin etmək üçün,  2-ci hissə şərt vermək üçün və sonuncu hissə müəyyən bir əməliyyatı yerinə yetirmək üçün istifadə olunur.Şərt ödəndiyi bütün hallarda For loop’un bloku daxilindəki proses işə düşür.

for(;;){
	Process;
}
Bu yazılış infinite for loop adlanır. Müəyyən şərt daxilində loop break olunmazsa sonsuzadək davam edəcək.


Break
Break keyword’ü müəyyən bir şərt daxilində loop’ları sonlandırmaq üçün və ya switch’dən çıxmaq üçün istifadə olunan bir ifadədir.

Continue
Continue keyword’ü vasitəsi ilə biz müəyyən şərt daxilində işləndiyi sətrdən sonra ki əməliyyatlar yerinə yetirilmədən loop’un əvvəlinə qayıtmaq üçün istifadə edilir.
Continue keyword’dən fərqli olaraq break keyword’ü loop’la yanaşı switch daxilində də işlənilir

