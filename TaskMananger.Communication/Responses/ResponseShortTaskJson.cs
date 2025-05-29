using TaskMananger.Communication.Enums;

namespace TaskMananger.Communication.Responses;
public class ResponseShortTaskJson
{
    public int Id {  get; set; }
    public string Name { get; set; } = string.Empty;
    public Status Status { get; set; }

}
