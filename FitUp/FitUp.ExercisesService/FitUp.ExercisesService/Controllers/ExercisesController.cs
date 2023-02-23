namespace FitUp.ExercisesService.Controllers
{
    using FitUp.Controllers;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using System.IO;

    [Route("api/[controller]")]
    [ApiController]
    public class ExercisesController : ApiController
    {
        private readonly ILogger<ExercisesController> logger;

        public ExercisesController(ILogger<ExercisesController> logger)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(this.logger));
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Get()
        {
            string text = System.IO.File.ReadAllText("C:\\Users\\User\\Documents\\GitHub\\FitUp-ASP.NET-Core-Microservices-Project\\FitUp\\FitUp.ExercisesService\\FitUp.ExercisesService.DataModel\\bin\\Debug\\net7.0\\exercises-microservice-settings.json");
            this.logger.LogInformation(text);
            return null;
        }
    }
}
