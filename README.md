# Lambda Warmer

Реализация [lambda-warmer](https://github.com/jeremydaly/lambda-warmer) на .NET

### Установка

Установите Lambda Warmer из Nuget как зависимость проекта

### Использование

1. Удалите `LambdaSerializer` аттрибут сборки. Это важно!
2. Отнаследуйте вашу функцию от `WarmerFunction<TRequest, TResponse>`
3. Реализуйте вашу бизнес логику в методе `InternalFunctionHandlerAsync`
4. Логику прогрева опишите в `InternalWarmUpAsync`
5. В настройках лямбды handler укажите как `FunctionHandlerAsync`. Это важно!

### Пример

В проекте LambdaWarmer.Function реализована простая лямбда