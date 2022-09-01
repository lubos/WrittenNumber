using System;

namespace WrittenNumber.Models
{
    public sealed class Currency
    {
        public string? One { get; set; }
        public string? Two { get; set; }
        public string? Few { get; set; }
        public string? Many { get; set; }
        public string? Other { get; set; }

        public string Get(long value)
        {
            if (value == 1) return One ?? Other;
            else if (value == 2) return Two ?? Other;
            else if (value < 5) return Few ?? Other;
            else if (value < 10) return Many ?? Other;
            return Other;
        }
    }
}
