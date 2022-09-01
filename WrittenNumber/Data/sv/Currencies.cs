using WrittenNumber.Models;

namespace WrittenNumber.Data.sv
{
	public static class Currencies
	{
		public static Dictionary<string, Currency> Get()
		{
			return new Dictionary<string, Currency>()
			{
				["AED"] = new Currency()
				{
					Other = "emiratisk dirham",
				},
				["AFN"] = new Currency()
				{
					One = "afghansk afghani",
					Other = "afghanska afghani",
				},
				["ALL"] = new Currency()
				{
					One = "albansk lek",
					Other = "albanska leke",
				},
				["AMD"] = new Currency()
				{
					One = "armenisk dram",
					Other = "armeniska dram",
				},
				["ANG"] = new Currency()
				{
					Other = "antillergulden",
				},
				["AOA"] = new Currency()
				{
					One = "angolansk kwanza",
					Other = "angolanska kwanza",
				},
				["ARS"] = new Currency()
				{
					One = "argentinsk peso",
					Other = "argentinska pesos",
				},
				["AUD"] = new Currency()
				{
					One = "australisk dollar",
					Other = "australiska dollar",
				},
				["AWG"] = new Currency()
				{
					One = "arubansk florin",
					Other = "arubanska floriner",
				},
				["BAM"] = new Currency()
				{
					One = "bosnisk-hercegovinsk mark (konvertibel)",
					Other = "bosnisk-hercegovinska mark (konvertibla)",
				},
				["BBD"] = new Currency()
				{
					Other = "barbadisk dollar",
				},
				["BDT"] = new Currency()
				{
					One = "bangladeshisk taka",
					Other = "bangladeshiska taka",
				},
				["BGN"] = new Currency()
				{
					One = "bulgarisk lev",
					Other = "bulgariska leva",
				},
				["BHD"] = new Currency()
				{
					One = "bahrainsk dinar",
					Other = "bahrainska dinarer",
				},
				["BIF"] = new Currency()
				{
					One = "burundisk franc",
					Other = "burundiska franc",
				},
				["BMD"] = new Currency()
				{
					Other = "bermudisk dollar",
				},
				["BND"] = new Currency()
				{
					One = "bruneisk dollar",
					Other = "bruneiska dollar",
				},
				["BOB"] = new Currency()
				{
					One = "boliviansk boliviano",
					Other = "bolivianska bolivianos",
				},
				["BOV"] = new Currency()
				{
					One = "boliviansk mvdol",
					Other = "bolivianska mvdol",
				},
				["BRL"] = new Currency()
				{
					One = "brasiliansk real",
					Other = "brasilianska real",
				},
				["BTN"] = new Currency()
				{
					One = "bhutanesisk ngultrum",
					Other = "bhutanesiska ngultrum",
				},
				["BWP"] = new Currency()
				{
					One = "botswansk pula",
					Other = "botswanska pula",
				},
				["BYN"] = new Currency()
				{
					One = "vitrysk rubel",
					Other = "vitryska rubel",
				},
				["BZD"] = new Currency()
				{
					One = "belizisk dollar",
					Other = "beliziska dollar",
				},
				["CAD"] = new Currency()
				{
					One = "kanadensisk dollar",
					Other = "kanadensiska dollar",
				},
				["CDF"] = new Currency()
				{
					One = "kongolesisk franc",
					Other = "kongolesiska franc",
				},
				["CHE"] = new Currency()
				{
					One = "euro (WIR Bank)",
					Other = "euro (konvertibelt konto, WIR Bank, Schweiz)",
				},
				["CHF"] = new Currency()
				{
					One = "schweizisk franc",
					Other = "schweiziska franc",
				},
				["CHW"] = new Currency()
				{
					One = "franc (WIR Bank)",
					Other = "franc (konvertibelt konto, WIR Bank, Schweiz)",
				},
				["CLF"] = new Currency()
				{
					One = "chilensk unidad de fomento",
					Other = "chilenska unidad de fomento",
				},
				["CNY"] = new Currency()
				{
					One = "kinesisk yuan",
					Other = "kinesiska yuan",
				},
				["COP"] = new Currency()
				{
					One = "colombiansk peso",
					Other = "colombianska pesos",
				},
				["COU"] = new Currency()
				{
					One = "colombiansk unidad de valor real",
					Other = "colombianska unidad de valor real",
				},
				["CRC"] = new Currency()
				{
					One = "costarikansk colón",
					Other = "costarikanska colón",
				},
				["CUC"] = new Currency()
				{
					One = "kubansk peso (konvertibel)",
					Other = "kubanska pesos (konvertibla)",
				},
				["CUP"] = new Currency()
				{
					One = "kubansk peso",
					Other = "kubanska pesos",
				},
				["CVE"] = new Currency()
				{
					One = "kapverdisk escudo",
					Other = "kapverdiska escudos",
				},
				["CZK"] = new Currency()
				{
					One = "tjeckisk koruna",
					Other = "tjeckiska koruna",
				},
				["DJF"] = new Currency()
				{
					One = "djiboutisk franc",
					Other = "djiboutiska franc",
				},
				["DKK"] = new Currency()
				{
					One = "dansk krona",
					Other = "danska kronor",
				},
				["DOP"] = new Currency()
				{
					One = "dominikansk peso",
					Other = "dominikanska pesos",
				},
				["DZD"] = new Currency()
				{
					One = "algerisk dinar",
					Other = "algeriska dinarer",
				},
				["EGP"] = new Currency()
				{
					One = "egyptiskt pund",
					Other = "egyptiska pund",
				},
				["ERN"] = new Currency()
				{
					One = "eritreansk nakfa",
					Other = "eritreanska nakfa",
				},
				["ETB"] = new Currency()
				{
					One = "etiopisk birr",
					Other = "etiopiska birr",
				},
				["EUR"] = new Currency()
				{
					Other = "euro",
				},
				["FJD"] = new Currency()
				{
					Other = "Fijidollar",
				},
				["FKP"] = new Currency()
				{
					Other = "Falklandspund",
				},
				["GBP"] = new Currency()
				{
					One = "brittiskt pund",
					Other = "brittiska pund",
				},
				["GEL"] = new Currency()
				{
					One = "georgisk lari",
					Other = "georgiska lari",
				},
				["GHS"] = new Currency()
				{
					One = "ghanansk cedi",
					Other = "ghananska cedi",
				},
				["GIP"] = new Currency()
				{
					One = "gibraltiskt pund",
					Other = "gibraltiska pund",
				},
				["GMD"] = new Currency()
				{
					One = "gambisk dalasi",
					Other = "gambiska dalasi",
				},
				["GNF"] = new Currency()
				{
					One = "guineansk franc",
					Other = "guineanska franc",
				},
				["GTQ"] = new Currency()
				{
					One = "guatemalansk quetzal",
					Other = "guatemalanska quetzal",
				},
				["GYD"] = new Currency()
				{
					Other = "Guyanadollar",
				},
				["HKD"] = new Currency()
				{
					Other = "Hongkongdollar",
				},
				["HNL"] = new Currency()
				{
					One = "honduransk lempira",
					Other = "honduranska lempira",
				},
				["HRK"] = new Currency()
				{
					One = "kroatisk kuna",
					Other = "kroatiska kunor",
				},
				["HTG"] = new Currency()
				{
					One = "haitisk gourde",
					Other = "haitiska gourder",
				},
				["HUF"] = new Currency()
				{
					One = "ungersk forint",
					Other = "ungerska forinter",
				},
				["IDR"] = new Currency()
				{
					One = "indonesisk rupie",
					Other = "indonesiska rupier",
				},
				["ILS"] = new Currency()
				{
					One = "israelisk ny shekel",
					Other = "israeliska nya shekel",
				},
				["INR"] = new Currency()
				{
					One = "indisk rupie",
					Other = "indiska rupier",
				},
				["IQD"] = new Currency()
				{
					One = "irakisk dinar",
					Other = "irakiska dinarer",
				},
				["IRR"] = new Currency()
				{
					One = "iransk rial",
					Other = "iranska rial",
				},
				["ISK"] = new Currency()
				{
					One = "isländsk krona",
					Other = "isländska kronor",
				},
				["JMD"] = new Currency()
				{
					One = "Jamaica-dollar",
					Other = "jamaicansk dollar",
				},
				["JOD"] = new Currency()
				{
					One = "jordansk dinar",
					Other = "jordanska dinarer",
				},
				["JPY"] = new Currency()
				{
					One = "japansk yen",
					Other = "japanska yen",
				},
				["KES"] = new Currency()
				{
					One = "kenyansk shilling",
					Other = "kenyanska shilling",
				},
				["KGS"] = new Currency()
				{
					One = "kirgizisk som",
					Other = "kirgiziska somer",
				},
				["KHR"] = new Currency()
				{
					One = "kambodjansk riel",
					Other = "kambodjanska riel",
				},
				["KMF"] = new Currency()
				{
					One = "komorisk franc",
					Other = "komoriska franc",
				},
				["KPW"] = new Currency()
				{
					One = "nordkoreansk won",
					Other = "nordkoreanska won",
				},
				["KRW"] = new Currency()
				{
					One = "sydkoreansk won",
					Other = "sydkoreanska won",
				},
				["KWD"] = new Currency()
				{
					One = "kuwaitisk dinar",
					Other = "kuwaitiska dinarer",
				},
				["KYD"] = new Currency()
				{
					Other = "caymansk dollar",
				},
				["KZT"] = new Currency()
				{
					One = "kazakisk tenge",
					Other = "kazakiska tenge",
				},
				["LAK"] = new Currency()
				{
					One = "laotisk kip",
					Other = "laotiska kip",
				},
				["LBP"] = new Currency()
				{
					One = "libanesiskt pund",
					Other = "libanesiska pund",
				},
				["LKR"] = new Currency()
				{
					One = "srilankesisk rupie",
					Other = "srilankesiska rupier",
				},
				["LRD"] = new Currency()
				{
					One = "liberiansk dollar",
					Other = "liberianska dollar",
				},
				["LSL"] = new Currency()
				{
					One = "lesothisk loti",
					Other = "lesothiska lotier",
				},
				["LYD"] = new Currency()
				{
					One = "libysk dinar",
					Other = "libyska dinarer",
				},
				["MAD"] = new Currency()
				{
					One = "marockansk dirham",
					Other = "marockanska dirhamer",
				},
				["MDL"] = new Currency()
				{
					One = "moldavisk leu",
					Other = "moldaviska lei",
				},
				["MGA"] = new Currency()
				{
					One = "madagaskisk ariary",
					Other = "madagaskiska ariary",
				},
				["MKD"] = new Currency()
				{
					One = "makedonisk denar",
					Other = "makedoniska denarer",
				},
				["MMK"] = new Currency()
				{
					One = "myanmarisk kyat",
					Other = "myanmariska kyat",
				},
				["MNT"] = new Currency()
				{
					One = "mongolisk tögrög",
					Other = "mongoliska tögrög",
				},
				["MOP"] = new Currency()
				{
					One = "makanesisk pataca",
					Other = "makanesiska pataca",
				},
				["MRU"] = new Currency()
				{
					One = "mauretansk ouguiya",
					Other = "mauretanska ouguiya",
				},
				["MUR"] = new Currency()
				{
					One = "mauritisk rupie",
					Other = "mauritiska rupier",
				},
				["MVR"] = new Currency()
				{
					One = "maldivisk rufiyaa",
					Other = "maldiviska rufiyer",
				},
				["MWK"] = new Currency()
				{
					One = "malawisk kwacha",
					Other = "malawiska kwacha",
				},
				["MXN"] = new Currency()
				{
					One = "mexikansk peso",
					Other = "mexikanska pesos",
				},
				["MXV"] = new Currency()
				{
					One = "mexikansk unidad de inversion",
					Other = "mexikanska unidad de inversion",
				},
				["MYR"] = new Currency()
				{
					One = "malaysisk ringgit",
					Other = "malaysiska ringgiter",
				},
				["MZN"] = new Currency()
				{
					One = "moçambikisk metical",
					Other = "moçambikiska metical",
				},
				["NAD"] = new Currency()
				{
					One = "namibisk dollar",
					Other = "namibiska dollar",
				},
				["NGN"] = new Currency()
				{
					One = "nigeriansk naira",
					Other = "nigerianska naira",
				},
				["NIO"] = new Currency()
				{
					One = "nicaraguansk córdoba",
					Other = "nicaraguanska córdobas",
				},
				["NOK"] = new Currency()
				{
					One = "norsk krona",
					Other = "norska kronor",
				},
				["NPR"] = new Currency()
				{
					One = "nepalesisk rupie",
					Other = "nepalesiska rupier",
				},
				["NZD"] = new Currency()
				{
					One = "nyzeeländsk dollar",
					Other = "nyzeeländska dollar",
				},
				["OMR"] = new Currency()
				{
					One = "omansk rial",
					Other = "omanska rial",
				},
				["PAB"] = new Currency()
				{
					One = "panamansk balboa",
					Other = "panamanska balboa",
				},
				["PEN"] = new Currency()
				{
					One = "peruansk sol",
					Other = "peruanska sol",
				},
				["PGK"] = new Currency()
				{
					One = "papuansk kina",
					Other = "papuanska kinor",
				},
				["PHP"] = new Currency()
				{
					One = "filippinsk peso",
					Other = "filippinska pesos",
				},
				["PKR"] = new Currency()
				{
					One = "pakistansk rupie",
					Other = "pakistanska rupier",
				},
				["PLN"] = new Currency()
				{
					One = "polsk zloty",
					Other = "polska zloty",
				},
				["PYG"] = new Currency()
				{
					One = "paraguayansk guarani",
					Other = "paraguayska guarani",
				},
				["QAR"] = new Currency()
				{
					One = "qatarisk rial",
					Other = "qatariska rial",
				},
				["RON"] = new Currency()
				{
					One = "rumänsk leu",
					Other = "rumänska lei",
				},
				["RSD"] = new Currency()
				{
					One = "serbisk dinar",
					Other = "serbiska dinarer",
				},
				["RUB"] = new Currency()
				{
					One = "rysk rubel",
					Other = "ryska rubel",
				},
				["RWF"] = new Currency()
				{
					One = "rwandisk franc",
					Other = "rwandiska franc",
				},
				["SAR"] = new Currency()
				{
					One = "saudisk riyal",
					Other = "saudiska riyal",
				},
				["SBD"] = new Currency()
				{
					Other = "Salomondollar",
				},
				["SCR"] = new Currency()
				{
					One = "seychellisk rupie",
					Other = "seychelliska rupier",
				},
				["SDG"] = new Currency()
				{
					One = "sudanesiskt pund",
					Other = "sudanesiska pund",
				},
				["SEK"] = new Currency()
				{
					One = "svensk krona",
					Other = "svenska kronor",
				},
				["SGD"] = new Currency()
				{
					One = "singaporiansk dollar",
					Other = "singaporianska dollar",
				},
				["SHP"] = new Currency()
				{
					Other = "sankthelenskt pund",
				},
				["SLL"] = new Currency()
				{
					One = "sierraleonsk leone",
					Other = "sierraleonska leoner",
				},
				["SOS"] = new Currency()
				{
					One = "somalisk shilling",
					Other = "somaliska shilling",
				},
				["SRD"] = new Currency()
				{
					One = "surinamesisk dollar",
					Other = "surinamesiska dollar",
				},
				["SSP"] = new Currency()
				{
					One = "sydsudanesiskt pund",
					Other = "sydsudanesiska pund",
				},
				["STN"] = new Currency()
				{
					One = "saotomeansk dobra",
					Other = "saotomeanska dobra",
				},
				["SVC"] = new Currency()
				{
					One = "salvadoransk colón",
					Other = "salvadoranska colón",
				},
				["SYP"] = new Currency()
				{
					One = "syriskt pund",
					Other = "syriska pund",
				},
				["SZL"] = new Currency()
				{
					One = "swaziländsk lilangeni",
					Other = "swaziländska lilangeni",
				},
				["THB"] = new Currency()
				{
					One = "thailändsk baht",
					Other = "thailändska baht",
				},
				["TJS"] = new Currency()
				{
					One = "tadzjikisk somoni",
					Other = "tadzjikiska somoni",
				},
				["TMT"] = new Currency()
				{
					One = "turkmenistansk manat",
					Other = "turkmenistanska manat",
				},
				["TND"] = new Currency()
				{
					One = "tunisisk dinar",
					Other = "tunisiska dinarer",
				},
				["TOP"] = new Currency()
				{
					One = "tongansk paʻanga",
					Other = "tonganska paʻanga",
				},
				["TRY"] = new Currency()
				{
					One = "turkisk lira",
					Other = "turkiska lira",
				},
				["TTD"] = new Currency()
				{
					Other = "Trinidaddollar",
				},
				["TWD"] = new Currency()
				{
					Other = "taiwanesisk dollar",
				},
				["TZS"] = new Currency()
				{
					One = "tanzanisk shilling",
					Other = "tanzaniska shilling",
				},
				["UAH"] = new Currency()
				{
					One = "ukrainsk hryvnia",
					Other = "ukrainska hryvnia",
				},
				["UGX"] = new Currency()
				{
					One = "ugandisk shilling",
					Other = "ugandiska shilling",
				},
				["USD"] = new Currency()
				{
					Other = "amerikansk dollar",
				},
				["UYU"] = new Currency()
				{
					One = "uruguayansk peso",
					Other = "uruguayanska pesos",
				},
				["UZS"] = new Currency()
				{
					One = "uzbekisk sum",
					Other = "uzbekiska sum",
				},
				["VES"] = new Currency()
				{
					One = "venezuelansk bolívar",
					Other = "venezuelanska bolívar",
				},
				["VND"] = new Currency()
				{
					One = "vietnamesisk dong",
					Other = "vietnamesiska dong",
				},
				["VUV"] = new Currency()
				{
					One = "vanuatisk vatu",
					Other = "vanuatiska vatu",
				},
				["WST"] = new Currency()
				{
					One = "västsamoansk tala",
					Other = "västsamoanska tala",
				},
				["XAF"] = new Currency()
				{
					One = "centralafrikansk franc",
					Other = "centralafrikanska franc",
				},
				["XCD"] = new Currency()
				{
					One = "östkaribisk dollar",
					Other = "östkaribiska dollar",
				},
				["XOF"] = new Currency()
				{
					One = "västafrikansk franc",
					Other = "västafrikanska franc",
				},
				["XPF"] = new Currency()
				{
					Other = "CFP-franc",
				},
				["YER"] = new Currency()
				{
					One = "jemenitisk rial",
					Other = "jemenitiska rial",
				},
				["ZAR"] = new Currency()
				{
					One = "sydafrikansk rand",
					Other = "sydafrikanska rand",
				},
				["ZMW"] = new Currency()
				{
					One = "zambisk kwacha",
					Other = "zambiska kwacha",
				},
				["ZWL"] = new Currency()
				{
					Other = "Zimbabwe-dollar (2009)",
				},
			};
		}
	}
}
