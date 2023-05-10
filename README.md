# Lambda Warmer

Реализация [lambda-warmer](https://github.com/jeremydaly/lambda-warmer) на .NET

### Установка

Установите Lambda Warmer из Nuget как зависимость проекта

```shell
dotnet add package LambdaWarmer --version 1.0.0
```

### Использование

1. Удалите `LambdaSerializer` аттрибут сборки. Это важно!
2. Отнаследуйте вашу функцию от `WarmerFunction<TRequest, TResponse>`
3. Реализуйте вашу бизнес логику в методе `InternalFunctionHandlerAsync`
4. Логику прогрева опишите в `InternalWarmUpAsync`
5. В настройках лямбды handler укажите как `FunctionHandlerAsync`. Это важно!
6. Настройте CloudWatch Events триггер с body:
    ```json
    {
      "warmer": true,
      "concurrency": 69
    }
    ```

### Пример

В проекте `LambdaWarmer.TestFunction` реализована простая лямбда
