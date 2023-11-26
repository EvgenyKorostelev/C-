// Метод 1
void Method01()
{
    Console.WriteLine("Автор: KorostelevEV");
}
// вызов метода Method01();

//Метод 2
void Method02(string msg)
{
    Console.WriteLine(msg);
}
// вызов метода Method02(msg: "Привет");

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
    Console.WriteLine(msg);
    i++;
    }
}
// вызов метода Method21(msg: "Привет",count: 4);
// вызов метода Method21(count: 4, msg: "Привет");

//Метод 3
int Method03()
{
    return DateTime.Now.Year;
}
// вызов метода int year = Method03();
// вызов метода Console.WriteLine(year);

//Метод 4
string Method04(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
// вызов метода string res = Method04(10, "rwweqetwewq ");
// вызов метода Console.WriteLine(res);