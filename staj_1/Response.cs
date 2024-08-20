namespace staj_1
{
    public class Response
    {
        public string Message { get; set; }
        public object Data { get; set; }
        public Response(string message)
        {
            Message = message;
        }
        public Response(string message, object data)
        {
            Message = message;
            Data = data;

        }
    }
    
}
