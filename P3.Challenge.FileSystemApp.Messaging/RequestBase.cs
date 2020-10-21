using System;

namespace P3.Challenge.FileSystemApp.Messaging
{
    public abstract class RequestBase
    {
        public Guid RequestToken { get; set; }
    }
}
