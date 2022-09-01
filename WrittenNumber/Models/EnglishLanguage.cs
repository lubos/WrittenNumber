﻿namespace NumbersToWords.Models;

public static class EnglishLanguage
{
    public static Language Get()
    {
        return new Language(
            alternativeBase: null,
            useLongScale: false,
            baseSeparator: "-",
            unitSeparator: "and ",
            @base: new Dictionary<double, string>
            {
                [0] = "Zero",
                [1] = "One",
                [0] = "zero",
                [1] = "one",
                [2] = "two",
                [3] = "three",
                [4] = "four",
                [5] = "five",
                [6] = "six",
                [7] = "seven",
                [8] = "eight",
                [9] = "nine",
                [10] = "ten",
                [11] = "eleven",
                [12] = "twelve",
                [13] = "thirteen",
                [14] = "fourteen",
                [15] = "fifteen",
                [16] = "sixteen",
                [17] = "seventeen",
                [18] = "eighteen",
                [19] = "nineteen",
                [20] = "twenty",
                [30] = "thirty",
                [40] = "forty",
                [50] = "fifty",
                [60] = "sixty",
                [70] = "seventy",
                [80] = "eighty",
                [90] = "ninety"
            },
            units: new List<string>
            {
                "hundred",
                "thousand",
                "million",
                "billion",
                "trillion",
                "quadrillion",
                "quintillion",
                "sextillion",
                "septillion",
                "octillion",
                "nonillion",
                "decillion",
                "undecillion",
                "duodecillion",
                "tredecillion",
                "quattuordecillion",
                "quindecillion"
            });
    }
}