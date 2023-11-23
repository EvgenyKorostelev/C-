//Console.Write("Введите целое число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//int count = 1;
//while(num>10)
//{
//    num = num /10;
//    count++;
//}
//Console.Write(count);

//---------------------------------------------------------------------
void NumCount(int num){
    int count = 0;
    while(num>0){
        count++;
        num /= 10;
    }
    Console.WriteLine($"Sum of digits is {count}");
}

Console.WriteLine("Enter your num");
int num = Convert.ToInt32(Console.ReadLine());
NumCount(num);