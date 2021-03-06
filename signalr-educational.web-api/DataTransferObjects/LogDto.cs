using System;

namespace SignalR.Educational.WebApi.DataTransferObjects
{
    public class LogDto
    {
        public DateTime DateTime { get; set; }
        public string Message { get; set; }
        public string MachineName { get; set; }
    }
}
