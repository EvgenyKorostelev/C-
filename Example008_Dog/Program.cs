Console.WriteLine("Введите Расстояние: ");
double distans = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите скорость 1-ого друга: ");
int speedFfirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите скорость 2-ого друга: ");
int speedFsecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите скорость собаки: ");
int speedDog = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите к какому другу бежит собака 1 или 2: ");
int friend = Convert.ToInt32(Console.ReadLine());
int count = 0;
double time = 0;

while(distans > 10)
{
    if(friend == 2)
    {
        time = distans / (speedFsecond + speedDog);
        distans = distans - time * (speedFfirst + speedFsecond);
        count++;
        friend = 1;
    }
    else
    {
        time = distans / (speedFfirst + speedDog);
        distans = distans - time * (speedFfirst + speedFsecond);
        count++;
        friend = 2;
    }
}
Console.WriteLine($"Дистанция: {distans}");
Console.Write($"Собака пробежала раз: {count}");

