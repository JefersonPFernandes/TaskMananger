using TaskMananger.Communication.Requests;
using TaskMananger.Communication.Responses;

namespace TaskMananger.Application.Tasks.UseCases.Register;
public class RegisterTaskUseCase
{
    public ResponseRegisteredTaskJson Execute (RequestRegisterTaskJson request)
    {
        return new ResponseRegisteredTaskJson
        {
            Id = request.Id,
            Name = request.Name,            
        };
    }
}
