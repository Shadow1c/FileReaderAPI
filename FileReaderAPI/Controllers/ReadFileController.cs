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
            try
            {
                var result = _service.GetAll();
                return StatusCode(200, result);
            }
            catch (Exception ex) 
            {
                return StatusCode(400, "Error");
            }
        }

        // GET: ReadFileController/5
        [HttpGet("{id}")]
        public ActionResult GetOrder([FromRoute]string id)
        {
            try
            {
                var result = _service.GetOrder(id);
                return StatusCode(200, result);
            }
            catch(Exception ex)
            {
                return StatusCode(404, "Not Found");
            }
        }
    }
}
