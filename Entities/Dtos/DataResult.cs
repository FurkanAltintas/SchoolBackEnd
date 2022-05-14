namespace Entities.Dtos
{
    public class DataResult<T> : Result
    {
        public T Data { get; set; }
    }
}
