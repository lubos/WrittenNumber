using WrittenNumber.Models;

namespace WrittenNumber.Data.nl
{
	public static class Currencies
	{
		public static Dictionary<string, Currency> Get()
		{
			return new Dictionary<string, Currency>()
			{
				["AED"] = new Currency()
				{
					Other = "VAE-dirham",
				},
				["AFN"] = new Currency()
				{
					Other = "Afghaanse afghani",
				},
				["ALL"] = new Currency()
				{
					Other = "Albanese lek",
				},
				["AMD"] = new Currency()
				{
					Other = "Armeense dram",
				},
				["ANG"] = new Currency()
				{
					Other = "Nederlands-Antilliaanse gulden",
				},
				["AOA"] = new Currency()
				{
					Other = "Angolese kwanza",
				},
				["ARS"] = new Currency()
				{
					Other = "Argentijnse peso",
				},
				["AUD"] = new Currency()
				{
					Other = "Australische dollar",
				},
				["AWG"] = new Currency()
				{
					Other = "Arubaanse gulden",
				},
				["BAM"] = new Currency()
				{
					Other = "Bosnische convertibele mark",
				},
				["BBD"] = new Currency()
				{
					Other = "Barbadaanse dollar",
				},
				["BDT"] = new Currency()
				{
					Other = "Bengalese taka",
				},
				["BGN"] = new Currency()
				{
					One = "Bulgaarse lev",
					Other = "Bulgaarse leva",
				},
				["BHD"] = new Currency()
				{
					Other = "Bahreinse dinar",
				},
				["BIF"] = new Currency()
				{
					Other = "Burundese frank",
				},
				["BMD"] = new Currency()
				{
					Other = "Bermuda-dollar",
				},
				["BND"] = new Currency()
				{
					Other = "Bruneise dollar",
				},
				["BOB"] = new Currency()
				{
					Other = "Boliviaanse boliviano",
				},
				["BOV"] = new Currency()
				{
					Other = "Boliviaanse mvdol",
				},
				["BRL"] = new Currency()
				{
					Other = "Braziliaanse real",
				},
				["BTN"] = new Currency()
				{
					Other = "Bhutaanse ngultrum",
				},
				["BWP"] = new Currency()
				{
					Other = "Botswaanse pula",
				},
				["BYN"] = new Currency()
				{
					Other = "Belarussische roebel",
				},
				["BZD"] = new Currency()
				{
					Other = "Belizaanse dollar",
				},
				["CAD"] = new Currency()
				{
					Other = "Canadese dollar",
				},
				["CDF"] = new Currency()
				{
					Other = "Congolese frank",
				},
				["CHE"] = new Currency()
				{
					Other = "WIR euro",
				},
				["CHF"] = new Currency()
				{
					Other = "Zwitserse frank",
				},
				["CHW"] = new Currency()
				{
					Other = "WIR franc",
				},
				["CLF"] = new Currency()
				{
					Other = "Chileense unidades de fomento",
				},
				["CNY"] = new Currency()
				{
					Other = "Chinese yuan",
				},
				["COP"] = new Currency()
				{
					Other = "Colombiaanse peso",
				},
				["COU"] = new Currency()
				{
					Other = "Unidad de Valor Real",
				},
				["CRC"] = new Currency()
				{
					Other = "Costa Ricaanse colon",
				},
				["CUC"] = new Currency()
				{
					Other = "Cubaanse convertibele peso",
				},
				["CUP"] = new Currency()
				{
					Other = "Cubaanse peso",
				},
				["CVE"] = new Currency()
				{
					Other = "Kaapverdische escudo",
				},
				["CZK"] = new Currency()
				{
					One = "Tsjechische kroon",
					Other = "Tsjechische kronen",
				},
				["DJF"] = new Currency()
				{
					Other = "Djiboutiaanse frank",
				},
				["DKK"] = new Currency()
				{
					One = "Deense kroon",
					Other = "Deense kronen",
				},
				["DOP"] = new Currency()
				{
					Other = "Dominicaanse peso",
				},
				["DZD"] = new Currency()
				{
					Other = "Algerijnse dinar",
				},
				["EGP"] = new Currency()
				{
					Other = "Egyptisch pond",
				},
				["ERN"] = new Currency()
				{
					Other = "Eritrese nakfa",
				},
				["ETB"] = new Currency()
				{
					Other = "Ethiopische birr",
				},
				["EUR"] = new Currency()
				{
					Other = "euro",
				},
				["FJD"] = new Currency()
				{
					Other = "Fiji-dollar",
				},
				["FKP"] = new Currency()
				{
					Other = "Falklandeilands pond",
				},
				["GBP"] = new Currency()
				{
					Other = "Brits pond",
				},
				["GEL"] = new Currency()
				{
					Other = "Georgische lari",
				},
				["GHS"] = new Currency()
				{
					Other = "Ghanese cedi",
				},
				["GIP"] = new Currency()
				{
					Other = "Gibraltarees pond",
				},
				["GMD"] = new Currency()
				{
					Other = "Gambiaanse dalasi",
				},
				["GNF"] = new Currency()
				{
					Other = "Guinese frank",
				},
				["GTQ"] = new Currency()
				{
					Other = "Guatemalteekse quetzal",
				},
				["GYD"] = new Currency()
				{
					Other = "Guyaanse dollar",
				},
				["HKD"] = new Currency()
				{
					Other = "Hongkongse dollar",
				},
				["HNL"] = new Currency()
				{
					Other = "Hondurese lempira",
				},
				["HRK"] = new Currency()
				{
					Other = "Kroatische kuna",
				},
				["HTG"] = new Currency()
				{
					Other = "Haïtiaanse gourde",
				},
				["HUF"] = new Currency()
				{
					Other = "Hongaarse forint",
				},
				["IDR"] = new Currency()
				{
					Other = "Indonesische roepia",
				},
				["ILS"] = new Currency()
				{
					Other = "Israëlische nieuwe shekel",
				},
				["INR"] = new Currency()
				{
					Other = "Indiase roepie",
				},
				["IQD"] = new Currency()
				{
					Other = "Iraakse dinar",
				},
				["IRR"] = new Currency()
				{
					Other = "Iraanse rial",
				},
				["ISK"] = new Currency()
				{
					One = "IJslandse kroon",
					Other = "IJslandse kronen",
				},
				["JMD"] = new Currency()
				{
					Other = "Jamaicaanse dollar",
				},
				["JOD"] = new Currency()
				{
					Other = "Jordaanse dinar",
				},
				["JPY"] = new Currency()
				{
					Other = "Japanse yen",
				},
				["KES"] = new Currency()
				{
					Other = "Keniaanse shilling",
				},
				["KGS"] = new Currency()
				{
					Other = "Kirgizische som",
				},
				["KHR"] = new Currency()
				{
					Other = "Cambodjaanse riel",
				},
				["KMF"] = new Currency()
				{
					Other = "Comorese frank",
				},
				["KPW"] = new Currency()
				{
					Other = "Noord-Koreaanse won",
				},
				["KRW"] = new Currency()
				{
					Other = "Zuid-Koreaanse won",
				},
				["KWD"] = new Currency()
				{
					Other = "Koeweitse dinar",
				},
				["KYD"] = new Currency()
				{
					Other = "Kaaimaneilandse dollar",
				},
				["KZT"] = new Currency()
				{
					Other = "Kazachse tenge",
				},
				["LAK"] = new Currency()
				{
					Other = "Laotiaanse kip",
				},
				["LBP"] = new Currency()
				{
					Other = "Libanees pond",
				},
				["LKR"] = new Currency()
				{
					Other = "Sri Lankaanse roepie",
				},
				["LRD"] = new Currency()
				{
					Other = "Liberiaanse dollar",
				},
				["LSL"] = new Currency()
				{
					Other = "Lesothaanse loti",
				},
				["LYD"] = new Currency()
				{
					Other = "Libische dinar",
				},
				["MAD"] = new Currency()
				{
					Other = "Marokkaanse dirham",
				},
				["MDL"] = new Currency()
				{
					Other = "Moldavische leu",
				},
				["MGA"] = new Currency()
				{
					Other = "Malagassische ariary",
				},
				["MKD"] = new Currency()
				{
					Other = "Macedonische denar",
				},
				["MMK"] = new Currency()
				{
					Other = "Myanmarese kyat",
				},
				["MNT"] = new Currency()
				{
					Other = "Mongoolse tugrik",
				},
				["MOP"] = new Currency()
				{
					Other = "Macause pataca",
				},
				["MRU"] = new Currency()
				{
					Other = "Mauritaanse ouguiya",
				},
				["MUR"] = new Currency()
				{
					Other = "Mauritiaanse roepie",
				},
				["MVR"] = new Currency()
				{
					Other = "Maldivische rufiyaa",
				},
				["MWK"] = new Currency()
				{
					Other = "Malawische kwacha",
				},
				["MXN"] = new Currency()
				{
					Other = "Mexicaanse peso",
				},
				["MXV"] = new Currency()
				{
					Other = "Mexicaanse unidad de inversion (UDI)",
				},
				["MYR"] = new Currency()
				{
					Other = "Maleisische ringgit",
				},
				["MZN"] = new Currency()
				{
					Other = "Mozambikaanse metical",
				},
				["NAD"] = new Currency()
				{
					Other = "Namibische dollar",
				},
				["NGN"] = new Currency()
				{
					Other = "Nigeriaanse naira",
				},
				["NIO"] = new Currency()
				{
					Other = "Nicaraguaanse córdoba",
				},
				["NOK"] = new Currency()
				{
					One = "Noorse kroon",
					Other = "Noorse kronen",
				},
				["NPR"] = new Currency()
				{
					Other = "Nepalese roepie",
				},
				["NZD"] = new Currency()
				{
					Other = "Nieuw-Zeelandse dollar",
				},
				["OMR"] = new Currency()
				{
					Other = "Omaanse rial",
				},
				["PAB"] = new Currency()
				{
					Other = "Panamese balboa",
				},
				["PEN"] = new Currency()
				{
					Other = "Peruaanse sol",
				},
				["PGK"] = new Currency()
				{
					Other = "Papoea-Nieuw-Guinese kina",
				},
				["PHP"] = new Currency()
				{
					Other = "Filipijnse peso",
				},
				["PKR"] = new Currency()
				{
					Other = "Pakistaanse roepie",
				},
				["PLN"] = new Currency()
				{
					Other = "Poolse zloty",
				},
				["PYG"] = new Currency()
				{
					Other = "Paraguayaanse guarani",
				},
				["QAR"] = new Currency()
				{
					Other = "Qatarese rial",
				},
				["RON"] = new Currency()
				{
					Other = "Roemeense leu",
				},
				["RSD"] = new Currency()
				{
					Other = "Servische dinar",
				},
				["RUB"] = new Currency()
				{
					Other = "Russische roebel",
				},
				["RWF"] = new Currency()
				{
					Other = "Rwandese frank",
				},
				["SAR"] = new Currency()
				{
					Other = "Saoedi-Arabische riyal",
				},
				["SBD"] = new Currency()
				{
					Other = "Salomon-dollar",
				},
				["SCR"] = new Currency()
				{
					Other = "Seychelse roepie",
				},
				["SDG"] = new Currency()
				{
					Other = "Soedanees pond",
				},
				["SEK"] = new Currency()
				{
					One = "Zweedse kroon",
					Other = "Zweedse kronen",
				},
				["SGD"] = new Currency()
				{
					Other = "Singaporese dollar",
				},
				["SHP"] = new Currency()
				{
					Other = "Sint-Heleens pond",
				},
				["SLL"] = new Currency()
				{
					Other = "Sierraleoonse leone",
				},
				["SOS"] = new Currency()
				{
					Other = "Somalische shilling",
				},
				["SRD"] = new Currency()
				{
					Other = "Surinaamse dollar",
				},
				["SSP"] = new Currency()
				{
					Other = "Zuid-Soedanees pond",
				},
				["STN"] = new Currency()
				{
					Other = "Santomese dobra",
				},
				["SVC"] = new Currency()
				{
					Other = "Salvadoraanse colón",
				},
				["SYP"] = new Currency()
				{
					Other = "Syrisch pond",
				},
				["SZL"] = new Currency()
				{
					Other = "Swazische lilangeni",
				},
				["THB"] = new Currency()
				{
					Other = "Thaise baht",
				},
				["TJS"] = new Currency()
				{
					Other = "Tadzjiekse somoni",
				},
				["TMT"] = new Currency()
				{
					Other = "Turkmeense manat",
				},
				["TND"] = new Currency()
				{
					Other = "Tunesische dinar",
				},
				["TOP"] = new Currency()
				{
					Other = "Tongaanse paʻanga",
				},
				["TRY"] = new Currency()
				{
					Other = "Turkse lira",
				},
				["TTD"] = new Currency()
				{
					Other = "Trinidad en Tobago-dollar",
				},
				["TWD"] = new Currency()
				{
					Other = "Nieuwe Taiwanese dollar",
				},
				["TZS"] = new Currency()
				{
					Other = "Tanzaniaanse shilling",
				},
				["UAH"] = new Currency()
				{
					Other = "Oekraïense hryvnia",
				},
				["UGX"] = new Currency()
				{
					Other = "Oegandese shilling",
				},
				["USD"] = new Currency()
				{
					Other = "Amerikaanse dollar",
				},
				["UYU"] = new Currency()
				{
					Other = "Uruguayaanse peso",
				},
				["UZS"] = new Currency()
				{
					Other = "Oezbeekse sum",
				},
				["VES"] = new Currency()
				{
					Other = "Venezolaanse bolivar",
				},
				["VND"] = new Currency()
				{
					Other = "Vietnamese dong",
				},
				["VUV"] = new Currency()
				{
					Other = "Vanuatuaanse vatu",
				},
				["WST"] = new Currency()
				{
					Other = "Samoaanse tala",
				},
				["XAF"] = new Currency()
				{
					Other = "CFA-frank",
				},
				["XCD"] = new Currency()
				{
					Other = "Oost-Caribische dollar",
				},
				["XOF"] = new Currency()
				{
					Other = "CFA-franc BCEAO",
				},
				["XPF"] = new Currency()
				{
					Other = "CFP-frank",
				},
				["YER"] = new Currency()
				{
					Other = "Jemenitische rial",
				},
				["ZAR"] = new Currency()
				{
					Other = "Zuid-Afrikaanse rand",
				},
				["ZMW"] = new Currency()
				{
					Other = "Zambiaanse kwacha",
				},
				["ZWL"] = new Currency()
				{
					Other = "Zimbabwaanse dollar (2009)",
				},
			};
		}
	}
}
