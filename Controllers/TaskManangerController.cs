using Microsoft.AspNetCore.Mvc;
using TaskMananger.Application.Tasks.UseCases.Delete;
using TaskMananger.Application.Tasks.UseCases.GetAll;
using TaskMananger.Application.Tasks.UseCases.GetById;
using TaskMananger.Application.Tasks.UseCases.Register;
using TaskMananger.Application.Tasks.UseCases.Update;
using TaskMananger.Communication.Requests;
using TaskMananger.Communication.Responses;

namespace TaskMananger.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskManangerController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]

    public IActionResult Create([FromBody] RequestRegisterTaskJson request)
    {
        var useCase = new RegisterTaskUseCase();

        var response = useCase.Execute(request);        

        return Created(string.Empty, response);
    }


    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTasksJson), StatusCodes.Status200OK)]    
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public IActionResult GetAll()
    {
        var useCase = new GetAllTasksUseCase();

        var response = useCase.Execute();

        if (response.Tasks.Any())
        {
            return Ok(response);
        }
        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public IActionResult GetById(int id)
    {
        var useCase = new GetTaskByIdUseCase();

        var response = useCase.Execute(id);

       
            return Ok(response);
    }


    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public IActionResult Update([FromRoute] int id, [FromBody] RequestRegisterTaskJson request)
    {
        var useCase = new UpdateTaskByIdUseCase();

        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public IActionResult Delete(int id)
    {
        var useCAse = new DeleteByIdUseCase();

        useCAse.Execute(id);

        return NoContent();
    }

}
