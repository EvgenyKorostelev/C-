Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Func(int numberTemp)
{
   int count = 0;
   while(numberTemp>10)
   {
       numberTemp = numberTemp /10;
       count++;
   }
   count++;
   Console.Write(count);
}

Console.Write($"Количество цифр в числе {num}: ");
Func(num);

//---------------------------------------------------------------------
//void NumCount(int num){
//    int count = 0;
//    while(num>0){
//        count++;
//        num /= 10;
//    }
//    Console.WriteLine($"Sum of digits is {count}");
//}

//Console.WriteLine("Enter your num");
//int num = Convert.ToInt32(Console.ReadLine());
//NumCount(num);