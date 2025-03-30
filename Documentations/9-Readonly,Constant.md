Readonly
Readonly dedikdə hər hansa bir field’a və ya property’ə dəyər assign olunmasının(set olunmasının) qarşısını almaq, yalnızca dəyəri oxuna bilməsini(get oluna bilməsini) təmin etmək məqsədi ilə istifadə olunan bir anlayış başa düşülür. Readonly anlayışı field & property’lərə tətbiq edilir. Readonly field & property’ə yalnız təyin olunduğu yerdə və Constructor daxilində dəyər mənimsədilə bilər(başqa bir yerdə dəyər assign edilən zaman compile time olan readonly errorla qarşılaşırıq). Lakin istənilən yerdə dəyəri oxuna bilər. Readonly field & property təyin olduğu yerdə dəyər assign olunmasa da olar.
Field’ın Readonly olması üçün biz field təyin olunan zaman “readonly” keyword’dən istifadə etməliyik. Property’in Readonly olması üçün isə property təyin olunan zaman sadəcə get method’u yazılır, set method’u təyin edilmir.


Constant
Constant dedikdə hər hansısa bir field’ın constant bir dəyərə sahib olması və heç bir situasiyada dəyişilə bilməməsi başa düşülür. Readonly’dən fərqli olaraq yalnız field’lara şamil olunur, və mütləq təyin olunduğu yerdə dəyər assign olunmalıdır. Əks təqdirdə compile time error verir. Const olaraq təyin olunan Field’lar implicitly olaraq static olur. Local variable-lar da const olaraq işarələnə bilər.
