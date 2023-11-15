double distans = 1000;
int speedFfirst = 2;
int speedFsecond = 5;
int speedDog = 12;
int friend = 2;
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

