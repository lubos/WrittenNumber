﻿using WrittenNumber.Models;

namespace WrittenNumber.Data.Vi;

public static class VietnameseLanguage
{
    public static Language Get()
    {
        return new Language(
            useLongScale: false,
            baseSeparator: " ",
            unitSeparator: "và ",
            @base: new Dictionary<long, string>
            {
                [0] = "không",
                [1] = "một",
                [2] = "hai",
                [3] = "ba",
                [4] = "bốn",
                [5] = "năm",
                [6] = "sáu",
                [7] = "bảy",
                [8] = "tám",
                [9] = "chín",
                [10] = "mười",
                [15] = "mười lăm",
                [20] = "hai mươi",
                [21] = "hai mươi mốt",
                [25] = "hai mươi lăm",
                [30] = "ba mươi",
                [31] = "ba mươi mốt",
                [40] = "bốn mươi",
                [41] = "bốn mươi mốt",
                [45] = "bốn mươi lăm",
                [50] = "năm mươi",
                [51] = "năm mươi mốt",
                [55] = "năm mươi lăm",
                [60] = "sáu mươi",
                [61] = "sáu mươi mốt",
                [65] = "sáu mươi lăm",
                [70] = "bảy mươi",
                [71] = "bảy mươi mốt",
                [75] = "bảy mươi lăm",
                [80] = "tám mươi",
                [81] = "tám mươi mốt",
                [85] = "tám mươi lăm",
                [90] = "chín mươi",
                [91] = "chín mươi mốt",
                [95] = "chín mươi lăm"
            },
            units: new List<object>
            {
                "trăm",
                "ngàn",
                "triệu",
                "tỷ",
                "nghìn tỷ"
            });
    }
}