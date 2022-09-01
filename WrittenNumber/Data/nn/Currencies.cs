using WrittenNumber.Models;

namespace WrittenNumber.Data.nn
{
	public static class Currencies
	{
		public static Dictionary<string, Currency> Get()
		{
			return new Dictionary<string, Currency>()
			{
				["AED"] = new Currency()
				{
					One = "emiratarabisk dirham",
					Other = "emiratarabiske dirham",
				},
				["AFN"] = new Currency()
				{
					One = "afghansk afghani",
					Other = "afghanske afghani",
				},
				["ALL"] = new Currency()
				{
					One = "albansk lek",
					Other = "albanske lek",
				},
				["AMD"] = new Currency()
				{
					One = "armensk dram",
					Other = "armenske dram",
				},
				["ANG"] = new Currency()
				{
					One = "nederlandsk antillegylden",
					Other = "nederlandske antillegylden",
				},
				["AOA"] = new Currency()
				{
					One = "angolansk kwanza",
					Other = "angolanske kwanza",
				},
				["ARS"] = new Currency()
				{
					One = "argentinsk peso",
					Other = "argentinske pesos",
				},
				["AUD"] = new Currency()
				{
					One = "australsk dollar",
					Other = "australske dollar",
				},
				["AWG"] = new Currency()
				{
					One = "arubisk florin",
					Other = "arubiske floriner",
				},
				["BAM"] = new Currency()
				{
					One = "bosnisk-hercegovinsk konvertibel mark",
					Other = "bosnisk-hercegovinske konvertible mark",
				},
				["BBD"] = new Currency()
				{
					One = "barbadisk dollar",
					Other = "barbadiske dollar",
				},
				["BDT"] = new Currency()
				{
					One = "bangladeshisk taka",
					Other = "bangladeshiske taka",
				},
				["BGN"] = new Currency()
				{
					One = "bulgarsk lev",
					Other = "bulgarske lev",
				},
				["BHD"] = new Currency()
				{
					One = "bahrainsk dinar",
					Other = "bahrainske dinarar",
				},
				["BIF"] = new Currency()
				{
					One = "burundisk franc",
					Other = "burundiske franc",
				},
				["BMD"] = new Currency()
				{
					One = "bermudisk dollar",
					Other = "bermudiske dollar",
				},
				["BND"] = new Currency()
				{
					One = "bruneisk dollar",
					Other = "bruneiske dollar",
				},
				["BOB"] = new Currency()
				{
					One = "boliviansk boliviano",
					Other = "bolivianske boliviano",
				},
				["BOV"] = new Currency()
				{
					Other = "bolivianske mvdol",
				},
				["BRL"] = new Currency()
				{
					One = "brasiliansk real",
					Other = "brasilianske real",
				},
				["BTN"] = new Currency()
				{
					One = "bhutansk ngultrum",
					Other = "bhutanske ngultrum",
				},
				["BWP"] = new Currency()
				{
					One = "botswansk pula",
					Other = "botswanske pula",
				},
				["BYN"] = new Currency()
				{
					One = "ny kviterussisk rubel",
					Other = "nye kviterussiske rublar",
				},
				["BZD"] = new Currency()
				{
					One = "belizisk dollar",
					Other = "beliziske dollar",
				},
				["CAD"] = new Currency()
				{
					One = "kanadisk dollar",
					Other = "kanadiske dollar",
				},
				["CDF"] = new Currency()
				{
					One = "kongolesisk franc",
					Other = "kongolesiske franc",
				},
				["CHE"] = new Currency()
				{
					Other = "WIR euro",
				},
				["CHF"] = new Currency()
				{
					One = "sveitsisk franc",
					Other = "sveitsiske franc",
				},
				["CHW"] = new Currency()
				{
					Other = "WIR franc",
				},
				["CLF"] = new Currency()
				{
					One = "chilensk unidades de fomento",
					Other = "chilenske unidades de fomento",
				},
				["CNY"] = new Currency()
				{
					One = "kinesisk yuan",
					Other = "kinesiske yuan",
				},
				["COP"] = new Currency()
				{
					One = "kolombiansk peso",
					Other = "kolombianske pesos",
				},
				["COU"] = new Currency()
				{
					Other = "unidad de valor real",
				},
				["CRC"] = new Currency()
				{
					One = "kostarikansk colón",
					Other = "kostarikanske colón",
				},
				["CUC"] = new Currency()
				{
					One = "kubansk konvertibel peso",
					Other = "kubanske konvertible pesos",
				},
				["CUP"] = new Currency()
				{
					One = "kubansk peso",
					Other = "kubanske pesos",
				},
				["CVE"] = new Currency()
				{
					One = "kappverdisk escudo",
					Other = "kappverdiske escudo",
				},
				["CZK"] = new Currency()
				{
					One = "tsjekkisk koruna",
					Other = "tsjekkiske koruna",
				},
				["DJF"] = new Currency()
				{
					One = "djiboutisk franc",
					Other = "djiboutiske franc",
				},
				["DKK"] = new Currency()
				{
					One = "dansk krone",
					Other = "danske kroner",
				},
				["DOP"] = new Currency()
				{
					One = "dominikansk peso",
					Other = "dominikanske pesos",
				},
				["DZD"] = new Currency()
				{
					One = "algerisk dinar",
					Other = "algeriske dinarar",
				},
				["EGP"] = new Currency()
				{
					One = "egyptisk pund",
					Other = "egyptiske pund",
				},
				["ERN"] = new Currency()
				{
					One = "eritreisk nakfa",
					Other = "eritreiske nakfa",
				},
				["ETB"] = new Currency()
				{
					One = "etiopisk birr",
					Other = "etiopiske birr",
				},
				["EUR"] = new Currency()
				{
					Other = "euro",
				},
				["FJD"] = new Currency()
				{
					One = "fijiansk dollar",
					Other = "fijianske dollar",
				},
				["FKP"] = new Currency()
				{
					Other = "falklandspund",
				},
				["GBP"] = new Currency()
				{
					One = "britisk pund",
					Other = "britiske pund",
				},
				["GEL"] = new Currency()
				{
					One = "georgisk lari",
					Other = "georgiske lari",
				},
				["GHS"] = new Currency()
				{
					One = "ghanesisk cedi",
					Other = "ghanesiske cedi",
				},
				["GIP"] = new Currency()
				{
					One = "gibraltarsk pund",
					Other = "gibraltarske pund",
				},
				["GMD"] = new Currency()
				{
					One = "gambisk dalasi",
					Other = "gambiske dalasi",
				},
				["GNF"] = new Currency()
				{
					One = "guineansk franc",
					Other = "guineanske franc",
				},
				["GTQ"] = new Currency()
				{
					One = "guatemalansk quetzal",
					Other = "guatemalanske quetzal",
				},
				["GYD"] = new Currency()
				{
					One = "guyansk dollar",
					Other = "guyanske dollar",
				},
				["HKD"] = new Currency()
				{
					Other = "Hongkong-dollar",
				},
				["HNL"] = new Currency()
				{
					One = "honduransk lempira",
					Other = "honduranske lempira",
				},
				["HRK"] = new Currency()
				{
					One = "kroatisk kuna",
					Other = "kroatiske kuna",
				},
				["HTG"] = new Currency()
				{
					One = "haitisk gourde",
					Other = "haitiske gourde",
				},
				["HUF"] = new Currency()
				{
					One = "ungarsk forint",
					Other = "ungarske forintar",
				},
				["IDR"] = new Currency()
				{
					One = "indonesisk rupi",
					Other = "indonesiske rupiar",
				},
				["ILS"] = new Currency()
				{
					One = "ny israelsk shekel",
					Other = "nye israelske sheklar",
				},
				["INR"] = new Currency()
				{
					One = "indisk rupi",
					Other = "indiske rupiar",
				},
				["IQD"] = new Currency()
				{
					One = "irakisk dinar",
					Other = "irakiske dinarar",
				},
				["IRR"] = new Currency()
				{
					One = "iransk rial",
					Other = "iranske rial",
				},
				["ISK"] = new Currency()
				{
					One = "islandsk krone",
					Other = "islandske kroner",
				},
				["JMD"] = new Currency()
				{
					One = "jamaikansk dollar",
					Other = "jamaikanske dollar",
				},
				["JOD"] = new Currency()
				{
					One = "jordansk dinar",
					Other = "jordanske dinarar",
				},
				["JPY"] = new Currency()
				{
					One = "japansk yen",
					Other = "japanske yen",
				},
				["KES"] = new Currency()
				{
					One = "kenyansk shilling",
					Other = "kenyanske shilling",
				},
				["KGS"] = new Currency()
				{
					One = "kirgisisk som",
					Other = "kirgisiske som",
				},
				["KHR"] = new Currency()
				{
					One = "kambodsjansk riel",
					Other = "kambodsjanske riel",
				},
				["KMF"] = new Currency()
				{
					One = "komorisk franc",
					Other = "komoriske franc",
				},
				["KPW"] = new Currency()
				{
					One = "nordkoreansk won",
					Other = "nordkoreanske won",
				},
				["KRW"] = new Currency()
				{
					One = "sørkoreansk won",
					Other = "sørkoreanske won",
				},
				["KWD"] = new Currency()
				{
					One = "kuwaitisk dinar",
					Other = "kuwaitiske dinarar",
				},
				["KYD"] = new Currency()
				{
					One = "caymansk dollar",
					Other = "caymanske dollar",
				},
				["KZT"] = new Currency()
				{
					One = "kasakhstansk tenge",
					Other = "kasakhstanske tenge",
				},
				["LAK"] = new Currency()
				{
					One = "laotisk kip",
					Other = "laotiske kip",
				},
				["LBP"] = new Currency()
				{
					One = "libanesisk pund",
					Other = "libanesiske pund",
				},
				["LKR"] = new Currency()
				{
					One = "srilankisk rupi",
					Other = "srilankiske rupiar",
				},
				["LRD"] = new Currency()
				{
					One = "liberisk dollar",
					Other = "liberiske dollar",
				},
				["LSL"] = new Currency()
				{
					One = "lesothisk loti",
					Other = "lesothiske loti",
				},
				["LYD"] = new Currency()
				{
					One = "libysk dinar",
					Other = "libyske dinarar",
				},
				["MAD"] = new Currency()
				{
					One = "marokkansk dirham",
					Other = "marokkanske dirham",
				},
				["MDL"] = new Currency()
				{
					One = "moldovsk leu",
					Other = "moldovske leuar",
				},
				["MGA"] = new Currency()
				{
					One = "madagassisk ariary",
					Other = "madagassiske ariary",
				},
				["MKD"] = new Currency()
				{
					One = "makedonsk denar",
					Other = "makedonske denarar",
				},
				["MMK"] = new Currency()
				{
					One = "myanmarsk kyat",
					Other = "myanmarske kyat",
				},
				["MNT"] = new Currency()
				{
					One = "mongolsk tugrik",
					Other = "mongolske tugrik",
				},
				["MOP"] = new Currency()
				{
					One = "makaoisk pataca",
					Other = "makaoiske pataca",
				},
				["MRU"] = new Currency()
				{
					One = "mauritansk ouguiya",
					Other = "mauritanske ouguiya",
				},
				["MUR"] = new Currency()
				{
					One = "mauritisk rupi",
					Other = "mauritiske rupiar",
				},
				["MVR"] = new Currency()
				{
					One = "maldivisk rufiyaa",
					Other = "maldiviske rufiyaa",
				},
				["MWK"] = new Currency()
				{
					One = "malawisk kwacha",
					Other = "malawiske kwacha",
				},
				["MXN"] = new Currency()
				{
					One = "meksikansk peso",
					Other = "meksikanske pesos",
				},
				["MXV"] = new Currency()
				{
					One = "meksikansk unidad de inversion (UDI)",
					Other = "meksikanske unidad de inversion (UDI)",
				},
				["MYR"] = new Currency()
				{
					One = "malaysisk ringgit",
					Other = "malaysiske ringgit",
				},
				["MZN"] = new Currency()
				{
					One = "mosambikisk metical",
					Other = "mosambikiske metical",
				},
				["NAD"] = new Currency()
				{
					One = "namibisk dollar",
					Other = "namibiske dollar",
				},
				["NGN"] = new Currency()
				{
					One = "nigeriansk naira",
					Other = "nigerianske naira",
				},
				["NIO"] = new Currency()
				{
					One = "nicaraguansk córdoba",
					Other = "nicaraguanske córdoba",
				},
				["NOK"] = new Currency()
				{
					One = "norsk krone",
					Other = "norske kroner",
				},
				["NPR"] = new Currency()
				{
					One = "nepalsk rupi",
					Other = "nepalske rupiar",
				},
				["NZD"] = new Currency()
				{
					One = "nyzealandsk dollar",
					Other = "nyzealandske dollar",
				},
				["OMR"] = new Currency()
				{
					One = "omansk rial",
					Other = "omanske rial",
				},
				["PAB"] = new Currency()
				{
					One = "panamansk balboa",
					Other = "panamanske balboa",
				},
				["PEN"] = new Currency()
				{
					One = "peruansk sol",
					Other = "peruanske sol",
				},
				["PGK"] = new Currency()
				{
					One = "papuansk kina",
					Other = "papuanske kina",
				},
				["PHP"] = new Currency()
				{
					One = "filippinsk peso",
					Other = "filippinske pesos",
				},
				["PKR"] = new Currency()
				{
					One = "pakistansk rupi",
					Other = "pakistanske rupiar",
				},
				["PLN"] = new Currency()
				{
					One = "polsk zloty",
					Other = "polske zloty",
				},
				["PYG"] = new Currency()
				{
					One = "paraguayansk guaraní",
					Other = "paraguayanske guaraní",
				},
				["QAR"] = new Currency()
				{
					One = "qatarsk rial",
					Other = "qatarske rial",
				},
				["RON"] = new Currency()
				{
					One = "rumensk leu",
					Other = "rumenske leuar",
				},
				["RSD"] = new Currency()
				{
					One = "serbisk dinar",
					Other = "serbiske dinarar",
				},
				["RUB"] = new Currency()
				{
					One = "russisk rubel",
					Other = "russiske rublar",
				},
				["RWF"] = new Currency()
				{
					One = "rwandisk franc",
					Other = "rwandiske franc",
				},
				["SAR"] = new Currency()
				{
					One = "saudiarabisk rial",
					Other = "saudiarabiske rial",
				},
				["SBD"] = new Currency()
				{
					One = "salomonsk dollar",
					Other = "salomonske dollar",
				},
				["SCR"] = new Currency()
				{
					One = "seychellisk rupi",
					Other = "seychelliske rupiar",
				},
				["SDG"] = new Currency()
				{
					One = "sudansk pund",
					Other = "sudanske pund",
				},
				["SEK"] = new Currency()
				{
					One = "svensk krone",
					Other = "svenske kroner",
				},
				["SGD"] = new Currency()
				{
					One = "singaporsk dollar",
					Other = "singaporske dollar",
				},
				["SHP"] = new Currency()
				{
					One = "sankthelensk pund",
					Other = "sankthelenske pund",
				},
				["SLL"] = new Currency()
				{
					One = "sierraleonsk leone",
					Other = "sierraleonske leone",
				},
				["SOS"] = new Currency()
				{
					One = "somalisk shilling",
					Other = "somaliske shilling",
				},
				["SRD"] = new Currency()
				{
					One = "surinamsk dollar",
					Other = "surinamske dollar",
				},
				["SSP"] = new Currency()
				{
					One = "sørsudansk pund",
					Other = "sørsudanske pund",
				},
				["STN"] = new Currency()
				{
					One = "saotomesisk dobra",
					Other = "saotomesiske dobra",
				},
				["SVC"] = new Currency()
				{
					One = "salvadoransk colon",
					Other = "salvadoranske colon",
				},
				["SYP"] = new Currency()
				{
					One = "syrisk pund",
					Other = "syriske pund",
				},
				["SZL"] = new Currency()
				{
					One = "eswatinisk lilangeni",
					Other = "eswatiniske emalangeni",
				},
				["THB"] = new Currency()
				{
					One = "thailandsk baht",
					Other = "thailandske baht",
				},
				["TJS"] = new Currency()
				{
					One = "tadsjikisk somoni",
					Other = "tadsjikiske somoni",
				},
				["TMT"] = new Currency()
				{
					One = "turkmensk manat",
					Other = "turkmenske manat",
				},
				["TND"] = new Currency()
				{
					One = "tunisisk dinar",
					Other = "tunisiske dinarar",
				},
				["TOP"] = new Currency()
				{
					One = "tongansk paʻanga",
					Other = "tonganske paʻanga",
				},
				["TRY"] = new Currency()
				{
					One = "tyrkisk lire",
					Other = "tyrkiske lire",
				},
				["TTD"] = new Currency()
				{
					One = "trinidadisk dollar",
					Other = "trinidadiske dollar",
				},
				["TWD"] = new Currency()
				{
					One = "ny taiwansk dollar",
					Other = "nye taiwanske dollar",
				},
				["TZS"] = new Currency()
				{
					One = "tanzaniansk shilling",
					Other = "tanzanianske shilling",
				},
				["UAH"] = new Currency()
				{
					One = "ukrainsk hryvnia",
					Other = "ukrainske hryvnia",
				},
				["UGX"] = new Currency()
				{
					One = "ugandisk shilling",
					Other = "ugandiske shilling",
				},
				["USD"] = new Currency()
				{
					One = "amerikansk dollar",
					Other = "amerikanske dollar",
				},
				["UYU"] = new Currency()
				{
					One = "uruguayansk peso",
					Other = "uruguayanske pesos",
				},
				["UZS"] = new Currency()
				{
					One = "usbekisk sum",
					Other = "usbekiske sum",
				},
				["VES"] = new Currency()
				{
					One = "venezuelansk bolivar",
					Other = "venezuelanske bolivar",
				},
				["VND"] = new Currency()
				{
					One = "vietnamesisk dong",
					Other = "vietnamesiske dong",
				},
				["VUV"] = new Currency()
				{
					One = "vanuatuisk vatu",
					Other = "vanuatuiske vatu",
				},
				["WST"] = new Currency()
				{
					One = "samoansk tala",
					Other = "samoanske tala",
				},
				["XAF"] = new Currency()
				{
					One = "sentralafrikansk CFA-franc",
					Other = "sentralafrikanske CFA-franc",
				},
				["XCD"] = new Currency()
				{
					One = "austkaribisk dollar",
					Other = "austkaribiske dollar",
				},
				["XOF"] = new Currency()
				{
					One = "vestafrikansk CFA-franc",
					Other = "vestafrikanske CFA-franc",
				},
				["XPF"] = new Currency()
				{
					Other = "CFP-franc",
				},
				["YER"] = new Currency()
				{
					One = "jemenittisk rial",
					Other = "jemenittiske rial",
				},
				["ZAR"] = new Currency()
				{
					One = "sørafrikansk rand",
					Other = "sørafrikanske rand",
				},
				["ZMW"] = new Currency()
				{
					One = "zambisk kwacha",
					Other = "zambiske kwacha",
				},
				["ZWL"] = new Currency()
				{
					One = "zimbabwisk dollar (2009)",
					Other = "zimbabwiske dollar (2009)",
				},
			};
		}
	}
}
