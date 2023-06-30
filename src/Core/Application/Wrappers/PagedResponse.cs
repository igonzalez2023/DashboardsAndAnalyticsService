namespace Application.Wrappers;

public class PagedResponse<T> : Response<T>
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }

    public PagedResponse(T data, int pageNumber, int pageSize) : base(data)
    {
        PageNumber=pageNumber;
        PageSize=pageSize;
    }
}