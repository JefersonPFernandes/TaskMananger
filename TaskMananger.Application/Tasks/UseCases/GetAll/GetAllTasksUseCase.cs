using TaskMananger.Communication.Responses;

namespace TaskMananger.Application.Tasks.UseCases.GetAll;
public class GetAllTasksUseCase
{
    public ResponseAllTasksJson Execute()
    {
        return new ResponseAllTasksJson()
        {
            Tasks = new List<ResponseShortTaskJson>
            {
                new ResponseShortTaskJson
                {
                Id = 1,
                Name = "Varrer",
                Status = Communication.Enums.Status.Aguardando
                }
            }
        };
    }
}
