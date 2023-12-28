
// Worker w = new()
// {
//     Id = 0,
//     Age = 22,
//     Salary = 1111,
//     FirstName = "Вася",
//     LastName = "Васечкин"
// };


// // Create
// Repository.Append(w);
// Repository.Append(new() {Id = 1, Age = 25, Salary = 2222, FirstName = "Маша", LastName = "Васечкинина"});
// Repository.Append(new() {Id = 2, Age = 26, Salary = 3333, FirstName = "Юля", LastName = "Петрова"});
// Repository.Append(new() {Id = 3, Age = 27, Salary = 4444, FirstName = "Петя", LastName = "Алексеев"});
// Repository.Append(new() {Id = 4, Age = 28, Salary = 5555, FirstName = "Юра", LastName = "Гагарин"});

// Worker w1 = Repository.Read(1);
// string json = new WorkerConverter().ToJson(w1);
// Console.WriteLine(json);

//=======================================================

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();
app.MapControllers();
app.Run();

//========================================================

// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.
// // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.UseHttpsRedirection();

// var summaries = new[]
// {
//     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
// };

// app.MapGet("/weatherforecast", () =>
// {
//     var forecast =  Enumerable.Range(1, 5).Select(index =>
//         new WeatherForecast
//         (
//             DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
//             Random.Shared.Next(-20, 55),
//             summaries[Random.Shared.Next(summaries.Length)]
//         ))
//         .ToArray();
//     return forecast;
// })
// .WithName("GetWeatherForecast")
// .WithOpenApi();

// app.Run();

// record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
// {
//     public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
// }
