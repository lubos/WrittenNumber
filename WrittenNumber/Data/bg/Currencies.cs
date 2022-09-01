using WrittenNumber.Models;

namespace WrittenNumber.Data.bg
{
	public static class Currencies
	{
		public static Dictionary<string, Currency> Get()
		{
			return new Dictionary<string, Currency>()
			{
				["AED"] = new Currency()
				{
					One = "дирхам на Обединените арабски емирства",
					Other = "дирхама на Обединените арабски емирства",
				},
				["AFN"] = new Currency()
				{
					One = "афганистански афган",
					Other = "афганистански афгана",
				},
				["ALL"] = new Currency()
				{
					One = "албански лек",
					Other = "албански лека",
				},
				["AMD"] = new Currency()
				{
					One = "арменски драм",
					Other = "арменски драма",
				},
				["ANG"] = new Currency()
				{
					One = "антилски гулден",
					Other = "антилски гулдена",
				},
				["AOA"] = new Currency()
				{
					One = "анголска кванза",
					Other = "анголски кванзи",
				},
				["ARS"] = new Currency()
				{
					One = "аржентинско песо",
					Other = "аржентински песо",
				},
				["AUD"] = new Currency()
				{
					One = "австралийски долар",
					Other = "австралийски долара",
				},
				["AWG"] = new Currency()
				{
					One = "арубски флорин",
					Other = "арубски флорина",
				},
				["BAM"] = new Currency()
				{
					One = "босненска конвертируема марка",
					Other = "босненски конвертируеми марки",
				},
				["BBD"] = new Currency()
				{
					One = "барбадоски долар",
					Other = "барбадоски долара",
				},
				["BDT"] = new Currency()
				{
					One = "бангладешка така",
					Other = "бангладешки таки",
				},
				["BGN"] = new Currency()
				{
					One = "български лев",
					Other = "български лева",
				},
				["BHD"] = new Currency()
				{
					One = "бахрейнски динар",
					Other = "бахрейнски динара",
				},
				["BIF"] = new Currency()
				{
					One = "бурундийски франк",
					Other = "бурундийски франка",
				},
				["BMD"] = new Currency()
				{
					One = "бермудски долар",
					Other = "бермудски долара",
				},
				["BND"] = new Currency()
				{
					One = "брунейски долар",
					Other = "брунейски долара",
				},
				["BOB"] = new Currency()
				{
					One = "боливийско боливиано",
					Other = "боливийски боливиано",
				},
				["BOV"] = new Currency()
				{
					Other = "боливийски мвдол",
				},
				["BRL"] = new Currency()
				{
					One = "бразилски реал",
					Other = "бразилски реала",
				},
				["BTN"] = new Currency()
				{
					One = "бутански нгултрум",
					Other = "бутански нгултрума",
				},
				["BWP"] = new Currency()
				{
					One = "ботсванска пула",
					Other = "ботсвански пули",
				},
				["BYN"] = new Currency()
				{
					One = "беларуска рубла",
					Other = "беларуски рубли",
				},
				["BZD"] = new Currency()
				{
					One = "белизийски долар",
					Other = "белизийски долара",
				},
				["CAD"] = new Currency()
				{
					One = "канадски долар",
					Other = "канадски долара",
				},
				["CDF"] = new Currency()
				{
					One = "конгоански франк",
					Other = "конгоански франка",
				},
				["CHF"] = new Currency()
				{
					One = "швейцарски франк",
					Other = "швейцарски франка",
				},
				["CNY"] = new Currency()
				{
					One = "китайски юан",
					Other = "китайски юана",
				},
				["COP"] = new Currency()
				{
					One = "колумбийско песо",
					Other = "колумбийски песо",
				},
				["CRC"] = new Currency()
				{
					One = "костарикански колон",
					Other = "костарикански колона",
				},
				["CUC"] = new Currency()
				{
					One = "кубинско конвертируемо песо",
					Other = "кубински конвертируеми песо",
				},
				["CUP"] = new Currency()
				{
					One = "кубинско песо",
					Other = "кубински песо",
				},
				["CVE"] = new Currency()
				{
					Other = "ескудо на Кабо Верде",
				},
				["CZK"] = new Currency()
				{
					One = "чешка крона",
					Other = "чешки крони",
				},
				["DJF"] = new Currency()
				{
					One = "джибутски франк",
					Other = "джибутски франка",
				},
				["DKK"] = new Currency()
				{
					One = "датска крона",
					Other = "датски крони",
				},
				["DOP"] = new Currency()
				{
					One = "доминиканско песо",
					Other = "доминикански песо",
				},
				["DZD"] = new Currency()
				{
					One = "алжирски динар",
					Other = "алжирски динара",
				},
				["EGP"] = new Currency()
				{
					One = "египетска лира",
					Other = "египетски лири",
				},
				["ERN"] = new Currency()
				{
					One = "еритрейска накфа",
					Other = "еритрейски накфи",
				},
				["ETB"] = new Currency()
				{
					One = "етиопски бир",
					Other = "етиопски бира",
				},
				["EUR"] = new Currency()
				{
					Other = "евро",
				},
				["FJD"] = new Currency()
				{
					One = "фиджийски долар",
					Other = "фиджийски долара",
				},
				["FKP"] = new Currency()
				{
					One = "фолкландска лира",
					Other = "фолкландски лири",
				},
				["GBP"] = new Currency()
				{
					One = "британска лира",
					Other = "британски лири",
				},
				["GEL"] = new Currency()
				{
					Other = "грузински лари",
				},
				["GHS"] = new Currency()
				{
					One = "ганайско седи",
					Other = "ганайски седи",
				},
				["GIP"] = new Currency()
				{
					One = "гибралтарска лира",
					Other = "гибралтарски лири",
				},
				["GMD"] = new Currency()
				{
					One = "гамбийско даласи",
					Other = "гамбийски даласи",
				},
				["GNF"] = new Currency()
				{
					One = "гвинейски франк",
					Other = "гвинейски франка",
				},
				["GTQ"] = new Currency()
				{
					One = "гватемалски кетцал",
					Other = "гватемалски кетцала",
				},
				["GYD"] = new Currency()
				{
					One = "гаянски долар",
					Other = "гаянски долара",
				},
				["HKD"] = new Currency()
				{
					One = "хонконгски долар",
					Other = "хонконгски долара",
				},
				["HNL"] = new Currency()
				{
					One = "хондураска лемпира",
					Other = "хондураски лемпири",
				},
				["HRK"] = new Currency()
				{
					One = "хърватска куна",
					Other = "хърватски куни",
				},
				["HTG"] = new Currency()
				{
					One = "хаитски гурд",
					Other = "хаитски гурда",
				},
				["HUF"] = new Currency()
				{
					One = "унгарски форинт",
					Other = "унгарски форинта",
				},
				["IDR"] = new Currency()
				{
					One = "индонезийска рупия",
					Other = "индонезийски рупии",
				},
				["ILS"] = new Currency()
				{
					One = "израелски нов шекел",
					Other = "израелски нови шекела",
				},
				["INR"] = new Currency()
				{
					One = "индийска рупия",
					Other = "индийски рупии",
				},
				["IQD"] = new Currency()
				{
					One = "иракски динар",
					Other = "иракски динара",
				},
				["IRR"] = new Currency()
				{
					One = "ирански риал",
					Other = "ирански риала",
				},
				["ISK"] = new Currency()
				{
					One = "исландска крона",
					Other = "исландски крони",
				},
				["JMD"] = new Currency()
				{
					One = "ямайски долар",
					Other = "ямайски долара",
				},
				["JOD"] = new Currency()
				{
					One = "йордански динар",
					Other = "йордански динара",
				},
				["JPY"] = new Currency()
				{
					One = "японска йена",
					Other = "японски йени",
				},
				["KES"] = new Currency()
				{
					One = "кенийски шилинг",
					Other = "кенийски шилинга",
				},
				["KGS"] = new Currency()
				{
					One = "киргизстански сом",
					Other = "киргизстански сома",
				},
				["KHR"] = new Currency()
				{
					One = "камбоджански риел",
					Other = "камбоджански риела",
				},
				["KMF"] = new Currency()
				{
					One = "коморски франк",
					Other = "коморски франка",
				},
				["KPW"] = new Currency()
				{
					One = "севернокорейски вон",
					Other = "севернокорейски вона",
				},
				["KRW"] = new Currency()
				{
					One = "южнокорейски вон",
					Other = "южнокорейски вона",
				},
				["KWD"] = new Currency()
				{
					One = "кувейтски динар",
					Other = "кувейтски динара",
				},
				["KYD"] = new Currency()
				{
					One = "кайманов долар",
					Other = "кайманови долара",
				},
				["KZT"] = new Currency()
				{
					One = "казахстанско тенге",
					Other = "казахстански тенге",
				},
				["LAK"] = new Currency()
				{
					One = "лаоски кип",
					Other = "лаоски кипа",
				},
				["LBP"] = new Currency()
				{
					One = "ливанска лира",
					Other = "ливански лири",
				},
				["LKR"] = new Currency()
				{
					One = "шриланкска рупия",
					Other = "шриланкски рупии",
				},
				["LRD"] = new Currency()
				{
					One = "либерийски долар",
					Other = "либерийски долара",
				},
				["LSL"] = new Currency()
				{
					One = "лесотско лоти",
					Other = "лесотски лоти",
				},
				["LYD"] = new Currency()
				{
					One = "либийски динар",
					Other = "либийски динара",
				},
				["MAD"] = new Currency()
				{
					One = "марокански дирхам",
					Other = "марокански дирхама",
				},
				["MDL"] = new Currency()
				{
					One = "молдовска лея",
					Other = "молдовски леи",
				},
				["MGA"] = new Currency()
				{
					One = "малгашко ариари",
					Other = "малгашки ариари",
				},
				["MKD"] = new Currency()
				{
					One = "македонски денар",
					Other = "македонски денара",
				},
				["MMK"] = new Currency()
				{
					One = "мианмарски киат",
					Other = "мианмарски киата",
				},
				["MNT"] = new Currency()
				{
					One = "монголски тугрик",
					Other = "монголски тугрика",
				},
				["MOP"] = new Currency()
				{
					One = "патака на Макао",
					Other = "патаки на Макао",
				},
				["MRU"] = new Currency()
				{
					One = "мавританска угия",
					Other = "мавритански угии",
				},
				["MUR"] = new Currency()
				{
					One = "маврицийска рупия",
					Other = "маврицийски рупии",
				},
				["MVR"] = new Currency()
				{
					One = "малдивска руфия",
					Other = "малдивски руфии",
				},
				["MWK"] = new Currency()
				{
					One = "малавийска куача",
					Other = "малавийски куачи",
				},
				["MXN"] = new Currency()
				{
					One = "мексиканско песо",
					Other = "мексикански песо",
				},
				["MYR"] = new Currency()
				{
					One = "малайзийски рингит",
					Other = "малайзийски рингита",
				},
				["MZN"] = new Currency()
				{
					One = "мозамбикски метикал",
					Other = "мозамбикски метикала",
				},
				["NAD"] = new Currency()
				{
					One = "намибийски долар",
					Other = "намибийски долара",
				},
				["NGN"] = new Currency()
				{
					One = "нигерийска найра",
					Other = "нигерийски найри",
				},
				["NIO"] = new Currency()
				{
					One = "никарагуанска кордоба",
					Other = "никарагуански кордоби",
				},
				["NOK"] = new Currency()
				{
					One = "норвежка крона",
					Other = "норвежки крони",
				},
				["NPR"] = new Currency()
				{
					One = "непалска рупия",
					Other = "непалски рупии",
				},
				["NZD"] = new Currency()
				{
					One = "новозеландски долар",
					Other = "новозеландски долара",
				},
				["OMR"] = new Currency()
				{
					One = "омански риал",
					Other = "омански риала",
				},
				["PAB"] = new Currency()
				{
					One = "панамска балбоа",
					Other = "панамски балбоа",
				},
				["PEN"] = new Currency()
				{
					One = "перуански сол",
					Other = "перуански сола",
				},
				["PGK"] = new Currency()
				{
					One = "папуа-новогвинейска кина",
					Other = "папуа-новогвинейски кини",
				},
				["PHP"] = new Currency()
				{
					One = "филипинско песо",
					Other = "филипински песо",
				},
				["PKR"] = new Currency()
				{
					One = "пакистанска рупия",
					Other = "пакистански рупии",
				},
				["PLN"] = new Currency()
				{
					One = "полска злота",
					Other = "полски злоти",
				},
				["PYG"] = new Currency()
				{
					One = "парагвайско гуарани",
					Other = "парагвайски гуарани",
				},
				["QAR"] = new Currency()
				{
					One = "катарски риал",
					Other = "катарски риала",
				},
				["RON"] = new Currency()
				{
					One = "румънска лея",
					Other = "румънски леи",
				},
				["RSD"] = new Currency()
				{
					One = "сръбски динар",
					Other = "сръбски динара",
				},
				["RUB"] = new Currency()
				{
					One = "руска рубла",
					Other = "руски рубли",
				},
				["RWF"] = new Currency()
				{
					One = "руандски франк",
					Other = "руандски франка",
				},
				["SAR"] = new Currency()
				{
					One = "саудитски риал",
					Other = "саудитски риала",
				},
				["SBD"] = new Currency()
				{
					One = "долар на Соломоновите острови",
					Other = "долара на Соломоновите острови",
				},
				["SCR"] = new Currency()
				{
					One = "сейшелска рупия",
					Other = "сейшелски рупии",
				},
				["SDG"] = new Currency()
				{
					One = "суданска лира",
					Other = "судански лири",
				},
				["SEK"] = new Currency()
				{
					One = "шведска крона",
					Other = "шведски крони",
				},
				["SGD"] = new Currency()
				{
					One = "сингапурски долар",
					Other = "сингапурски долара",
				},
				["SHP"] = new Currency()
				{
					One = "лира на Света Елена",
					Other = "лири на Света Елена",
				},
				["SLL"] = new Currency()
				{
					One = "сиералеонско леоне",
					Other = "сиералеонски леоне",
				},
				["SOS"] = new Currency()
				{
					One = "сомалийски шилинг",
					Other = "сомалийски шилинга",
				},
				["SRD"] = new Currency()
				{
					One = "суринамски долар",
					Other = "суринамски долара",
				},
				["SSP"] = new Currency()
				{
					One = "южносуданска лира",
					Other = "южносудански лири",
				},
				["STN"] = new Currency()
				{
					Other = "добра на Сао Томе и Принсипи",
				},
				["SVC"] = new Currency()
				{
					One = "салвадорски колон",
					Other = "салвадорски колона",
				},
				["SYP"] = new Currency()
				{
					One = "сирийска лира",
					Other = "сирийски лири",
				},
				["SZL"] = new Currency()
				{
					Other = "свазилендски лилангени",
				},
				["THB"] = new Currency()
				{
					One = "тайландски бат",
					Other = "тайландски бата",
				},
				["TJS"] = new Currency()
				{
					Other = "таджикистански сомони",
				},
				["TMT"] = new Currency()
				{
					One = "туркменски манат",
					Other = "туркменски маната",
				},
				["TND"] = new Currency()
				{
					One = "тунизийски динар",
					Other = "тунизийски динара",
				},
				["TOP"] = new Currency()
				{
					One = "тонганска паанга",
					Other = "тонгански паанги",
				},
				["TRY"] = new Currency()
				{
					One = "турска лира",
					Other = "турски лири",
				},
				["TTD"] = new Currency()
				{
					One = "долар на Тринидад и Тобаго",
					Other = "долара на Тринидад и Тобаго",
				},
				["TWD"] = new Currency()
				{
					One = "тайвански долар",
					Other = "тайвански долара",
				},
				["TZS"] = new Currency()
				{
					One = "танзанийски шилинг",
					Other = "танзанийски шилинга",
				},
				["UAH"] = new Currency()
				{
					One = "украинска гривня",
					Other = "украински гривни",
				},
				["UGX"] = new Currency()
				{
					One = "угандски шилинг",
					Other = "угандски шилинга",
				},
				["USD"] = new Currency()
				{
					One = "щатски долар",
					Other = "щатски долара",
				},
				["UYU"] = new Currency()
				{
					One = "уругвайско песо",
					Other = "уругвайски песо",
				},
				["UZS"] = new Currency()
				{
					One = "узбекски сум",
					Other = "узбекски сума",
				},
				["VES"] = new Currency()
				{
					One = "венецуелски боливар (VES)",
					Other = "венецуелски боливара (VES)",
				},
				["VND"] = new Currency()
				{
					One = "виетнамски донг",
					Other = "виетнамски донга",
				},
				["VUV"] = new Currency()
				{
					One = "вануатско вату",
					Other = "вануатски вату",
				},
				["WST"] = new Currency()
				{
					One = "самоанска тала",
					Other = "самоански тали",
				},
				["XAF"] = new Currency()
				{
					One = "централноафрикански франк",
					Other = "централноафрикански франка",
				},
				["XCD"] = new Currency()
				{
					One = "източнокарибски долар",
					Other = "източнокарибски долара",
				},
				["XOF"] = new Currency()
				{
					One = "западноафрикански франк",
					Other = "западноафрикански франка",
				},
				["XPF"] = new Currency()
				{
					One = "CFP франк",
					Other = "CFP франка",
				},
				["YER"] = new Currency()
				{
					One = "йеменски риал",
					Other = "йеменски риала",
				},
				["ZAR"] = new Currency()
				{
					One = "южноафрикански ранд",
					Other = "южноафрикански ранда",
				},
				["ZMW"] = new Currency()
				{
					One = "замбийска куача",
					Other = "замбийски куачи",
				},
				["ZWL"] = new Currency()
				{
					One = "зимбабвийски долар (2009)",
					Other = "зимбабвийски долара (2009)",
				},
			};
		}
	}
}
