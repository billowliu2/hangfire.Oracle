using System;

namespace Uinfor.Hangfire.Oracle.Entities
{
    internal class Server
    {
        public string Id { get; set; }
        public string Data { get; set; }
        public DateTime LastHeartbeat { get; set; }
    }
}