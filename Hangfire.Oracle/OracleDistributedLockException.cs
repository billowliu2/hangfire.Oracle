using System;

namespace Uinfor.Hangfire.Oracle
{
    public class OracleDistributedLockException : Exception
    {
        public OracleDistributedLockException(string message) : base(message)
        {
        }
    }
}
