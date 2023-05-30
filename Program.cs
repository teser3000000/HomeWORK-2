Console.WriteLine("Вывод на экран всех нечетных чисел в диапозоне от 1 до 100:");
for (int i = 0; i <= 100; i++) if (i % 2 != 0) Console.Write($" {i}");

Console.Write("\nПервые 10 чисел Фибоначчи: 0 1");
for (int i = 0, fibonacciNumbersFirst = 0, fibonacciNumbersTwelve = 1, resultOfMultiplication; i <= 7; i++)
{
    resultOfMultiplication = fibonacciNumbersFirst + fibonacciNumbersTwelve;
    fibonacciNumbersFirst = fibonacciNumbersTwelve;
    fibonacciNumbersTwelve = resultOfMultiplication;
    Console.Write($" {resultOfMultiplication}");
}

//В какой день суммарный пробег лыжника превысит 100k
Console.WriteLine("\n");
for (double i = 2, mileage = 10; mileage <= 100; i++)
{
    mileage += mileage * (10f / 100);
    Console.Write($"\n День {i} -- {Math.Round(mileage, 2)}");
}
