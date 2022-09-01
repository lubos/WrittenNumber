using System;
using System.Collections.Generic;
using System.Linq;

foreach (var e in System.IO.Directory.GetDirectories("main"))
{
    if (e.Split('\\').Last().Length != 2) continue;

    var key = e.Split('\\').Last();

    var file = e + "\\currencies.json";

    var json = File.ReadAllText(file);

    var json2 = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<string, object>>>>>(json);

    var currencies = json2["main"][key]["numbers"]["currencies"];

    var json3 = Newtonsoft.Json.JsonConvert.SerializeObject(json2["main"][key]["numbers"]["currencies"]);

    var currencies2 = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json3);

    foreach (var e2 in currencies2)
    {
        Console.WriteLine(e2.Key);
    }

    var activeCurrencies = new string[]
        {
            "AED",
            "AFN",
            "ALL",
            "AMD",
            "ANG",
            "AOA",
            "ARS",
            "AUD",
            "AUD",
            "AWG",
            "ANZ",
            "BAM",
            "BBD",
            "BDT",
            "BGN",
            "BHD",
            "BIF",
            "BMD",
            "BND",
            "BOB",
            "BOV",
            "BRL",
            "BDS",
            "BTN",
            "BWP",
            "BYN",
            "BZD",
            "CAD",
            "CDF",
            "CHE",
            "CHF",
            "CHW",
            "CLF",
            "CPL",
            "COP",
            "COU",
            "COU",
            "CRC",
            "CUC",
            "CUP",
            "CVE",
            "CZK",
            "DJF",
            "DKK",
            "DOP",
            "DZD",
            "EGP",
            "ERN",
            "ETB",
            "EUR",
            "FJD",
            "FKP",
            "GBP",
            "GEL",
            "GHS",
            "GIP",
            "GMD",
            "GNF",
            "GTQ",
            "GYD",
            "HKD",
            "HNL",
            "HRK",
            "HTG",
            "HUF",
            "IDR",
            "ILS",
            "INR",
            "IQD",
            "IRR",
            "ISK",
            "JMD",
            "JOD",
            "JPY",
            "KES",
            "KGS",
            "KHR",
            "KMF",
            "KPW",
            "KRW",
            "KWD",
            "KYD",
            "KZT",
            "LAK",
            "LBP",
            "LKR",
            "LRD",
            "LSL",
            "LYD",
            "MAD",
            "MDL",
            "MGA",
            "MKD",
            "MMK",
            "MNT",
            "MOP",
            "MRU",
            "MUR",
            "MVR",
            "MWK",
            "MXN",
            "MXV",
            "MYR",
            "MZN",
            "NAD",
            "NGN",
            "NIO",
            "NOK",
            "NPR",
            "NZD",
            "OMR",
            "PAB",
            "PEN",
            "PGK",
            "PHP",
            "PKR",
            "PLN",
            "PYG",
            "QAR",
            "RON",
            "RSD",
            "CNY",
            "RUB",
            "RWF",
            "SAR",
            "SBD",
            "SCR",
            "SDG",
            "SEK",
            "SGD",
            "SHP",
            "SLL",
            "SLE",
            "SOS",
            "SRD",
            "SSP",
            "STN",
            "SVC",
            "SYP",
            "SZL",
            "THB",
            "TJS",
            "TMT",
            "TND",
            "TOP",
            "TRY",
            "TTD",
            "TWD",
            "TZS",
            "UAH",
            "UGX",
            "USD",
            "UYU",
            "UZS",
            "VED",
            "VES",
            "VND",
            "VUV",
            "WST",
            "XAF",
            "XCD",
            "XOF",
            "XPF",
            "YER",
            "ZAR",
            "ZMW",
            "ZWL"
        };

    Directory.CreateDirectory("output\\"+key);

    var sb = new System.Text.StringBuilder();
    sb.AppendLine("using WrittenNumber.Models;");
    sb.AppendLine("");
    sb.AppendLine("namespace WrittenNumber.Data."+ key);
    sb.AppendLine("{");
    sb.AppendLine("\tpublic static class Currencies");
    sb.AppendLine("\t{");
    sb.AppendLine("\t\tpublic static Dictionary<string, Currency> Get()");
    sb.AppendLine("\t\t{");
    sb.AppendLine("\t\t\treturn new Dictionary<string, Currency>()");
    sb.AppendLine("\t\t\t{");
    foreach (var e2 in currencies2)
    {
        if (!activeCurrencies.Contains(e2.Key)) continue;

        if (e2.Value.ContainsKey("displayName-count-other"))
        {
            sb.AppendLine($"\t\t\t\t[\"{e2.Key}\"] = new Currency()");
            sb.AppendLine("\t\t\t\t{");
            if (e2.Value.ContainsKey("displayName-count-one") && e2.Value["displayName-count-one"] != e2.Value["displayName-count-other"]) sb.AppendLine($"\t\t\t\t\tOne = \"{e2.Value["displayName-count-one"]}\",");
            if (e2.Value.ContainsKey("displayName-count-two")) sb.AppendLine($"\t\t\t\t\tTwo = \"{e2.Value["displayName-count-two"]}\",");
            if (e2.Value.ContainsKey("displayName-count-few")) sb.AppendLine($"\t\t\t\t\tFew = \"{e2.Value["displayName-count-few"]}\",");
            if (e2.Value.ContainsKey("displayName-count-many")) sb.AppendLine($"\t\t\t\t\tMany = \"{e2.Value["displayName-count-many"]}\",");
            sb.AppendLine($"\t\t\t\t\tOther = \"{e2.Value["displayName-count-other"]}\",");
            sb.AppendLine("\t\t\t\t},");
        }
    }
    sb.AppendLine("\t\t\t};");
    sb.AppendLine("\t\t}");
    sb.AppendLine("\t}");
    sb.AppendLine("}");

    File.WriteAllText($"output\\{key}\\Currencies.cs", sb.ToString());
}