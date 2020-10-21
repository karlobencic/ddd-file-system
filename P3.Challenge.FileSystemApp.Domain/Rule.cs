namespace P3.Challenge.FileSystemApp.Domain
{
    public class Rule
    {
        public string Code { get; }
        public string Message { get; }

        public Rule(string code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}
