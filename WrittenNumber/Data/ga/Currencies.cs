using WrittenNumber.Models;

namespace WrittenNumber.Data.ga
{
	public static class Currencies
	{
		public static Dictionary<string, Currency> Get()
		{
			return new Dictionary<string, Currency>()
			{
				["AED"] = new Currency()
				{
					Two = "dhirham Aontas na nÉimíríochtaí Arabacha",
					Few = "dhirham Aontas na nÉimíríochtaí Arabacha",
					Many = "ndirham Aontas na nÉimíríochtaí Arabacha",
					Other = "dirham Aontas na nÉimíríochtaí Arabacha",
				},
				["AFN"] = new Currency()
				{
					Two = "afghani na hAfganastáine",
					Few = "afghani na hAfganastáine",
					Many = "n-afghani na hAfganastáine",
					Other = "afghani na hAfganastáine",
				},
				["ALL"] = new Currency()
				{
					One = "lek na hAlbáine",
					Two = "lek na hAlbáine",
					Few = "lek na hAlbáine",
					Many = "lek na hAlbáine",
					Other = "Lek na hAlbáine",
				},
				["AMD"] = new Currency()
				{
					Two = "dhram na hAirméine",
					Few = "dhram na hAirméine",
					Many = "ndram na hAirméine",
					Other = "dram na hAirméine",
				},
				["ANG"] = new Currency()
				{
					One = "ghildear Aintillí na hÍsiltíre",
					Two = "ghildear Aintillí na hÍsiltíre",
					Few = "ghildear Aintillí na hÍsiltíre",
					Many = "ngildear Aintillí na hÍsiltíre",
					Other = "gildear Aintillí na hÍsiltíre",
				},
				["AOA"] = new Currency()
				{
					Two = "kwanza Angóla",
					Few = "kwanza Angóla",
					Many = "kwanza Angóla",
					Other = "kwanza Angóla",
				},
				["ARS"] = new Currency()
				{
					One = "pheso na hAirgintíne",
					Two = "pheso na hAirgintíne",
					Few = "pheso na hAirgintíne",
					Many = "bpeso na hAirgintíne",
					Other = "peso na hAirgintíne",
				},
				["AUD"] = new Currency()
				{
					Two = "dhollar na hAstráile",
					Few = "dhollar na hAstráile",
					Many = "ndollar na hAstráile",
					Other = "dollar na hAstráile",
				},
				["AWG"] = new Currency()
				{
					One = "fhlóirín Arúba",
					Two = "fhlóirín Arúba",
					Few = "fhlóirín Arúba",
					Many = "bhflóirín Arúba",
					Other = "flóirín Arúba",
				},
				["BAM"] = new Currency()
				{
					One = "mharg inmhalartaithe na Boisnia-Heirseagaivéine",
					Two = "mharg inmhalartaithe na Boisnia-Heirseagaivéine",
					Few = "mharg inmhalartaithe na Boisnia-Heirseagaivéine",
					Many = "marg inmhalartaithe na Boisnia-Heirseagaivéine",
					Other = "marg inmhalartaithe na Boisnia-Heirseagaivéine",
				},
				["BBD"] = new Currency()
				{
					Two = "dhollar Bharbadós",
					Few = "dhollar Bharbadós",
					Many = "ndollar Bharbadós",
					Other = "dollar Bharbadós",
				},
				["BDT"] = new Currency()
				{
					Two = "thaka na Banglaidéise",
					Few = "thaka na Banglaidéise",
					Many = "dtaka na Banglaidéise",
					Other = "taka na Banglaidéise",
				},
				["BGN"] = new Currency()
				{
					Two = "lev na Bulgáire",
					Few = "lev na Bulgáire",
					Many = "lev na Bulgáire",
					Other = "lev na Bulgáire",
				},
				["BHD"] = new Currency()
				{
					Two = "dhinar Bhairéin",
					Few = "dhinar Bhairéin",
					Many = "ndinar Bhairéin",
					Other = "dinar Bhairéin",
				},
				["BIF"] = new Currency()
				{
					One = "fhranc na Burúine",
					Two = "fhranc na Burúine",
					Few = "fhranc na Burúine",
					Many = "bhfranc na Burúine",
					Other = "franc na Burúine",
				},
				["BMD"] = new Currency()
				{
					Two = "dhollar Bheirmiúda",
					Few = "dhollar Bheirmiúda",
					Many = "ndollar Bheirmiúda",
					Other = "dollar Bheirmiúda",
				},
				["BND"] = new Currency()
				{
					Two = "dhollar Bhrúiné",
					Few = "dhollar Bhrúiné",
					Many = "ndollar Bhrúiné",
					Other = "dollar Bhrúiné",
				},
				["BOB"] = new Currency()
				{
					One = "bholiviano",
					Two = "bholiviano",
					Few = "bholiviano",
					Many = "mboliviano",
					Other = "boliviano",
				},
				["BOV"] = new Currency()
				{
					Two = "mvdol na Bolaive",
					Few = "mvdol na Bolaive",
					Many = "mvdol na Bolaive",
					Other = "mvdol na Bolaive",
				},
				["BRL"] = new Currency()
				{
					Two = "real na Brasaíle",
					Few = "real na Brasaíle",
					Many = "real na Brasaíle",
					Other = "real na Brasaíle",
				},
				["BTN"] = new Currency()
				{
					Two = "ngultrum na Bútáine",
					Few = "ngultrum na Bútáine",
					Many = "ngultrum na Bútáine",
					Other = "ngultrum na Bútáine",
				},
				["BWP"] = new Currency()
				{
					One = "phula na Botsuáine",
					Two = "phula na Botsuáine",
					Few = "phula na Botsuáine",
					Many = "bpula na Botsuáine",
					Other = "pula na Botsuáine",
				},
				["BYN"] = new Currency()
				{
					Two = "rúbal na Bealarúise",
					Few = "rúbal na Bealarúise",
					Many = "rúbal na Bealarúise",
					Other = "rúbal na Bealarúise",
				},
				["BZD"] = new Currency()
				{
					Two = "dhollar na Beilíse",
					Few = "dhollar na Beilíse",
					Many = "ndollar na Beilíse",
					Other = "dollar na Beilíse",
				},
				["CAD"] = new Currency()
				{
					Two = "dhollar Cheanada",
					Few = "dhollar Cheanada",
					Many = "ndollar Cheanada",
					Other = "dollar Cheanada",
				},
				["CDF"] = new Currency()
				{
					One = "fhranc an Chongó",
					Two = "fhranc an Chongó",
					Few = "fhranc an Chongó",
					Many = "bhfranc an Chongó",
					Other = "franc an Chongó",
				},
				["CHF"] = new Currency()
				{
					One = "fhranc na hEilvéise",
					Two = "fhranc na hEilvéise",
					Few = "fhranc na hEilvéise",
					Many = "bhfranc na hEilvéise",
					Other = "franc na hEilvéise",
				},
				["CLF"] = new Currency()
				{
					Two = "Unidades de Fomento na Sile",
					Few = "Unidades de Fomento na Sile",
					Many = "Unidades de Fomento na Sile",
					Other = "Unidades de Fomento na Sile",
				},
				["CNY"] = new Currency()
				{
					Two = "yuan na Síne",
					Few = "yuan na Síne",
					Many = "yuan na Síne",
					Other = "yuan na Síne",
				},
				["COP"] = new Currency()
				{
					One = "pheso na Colóime",
					Two = "pheso na Colóime",
					Few = "pheso na Colóime",
					Many = "bpeso na Colóime",
					Other = "peso na Colóime",
				},
				["CRC"] = new Currency()
				{
					One = "cholón Chósta Ríce",
					Two = "cholón Chósta Ríce",
					Few = "cholón Chósta Ríce",
					Many = "gcolón Chósta Ríce",
					Other = "colón Chósta Ríce",
				},
				["CUC"] = new Currency()
				{
					One = "pheso inmhalartaithe Chúba",
					Two = "pheso inmhalartaithe Chúba",
					Few = "pheso inmhalartaithe Chúba",
					Many = "bpeso inmhalartaithe Chúba",
					Other = "peso inmhalartaithe Chúba",
				},
				["CUP"] = new Currency()
				{
					One = "pheso Chúba",
					Two = "pheso Chúba",
					Few = "pheso Chúba",
					Many = "bpeso Chúba",
					Other = "peso Chúba",
				},
				["CVE"] = new Currency()
				{
					Two = "escudo Rinn Verde",
					Few = "escudo Rinn Verde",
					Many = "n-escudo Rinn Verde",
					Other = "escudo Rinn Verde",
				},
				["CZK"] = new Currency()
				{
					Two = "koruna Phoblacht na Seice",
					Few = "koruna Phoblacht na Seice",
					Many = "koruna Phoblacht na Seice",
					Other = "koruna Phoblacht na Seice",
				},
				["DJF"] = new Currency()
				{
					One = "fhranc Djibouti",
					Two = "fhranc Djibouti",
					Few = "fhranc Djibouti",
					Many = "bhfranc Djibouti",
					Other = "franc Djibouti",
				},
				["DKK"] = new Currency()
				{
					One = "choróin na Danmhairge",
					Two = "choróin na Danmhairge",
					Few = "choróin na Danmhairge",
					Many = "gcoróin na Danmhairge",
					Other = "coróin na Danmhairge",
				},
				["DOP"] = new Currency()
				{
					One = "pheso na Poblachta Doiminicí",
					Two = "pheso na Poblachta Doiminicí",
					Few = "pheso na Poblachta Doiminicí",
					Many = "bpeso na Poblachta Doiminicí",
					Other = "peso na Poblachta Doiminicí",
				},
				["DZD"] = new Currency()
				{
					Two = "dhinar na hAilgéire",
					Few = "dhinar na hAilgéire",
					Many = "ndinar na hAilgéire",
					Other = "dinar na hAilgéire",
				},
				["EGP"] = new Currency()
				{
					One = "phunt na hÉigipte",
					Two = "phunt na hÉigipte",
					Few = "phunt na hÉigipte",
					Many = "bpunt na hÉigipte",
					Other = "punt na hÉigipte",
				},
				["ERN"] = new Currency()
				{
					Two = "nakfa na hEiritré",
					Few = "nakfa na hEiritré",
					Many = "nakfa na hEiritré",
					Other = "nakfa na hEiritré",
				},
				["ETB"] = new Currency()
				{
					One = "bhirr na hAetóipe",
					Two = "bhirr na hAetóipe",
					Few = "bhirr na hAetóipe",
					Many = "mbirr na hAetóipe",
					Other = "birr na hAetóipe",
				},
				["EUR"] = new Currency()
				{
					Two = "euro",
					Few = "euro",
					Many = "euro",
					Other = "euro",
				},
				["FJD"] = new Currency()
				{
					Two = "dhollar Fhidsí",
					Few = "dhollar Fhidsí",
					Many = "ndollar Fhidsí",
					Other = "dollar Fhidsí",
				},
				["FKP"] = new Currency()
				{
					One = "phunt Oileáin Fháclainne",
					Two = "phunt Oileáin Fháclainne",
					Few = "phunt Oileáin Fháclainne",
					Many = "bpunt Oileáin Fháclainne",
					Other = "punt Oileáin Fháclainne",
				},
				["GBP"] = new Currency()
				{
					One = "phunt steirling",
					Two = "phunt steirling",
					Few = "phunt steirling",
					Many = "bpunt steirling",
					Other = "punt steirling",
				},
				["GEL"] = new Currency()
				{
					Two = "lari na Seoirsia",
					Few = "lari na Seoirsia",
					Many = "lari na Seoirsia",
					Other = "lari na Seoirsia",
				},
				["GHS"] = new Currency()
				{
					One = "chedi Ghána",
					Two = "chedi Ghána",
					Few = "chedi Ghána",
					Many = "gcedi Ghána",
					Other = "cedi Ghána",
				},
				["GIP"] = new Currency()
				{
					One = "phunt Ghiobráltar",
					Two = "phunt Ghiobráltar",
					Few = "phunt Ghiobráltar",
					Many = "bpunt Ghiobráltar",
					Other = "punt Ghiobráltar",
				},
				["GMD"] = new Currency()
				{
					Two = "dhalasi na Gaimbia",
					Few = "dhalasi na Gaimbia",
					Many = "ndalasi na Gaimbia",
					Other = "dalasi na Gaimbia",
				},
				["GNF"] = new Currency()
				{
					One = "fhranc na Guine",
					Two = "fhranc na Guine",
					Few = "fhranc na Guine",
					Many = "bhfranc na Guine",
					Other = "franc na Guine",
				},
				["GTQ"] = new Currency()
				{
					Two = "quetzal Ghuatamala",
					Few = "quetzal Ghuatamala",
					Many = "quetzal Ghuatamala",
					Other = "quetzal Ghuatamala",
				},
				["GYD"] = new Currency()
				{
					Two = "dhollar na Guáine",
					Few = "dhollar na Guáine",
					Many = "ndollar na Guáine",
					Other = "dollar na Guáine",
				},
				["HKD"] = new Currency()
				{
					Two = "dhollar Hong Cong",
					Few = "dhollar Hong Cong",
					Many = "ndollar Hong Cong",
					Other = "dollar Hong Cong",
				},
				["HNL"] = new Currency()
				{
					Two = "lempira Hondúras",
					Few = "lempira Hondúras",
					Many = "lempira Hondúras",
					Other = "lempira Hondúras",
				},
				["HRK"] = new Currency()
				{
					Two = "kuna na Cróite",
					Few = "kuna na Cróite",
					Many = "kuna na Cróite",
					Other = "kuna na Cróite",
				},
				["HTG"] = new Currency()
				{
					One = "ghourde Háítí",
					Two = "ghourde Háítí",
					Few = "ghourde Háítí",
					Many = "ngourde Háítí",
					Other = "gourde Háítí",
				},
				["HUF"] = new Currency()
				{
					One = "fhorint na hUngáire",
					Two = "fhorint na hUngáire",
					Few = "fhorint na hUngáire",
					Many = "bhforint na hUngáire",
					Other = "forint na hUngáire",
				},
				["IDR"] = new Currency()
				{
					Two = "rupiah na hIndinéise",
					Few = "rupiah na hIndinéise",
					Many = "rupiah na hIndinéise",
					Other = "rupiah na hIndinéise",
				},
				["ILS"] = new Currency()
				{
					Two = "sheiceal nua Iosrael",
					Few = "sheiceal nua Iosrael",
					Many = "seiceal nua Iosrael",
					Other = "seiceal nua Iosrael",
				},
				["INR"] = new Currency()
				{
					Two = "rúipí na hIndia",
					Few = "rúipí na hIndia",
					Many = "rúipí na hIndia",
					Other = "rúipí na hIndia",
				},
				["IQD"] = new Currency()
				{
					Two = "dhinar na hIaráice",
					Few = "dhinar na hIaráice",
					Many = "ndinar na hIaráice",
					Other = "dinar na hIaráice",
				},
				["IRR"] = new Currency()
				{
					Two = "rial na hIaráine",
					Few = "rial na hIaráine",
					Many = "rial na hIaráine",
					Other = "rial na hIaráine",
				},
				["ISK"] = new Currency()
				{
					Two = "króna na hÍoslainne",
					Few = "króna na hÍoslainne",
					Many = "króna na hÍoslainne",
					Other = "króna na hÍoslainne",
				},
				["JMD"] = new Currency()
				{
					Two = "dhollar na hIamáice",
					Few = "dhollar na hIamáice",
					Many = "ndollar na hIamáice",
					Other = "dollar na hIamáice",
				},
				["JOD"] = new Currency()
				{
					Two = "dhinar na hIordáine",
					Few = "dhinar na hIordáine",
					Many = "ndinar na hIordáine",
					Other = "dinar na hIordáine",
				},
				["JPY"] = new Currency()
				{
					Two = "yen na Seapáine",
					Few = "yen na Seapáine",
					Many = "yen na Seapáine",
					Other = "yen na Seapáine",
				},
				["KES"] = new Currency()
				{
					Two = "scilling na Céinia",
					Few = "scilling na Céinia",
					Many = "scilling na Céinia",
					Other = "scilling na Céinia",
				},
				["KGS"] = new Currency()
				{
					Two = "shom na Cirgeastáine",
					Few = "shom na Cirgeastáine",
					Many = "som na Cirgeastáine",
					Other = "som na Cirgeastáine",
				},
				["KHR"] = new Currency()
				{
					Two = "riel na Cambóide",
					Few = "riel na Cambóide",
					Many = "riel na Cambóide",
					Other = "riel na Cambóide",
				},
				["KMF"] = new Currency()
				{
					One = "fhranc Oileáin Chomóra",
					Two = "fhranc Oileáin Chomóra",
					Few = "fhranc Oileáin Chomóra",
					Many = "bhfranc Oileáin Chomóra",
					Other = "franc Oileáin Chomóra",
				},
				["KPW"] = new Currency()
				{
					Two = "won na Cóiré Thuaidh",
					Few = "won na Cóiré Thuaidh",
					Many = "won na Cóiré Thuaidh",
					Other = "won na Cóiré Thuaidh",
				},
				["KRW"] = new Currency()
				{
					Two = "won na Cóiré Theas",
					Few = "won na Cóiré Theas",
					Many = "won na Cóiré Theas",
					Other = "won na Cóiré Theas",
				},
				["KWD"] = new Currency()
				{
					Two = "dhinar Chuáit",
					Few = "dhinar Chuáit",
					Many = "ndinar Chuáit",
					Other = "dinar Chuáit",
				},
				["KYD"] = new Currency()
				{
					Two = "dhollar Oileáin Cayman",
					Few = "dhollar Oileáin Cayman",
					Many = "ndollar Oileáin Cayman",
					Other = "dollar Oileáin Cayman",
				},
				["KZT"] = new Currency()
				{
					Two = "thenge na Casacstáine",
					Few = "thenge na Casacstáine",
					Many = "dtenge na Casacstáine",
					Other = "tenge na Casacstáine",
				},
				["LAK"] = new Currency()
				{
					Two = "kip Laos",
					Few = "kip Laos",
					Many = "kip Laos",
					Other = "kip Laos",
				},
				["LBP"] = new Currency()
				{
					One = "phunt na Liobáine",
					Two = "phunt na Liobáine",
					Few = "phunt na Liobáine",
					Many = "bpunt na Liobáine",
					Other = "punt na Liobáine",
				},
				["LKR"] = new Currency()
				{
					Two = "rúipí Shrí Lanca",
					Few = "rúipí Shrí Lanca",
					Many = "rúipí Shrí Lanca",
					Other = "rúipí Shrí Lanca",
				},
				["LRD"] = new Currency()
				{
					Two = "dhollar na Libéire",
					Few = "dhollar na Libéire",
					Many = "ndollar na Libéire",
					Other = "dollar na Libéire",
				},
				["LSL"] = new Currency()
				{
					Two = "Loti Leosóta",
					Few = "Loti Leosóta",
					Many = "Loti Leosóta",
					Other = "Loti Leosóta",
				},
				["LYD"] = new Currency()
				{
					Two = "dhinar na Libia",
					Few = "dhinar na Libia",
					Many = "ndinar na Libia",
					Other = "dinar na Libia",
				},
				["MAD"] = new Currency()
				{
					Two = "dhirham Mharacó",
					Few = "dhirham Mharacó",
					Many = "ndirham Mharacó",
					Other = "dirham Mharacó",
				},
				["MDL"] = new Currency()
				{
					Two = "leu na Moldóive",
					Few = "leu na Moldóive",
					Many = "leu na Moldóive",
					Other = "leu na Moldóive",
				},
				["MGA"] = new Currency()
				{
					Two = "ariary Mhadagascar",
					Few = "ariary Mhadagascar",
					Many = "n-ariary Mhadagascar",
					Other = "ariary Mhadagascar",
				},
				["MKD"] = new Currency()
				{
					Two = "dhenar na Macadóine",
					Few = "dhenar na Macadóine",
					Many = "ndenar na Macadóine",
					Other = "denar na Macadóine",
				},
				["MMK"] = new Currency()
				{
					Two = "kyat Mhaenmar",
					Few = "kyat Mhaenmar",
					Many = "kyat Mhaenmar",
					Other = "kyat Mhaenmar",
				},
				["MNT"] = new Currency()
				{
					Two = "thugrik na Mongóile",
					Few = "thugrik na Mongóile",
					Many = "dtugrik na Mongóile",
					Other = "tugrik na Mongóile",
				},
				["MOP"] = new Currency()
				{
					One = "phataca Mhacao",
					Two = "phataca Mhacao",
					Few = "phataca Mhacao",
					Many = "bpataca Mhacao",
					Other = "pataca Mhacao",
				},
				["MRU"] = new Currency()
				{
					Two = "ouguiya na Máratáine",
					Few = "ouguiya na Máratáine",
					Many = "n-ouguiya na Máratáine",
					Other = "ouguiya na Máratáine",
				},
				["MUR"] = new Currency()
				{
					Two = "rúipí Oileán Mhuirís",
					Few = "rúipí Oileán Mhuirís",
					Many = "rúipí Oileán Mhuirís",
					Other = "rúipí Oileán Mhuirís",
				},
				["MVR"] = new Currency()
				{
					Two = "rufiyaa Oileáin Mhaildíve",
					Few = "rufiyaa Oileáin Mhaildíve",
					Many = "rufiyaa Oileáin Mhaildíve",
					Other = "rufiyaa Oileáin Mhaildíve",
				},
				["MWK"] = new Currency()
				{
					Two = "kwacha na Maláive",
					Few = "kwacha na Maláive",
					Many = "kwacha na Maláive",
					Other = "kwacha na Maláive",
				},
				["MXN"] = new Currency()
				{
					One = "pheso Mheicsiceo",
					Two = "pheso Mheicsiceo",
					Few = "pheso Mheicsiceo",
					Many = "bpeso Mheicsiceo",
					Other = "peso Mheicsiceo",
				},
				["MXV"] = new Currency()
				{
					Two = "Unidad de Inversion (UDI) Meicsiceo",
					Few = "Unidad de Inversion (UDI) Meicsiceo",
					Many = "Unidad de Inversion (UDI) Meicsiceo",
					Other = "Unidad de Inversion (UDI) Meicsiceo",
				},
				["MYR"] = new Currency()
				{
					Two = "ringgit na Malaeisia",
					Few = "ringgit na Malaeisia",
					Many = "ringgit na Malaeisia",
					Other = "ringgit na Malaeisia",
				},
				["MZN"] = new Currency()
				{
					One = "mhetical Mhósaimbíc",
					Two = "mhetical Mhósaimbíc",
					Few = "mhetical Mhósaimbíc",
					Many = "metical Mhósaimbíc",
					Other = "metical Mhósaimbíc",
				},
				["NAD"] = new Currency()
				{
					Two = "dhollar na Namaibe",
					Few = "dhollar na Namaibe",
					Many = "ndollar na Namaibe",
					Other = "dollar na Namaibe",
				},
				["NGN"] = new Currency()
				{
					Two = "naira na Nigéire",
					Few = "naira na Nigéire",
					Many = "naira na Nigéire",
					Other = "naira na Nigéire",
				},
				["NIO"] = new Currency()
				{
					One = "chórdoba Nicearagua",
					Two = "chórdoba Nicearagua",
					Few = "chórdoba Nicearagua",
					Many = "gcórdoba Nicearagua",
					Other = "córdoba Nicearagua",
				},
				["NOK"] = new Currency()
				{
					One = "choróin na hIorua",
					Two = "choróin na hIorua",
					Few = "choróin na hIorua",
					Many = "gcoróin na hIorua",
					Other = "coróin na hIorua",
				},
				["NPR"] = new Currency()
				{
					Two = "rúipí Neipeal",
					Few = "rúipí Neipeal",
					Many = "rúipí Neipeal",
					Other = "rúipí Neipeal",
				},
				["NZD"] = new Currency()
				{
					Two = "dhollar na Nua-Shéalainne",
					Few = "dhollar na Nua-Shéalainne",
					Many = "ndollar na Nua-Shéalainne",
					Other = "dollar na Nua-Shéalainne",
				},
				["OMR"] = new Currency()
				{
					Two = "rial Óman",
					Few = "rial Óman",
					Many = "rial Óman",
					Other = "rial Óman",
				},
				["PAB"] = new Currency()
				{
					One = "bhalboa Phanama",
					Two = "bhalboa Phanama",
					Few = "bhalboa Phanama",
					Many = "mbalboa Phanama",
					Other = "balboa Phanama",
				},
				["PEN"] = new Currency()
				{
					One = "sol Pheiriú",
					Two = "shol Pheiriú",
					Few = "sol Pheiriú",
					Many = "sol Pheiriú",
					Other = "Sol Pheiriú",
				},
				["PGK"] = new Currency()
				{
					Two = "kina Nua-Ghuine Phapua",
					Few = "kina Nua-Ghuine Phapua",
					Many = "kina Nua-Ghuine Phapua",
					Other = "kina Nua-Ghuine Phapua",
				},
				["PHP"] = new Currency()
				{
					One = "pheso na nOileán Filipíneach",
					Two = "pheso na nOileán Filipíneach",
					Few = "pheso na nOileán Filipíneach",
					Many = "bpeso na nOileán Filipíneach",
					Other = "peso na nOileán Filipíneach",
				},
				["PKR"] = new Currency()
				{
					Two = "rúipí na Pacastáine",
					Few = "rúipí na Pacastáine",
					Many = "rúipí na Pacastáine",
					Other = "rúipí na Pacastáine",
				},
				["PLN"] = new Currency()
				{
					Two = "zloty na Polainne",
					Few = "zloty na Polainne",
					Many = "zloty na Polainne",
					Other = "zloty na Polainne",
				},
				["PYG"] = new Currency()
				{
					One = "ghuaraní Pharagua",
					Two = "ghuaraní Pharagua",
					Few = "ghuaraní Pharagua",
					Many = "nguaraní Pharagua",
					Other = "guaraní Pharagua",
				},
				["QAR"] = new Currency()
				{
					Two = "riyal Chatar",
					Few = "riyal Chatar",
					Many = "riyal Chatar",
					Other = "riyal Chatar",
				},
				["RON"] = new Currency()
				{
					Two = "leu na Rómáine",
					Few = "leu na Rómáine",
					Many = "leu na Rómáine",
					Other = "leu na Rómáine",
				},
				["RSD"] = new Currency()
				{
					Two = "dhinar na Seirbia",
					Few = "dhinar na Seirbia",
					Many = "ndinar na Seirbia",
					Other = "dinar na Seirbia",
				},
				["RUB"] = new Currency()
				{
					Two = "rúbal na Rúise",
					Few = "rúbal na Rúise",
					Many = "rúbal na Rúise",
					Other = "rúbal na Rúise",
				},
				["RWF"] = new Currency()
				{
					One = "fhranc Ruanda",
					Two = "fhranc Ruanda",
					Few = "fhranc Ruanda",
					Many = "bhfranc Ruanda",
					Other = "franc Ruanda",
				},
				["SAR"] = new Currency()
				{
					Two = "riyal na hAraibe Sádaí",
					Few = "riyal na hAraibe Sádaí",
					Many = "riyal na hAraibe Sádaí",
					Other = "riyal na hAraibe Sádaí",
				},
				["SBD"] = new Currency()
				{
					Two = "dhollar Oileáin Sholomón",
					Few = "dhollar Oileáin Sholomón",
					Many = "ndollar Oileáin Sholomón",
					Other = "dollar Oileáin Sholomón",
				},
				["SCR"] = new Currency()
				{
					Two = "rúipí na Séiséal",
					Few = "rúipí na Séiséal",
					Many = "rúipí na Séiséal",
					Other = "rúipí na Séiséal",
				},
				["SDG"] = new Currency()
				{
					One = "phunt na Súdáine",
					Two = "phunt na Súdáine",
					Few = "phunt na Súdáine",
					Many = "bpunt na Súdáine",
					Other = "punt na Súdáine",
				},
				["SEK"] = new Currency()
				{
					One = "choróin na Sualainne",
					Two = "choróin na Sualainne",
					Few = "choróin na Sualainne",
					Many = "gcoróin na Sualainne",
					Other = "coróin na Sualainne",
				},
				["SGD"] = new Currency()
				{
					Two = "dhollar Shingeapór",
					Few = "dhollar Shingeapór",
					Many = "ndollar Shingeapór",
					Other = "dollar Shingeapór",
				},
				["SHP"] = new Currency()
				{
					One = "phunt San Héilin",
					Two = "phunt San Héilin",
					Few = "phunt San Héilin",
					Many = "bpunt San Héilin",
					Other = "punt San Héilin",
				},
				["SLL"] = new Currency()
				{
					Two = "leone Shiarra Leon",
					Few = "leone Shiarra Leon",
					Many = "leone Shiarra Leon",
					Other = "leone Shiarra Leon",
				},
				["SOS"] = new Currency()
				{
					Two = "scilling na Somáile",
					Few = "scilling na Somáile",
					Many = "scilling na Somáile",
					Other = "scilling na Somáile",
				},
				["SRD"] = new Currency()
				{
					Two = "dhollar Shuranam",
					Few = "dhollar Shuranam",
					Many = "ndollar Shuranam",
					Other = "dollar Shuranam",
				},
				["SSP"] = new Currency()
				{
					One = "phunt na Súdáine Theas",
					Two = "phunt na Súdáine Theas",
					Few = "phunt na Súdáine Theas",
					Many = "bpunt na Súdáine Theas",
					Other = "punt na Súdáine Theas",
				},
				["STN"] = new Currency()
				{
					Two = "dhobra São Tomé agus Príncipe",
					Few = "dhobra São Tomé agus Príncipe",
					Many = "ndobra São Tomé agus Príncipe",
					Other = "dobra São Tomé agus Príncipe",
				},
				["SVC"] = new Currency()
				{
					One = "cholón na Salvadóire",
					Two = "cholón na Salvadóire",
					Few = "cholón na Salvadóire",
					Many = "gcolón na Salvadóire",
					Other = "colón na Salvadóire",
				},
				["SYP"] = new Currency()
				{
					One = "phunt na Siria",
					Two = "phunt na Siria",
					Few = "phunt na Siria",
					Many = "bpunt na Siria",
					Other = "punt na Siria",
				},
				["SZL"] = new Currency()
				{
					Two = "lilangeni na Suasalainne",
					Few = "lilangeni na Suasalainne",
					Many = "lilangeni na Suasalainne",
					Other = "lilangeni na Suasalainne",
				},
				["THB"] = new Currency()
				{
					One = "bhaht na Téalainne",
					Two = "bhaht na Téalainne",
					Few = "bhaht na Téalainne",
					Many = "mbaht na Téalainne",
					Other = "baht na Téalainne",
				},
				["TJS"] = new Currency()
				{
					Two = "shomoni na Táidsíceastáine",
					Few = "shomoni na Táidsíceastáine",
					Many = "somoni na Táidsíceastáine",
					Other = "somoni na Táidsíceastáine",
				},
				["TMT"] = new Currency()
				{
					One = "mhanat na Tuircméanastáine",
					Two = "mhanat na Tuircméanastáine",
					Few = "mhanat na Tuircméanastáine",
					Many = "manat na Tuircméanastáine",
					Other = "manat na Tuircméanastáine",
				},
				["TND"] = new Currency()
				{
					Two = "dhinar na Túinéise",
					Few = "dhinar na Túinéise",
					Many = "ndinar na Túinéise",
					Other = "dinar na Túinéise",
				},
				["TOP"] = new Currency()
				{
					One = "phaʻanga Thonga",
					Two = "phaʻanga Thonga",
					Few = "phaʻanga Thonga",
					Many = "bpaʻanga Thonga",
					Other = "paʻanga Thonga",
				},
				["TRY"] = new Currency()
				{
					Two = "lira na Tuirce",
					Few = "lira na Tuirce",
					Many = "lira na Tuirce",
					Other = "lira na Tuirce",
				},
				["TTD"] = new Currency()
				{
					Two = "dhollar Oileán na Tríonóide agus Tobága",
					Few = "dhollar Oileán na Tríonóide agus Tobága",
					Many = "ndollar Oileán na Tríonóide agus Tobága",
					Other = "dollar Oileán na Tríonóide agus Tobága",
				},
				["TWD"] = new Currency()
				{
					Two = "dhollar nua na Téaváine",
					Few = "dhollar nua na Téaváine",
					Many = "ndollar nua na Téaváine",
					Other = "dollar nua na Téaváine",
				},
				["TZS"] = new Currency()
				{
					Two = "scilling na Tansáine",
					Few = "scilling na Tansáine",
					Many = "scilling na Tansáine",
					Other = "scilling na Tansáine",
				},
				["UAH"] = new Currency()
				{
					Two = "hryvnia na hÚcráine",
					Few = "hryvnia na hÚcráine",
					Many = "hryvnia na hÚcráine",
					Other = "hryvnia na hÚcráine",
				},
				["UGX"] = new Currency()
				{
					Two = "scilling Uganda",
					Few = "scilling Uganda",
					Many = "scilling Uganda",
					Other = "scilling Uganda",
				},
				["USD"] = new Currency()
				{
					Two = "dhollar S.A.M.",
					Few = "dhollar S.A.M.",
					Many = "ndollar S.A.M.",
					Other = "dollar S.A.M.",
				},
				["UYU"] = new Currency()
				{
					One = "pheso Uragua",
					Two = "pheso Uragua",
					Few = "pheso Uragua",
					Many = "bpeso Uragua",
					Other = "peso Uragua",
				},
				["UZS"] = new Currency()
				{
					Two = "shum na hÚisbéiceastáine",
					Few = "shum na hÚisbéiceastáine",
					Many = "sum na hÚisbéiceastáine",
					Other = "sum na hÚisbéiceastáine",
				},
				["VES"] = new Currency()
				{
					One = "bholívar Veiniséala",
					Two = "bholívar Veiniséala",
					Few = "bholívar Veiniséala",
					Many = "mbolívar Veiniséala",
					Other = "bolívar Veiniséala",
				},
				["VND"] = new Currency()
				{
					One = "dong Vítneam",
					Two = "dhong Vítneam",
					Few = "dhong Vítneam",
					Many = "ndong Vítneam",
					Other = "Dong Vítneam",
				},
				["VUV"] = new Currency()
				{
					Two = "vatu Vanuatú",
					Few = "vatu Vanuatú",
					Many = "vatu Vanuatú",
					Other = "vatu Vanuatú",
				},
				["WST"] = new Currency()
				{
					Two = "thala Shamó",
					Few = "thala Shamó",
					Many = "dtala Shamó",
					Other = "tala Shamó",
				},
				["XAF"] = new Currency()
				{
					One = "fhranc CFA na hAfraice Láir",
					Two = "fhranc CFA na hAfraice Láir",
					Few = "fhranc CFA na hAfraice Láir",
					Many = "bhfranc CFA na hAfraice Láir",
					Other = "franc CFA na hAfraice Láir",
				},
				["XCD"] = new Currency()
				{
					Two = "dhollar na Cairibe Thoir",
					Few = "dhollar na Cairibe Thoir",
					Many = "ndollar na Cairibe Thoir",
					Other = "dollar na Cairibe Thoir",
				},
				["XOF"] = new Currency()
				{
					One = "fhranc CFA Iarthar na hAfraice",
					Two = "fhranc CFA Iarthar na hAfraice",
					Few = "fhranc CFA Iarthar na hAfraice",
					Many = "bhfranc CFA Iarthar na hAfraice",
					Other = "franc CFA Iarthar na hAfraice",
				},
				["XPF"] = new Currency()
				{
					One = "fhranc CFP",
					Two = "fhranc CFP",
					Few = "fhranc CFP",
					Many = "bhfranc CFP",
					Other = "franc CFP",
				},
				["YER"] = new Currency()
				{
					Two = "rial Éimin",
					Few = "rial Éimin",
					Many = "rial Éimin",
					Other = "rial Éimin",
				},
				["ZAR"] = new Currency()
				{
					Two = "rand na hAfraice Theas",
					Few = "rand na hAfraice Theas",
					Many = "rand na hAfraice Theas",
					Other = "rand na hAfraice Theas",
				},
				["ZMW"] = new Currency()
				{
					Two = "kwacha na Saimbia",
					Few = "kwacha na Saimbia",
					Many = "kwacha na Saimbia",
					Other = "kwacha na Saimbia",
				},
			};
		}
	}
}
