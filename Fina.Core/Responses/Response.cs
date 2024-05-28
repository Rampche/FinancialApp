using System

namespace Fina.Core.Response



public class Response<TData> {

    private int _code = Configuration.DefaultStatusCode;

    [JsonConstructor]
    public Response() {
        => _code = Configuration.DefaultStatusCode;

    }

    public Response(
        TData? data, 
        int code = Configuration.DefaultStatusCode,
            string? message = null) 
        {
        Data = data;
        _code = code;
        Message = message;
    }

    public object? TData { get; set; }
    public string? Message;

    [JsonIgnore]
    private bool IsSuccess => _code is >= 200 and <= 299;
}
