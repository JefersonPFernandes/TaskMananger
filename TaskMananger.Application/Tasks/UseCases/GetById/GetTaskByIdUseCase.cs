using TaskMananger.Communication.Responses;

namespace TaskMananger.Application.Tasks.UseCases.GetById;
public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int Id)
    {
        return new ResponseTaskJson
        {
            Id = Id,
            Name = "Varrer",
            Description = "Varrer a calçada",
            Priority = Communication.Enums.Priority.Média,
            DeadLine = new DateTime(year: 2025, month: 06, day: 20),
            Status = Communication.Enums.Status.Aguardando
        };
    }
}
