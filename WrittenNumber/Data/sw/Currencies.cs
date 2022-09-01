using WrittenNumber.Models;

namespace WrittenNumber.Data.sw
{
	public static class Currencies
	{
		public static Dictionary<string, Currency> Get()
		{
			return new Dictionary<string, Currency>()
			{
				["AED"] = new Currency()
				{
					One = "dirham ya Falme za Kiarabu",
					Other = "dirham za Falme za Kiarabu",
				},
				["AFN"] = new Currency()
				{
					One = "afghani ya Afghanistan",
					Other = "afghani za Afghanistan",
				},
				["ALL"] = new Currency()
				{
					One = "lek ya Albania",
					Other = "lek za Albania",
				},
				["AMD"] = new Currency()
				{
					One = "dram ya Armenia",
					Other = "dram za Armenia",
				},
				["ANG"] = new Currency()
				{
					One = "guilder ya Antili za Kiholanzi",
					Other = "guilder za Antili za Kiholanzi",
				},
				["AOA"] = new Currency()
				{
					One = "kwanza ya Angola",
					Other = "kwanza za Angola",
				},
				["ARS"] = new Currency()
				{
					One = "peso ya Ajentina",
					Other = "peso za Ajentina",
				},
				["AUD"] = new Currency()
				{
					One = "dola ya Australia",
					Other = "dola za Australia",
				},
				["AWG"] = new Currency()
				{
					One = "florin ya Aruba",
					Other = "florin za Aruba",
				},
				["BAM"] = new Currency()
				{
					One = "convertible mark ya Bosnia na Hezegovina",
					Other = "convertible mark za Bosnia na Hezegovina",
				},
				["BBD"] = new Currency()
				{
					One = "dola ya Barbados",
					Other = "dola za Barbados",
				},
				["BDT"] = new Currency()
				{
					One = "taka ya Bangladesh",
					Other = "taka za Bangladesh",
				},
				["BGN"] = new Currency()
				{
					One = "lev ya Bulgaria",
					Other = "lev za Bulgaria",
				},
				["BHD"] = new Currency()
				{
					One = "dinari ya Bahareni",
					Other = "dinari za Bahareni",
				},
				["BIF"] = new Currency()
				{
					One = "faranga ya Burundi",
					Other = "faranga za Burundi",
				},
				["BMD"] = new Currency()
				{
					One = "dola ya Bermuda",
					Other = "dola za Bermuda",
				},
				["BND"] = new Currency()
				{
					One = "dola ya Brunei",
					Other = "dola za Brunei",
				},
				["BOB"] = new Currency()
				{
					One = "Boliviano ya Bolivia",
					Other = "Boliviano za Bolivia",
				},
				["BRL"] = new Currency()
				{
					One = "Real ya Brazil",
					Other = "Real za Brazil",
				},
				["BTN"] = new Currency()
				{
					One = "ngultrum ya Bhutan",
					Other = "ngultrum za Bhutan",
				},
				["BWP"] = new Currency()
				{
					One = "pula ya Botswana",
					Other = "pula za Botswana",
				},
				["BYN"] = new Currency()
				{
					One = "ruble ya Belarus",
					Other = "ruble za Belarus",
				},
				["BZD"] = new Currency()
				{
					One = "dola ya Belize",
					Other = "dola za Belize",
				},
				["CAD"] = new Currency()
				{
					One = "dola ya Canada",
					Other = "dola za Canada",
				},
				["CDF"] = new Currency()
				{
					One = "faranga ya Kongo",
					Other = "faranga za Kongo",
				},
				["CHF"] = new Currency()
				{
					One = "faranga ya Uswisi",
					Other = "faranga za Uswisi",
				},
				["CNY"] = new Currency()
				{
					One = "yuan ya Uchina",
					Other = "yuan za Uchina",
				},
				["COP"] = new Currency()
				{
					One = "peso ya Kolombia",
					Other = "peso za Kolombia",
				},
				["CRC"] = new Currency()
				{
					One = "colon ya Kostarika",
					Other = "colon za Kostarika",
				},
				["CUC"] = new Currency()
				{
					One = "peso ya Kuba inayoweza kubadilishwa",
					Other = "peso za Kuba zinazoweza kubadilishwa",
				},
				["CUP"] = new Currency()
				{
					One = "peso ya Kuba",
					Other = "peso za Kuba",
				},
				["CVE"] = new Currency()
				{
					One = "eskudo ya Cape Verde",
					Other = "eskudo za Cape Verde",
				},
				["CZK"] = new Currency()
				{
					One = "koruna ya Jamhuri ya Czech",
					Other = "koruna za Jamhuri ya Czech",
				},
				["DJF"] = new Currency()
				{
					One = "faranga ya Jibuti",
					Other = "faranga za Jibuti",
				},
				["DKK"] = new Currency()
				{
					One = "krone ya Denmark",
					Other = "krone za Denmark",
				},
				["DOP"] = new Currency()
				{
					One = "peso ya Dominika",
					Other = "peso za Dominika",
				},
				["DZD"] = new Currency()
				{
					One = "dinar ya Aljeria",
					Other = "dinar za Aljeria",
				},
				["EGP"] = new Currency()
				{
					One = "pauni ya Misri",
					Other = "pauni za Misri",
				},
				["ERN"] = new Currency()
				{
					One = "nakfa ya Eritrea",
					Other = "nakfa za Eritrea",
				},
				["ETB"] = new Currency()
				{
					One = "birr ya Uhabeshi",
					Other = "birr za Uhabeshi",
				},
				["EUR"] = new Currency()
				{
					Other = "yuro",
				},
				["FJD"] = new Currency()
				{
					One = "dola ya Fiji",
					Other = "dola za Fiji",
				},
				["FKP"] = new Currency()
				{
					One = "Pauni ya Visiwa vya Falkland",
					Other = "Pauni za Visiwa vya Falkland",
				},
				["GBP"] = new Currency()
				{
					One = "pauni ya Uingereza",
					Other = "pauni za Uingereza",
				},
				["GEL"] = new Currency()
				{
					One = "lari ya Jojia",
					Other = "lari za Jojia",
				},
				["GHS"] = new Currency()
				{
					One = "cedi ya Ghana",
					Other = "cedi za Ghana",
				},
				["GIP"] = new Currency()
				{
					One = "pauni ya Gibraltar",
					Other = "pauni za Gibraltar",
				},
				["GMD"] = new Currency()
				{
					One = "dalasi ya Gambia",
					Other = "dalasi za Gambia",
				},
				["GNF"] = new Currency()
				{
					One = "faranga ya Guinea",
					Other = "faranga za Guinea",
				},
				["GTQ"] = new Currency()
				{
					One = "quetzal ya Guatemala",
					Other = "quetzal za Guatemala",
				},
				["GYD"] = new Currency()
				{
					One = "dola ya Guyana",
					Other = "dola za Guyana",
				},
				["HKD"] = new Currency()
				{
					One = "dola ya Hong Kong",
					Other = "dola za Hong Kong",
				},
				["HNL"] = new Currency()
				{
					One = "lempira ya Hondurasi",
					Other = "lempira za Hondurasi",
				},
				["HRK"] = new Currency()
				{
					One = "kuna ya Korasia",
					Other = "kuna za Korasia",
				},
				["HTG"] = new Currency()
				{
					One = "gourde ya Haiti",
					Other = "gourde za Haiti",
				},
				["HUF"] = new Currency()
				{
					One = "forint ya Hungaria",
					Other = "forint za Hungaria",
				},
				["IDR"] = new Currency()
				{
					One = "rupiah ya Indonesia",
					Other = "rupiah za Indonesia",
				},
				["ILS"] = new Currency()
				{
					One = "shekeli mpya ya Israel",
					Other = "shekeli mpya za Israel",
				},
				["INR"] = new Currency()
				{
					One = "rupia ya India",
					Other = "rupia za India",
				},
				["IQD"] = new Currency()
				{
					One = "dinari ya Iraki",
					Other = "dinari za Iraki",
				},
				["IRR"] = new Currency()
				{
					One = "rial ya Iran",
					Other = "rial za Iran",
				},
				["ISK"] = new Currency()
				{
					One = "krona ya Aisilandi",
					Other = "krona za Aisilandi",
				},
				["JMD"] = new Currency()
				{
					One = "dola ya Jamaika",
					Other = "dola za Jamaika",
				},
				["JOD"] = new Currency()
				{
					One = "dinari ya Jordan",
					Other = "dinari za Jordan",
				},
				["JPY"] = new Currency()
				{
					One = "yen ya Japani",
					Other = "yen za Japani",
				},
				["KES"] = new Currency()
				{
					One = "shilingi ya Kenya",
					Other = "shilingi za Kenya",
				},
				["KGS"] = new Currency()
				{
					One = "som ya Kyrgystan",
					Other = "som za Kyrgystan",
				},
				["KHR"] = new Currency()
				{
					One = "riel ya Kambodia",
					Other = "riel za Kambodia",
				},
				["KMF"] = new Currency()
				{
					One = "faranga ya Komoro",
					Other = "faranga za Komoro",
				},
				["KPW"] = new Currency()
				{
					One = "won ya Korea Kaskazini",
					Other = "won za Korea Kaskazini",
				},
				["KRW"] = new Currency()
				{
					One = "won ya Korea Kusini",
					Other = "won za Korea Kusini",
				},
				["KWD"] = new Currency()
				{
					One = "dinari ya Kuwait",
					Other = "dinari za Kuwait",
				},
				["KYD"] = new Currency()
				{
					One = "dola ya Visiwa vya Cayman",
					Other = "dola za Visiwa vya Cayman",
				},
				["KZT"] = new Currency()
				{
					One = "tenge ya Kazakhstan",
					Other = "tenge za Kazakhstan",
				},
				["LAK"] = new Currency()
				{
					One = "kip ya Laosi",
					Other = "kip za Laosi",
				},
				["LBP"] = new Currency()
				{
					One = "pauni ya Lebanon",
					Other = "pauni za Lebanon",
				},
				["LKR"] = new Currency()
				{
					One = "rupia ya Sri Lanka",
					Other = "rupia za Sri Lanka",
				},
				["LRD"] = new Currency()
				{
					One = "dola ya Liberia",
					Other = "dola za Liberia",
				},
				["LSL"] = new Currency()
				{
					Other = "Loti za Lesoto",
				},
				["LYD"] = new Currency()
				{
					One = "dinari ya Libya",
					Other = "dinari za Libya",
				},
				["MAD"] = new Currency()
				{
					One = "dirham ya Moroko",
					Other = "dirham za Moroko",
				},
				["MDL"] = new Currency()
				{
					One = "leu ya Moldova",
					Other = "leu za Moldova",
				},
				["MGA"] = new Currency()
				{
					One = "ariari ya Madagaska",
					Other = "ariari za Madagaska",
				},
				["MKD"] = new Currency()
				{
					One = "denar ya Masedonia",
					Other = "denar za Masedonia",
				},
				["MMK"] = new Currency()
				{
					One = "kyat ya Myanmar",
					Other = "kyat za Myanmar",
				},
				["MNT"] = new Currency()
				{
					One = "tugrik ya Mongolia",
					Other = "tugrik za Mongolia",
				},
				["MOP"] = new Currency()
				{
					One = "pataca ya Macau",
					Other = "pataca za Macau",
				},
				["MRU"] = new Currency()
				{
					One = "ouguiya ya Moritania",
					Other = "ouguiya za Moritania",
				},
				["MUR"] = new Currency()
				{
					One = "rupia ya Morisi",
					Other = "rupia za Morisi",
				},
				["MVR"] = new Currency()
				{
					One = "rufiyaa ya Maldives",
					Other = "rufiyaa za Maldives",
				},
				["MWK"] = new Currency()
				{
					One = "kwacha ya Malawi",
					Other = "kwacha za Malawi",
				},
				["MXN"] = new Currency()
				{
					One = "peso ya Meksiko",
					Other = "peso za Meksiko",
				},
				["MYR"] = new Currency()
				{
					One = "ringgit ya Malaysia",
					Other = "ringgit za Malaysia",
				},
				["MZN"] = new Currency()
				{
					One = "metikali ya Msumbiji",
					Other = "metikali za Msumbiji",
				},
				["NAD"] = new Currency()
				{
					One = "dola ya Namibia",
					Other = "dola za Namibia",
				},
				["NGN"] = new Currency()
				{
					One = "naira ya Nigeria",
					Other = "naira za Nigeria",
				},
				["NIO"] = new Currency()
				{
					One = "cordoba ya Nikaragwa",
					Other = "cordoba za Nikaragwa",
				},
				["NOK"] = new Currency()
				{
					One = "krone ya Norwe",
					Other = "krone za Norwe",
				},
				["NPR"] = new Currency()
				{
					One = "rupia ya Nepal",
					Other = "rupia za Nepal",
				},
				["NZD"] = new Currency()
				{
					One = "dola ya Nyuzilandi",
					Other = "dola za Nyuzilandi",
				},
				["OMR"] = new Currency()
				{
					One = "rial ya Omani",
					Other = "rial za Omani",
				},
				["PAB"] = new Currency()
				{
					Other = "balboa ya Panama",
				},
				["PEN"] = new Currency()
				{
					One = "sol ya Peru",
					Other = "sol za Peru",
				},
				["PGK"] = new Currency()
				{
					One = "kina ya Papua New Guinea",
					Other = "kina za Papua New Guinea",
				},
				["PHP"] = new Currency()
				{
					One = "peso ya Ufilipino",
					Other = "peso za Ufilipino",
				},
				["PKR"] = new Currency()
				{
					One = "rupia ya Pakistan",
					Other = "rupia za Pakistan",
				},
				["PLN"] = new Currency()
				{
					One = "zloty ya Poland",
					Other = "zloty za Poland",
				},
				["PYG"] = new Currency()
				{
					One = "guarani ya Paragwai",
					Other = "guarani za Paragwai",
				},
				["QAR"] = new Currency()
				{
					Other = "rial ya Qatar",
				},
				["RON"] = new Currency()
				{
					One = "leu ya Romania",
					Other = "leu za Romania",
				},
				["RSD"] = new Currency()
				{
					One = "dinar ya Serbia",
					Other = "dinar za Serbia",
				},
				["RUB"] = new Currency()
				{
					One = "ruble ya Urusi",
					Other = "ruble za Urusi",
				},
				["RWF"] = new Currency()
				{
					One = "faranga ya Rwanda",
					Other = "faranga za Rwanda",
				},
				["SAR"] = new Currency()
				{
					One = "riyal ya Saudia",
					Other = "riyal za Saudia",
				},
				["SBD"] = new Currency()
				{
					One = "dola ya Visiwa vya Solomon",
					Other = "dola za Visiwa vya Solomon",
				},
				["SCR"] = new Currency()
				{
					One = "rupia ya Ushelisheli",
					Other = "rupia za Ushelisheli",
				},
				["SDG"] = new Currency()
				{
					One = "pauni ya Sudan",
					Other = "pauni za Sudan",
				},
				["SEK"] = new Currency()
				{
					One = "krona ya Uswidi",
					Other = "krona za Uswidi",
				},
				["SGD"] = new Currency()
				{
					One = "dola ya Singapore",
					Other = "dola za Singapore",
				},
				["SHP"] = new Currency()
				{
					One = "pauni ya St. Helena",
					Other = "pauni za St. Helena",
				},
				["SLL"] = new Currency()
				{
					One = "leone ya Siera Leoni",
					Other = "leone za Siera Leoni",
				},
				["SOS"] = new Currency()
				{
					One = "shilingi ya Somalia",
					Other = "shilingi za Somalia",
				},
				["SRD"] = new Currency()
				{
					One = "dola ya Suriname",
					Other = "dola za Suriname",
				},
				["SSP"] = new Currency()
				{
					One = "pauni ya Sudan Kusini",
					Other = "pauni za Sudan Kusini",
				},
				["STN"] = new Currency()
				{
					One = "dobra ya Sao Tome na Principe",
					Other = "dobra za Sao Tome na Principe",
				},
				["SYP"] = new Currency()
				{
					One = "pauni ya Syria",
					Other = "pauni za Syria",
				},
				["SZL"] = new Currency()
				{
					One = "lilangeni ya Uswazi",
					Other = "emalangeni za Uswazi",
				},
				["THB"] = new Currency()
				{
					One = "baht ya Tailandi",
					Other = "baht za Tailandi",
				},
				["TJS"] = new Currency()
				{
					One = "somoni ya Tajikistan",
					Other = "somoni za Tajikistan",
				},
				["TMT"] = new Currency()
				{
					One = "manat ya Turkmenistan",
					Other = "manat za Turkmenistan",
				},
				["TND"] = new Currency()
				{
					One = "dinari ya Tunisia",
					Other = "dinari za Tunisia",
				},
				["TOP"] = new Currency()
				{
					One = "paʻanga ya Tonga",
					Other = "paʻanga za Tonga",
				},
				["TRY"] = new Currency()
				{
					One = "lira ya Uturuki",
					Other = "lira za Uturuki",
				},
				["TTD"] = new Currency()
				{
					One = "Dola ya Trinidad na Tobago",
					Other = "Dola za Trinidad na Tobago",
				},
				["TWD"] = new Currency()
				{
					One = "dola ya Taiwan",
					Other = "dola za Taiwan",
				},
				["TZS"] = new Currency()
				{
					One = "shilingi ya Tanzania",
					Other = "shilingi za Tanzania",
				},
				["UAH"] = new Currency()
				{
					One = "hryvnia ya Ukraine",
					Other = "hryvnia za Ukraine",
				},
				["UGX"] = new Currency()
				{
					One = "shilingi ya Uganda",
					Other = "shilingi za Uganda",
				},
				["USD"] = new Currency()
				{
					One = "dola ya Marekani",
					Other = "dola za Marekani",
				},
				["UYU"] = new Currency()
				{
					One = "peso ya Urugwai",
					Other = "peso za Urugwai",
				},
				["UZS"] = new Currency()
				{
					One = "som ya Uzbekistan",
					Other = "som za Uzbekistan",
				},
				["VES"] = new Currency()
				{
					One = "bolivar ya Venezuela",
					Other = "bolivar za Venezuela",
				},
				["VND"] = new Currency()
				{
					One = "dong ya Vietnam",
					Other = "dong za Vietnam",
				},
				["VUV"] = new Currency()
				{
					One = "vatu ya Vanuatu",
					Other = "vatu za Vanuatu",
				},
				["WST"] = new Currency()
				{
					One = "tala ya Samoa",
					Other = "tala za Samoa",
				},
				["XAF"] = new Currency()
				{
					One = "faranga ya Afrika ya Kati CFA",
					Other = "faranga za Afrika ya Kati CFA",
				},
				["XCD"] = new Currency()
				{
					One = "dola ya Karibi Mashariki",
					Other = "dola za Karibi Mashariki",
				},
				["XOF"] = new Currency()
				{
					One = "faranga ya Afrika Magharibi CFA",
					Other = "faranga za Afrika Magharibi CFA",
				},
				["XPF"] = new Currency()
				{
					One = "faranga ya CFP",
					Other = "faranga za CFP",
				},
				["YER"] = new Currency()
				{
					One = "rial ya Yemen",
					Other = "rial za Yemen",
				},
				["ZAR"] = new Currency()
				{
					One = "randi ya Afrika Kusini",
					Other = "randi za Afrika Kusini",
				},
				["ZMW"] = new Currency()
				{
					One = "kwacha ya Zambia",
					Other = "kwacha za Zambia",
				},
			};
		}
	}
}
