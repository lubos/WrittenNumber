﻿namespace WrittenNumber.Models;

public class Option
{
    public string Lang { get; set; } = "en";
    public bool NoAnd { get; set; } = false;
    public string? AlternativeBase { get; set; } = null;
}