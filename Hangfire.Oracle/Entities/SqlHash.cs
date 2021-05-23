﻿using System;

namespace Uinfor.Hangfire.Oracle.Entities
{
    internal class SqlHash
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Field { get; set; }
        public string Value { get; set; }
        public DateTime? ExpireAt { get; set; }
    }
}
