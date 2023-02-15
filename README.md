<div>
  <h2>:hammer:&nbsp Architecture</h2>
  <p>
    The project is divided into three bounded contexts (microservices).
  </p>
  <p>
    <h3>FitUp.ExercisesService:</h3>
    &nbsp● FitUp.ExercisesService (Web API) </br>
    &nbsp● FitUp.ExercisesService.DataModel </br>
    &nbsp&nbsp&nbsp- Models</br>
    &nbsp&nbsp&nbsp- Data</br>
    &nbsp&nbsp&nbsp- Common</br>
    &nbsp&nbsp&nbsp- Helpers</br>
    &nbsp&nbsp&nbsp- Seeder</br>
    &nbsp● FitUp.ExercisesService.DAL </br>
    &nbsp&nbsp&nbsp- Repositories</br>
    &nbsp&nbsp&nbsp- Helpers</br>
    &nbsp● FitUp.ExercisesService.Domain </br>
    &nbsp&nbsp&nbsp- Services</br>
    &nbsp&nbsp&nbsp- DTOs</br>
    &nbsp&nbsp&nbsp- Mapper</br>
    &nbsp&nbsp&nbsp- Common</br>
    &nbsp&nbsp&nbsp- Helpers</br>
    &nbsp● FitUp.ExercisesService.UnitTests </br>
    &nbsp&nbsp&nbsp- Controllers</br>
    &nbsp&nbsp&nbsp- Services</br>
  </p>
  
  <p>
    <h3>ProgramsService:</h3>
    &nbsp● FitUp.ProgramsService (Web API) </br>
    &nbsp● FitUp.ProgramsService.DataModel </br>
    &nbsp&nbsp&nbsp- Models</br>
    &nbsp&nbsp&nbsp- Data</br>
    &nbsp&nbsp&nbsp- Common</br>
    &nbsp&nbsp&nbsp- Helpers</br>
    &nbsp&nbsp&nbsp- Seeder</br>
    &nbsp● FitUp.ProgramsService.DAL </br>
    &nbsp&nbsp&nbsp- Repositories</br>
    &nbsp&nbsp&nbsp- Helpers</br>
    &nbsp● FitUp.ProgramsService.Domain </br>
    &nbsp&nbsp&nbsp- Services</br>
    &nbsp&nbsp&nbsp- DTOs</br>
    &nbsp&nbsp&nbsp- Mapper</br>
    &nbsp&nbsp&nbsp- Common</br>
    &nbsp&nbsp&nbsp- Helpers</br>
    &nbsp● FitUp.ProgramsService.UnitTests </br>
    &nbsp&nbsp&nbsp- Controllers</br>
    &nbsp&nbsp&nbsp- Services</br>
  </p>
  
  <p>
    <h3>ProgressionService:</h3>
    &nbsp● FitUp.ProgressionService (Web API) </br>
    &nbsp● FitUp.ProgressionService.DataModel </br>
    &nbsp&nbsp&nbsp- Models</br>
    &nbsp&nbsp&nbsp- Data</br>
    &nbsp&nbsp&nbsp- Common</br>
    &nbsp&nbsp&nbsp- Helpers</br>
    &nbsp&nbsp&nbsp- Seeder</br>
    &nbsp● FitUp.ProgressionService.DAL </br>
    &nbsp&nbsp&nbsp- Repositories</br>
    &nbsp&nbsp&nbsp- Helpers</br>
    &nbsp● FitUp.ProgressionService.Domain </br>
    &nbsp&nbsp&nbsp- Services</br>
    &nbsp&nbsp&nbsp- DTOs</br>
    &nbsp&nbsp&nbsp- Mapper</br>
    &nbsp&nbsp&nbsp- Common</br>
    &nbsp&nbsp&nbsp- Helpers</br>
    &nbsp● FitUp.ProgressionService.UnitTests </br>
    &nbsp&nbsp&nbsp- Controllers</br>
    &nbsp&nbsp&nbsp- Services</br>
  </p>
  
  </br>
  </br>
  <h2>The project architecture also can be:</h2> (Example for ane bounded context)
  <p>
    <h3>FitUp.ExercisesService:</h3>
    &nbsp● FitUp.ExercisesService (Web API) </br>
    &nbsp● Data </br>
    &nbsp&nbsp&nbsp- FitUp.ExercisesService.Models</br>
    &nbsp&nbsp&nbsp- FitUp.ExercisesService.Data</br>
    &nbsp&nbsp&nbsp- FitUp.ExercisesService.Common</br>
    &nbsp&nbsp&nbsp- FitUp.ExercisesService.Helpers</br>
    &nbsp&nbsp&nbsp- FitUp.ExercisesService.Seeder</br>
    &nbsp● DAL </br>
    &nbsp&nbsp&nbsp- FitUp.ExercisesService.DAL.Repositories</br>
    &nbsp&nbsp&nbsp- FitUp.ExercisesService.DAL.Helpers</br>
    &nbsp● Services </br>
    &nbsp&nbsp&nbsp- FitUp.ExercisesService.Services.Data </br>
    &nbsp&nbsp&nbsp- FitUp.ExercisesService.Services.DTOs </br>
    &nbsp&nbsp&nbsp- FitUp.ExercisesService.Services.Mapper</br>
    &nbsp&nbsp&nbsp- FitUp.ExercisesService.Services.Common</br>
    &nbsp&nbsp&nbsp- FitUp.ExercisesService.Services.Helpers</br>
    &nbsp● Tests </br>
    &nbsp&nbsp&nbsp- FitUp.ExercisesService.Tests.Controllers</br>
    &nbsp&nbsp&nbsp- FitUp.ExercisesService.Tests.Services</br>
  </p>
</div>
