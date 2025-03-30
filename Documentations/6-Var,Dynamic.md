Var
Var keyword’ü ilə variable’a value mənimsədildiyi zaman compile zamanı datatype müəyyən edilir. Biz həmin variable’a başqa bir yerdə fərqli datatype’dan bir value mənimsədə bilmərik. Bunu etsək compile time error verəcək. Əlavə olaraq var keyword’ü ilə variable yaranan zaman dəyər mütləq assign edilməlidir ki, compile zamanı hansı datatype’da bir variable olacağı bəlli olsun. Əks təqdirdə compile time error verəcək.
Bu keyword’ün yaradılma məqsədi fərqli dillər arasında dəstəklənməyən datatype dəyişənləri saxlamaq üçün ortaq keyword olsa da, günümüzdə istifadə məqsədi dəyişənin type’nı yazmağa tənbəllik etməkdir. Compiler’a əlavə iş gördürməmək üçün type’nı bildiyimiz dəyişənləri var keyword’ü ilə təyin etməməliyik.
Var ilə object arasındaki fərq odur ki, var keyword’dür, object isə type’dır. var ilə təyin etdiyimiz dəyişən stack yaddaşda saxlanılır, lakin object type dəyişən yaddaşda object şəklində saxlanacaq və daxilində həmin dəyəri saxlayacaq. Boxing etdiyimiz üçün unboxing edərək həmin dəyəri istifadə edə bilərik.
Var açar sözü ilə field & property təyin etmək olmur.

Dynamic
Dynamic keyword’ü ilə assign olunmuş variable’a hər dəfə müxtəlif datatype dəyər mənimsədilə bilər. Runtime olaraq datatype mənimsədildiyi üçün var keyword’dən fərqlənir və onun runtime versiyasıdır.
