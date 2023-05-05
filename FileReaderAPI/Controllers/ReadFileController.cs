using FileReaderAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileReaderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReadFileController : Controller
    {
        private readonly IReadFileService _service;
        private readonly ILogger<ReadFileController> _logger;

        public ReadFileController(ILogger<ReadFileController> logger, IReadFileService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        // GET: ReadFileController
        public ActionResult GetAll()
        {
            var result = new ReadFileService().GetAll();
            return StatusCode(200, result);
        }

        // GET: ReadFileController/5
        [HttpGet("{id}")]
        public ActionResult GetOrder([FromQuery]string id)
        {
            var result = new ReadFileService().GetOrder(id);
            return StatusCode(200, result);
        }
    }
}
