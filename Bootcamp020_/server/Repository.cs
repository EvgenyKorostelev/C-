public static class Repository
{
    static List<Worker> db;
    static Repository()
    {
        db = new();
        
        Worker w = new()
        {
            Id = 0,
            Age = 22,
            Salary = 1111,
            FirstName = "Вася",
            LastName = "Васечкин"
        };


        // Create
        Repository.Append(w);
        Repository.Append(new() { Id = 1, Age = 25, Salary = 2222, FirstName = "Маша", LastName = "Васечкинина" });
        Repository.Append(new() { Id = 2, Age = 26, Salary = 3333, FirstName = "Юля", LastName = "Петрова" });
        Repository.Append(new() { Id = 3, Age = 27, Salary = 4444, FirstName = "Петя", LastName = "Алексеев" });
        Repository.Append(new() { Id = 4, Age = 28, Salary = 5555, FirstName = "Юра", LastName = "Гагарин" });
    }
    //+
    public static void Append(Worker w) => db.Add(w);
    //+
    public static Worker Read(int id) => db[id];
    public static Worker[] Read() => db.ToArray();
    public static bool Update(int id, Worker w) { db[id] = w; return true; }
    public static void Delete(int id) => db.RemoveAt(id);
}