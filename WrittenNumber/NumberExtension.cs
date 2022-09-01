using System.Text.RegularExpressions;
using WrittenNumber.Models;

namespace WrittenNumber;

public static class NumberExtension
{
    private static readonly List<long> _shortScale = new()
    {
        100
    };

    private static readonly List<long> _longScale = new()
    {
        100,
        1000
    };

    static NumberExtension()
    {
        for (var i = 1; i <= 16; i++) _shortScale.Add((long)Math.Pow(10, i * 3));
        for (var i = 1; i <= 15; i++) _longScale.Add((long)Math.Pow(10, i * 6));
    }    

    public static string WrittenNumber(this string n, Option option)
    {
        if (long.TryParse(n, out var value)) return WrittenNumber(value, option);
        return string.Empty;
    }

    public static string WrittenNumber(this uint n, Option option)
    {
        return WrittenNumber(Convert.ToInt64(n), option);
    }

    public static string WrittenNumber(this double n, Option option)
    {
        return WrittenNumber(Convert.ToInt64(n), option);
    }

    public static string WrittenNumber(this int n, Option option)
    {
        return WrittenNumber(Convert.ToInt64(n), option);
    }

    public static string WrittenNumber(this long n, Option option)
    {
        return AppendCurrency(WrittenNumber(n, option, false, null), n, option);
    }

    private static string WrittenNumber(this long n, Option option, bool noAnd, Dictionary<long, string>? alternativeBase)
    {
        if (n < 0) return string.Empty;

        var language = option.Language switch
        {
            "es" => Data.Es.SpanishLanguage.Get(),
            "ar" => Data.Ar.ArabicLanguage.Get(),
            "az" => Data.az.AzerbaijaniLanguage.Get(),
            "pt" => Data.Pt.pt_PortugueseLanguage.Get(),
            "pt-PT" => Data.Pt_PT.PortugueseLanguage.Get(),
            "fr" => Data.Fr.FrenchLanguage.Get(),
            "it" => Data.It.ItalianLanguage.Get(),
            "vi" => Data.Vi.VietnameseLanguage.Get(),
            "tr" => Data.Tr.TurkishLanguage.Get(),
            "hu" => Data.Hu.HungaraianLangauge.Get(),
            "en-ID" => Data.en_IN.EnglishIndianLanguage.Get(),
            "uk" => Data.Uk.UkrainianLanguage.Get(),
            "ru" => Data.Ru.RussianLanguage.Get(),
            "id" => Data.Id.IndonesianLanguage.Get(),
            _ => Data.en.EnglishLanguage.Get()
        };

        var scale = language.UseLongScale ? _longScale : _shortScale;
        var units = new List<object>();

        if (language.Units is Dictionary<long, string> dictLanguageUnits)
        {
            var rawUnits = dictLanguageUnits;
            scale = new List<long>(dictLanguageUnits.Keys);
            var rawScale = new List<long>();
            foreach (var i in scale.Select((value, i) => new { i, value }))
            {
                var value = i.value;
                var index = i.i;
                rawScale.Add((long)Math.Pow(10, Convert.ToInt32(value)));
            }

            foreach (var (key, value) in dictLanguageUnits) units.Add(dictLanguageUnits[key]);
            scale = rawScale;
        }
        else if (language.Units is List<object> languageObjectUnits)
        {
            units.AddRange(languageObjectUnits);
        }
        else if (language.Units is List<string> languageStringUnits)
        {
            units.AddRange(languageStringUnits);
        }
        else
        {
            throw new ArgumentException(nameof(language.Units));
        }

        var baseCardinals = language.Base;

        if (language.UnitExceptions is Dictionary<double, string> unitExceptionDict && unitExceptionDict.ContainsKey(n)) return unitExceptionDict[n];
        if (alternativeBase != null && alternativeBase.ContainsKey(n)) return alternativeBase[n];
        if (baseCardinals.ContainsKey(n) && !string.IsNullOrEmpty(baseCardinals[n])) return baseCardinals[n];
        if (n < 100) return HandleSmallerThan100(n, language, baseCardinals, alternativeBase, option);

        var m = n % 100;
        var ret = new List<string>();
        if (m != 0)
        {
            if (noAnd && !(language.AndException.HasValue && language.AndException.Value)) ret.Add(m.WrittenNumber(option, false, null));
            else ret.Add(language.UnitSeparator + m.WrittenNumber(option, false, null));
        }

        double firstSignificant = 0;
        var len = units.Count;
        for (var i = 0; i < len; i++)
        {
            var r = n / scale[i];
            long divideBy;

            if (i == len - 1) divideBy = 1000000;
            else divideBy = scale[i + 1] / scale[i];

            r %= divideBy;

            if (r == 0) continue;
            firstSignificant = scale[i];

            {
                if (units[i] is LanguageUnit languageUnit && languageUnit.UseBaseInstead.HasValue && languageUnit.UseBaseInstead.Value)
                {
                    var shouldUseBaseException =
                        languageUnit.UseBaseException!.IndexOf(r) > -1 &&
                        (!languageUnit.UseBaseExceptionWhenNoTrailingNumbers.HasValue ||
                         !languageUnit.UseBaseExceptionWhenNoTrailingNumbers.Value ||
                         (i == 0 && ret.Any()));
                    if (!shouldUseBaseException)
                        ret.Add(alternativeBase != null &&
                                alternativeBase.ContainsKey(r * scale[i])
                            ? alternativeBase[r * scale[i]]
                            : baseCardinals[r * scale[i]]);
                    else
                        ret.Add(r > 1 && !string.IsNullOrEmpty(languageUnit.Plural)
                            ? languageUnit.Plural
                            : languageUnit.Singular!);
                    continue;
                }
            }

            var str = string.Empty;

            {
                if (units[i] is string strUnit)
                {
                    str = strUnit;
                }
                else if (units[i] is LanguageUnit languageUnit)
                {
                    if ((r == 1 || (languageUnit.UseSingularEnding.HasValue &&
                                    languageUnit.UseSingularEnding.Value && r % 10 == 1
                                    && (languageUnit.AvoidEndingRules == null ||
                                        languageUnit.AvoidEndingRules.IndexOf(r) < 0))) &&
                        !string.IsNullOrEmpty(languageUnit.Singular))
                    {
                        str = languageUnit.Singular;
                    }
                    else if (!string.IsNullOrEmpty(languageUnit.Few) && ((r > 1 && r < 5) ||
                                                                         (languageUnit.UseFewEnding.HasValue &&
                                                                          languageUnit.UseFewEnding.Value &&
                                                                          r % 10 > 1 && r % 10 < 5
                                                                          && (languageUnit.AvoidEndingRules ==
                                                                              null || languageUnit.AvoidEndingRules
                                                                                  .IndexOf(r) < 0))))
                    {
                        str = languageUnit.Few;
                    }
                    else
                    {
                        str = !string.IsNullOrEmpty(languageUnit.Plural) &&
                              (!languageUnit.AvoidInNumberPlural.HasValue ||
                               !languageUnit.AvoidInNumberPlural.Value || m == 0)
                            ? languageUnit.Plural
                            : languageUnit.Singular!;

                        // Languages with dual
                        str = r == 2 && !string.IsNullOrEmpty(languageUnit.Dual) ? languageUnit.Dual : str;

                        // "restrictedPlural" : use plural only for 3 to 10
                        str = r > 10 && languageUnit.RestrictedPlural.HasValue &&
                              languageUnit.RestrictedPlural.Value
                            ? languageUnit.Singular!
                            : str;
                    }
                }
            }

            {
                if (
                    units[i] is LanguageUnit languageUnit &&
                    languageUnit.AvoidPrefixException != null &&
                    languageUnit.AvoidPrefixException.Any() &&
                    languageUnit.AvoidPrefixException.IndexOf(r) > -1
                )
                {
                    ret.Add(str);
                    continue;
                }
            }
            string number;
            if (language.UnitExceptions != null &&
                r < language.UnitExceptions.Count &&
                language.UnitExceptions.ContainsKey(r))
                number = language.UnitExceptions[r];
            else if (units[i] is string)
                number = WrittenNumber(
                    r,
                    new Option
                    {
                        Language = option.Language
                    },
                    !(language.AndException.HasValue && language.AndException.Value),
                    null);
            else if (units[i] is LanguageUnit languageUnitCheck)
                number = WrittenNumber(
                    r,
                    new Option
                    {
                        Language = option.Language
                    },
                    !((language.AndException.HasValue && language.AndException.Value) || (languageUnitCheck.AndException.HasValue && languageUnitCheck.AndException.Value)),
                    languageUnitCheck.AlternativeBase);
            else number = string.Empty;
            n -= r * scale[i];
            ret.Add(number + " " + str);
        }

        var firstSignificantN = firstSignificant * Math.Floor(n / firstSignificant);
        var rest = n - firstSignificantN;

        if (language.AndWhenTrailing == true && firstSignificant != 0 && 0 < rest && ret[0].IndexOf(language.UnitSeparator) != 0)
        {
            var a = new List<string>
                {
                    ret[0],
                    Regex.Replace(language.UnitSeparator, @"\s+", string.Empty)
                };
            ret.RemoveAt(0);
            a.AddRange(ret);
            ret = a;
        }

        if (!string.IsNullOrEmpty(language.AllSeparator))
        {
            for (var j = 0; j < ret.Count - 1; j++)
            {
                ret[j] = language.AllSeparator + ret[j];
            }
        }
        ret.Reverse();
        var result = string.Join(" ", ret.ToArray());

        return result;
    }

    private static string AppendCurrency(string s, long value, Option option)
    {
        if (option.Currency != null)
        {
            var currencies = Currencies.Get(option.Language);

            if (currencies.TryGetValue(option.Currency, out Currency currency))
            {
                return s+" "+currency.Get(value);
            }
        }
        return s;
    }

    private static string HandleSmallerThan100(long n, Language language, Dictionary<long, string>? baseCardinals, Dictionary<long, string>? alternativeBaseCardinals, Option options)
    {
        var dec = n / 10 * 10;
        var unit = n - dec;

        var baseValue = alternativeBaseCardinals != null && alternativeBaseCardinals.ContainsKey(dec)
            ? alternativeBaseCardinals[dec]
            : baseCardinals != null && baseCardinals.ContainsKey(dec)
                ? baseCardinals[dec]
                : string.Empty;
        if (unit != 0) return baseValue + language.BaseSeparator + unit.WrittenNumber(options, false, null);

        return baseValue;
    }
}