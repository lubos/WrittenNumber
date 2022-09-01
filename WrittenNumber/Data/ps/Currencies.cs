using WrittenNumber.Models;

namespace WrittenNumber.Data.ps
{
	public static class Currencies
	{
		public static Dictionary<string, Currency> Get()
		{
			return new Dictionary<string, Currency>()
			{
				["AED"] = new Currency()
				{
					One = "UAE درهم",
					Other = "UAE درهمې",
				},
				["AFN"] = new Currency()
				{
					Other = "افغانۍ",
				},
				["ALL"] = new Currency()
				{
					One = "البانوي لک",
					Other = "البانوي لکي",
				},
				["AMD"] = new Currency()
				{
					One = "ارمينيايي ډرام",
					Other = "ارمينيايي ډرامز",
				},
				["ANG"] = new Currency()
				{
					One = "هالېنډې انټيليايي ګيلډر",
					Other = "هالېنډي انټيليايي ګيلډر",
				},
				["AOA"] = new Currency()
				{
					One = "انګولي کوانزا",
					Other = "انګولي کوانزې",
				},
				["ARS"] = new Currency()
				{
					One = "ارجنټاين پسو",
					Other = "ارجنټاين پسوز",
				},
				["AUD"] = new Currency()
				{
					One = "آسترالوي ډالر",
					Other = "آسترالوي ډالرې",
				},
				["AWG"] = new Currency()
				{
					Other = "اروبايي فلورن",
				},
				["BAM"] = new Currency()
				{
					One = "بوسنيا هرزګوينيايي بدلېدونکي مارک",
					Other = "بوسنيا هرزګوينيايي بدلېدونکي مارکس",
				},
				["BBD"] = new Currency()
				{
					One = "باربيډين ډالر",
					Other = "باربيډين ډالرې",
				},
				["BDT"] = new Currency()
				{
					One = "بنګالۍ ټاکه",
					Other = "بنګالۍ ټاکاس",
				},
				["BGN"] = new Currency()
				{
					One = "بلغاري ليو",
					Other = "بلغاري ليوا",
				},
				["BHD"] = new Currency()
				{
					One = "بحريني دينار",
					Other = "بحريني دينارونه",
				},
				["BIF"] = new Currency()
				{
					One = "برونډي فرانک",
					Other = "برونډي فرانکس",
				},
				["BMD"] = new Currency()
				{
					One = "برمودي ډالر",
					Other = "برمودي ډالرې",
				},
				["BND"] = new Currency()
				{
					One = "برونايي ډالر",
					Other = "برونايي ډالرې",
				},
				["BOB"] = new Currency()
				{
					Other = "بوليوي بوليويانو",
				},
				["BRL"] = new Currency()
				{
					One = "برازيلي ريل",
					Other = "برازيلي ريلز",
				},
				["BTN"] = new Currency()
				{
					One = "بهوټانۍ انګولټرم",
					Other = "بهوټانۍ انګولټرمس",
				},
				["BWP"] = new Currency()
				{
					One = "بوټسواني پولا",
					Other = "بوټسواني پولاز",
				},
				["BYN"] = new Currency()
				{
					One = "بلاروسي روبل",
					Other = "بلاروسي روبلز",
				},
				["BZD"] = new Currency()
				{
					One = "بليز ډالر",
					Other = "بليز ډالرې",
				},
				["CAD"] = new Currency()
				{
					One = "کاناډايي ډالر",
					Other = "کاناډايي ډالرې",
				},
				["CDF"] = new Currency()
				{
					One = "کانګولي فرانک",
					Other = "کانګولي فرانکس",
				},
				["CHF"] = new Currency()
				{
					One = "سويسي فرانک",
					Other = "سويسي فرانکس",
				},
				["CNY"] = new Currency()
				{
					Other = "چيني يوان",
				},
				["COP"] = new Currency()
				{
					One = "کولمبين پسو",
					Other = "کولمبين پسوز",
				},
				["CRC"] = new Currency()
				{
					One = "کوسټا ريکن کولون",
					Other = "کوسټا ريکن کولونز",
				},
				["CUC"] = new Currency()
				{
					One = "کيوبايي بدلېدونکې پسو",
					Other = "کيوبايي بدلېدونکې پسوز",
				},
				["CUP"] = new Currency()
				{
					One = "کيوبايي پسو",
					Other = "کيوبايي پسوز",
				},
				["CVE"] = new Currency()
				{
					One = "کيپ وردين اسکوډو",
					Other = "کيپ وردين اسکوډوز",
				},
				["CZK"] = new Currency()
				{
					One = "چيک کرونا",
					Other = "چيک کروناز",
				},
				["DJF"] = new Currency()
				{
					One = "جبوتي فرانک",
					Other = "جبوتي فرانکس",
				},
				["DKK"] = new Currency()
				{
					One = "ډنمارکي کرون",
					Other = "ډنمارکي کرونر",
				},
				["DOP"] = new Currency()
				{
					One = "دومينيکا پسو",
					Other = "دومينيکا پسوز",
				},
				["DZD"] = new Currency()
				{
					One = "الجيرين دينار",
					Other = "الجيرين دينارې",
				},
				["EGP"] = new Currency()
				{
					One = "مصري پونډ",
					Other = "مصري پونډونه",
				},
				["ERN"] = new Currency()
				{
					One = "ايريټرين نکفا",
					Other = "ايريټرين نکفاس",
				},
				["ETB"] = new Currency()
				{
					One = "ايتهوپيايي بر",
					Other = "ايتهوپيايي برز",
				},
				["EUR"] = new Currency()
				{
					One = "يورو",
					Other = "يوروز",
				},
				["FJD"] = new Currency()
				{
					One = "فجي ډالر",
					Other = "فجي ډالرې",
				},
				["FKP"] = new Currency()
				{
					One = "پاکلېنډ ټاپوګانو پونډ",
					Other = "پاکلېنډ ټاپوګانو پونډز",
				},
				["GBP"] = new Currency()
				{
					One = "برتانوې پونډ",
					Other = "برتانوې پونډونه",
				},
				["GEL"] = new Currency()
				{
					One = "جارجیا لاري",
					Other = "جارجیاېي لارېز",
				},
				["GHS"] = new Currency()
				{
					One = "ګانين سيډي",
					Other = "ګانين سيډيز",
				},
				["GIP"] = new Currency()
				{
					One = "جبل الطارقي پونډ",
					Other = "جبل الطارقي پونډونه",
				},
				["GMD"] = new Currency()
				{
					One = "ګيمبين دلاسې",
					Other = "ګيمبين دلاسېز",
				},
				["GNF"] = new Currency()
				{
					One = "ګنې فرانک",
					Other = "ګنې فرانکس",
				},
				["GTQ"] = new Currency()
				{
					One = "ګويټيمالن کوټزل",
					Other = "ګويټيمالن کوټزلز",
				},
				["GYD"] = new Currency()
				{
					One = "ګايانيز ډالر",
					Other = "ګايانيز ډالرز",
				},
				["HKD"] = new Currency()
				{
					One = "هانګ کانګ ډالر",
					Other = "هانګ کانګ ډالرې",
				},
				["HNL"] = new Currency()
				{
					One = "هونډوران ليمپيرا",
					Other = "هونډوران ليمپيراز",
				},
				["HRK"] = new Currency()
				{
					One = "کروشيايي کونا",
					Other = "کروشيايي کوناز",
				},
				["HTG"] = new Currency()
				{
					One = "هيټي ګورډ",
					Other = "هيټي ګورډز",
				},
				["HUF"] = new Currency()
				{
					One = "هنګري فورنټ",
					Other = "هنګري فورنټز",
				},
				["IDR"] = new Currency()
				{
					One = "انډونيشي روپيا",
					Other = "انډونيشي روپۍ",
				},
				["ILS"] = new Currency()
				{
					One = "اسرايلي نيو شيکل",
					Other = "اسرايلي نيو شيکلز",
				},
				["INR"] = new Currency()
				{
					Other = "هندي روپۍ",
				},
				["IQD"] = new Currency()
				{
					One = "عراقي دينار",
					Other = "عراقي دينارونه",
				},
				["IRR"] = new Currency()
				{
					One = "ايراني ريال",
					Other = "ايراني ريالونه",
				},
				["ISK"] = new Currency()
				{
					One = "آيسلېنډي کرونا",
					Other = "آيسلېنډي کرونر",
				},
				["JMD"] = new Currency()
				{
					One = "جمايکايي ډالر",
					Other = "جمايکايي ډالرې",
				},
				["JOD"] = new Currency()
				{
					One = "اردني دينار",
					Other = "اردني دينارونه",
				},
				["JPY"] = new Currency()
				{
					Other = "جاپاني ين",
				},
				["KES"] = new Currency()
				{
					One = "کينيايي شيلنګ",
					Other = "کينيايي شيلنګز",
				},
				["KGS"] = new Currency()
				{
					One = "کرغزستاني سوم",
					Other = "کرغزستاني سومز",
				},
				["KHR"] = new Currency()
				{
					One = "کمبوډي ريل",
					Other = "کمبوډي ريلس",
				},
				["KMF"] = new Currency()
				{
					One = "کوموري فرانک",
					Other = "کوموري فرانکس",
				},
				["KPW"] = new Currency()
				{
					Other = "شمالي کوريايي وان",
				},
				["KRW"] = new Currency()
				{
					Other = "جنوبي کوريايي وان",
				},
				["KWD"] = new Currency()
				{
					One = "کويتي دينار",
					Other = "کويتي دينارونه",
				},
				["KYD"] = new Currency()
				{
					One = "کيمن ټاپوګانو ډالر",
					Other = "کيمن ټاپوګانو ډالرې",
				},
				["KZT"] = new Currency()
				{
					One = "قازقستاني ټينج",
					Other = "قازقستاني ټينجز",
				},
				["LAK"] = new Currency()
				{
					One = "لاشې کپ",
					Other = "لاشې کپس",
				},
				["LBP"] = new Currency()
				{
					One = "لبناني پونډ",
					Other = "لبناني پونډونه",
				},
				["LKR"] = new Currency()
				{
					Other = "سري لنکن روپۍ",
				},
				["LRD"] = new Currency()
				{
					One = "لايبيرين ډالر",
					Other = "لايبيرين ډالرې",
				},
				["LSL"] = new Currency()
				{
					One = "Lesotho loti",
					Other = "Lesotho lotis",
				},
				["LYD"] = new Currency()
				{
					One = "ليبياېي دينار",
					Other = "ليبياېي دينارونه",
				},
				["MAD"] = new Currency()
				{
					One = "مراکشي درهم",
					Other = "مراکشي درهمونه",
				},
				["MDL"] = new Currency()
				{
					One = "مالډوي ليو",
					Other = "مالډوي لي",
				},
				["MGA"] = new Currency()
				{
					One = "ملاګاسي ارياري",
					Other = "ملاګاسي ارياريز",
				},
				["MKD"] = new Currency()
				{
					One = "مسيډونايي دينار",
					Other = "مسيډونايي دينارې",
				},
				["MMK"] = new Currency()
				{
					One = "ميانماري کيات",
					Other = "ميانماري کياتې",
				},
				["MNT"] = new Currency()
				{
					One = "منګوليايي توګريک",
					Other = "منګوليايي توګريکس",
				},
				["MOP"] = new Currency()
				{
					One = "مکانيس پټاکا",
					Other = "مکانيز پټاکاز",
				},
				["MRU"] = new Currency()
				{
					One = "موريشيسي ډالر",
					Other = "موريشيسي ډالرې",
				},
				["MUR"] = new Currency()
				{
					Other = "موريشيسي روپۍ",
				},
				["MVR"] = new Currency()
				{
					Other = "مالديپي روپيا",
				},
				["MWK"] = new Currency()
				{
					One = "ملاوي کواچا",
					Other = "ملاوي کواچاز",
				},
				["MXN"] = new Currency()
				{
					One = "ميکسيکن پيسو",
					Other = "ميکسيکن پيسوز",
				},
				["MYR"] = new Currency()
				{
					One = "ملايشي رنګټ",
					Other = "ملايشي رنګټې",
				},
				["MZN"] = new Currency()
				{
					One = "موزمبيقي ميټيکل",
					Other = "موزمبيقي ميټيکلز",
				},
				["NAD"] = new Currency()
				{
					One = "بيميبيايي ډالر",
					Other = "نيميبيايي ډالرې",
				},
				["NGN"] = new Currency()
				{
					One = "نايجيري نايرا",
					Other = "نايجيري نايراز",
				},
				["NIO"] = new Currency()
				{
					One = "نيکاراګون کورډوبا",
					Other = "نيکاراګون کورډوباز",
				},
				["NOK"] = new Currency()
				{
					One = "نارويجين کرون",
					Other = "نارويجين کرونر",
				},
				["NPR"] = new Currency()
				{
					Other = "نيپالي روپۍ",
				},
				["NZD"] = new Currency()
				{
					One = "نيوزي لينډي ډالر",
					Other = "نيوزي لينډي ډالرې",
				},
				["OMR"] = new Currency()
				{
					One = "عماني ريال",
					Other = "عماني ريالونه",
				},
				["PAB"] = new Currency()
				{
					One = "پانامۍ بالبوا",
					Other = "پانامۍ بالبوې",
				},
				["PEN"] = new Currency()
				{
					One = "پيروين سول",
					Other = "پيروين سولز",
				},
				["PGK"] = new Currency()
				{
					Other = "پاپوا نيوګاني کينا",
				},
				["PHP"] = new Currency()
				{
					One = "فلپاينۍ پسو",
					Other = "فلپاينۍ پسوز",
				},
				["PKR"] = new Currency()
				{
					One = "پاکستانۍ کلداره",
					Other = "پاکستانۍ کلدارې",
				},
				["PLN"] = new Currency()
				{
					One = "پولينډي زلوټي",
					Other = "پولينډي زلوټيز",
				},
				["PYG"] = new Currency()
				{
					Other = "پيراګوين ګوراني",
				},
				["QAR"] = new Currency()
				{
					One = "قطري ريال",
					Other = "قطري ريالونه",
				},
				["RON"] = new Currency()
				{
					One = "روماني ليو",
					Other = "روماني لي",
				},
				["RSD"] = new Currency()
				{
					One = "سربيايي دينار",
					Other = "سربيايي دينارې",
				},
				["RUB"] = new Currency()
				{
					One = "روسي روبل",
					Other = "روسي روبلز",
				},
				["RWF"] = new Currency()
				{
					One = "روانډي فرانک",
					Other = "روانډي فرانکس",
				},
				["SAR"] = new Currency()
				{
					One = "سعودي ريال",
					Other = "سعودي ريالونه",
				},
				["SBD"] = new Currency()
				{
					One = "سولومن ټاپوګانو ډالر",
					Other = "سولومن ټاپوګانو ډالرې",
				},
				["SCR"] = new Currency()
				{
					Other = "سيچيليسي روپۍ",
				},
				["SDG"] = new Currency()
				{
					One = "سوډاني پونډ",
					Other = "سوډاني پونډونه",
				},
				["SEK"] = new Currency()
				{
					One = "سويډني کرونا",
					Other = "سويډني کرونر",
				},
				["SGD"] = new Currency()
				{
					One = "سنګاپور ډالر",
					Other = "سنګاپور ډالرې",
				},
				["SHP"] = new Currency()
				{
					One = "سينټ هيلينا پونډ",
					Other = "سينټ هيلينا پونډونه",
				},
				["SLL"] = new Currency()
				{
					One = "سيرا ليوني ليون",
					Other = "سيرا ليوني ليونونه",
				},
				["SOS"] = new Currency()
				{
					One = "سومالي شيلنګ",
					Other = "سومالي شيلنګز",
				},
				["SRD"] = new Currency()
				{
					One = "سورينيمي ډالر",
					Other = "سورينيمي ډالرې",
				},
				["STN"] = new Currency()
				{
					One = "ساو ټوم او پرينسپي ډوبرا",
					Other = "ساو ټوم او پرينسپي ډوبراس",
				},
				["SYP"] = new Currency()
				{
					One = "سوريايي پونډ",
					Other = "سوريايي پونډونه",
				},
				["SZL"] = new Currency()
				{
					One = "سوازي ليلانګيني",
					Other = "سوازي ايمالانګيني",
				},
				["THB"] = new Currency()
				{
					One = "تهايي بات",
					Other = "تهايي باتونه",
				},
				["TJS"] = new Currency()
				{
					One = "تاجکستاني سوموني",
					Other = "تاجکستاني سومونيونه",
				},
				["TMT"] = new Currency()
				{
					Other = "ترکمانستاني منت",
				},
				["TND"] = new Currency()
				{
					One = "تيونسې دينار",
					Other = "تونسي دينار",
				},
				["TOP"] = new Currency()
				{
					Other = "ټونګن پانګا",
				},
				["TRY"] = new Currency()
				{
					Other = "ترکي ليرا",
				},
				["TTD"] = new Currency()
				{
					One = "ټرينيډاډ او ټوباګو ډالر",
					Other = "ټرينيډاډ او ټوباګو ډالرې",
				},
				["TWD"] = new Currency()
				{
					One = "نيو تائيواني ډالر",
					Other = "نيو تائيواني ډالرې",
				},
				["TZS"] = new Currency()
				{
					One = "تنزاني شيلنګ",
					Other = "تنزاني شيلنګز",
				},
				["UAH"] = new Currency()
				{
					One = "اوکرايني هريونيا",
					Other = "اوکرايني هريونياز",
				},
				["UGX"] = new Currency()
				{
					One = "يوګانډي شيلنګ",
					Other = "يوګانډي شيلنګز",
				},
				["USD"] = new Currency()
				{
					One = "امريکايي ډالر",
					Other = "امريکايي ډالرې",
				},
				["UYU"] = new Currency()
				{
					One = "يوراګوي پسو",
					Other = "يوراګوي پسوز",
				},
				["UZS"] = new Currency()
				{
					Other = "ازبکستاني سوم",
				},
				["VES"] = new Currency()
				{
					One = "وينزويلي بوليوار",
					Other = "وينزويلي بوليوارز",
				},
				["VND"] = new Currency()
				{
					Other = "ويتنامي ډونګ",
				},
				["VUV"] = new Currency()
				{
					One = "ونواتو واتو",
					Other = "ونواتو واتوس",
				},
				["WST"] = new Currency()
				{
					Other = "سموون تالا",
				},
				["XAF"] = new Currency()
				{
					One = "مرکزي افريقايي CFA فرانک",
					Other = "مرکزي افريقايي CFA فرانکس",
				},
				["XCD"] = new Currency()
				{
					One = "ختيځ کربين ډالر",
					Other = "ختيځ کربين ډالرې",
				},
				["XOF"] = new Currency()
				{
					One = "ختيځ افريقايي CFA فرانک",
					Other = "ختيځ افريقايي CFA فرانکس",
				},
				["XPF"] = new Currency()
				{
					One = "CFP فرانک",
					Other = "CFP فرانکس",
				},
				["YER"] = new Currency()
				{
					One = "يمني ريال",
					Other = "يمني ريالونه",
				},
				["ZAR"] = new Currency()
				{
					Other = "جنوبي افريقاېي رنډ",
				},
				["ZMW"] = new Currency()
				{
					One = "زيمبي کواچا",
					Other = "زيمبي کواچاز",
				},
			};
		}
	}
}
