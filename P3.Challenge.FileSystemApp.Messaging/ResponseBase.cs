﻿using System;
using System.Collections.Generic;

namespace P3.Challenge.FileSystemApp.Messaging
{
    public abstract class ResponseBase<T> where T : RequestBase
    {
        public Guid ResponseToken { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Request { get; set; }

        public List<ResponseStatus> Statuses { get; set; }

        protected ResponseBase()
        {
            Statuses = new List<ResponseStatus>();
        }
    }
}
