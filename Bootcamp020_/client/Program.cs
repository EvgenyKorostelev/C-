using System.Net.Http;
using Newtonsoft.Json;

HttpClient hc = new HttpClient();

string res1 = hc.GetStringAsync("http://localhost:5201/worker/getworker/2").Result;

Worker w = JsonConvert.DeserializeObject<Worker>(res1);

System.Console.WriteLine(w.FirstName);
System.Console.WriteLine(w.Age);
