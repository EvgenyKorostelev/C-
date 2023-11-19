Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
sum = (number / 100 + number % 10);
Console.WriteLine($"Сумма первой и последней цифры трехзначного числа `{sum}`");