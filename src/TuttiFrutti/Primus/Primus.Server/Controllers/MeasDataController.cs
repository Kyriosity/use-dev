using Microsoft.AspNetCore.Mvc;

namespace Primus.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MeasDataController : ControllerBase
    {
        [HttpGet(Name = $"Get{nameof(MeasData)}")]
        public IEnumerable<MeasData> Get() {
            return [.. Enumerable.Range(1, 5).Select(id => new MeasData {
                Title = $"Temperature {id}",
                Id = id,
                UnitA = Random.Shared.Next(-20, 55),
            })];
        }
    }
}
