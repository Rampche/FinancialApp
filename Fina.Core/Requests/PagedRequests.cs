namespace Fina.Core.Requests;


public abstract class PagedRequests : Request
{
    public int PageSize {  get; set; }
    public int PageNumber { get; set; }
}