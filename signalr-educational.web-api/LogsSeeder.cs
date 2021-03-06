using SignalR.Educational.WebApi.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SignalR.Educational.WebApi
{
    public static class LogsSeeder
    {
        public static IEnumerable<LogDto> GetLogs()
        {
            var random = new Random();
            var logs = new List<LogDto>
            {
                new LogDto { DateTime = DateTime.UtcNow.AddDays(-1), Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."},
                new LogDto { DateTime = DateTime.UtcNow.AddDays(-2), Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."},
                new LogDto { DateTime = DateTime.UtcNow.AddDays(-3), Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."},
                new LogDto { DateTime = DateTime.UtcNow.AddDays(-4), Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."},
                new LogDto { DateTime = DateTime.UtcNow.AddDays(-5), Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."},
                new LogDto { DateTime = DateTime.UtcNow.AddDays(-6), Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."},
                new LogDto { DateTime = DateTime.UtcNow.AddDays(-7), Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."},
                new LogDto { DateTime = DateTime.UtcNow.AddDays(-8), Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."},
                new LogDto { DateTime = DateTime.UtcNow.AddDays(-9), Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."},
                new LogDto { DateTime = DateTime.UtcNow.AddDays(-10), Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."}
            };

            return logs.Skip(random.Next(1, 5)).Take(random.Next(1, 5));
        }
    }
}
