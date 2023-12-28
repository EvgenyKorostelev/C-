using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers;

//  R   C     D     U
// get post delete put
[ApiController]
//url/worker/getworker
[Route("[controller]")]
public class WorkerController : ControllerBase
{
    [HttpGet]
    [Route("getworker")]
    public Worker[] Get() => Repository.Read();

    [HttpGet]
    [Route("getworker/{id}")]
    public Worker Get(int id) => Repository.Read(id);
}