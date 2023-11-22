
Console.WriteLine("Введите точку X, X не может быть равен 0");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку Y, Y не может быть равен 0");
int y = Convert.ToInt32(Console.ReadLine());


if (x > 0 && y > 0)
{
   Console.WriteLine($"Точка ({x},{y}) находится в I координатной четверти плоскости");
}
if (x > 0 && y < 0)
{
  Console.WriteLine($"Точка ({x},{y}) находится в IV координатной четверти плоскости");
}
if (x < 0 && y < 0)
{
  Console.WriteLine($"Точка ({x},{y}) находится в III координатной четверти плоскости");
}
if (x < 0 && y > 0)
{
  Console.WriteLine($"Точка ({x},{y}) находится во II координатной четверти плоскости");
}
if (x == 0 && y == 0)
{
  Console.WriteLine($"Точка ({x},{y}) некорректо введены исходные данные, перезапустите программу");
}