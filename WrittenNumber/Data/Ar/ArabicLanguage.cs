﻿using WrittenNumber.Models;

namespace WrittenNumber.Data.Ar;

public static class ArabicLanguage
{
    public static Language Get()
    {
        return new Language(
            alternativeBase: null,
            useLongScale: false,
            baseSeparator: "",
            unitSeparator: "",
            @base: new Dictionary<double, string>
            {
                [0] = "صفر",
                [1] = "واحد",
                [2] = "اثنان",
                [3] = "ثلاثة",
                [4] = "أربعة",
                [5] = "خمسة",
                [6] = "ستة",
                [7] = "سبعة",
                [8] = "ثمانية",
                [9] = "تسعة",

                [10] = "عشرة",
                [11] = "أحد عشر",
                [12] = "إثنا عشر",
                [13] = "ثلاثة عشر",
                [14] = "أربعة عشر",
                [15] = "خمسة عشر",
                [16] = "ستة عشر",
                [17] = "سبعة عشر",
                [18] = "ثمانية عشر",
                [19] = "تسعة عشر",

                [20] = "عشرون",
                [21] = "واحد وعشرون",
                [22] = "اثنان وعشرون",
                [23] = "ثلاثة وعشرون",
                [24] = "أربعة وعشرون",
                [25] = "خمسة وعشرون",
                [26] = "ستة وعشرون",
                [27] = "سبعة وعشرون",
                [28] = "ثمانية وعشرون",
                [29] = "تسعة وعشرون",

                [30] = "ثلاثون",
                [31] = "واحد وثلاثون",
                [32] = "اثنان وثلاثون",
                [33] = "ثلاثة وثلاثون",
                [34] = "أربعة وثلاثون",
                [35] = "خمسة وثلاثون",
                [36] = "ستة وثلاثون",
                [37] = "سبعة وثلاثون",
                [38] = "ثمانية وثلاثون",
                [39] = "تسعة وثلاثون",

                [40] = "أربعون",
                [41] = "واحد وأربعون",
                [42] = "اثنان وأربعون",
                [43] = "ثلاثة وأربعون",
                [44] = "أربعة وأربعون",
                [45] = "خمسة وأربعون",
                [46] = "ستة وأربعون",
                [47] = "سبعة وأربعون",
                [48] = "ثمانية وأربعون",
                [49] = "تسعة وأربعون",

                [50] = "خمسون",
                [51] = "واحد وخمسون",
                [52] = "اثنان وخمسون",
                [53] = "ثلاثة وخمسون",
                [54] = "أربعة وخمسون",
                [55] = "خمسة وخمسون",
                [56] = "ستة وخمسون",
                [57] = "سبعة وخمسون",
                [58] = "ثمانية وخمسون",
                [59] = "تسعة وخمسون",

                [60] = "ستون",
                [61] = "واحد وستون",
                [62] = "اثنان وستون",
                [63] = "ثلاثة وستون",
                [64] = "أربعة وستون",
                [65] = "خمسة وستون",
                [66] = "ستة وستون",
                [67] = "سبعة وستون",
                [68] = "ثمانية وستون",
                [69] = "تسعة وستون",

                [70] = "سبعون",
                [71] = "واحد وسبعون",
                [72] = "اثنان وسبعون",
                [73] = "ثلاثة وسبعون",
                [74] = "أربعة وسبعون",
                [75] = "خمسة وسبعون",
                [76] = "ستة وسبعون",
                [77] = "سبعة وسبعون",
                [78] = "ثمانية وسبعون",
                [79] = "تسعة وسبعون",

                [80] = "ثمانون",
                [81] = "واحد وثمانون",
                [82] = "اثنان وثمانون",
                [83] = "ثلاثة وثمانون",
                [84] = "أربعة وثمانون",
                [85] = "خمسة وثمانون",
                [86] = "ستة وثمانون",
                [87] = "سبعة وثمانون",
                [88] = "ثمانية وثمانون",
                [89] = "تسعة وثمانون",

                [90] = "تسعون",
                [91] = "واحد وتسعون",
                [92] = "اثنان وتسعون",
                [93] = "ثلاثة وتسعون",
                [94] = "أربعة وتسعون",
                [95] = "خمسة وتسعون",
                [96] = "ستة وتسعون",
                [97] = "سبعة وتسعون",
                [98] = "ثمانية وتسعون",
                [99] = "تسعة وتسعون",

                [200] = "مائتان",
                [300] = "ثلاثمائة",
                [400] = "أربعمائة",
                [500] = "خمسمائة",
                [600] = "ستمائة",
                [700] = "سبعمائة",
                [800] = "ثمانمائة",
                [900] = "تسعمائة"
            },
            units: new List<object>
            {
                new LanguageUnit
                {
                    UseBaseInstead = true,
                    UseBaseException = new List<double>
                    {
                        1
                    },
                    Singular = "مائة"
                },
                new LanguageUnit
                {
                    Dual = "ألفان",
                    Plural = "آلاف",
                    RestrictedPlural = true,
                    AvoidPrefixException = new List<double>
                    {
                        1,
                        2
                    },
                    Singular = "ألف"
                },
                new LanguageUnit
                {
                    Dual = "مليونان",
                    Plural = "ملايين",
                    RestrictedPlural = true,
                    AvoidPrefixException = new List<double>
                    {
                        1,
                        2
                    },
                    Singular = "مليون"
                },
                new LanguageUnit
                {
                    Dual = "ملياران",
                    Plural = "ملايير",
                    RestrictedPlural = true,
                    AvoidPrefixException = new List<double>
                    {
                        1,
                        2
                    },
                    Singular = "مليار"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "تريليون"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "كوادريليون"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "كوينتليون"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "سكستليون"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "سبتيلليون"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "أوكتيليون"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "نونيلليون"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "دشيليون"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "أوندشيلليون"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "دودشيليون"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "تريدشيليون"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "كواتوردشيليون"
                },
                new LanguageUnit
                {
                    AvoidPrefixException = new List<double>
                    {
                        1
                    },
                    Singular = "كويندشيليون"
                }
            })
        {
            AllSeparator = "و"
        };
    }
}