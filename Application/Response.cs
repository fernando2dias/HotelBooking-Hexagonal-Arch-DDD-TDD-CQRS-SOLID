namespace Application
{
    public abstract class Response
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public ErrorCodes ErrorCodes { get; set; }

    }

    public enum ErrorCodes
    {
        NOT_FOUND = 1,
        COULDNOT_STORE_DATA = 2,
    }

}
