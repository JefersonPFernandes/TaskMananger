using TaskMananger.Communication.Enums;

namespace TaskMananger.Communication.Responses;
public class ResponseRegisteredTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;    
    
}
