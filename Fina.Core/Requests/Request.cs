namespace Fina.Core.Requests

public abstract class Request //classe abstrata n�o pode ser instanciada, apenas herdada.
{
    public string UserId { get; set; } = string.Empty;
}
