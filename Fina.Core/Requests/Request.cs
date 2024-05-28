namespace Fina.Core.Requests

public abstract class Request //classe abstrata não pode ser instanciada, apenas herdada.
{
    public string UserId { get; set; } = string.Empty;
}
