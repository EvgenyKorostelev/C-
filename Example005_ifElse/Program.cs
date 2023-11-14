Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "ami")
{
    Console.WriteLine("И где ты была?");
}
else
{
    Console.Write("Привет: ");
    Console.Write(username);
}