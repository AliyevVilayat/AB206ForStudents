
Default Value (Optional parameter)
Method’a hər hansısa parametr təyin edən zaman biz bu parametr’ə default bir dəyər mənimsədə bilərik. Yəni biz method’u call edən zaman həmin parametrə uyğun olaraq bir arqument göndərməsək avtomatik olaraq default value mənimsədiləcək. Əks təqdirdə yeni dəyər set olunacaq və default value override ediləcək. Optional parametrlər, tələb olunan bütün parametrlərdən sonra yazılmalıdır, params xaric. Yəni sondan əvvələ doğru sıralanmalıdır. Əks təqdirdə errorla qarşılaşacağıq.

Params
Method yaranan zaman eyni type’dan neçə parametr təyin etməli olduğumuzu bilməyə bilərik. Bu problemin qarışısını almaq üçün params’dan istifadə etməliyik. Sadəcə göndərməli olduğumuz type array yaratmalı və qarşısına param yazmalıyıq. Beləliklə eyni type’dan istənilən qədər arqument göndərə bilərik. Avtomatik olaraq göndərilən arqumentlər bir array halına salınacaq. Bir method üçün yalnız 1 params parameter təyin etmək mümkündür. Params olaraq təyin olunan parametrlər, yalnız bütün parametrlərdən sonra yazıla bilər.
