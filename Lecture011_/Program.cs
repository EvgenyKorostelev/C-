// Напишите программу, 
// которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//Console.Write("Введите целое число: ");
//int num = Convert.ToInt32(Console.ReadLine());

//int Func(int sum)
//{
//    int sum = 0;
//    int n = 1;
//    while(n <= num)
//    num = 1 + n;
//    n++;
//    return sum;
//}
//int vivod = Func(num);
//Console.Write(vivod);

//-----------------------------------------------------------------------------
int NunFunc(int first){
    int sum = 0;
    for(int i=1;i<=first;i++){
        sum+=i;
    }
    return sum;

}

Console.WriteLine("enter numb");
int num = Convert.ToInt32(Console.ReadLine());
int res = NunFunc(num);
Console.WriteLine(res);
//------------------------------------------------------------------------------
Console.WriteLine("enter numb");
int num = Convert.ToInt32(Console.ReadLine());
int res = NunFunc(num);
Console.WriteLine(res);

void NunFunc(int first){
    int sum = 0;
    for(int i=1;i<=first;i++){
        sum+=i;
    }
    Console.WriteLine(sum);

}

Console.WriteLine("enter numb");
int num = Convert.ToInt32(Console.ReadLine());
NunFunc(num);