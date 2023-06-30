namespace Application.Wrappers;

public class Response<T>
{
    public Response(T data)
    {
        Data = data;
        Succeeded = true;
    }

    public bool Succeeded { get; set; }
    public T Data { get; set; }
}