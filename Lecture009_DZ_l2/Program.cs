Console.Write("Введите целое натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arrey;
arrey = new int[50];
int i = 0;

if (num < 10)
{
    Console.WriteLine(num);
} 
else
  while (num > 10)
  {
    arrey[i] = num % 10;
    num = num / 10; // num /= 10;
    i++;
    if(num < 10)
    {
      arrey[i] = num;  
    }
  }
 
int count = arrey.Length;
while(i < count && i > 0)
{
  Console.Write($"{arrey[i]}, ");
  i--;
  if(i == 0)
 {
   Console.Write($"{arrey[i]}");
 }
}
