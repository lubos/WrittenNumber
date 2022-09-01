using WrittenNumber.Models;

namespace WrittenNumber.Data.sk
{
	public static class Currencies
	{
		public static Dictionary<string, Currency> Get()
		{
			return new Dictionary<string, Currency>()
			{
				["AED"] = new Currency()
				{
					One = "SAE dirham",
					Few = "SAE dirhamy",
					Many = "SAE dirhamu",
					Other = "SAE dirhamov",
				},
				["AFN"] = new Currency()
				{
					One = "afganský afgání",
					Few = "afganské afgání",
					Many = "afganského afgání",
					Other = "afganských afgání",
				},
				["ALL"] = new Currency()
				{
					One = "albánsky lek",
					Few = "albánske leky",
					Many = "albánskeho leku",
					Other = "albánskych lekov",
				},
				["AMD"] = new Currency()
				{
					One = "arménsky dram",
					Few = "arménske dramy",
					Many = "arménskeho dramu",
					Other = "arménskych dramov",
				},
				["ANG"] = new Currency()
				{
					One = "antilský gulden",
					Few = "antilské guldeny",
					Many = "antilského guldena",
					Other = "antilských guldenov",
				},
				["AOA"] = new Currency()
				{
					One = "angolská kwanza",
					Few = "angolské kwanzy",
					Many = "angolskej kwanzy",
					Other = "angolských kwánz",
				},
				["ARS"] = new Currency()
				{
					One = "argentínske peso",
					Few = "argentínske pesos",
					Many = "argentínskeho pesa",
					Other = "argentínskych pesos",
				},
				["AUD"] = new Currency()
				{
					One = "austrálsky dolár",
					Few = "austrálske doláre",
					Many = "austrálskeho dolára",
					Other = "austrálskych dolárov",
				},
				["AWG"] = new Currency()
				{
					One = "arubský gulden",
					Few = "arubské guldeny",
					Many = "arubského guldena",
					Other = "arubských guldenov",
				},
				["BAM"] = new Currency()
				{
					One = "bosniansko-hercegovinská konvertibilná marka",
					Few = "bosniansko-hercegovinské konvertibilné marky",
					Many = "bosniansko-hercegovinskej konvertibilnej marky",
					Other = "bosniansko-hercegovinských konvertibilných mariek",
				},
				["BBD"] = new Currency()
				{
					One = "barbadoský dolár",
					Few = "barbadoské doláre",
					Many = "barbadoského dolára",
					Other = "barbadoských dolárov",
				},
				["BDT"] = new Currency()
				{
					One = "bangladéšska taka",
					Few = "bangladéšske taky",
					Many = "bangladéšskej taky",
					Other = "bangladéšskych ták",
				},
				["BGN"] = new Currency()
				{
					One = "bulharský lev",
					Few = "bulharské leva",
					Many = "bulharského leva",
					Other = "bulharských leva",
				},
				["BHD"] = new Currency()
				{
					One = "bahrajnský dinár",
					Few = "bahrajnské dináre",
					Many = "bahrajnského dinára",
					Other = "bahrajnských dinárov",
				},
				["BIF"] = new Currency()
				{
					One = "burundský frank",
					Few = "burundské franky",
					Many = "burundského franku",
					Other = "burundských frankov",
				},
				["BMD"] = new Currency()
				{
					One = "bermudský dolár",
					Few = "bermudské doláre",
					Many = "bermudského dolára",
					Other = "bermudských dolárov",
				},
				["BND"] = new Currency()
				{
					One = "brunejský dolár",
					Few = "brunejské doláre",
					Many = "brunejského dolára",
					Other = "brunejských dolárov",
				},
				["BOB"] = new Currency()
				{
					One = "bolívijské boliviano",
					Few = "bolívijské boliviana",
					Many = "bolívijského boliviana",
					Other = "bolívijských bolivian",
				},
				["BOV"] = new Currency()
				{
					One = "bolívijský mvdol",
					Few = "bolívijské mvdoly",
					Many = "bolívijského mvdolu",
					Other = "bolívijských mvdolov",
				},
				["BRL"] = new Currency()
				{
					One = "brazílsky real",
					Few = "brazílske realy",
					Many = "brazílskeho realu",
					Other = "brazílskych realov",
				},
				["BTN"] = new Currency()
				{
					One = "bhutánsky ngultrum",
					Few = "bhutánske ngultrumy",
					Many = "bhutánskeho ngultrumu",
					Other = "bhutánskych ngultrumov",
				},
				["BWP"] = new Currency()
				{
					One = "botswanská pula",
					Few = "botswanské puly",
					Many = "botswanskej puly",
					Other = "botswanských púl",
				},
				["BYN"] = new Currency()
				{
					One = "bieloruský rubeľ",
					Few = "bieloruské ruble",
					Many = "bieloruského rubľa",
					Other = "bieloruských rubľov",
				},
				["BZD"] = new Currency()
				{
					One = "belizský dolár",
					Few = "belizské doláre",
					Many = "belizského dolára",
					Other = "belizských dolárov",
				},
				["CAD"] = new Currency()
				{
					One = "kanadský dolár",
					Few = "kanadské doláre",
					Many = "kanadského dolára",
					Other = "kanadských dolárov",
				},
				["CDF"] = new Currency()
				{
					One = "konžský frank",
					Few = "konžské franky",
					Many = "konžského franku",
					Other = "konžských frankov",
				},
				["CHE"] = new Currency()
				{
					One = "švajčiarske WIR euro",
					Few = "švajčiarske WIR eurá",
					Many = "švajčiarskeho WIR eura",
					Other = "švajčiarskych WIR eur",
				},
				["CHF"] = new Currency()
				{
					One = "švajčiarsky frank",
					Few = "švajčiarske franky",
					Many = "švajčiarskeho franku",
					Other = "švajčiarskych frankov",
				},
				["CHW"] = new Currency()
				{
					One = "švajčiarsky WIR frank",
					Few = "švajčiarske WIR franky",
					Many = "švajčiarskeho WIR franku",
					Other = "švajčiarskych WIR frankov",
				},
				["CLF"] = new Currency()
				{
					One = "čilská účtovná jednotka (UF)",
					Few = "čilské účtovné jednotky (UF)",
					Many = "čilskej účtovnej jednotky (UF)",
					Other = "čilských účtovných jednotiek (UF)",
				},
				["CNY"] = new Currency()
				{
					One = "čínsky jüan",
					Few = "čínske jüany",
					Many = "čínskeho jüana",
					Other = "čínskych jüanov",
				},
				["COP"] = new Currency()
				{
					One = "kolumbijské peso",
					Few = "kolumbijské pesos",
					Many = "kolumbijského pesa",
					Other = "kolumbijských pesos",
				},
				["COU"] = new Currency()
				{
					One = "kolumbijská jednotka reálnej hodnoty",
					Few = "kolumbijské jednotky reálnej hodnoty",
					Many = "kolumbijskej jednotky reálnej hodnoty",
					Other = "kolumbijských jednotiek reálnej hodnoty",
				},
				["CRC"] = new Currency()
				{
					One = "kostarický colón",
					Few = "kostarické colóny",
					Many = "kostarického colóna",
					Other = "kostarických colónov",
				},
				["CUC"] = new Currency()
				{
					One = "kubánske konvertibilné peso",
					Few = "kubánske konvertibilné pesos",
					Many = "kubánskeho konvertibilného pesa",
					Other = "kubánskych konvertibilných pesos",
				},
				["CUP"] = new Currency()
				{
					One = "kubánske peso",
					Few = "kubánske pesos",
					Many = "kubánskeho pesa",
					Other = "kubánskych pesos",
				},
				["CVE"] = new Currency()
				{
					One = "kapverdské escudo",
					Few = "kapverdské escudá",
					Many = "kapverdského escuda",
					Other = "kapverdských escúd",
				},
				["CZK"] = new Currency()
				{
					One = "česká koruna",
					Few = "české koruny",
					Many = "českej koruny",
					Other = "českých korún",
				},
				["DJF"] = new Currency()
				{
					One = "džibutský frank",
					Few = "džibutské franky",
					Many = "džibutského franku",
					Other = "džibutských frankov",
				},
				["DKK"] = new Currency()
				{
					One = "dánska koruna",
					Few = "dánske koruny",
					Many = "dánskej koruny",
					Other = "dánskych korún",
				},
				["DOP"] = new Currency()
				{
					One = "dominikánske peso",
					Few = "dominikánske pesos",
					Many = "dominikánskeho pesa",
					Other = "dominikánske pesos",
				},
				["DZD"] = new Currency()
				{
					One = "alžírsky dinár",
					Few = "alžírske dináre",
					Many = "alžírskeho dinára",
					Other = "alžírskych dinárov",
				},
				["EGP"] = new Currency()
				{
					One = "egyptská libra",
					Few = "egyptské libry",
					Many = "egyptskej libry",
					Other = "egyptských libier",
				},
				["ERN"] = new Currency()
				{
					One = "eritrejská nakfa",
					Few = "eritrejské nakfy",
					Many = "eritrejskej nakfy",
					Other = "eritrejských nakief",
				},
				["ETB"] = new Currency()
				{
					One = "etiópsky birr",
					Few = "etiópske birry",
					Many = "etiópskeho birru",
					Other = "etiópskych birrov",
				},
				["EUR"] = new Currency()
				{
					One = "euro",
					Few = "eurá",
					Many = "eura",
					Other = "eur",
				},
				["FJD"] = new Currency()
				{
					One = "fidžijský dolár",
					Few = "fidžijské doláre",
					Many = "fidžijského dolára",
					Other = "fidžijských dolárov",
				},
				["FKP"] = new Currency()
				{
					One = "falklandská libra",
					Few = "falklandské libry",
					Many = "falklandskej libry",
					Other = "falklandských libier",
				},
				["GBP"] = new Currency()
				{
					One = "britská libra",
					Few = "britské libry",
					Many = "britskej libry",
					Other = "britských libier",
				},
				["GEL"] = new Currency()
				{
					One = "gruzínske lari",
					Few = "gruzínske lari",
					Many = "gruzínskeho lari",
					Other = "gruzínskych lari",
				},
				["GHS"] = new Currency()
				{
					One = "ghanské cedi",
					Few = "ghanské cedi",
					Many = "ghanského cedi",
					Other = "ghanských cedi",
				},
				["GIP"] = new Currency()
				{
					One = "gibraltárska libra",
					Few = "gibraltárske libry",
					Many = "gibraltárskej libry",
					Other = "gibraltárskych libier",
				},
				["GMD"] = new Currency()
				{
					One = "gambijské dalasi",
					Few = "gambijské dalasi",
					Many = "gambijského dalasi",
					Other = "gambijských dalasi",
				},
				["GNF"] = new Currency()
				{
					One = "guinejský frank",
					Few = "guinejské franky",
					Many = "guinejského franku",
					Other = "guinejských frankov",
				},
				["GTQ"] = new Currency()
				{
					One = "guatemalský quetzal",
					Few = "guatemalské quetzaly",
					Many = "guatemalského quetzala",
					Other = "guatemalských quetzalov",
				},
				["GYD"] = new Currency()
				{
					One = "guyanský dolár",
					Few = "guyanské doláre",
					Many = "guyanského dolára",
					Other = "guyanských dolárov",
				},
				["HKD"] = new Currency()
				{
					One = "hongkonský dolár",
					Few = "hongkonské doláre",
					Many = "hongkonského dolára",
					Other = "hongkonských dolárov",
				},
				["HNL"] = new Currency()
				{
					One = "honduraská lempira",
					Few = "honduraské lempiry",
					Many = "honduraskej lempiry",
					Other = "honduraských lempír",
				},
				["HRK"] = new Currency()
				{
					One = "chorvátska kuna",
					Few = "chorvátske kuny",
					Many = "chorvátskej kuny",
					Other = "chorvátskych kún",
				},
				["HTG"] = new Currency()
				{
					One = "haitské gourde",
					Few = "haitské gourde",
					Many = "haitského gourde",
					Other = "haitských gourde",
				},
				["HUF"] = new Currency()
				{
					One = "maďarský forint",
					Few = "maďarské forinty",
					Many = "maďarského forinta",
					Other = "maďarských forintov",
				},
				["IDR"] = new Currency()
				{
					One = "indonézska rupia",
					Few = "indonézske rupie",
					Many = "indonézskej rupie",
					Other = "indonézskych rupií",
				},
				["ILS"] = new Currency()
				{
					One = "izraelský šekel",
					Few = "izraelské šekely",
					Many = "izraelského šekela",
					Other = "izraelských šekelov",
				},
				["INR"] = new Currency()
				{
					One = "indická rupia",
					Few = "indické rupie",
					Many = "indickej rupie",
					Other = "indických rupií",
				},
				["IQD"] = new Currency()
				{
					One = "iracký dinár",
					Few = "iracké dináre",
					Many = "irackého dinára",
					Other = "irackých dinárov",
				},
				["IRR"] = new Currency()
				{
					One = "iránsky rial",
					Few = "iránske rialy",
					Many = "iránskeho rialu",
					Other = "iránskych rialov",
				},
				["ISK"] = new Currency()
				{
					One = "islandská koruna",
					Few = "islandské koruny",
					Many = "islandskej koruny",
					Other = "islandských korún",
				},
				["JMD"] = new Currency()
				{
					One = "jamajský dolár",
					Few = "jamajské doláre",
					Many = "jamajského dolára",
					Other = "jamajských dolárov",
				},
				["JOD"] = new Currency()
				{
					One = "jordánsky dinár",
					Few = "jordánske dináre",
					Many = "jordánskeho dinára",
					Other = "jordánskych dinárov",
				},
				["JPY"] = new Currency()
				{
					One = "japonský jen",
					Few = "japonské jeny",
					Many = "japonského jenu",
					Other = "japonských jenov",
				},
				["KES"] = new Currency()
				{
					One = "kenský šiling",
					Few = "kenské šilingy",
					Many = "kenského šilingu",
					Other = "kenských šilingov",
				},
				["KGS"] = new Currency()
				{
					One = "kirgizský som",
					Few = "kirgizské somy",
					Many = "kirgizského somu",
					Other = "kirgizských somov",
				},
				["KHR"] = new Currency()
				{
					One = "kambodžský riel",
					Few = "kambodžské riely",
					Many = "kambodžského rielu",
					Other = "kambodžských rielov",
				},
				["KMF"] = new Currency()
				{
					One = "komorský frank",
					Few = "komorské franky",
					Many = "komorského franku",
					Other = "komorských frankov",
				},
				["KPW"] = new Currency()
				{
					One = "severokórejský won",
					Few = "severokórejské wony",
					Many = "severokórejskeho wonu",
					Other = "severokórejských wonov",
				},
				["KRW"] = new Currency()
				{
					One = "juhokórejský won",
					Few = "juhokórejské wony",
					Many = "juhokórejského wonu",
					Other = "juhokórejských wonov",
				},
				["KWD"] = new Currency()
				{
					One = "kuvajtský dinár",
					Few = "kuvajtské dináre",
					Many = "kuvajtského dinára",
					Other = "kuvajtských dinárov",
				},
				["KYD"] = new Currency()
				{
					One = "kajmanský dolár",
					Few = "kajmanské doláre",
					Many = "kajmanského dolára",
					Other = "kajmanských dolárov",
				},
				["KZT"] = new Currency()
				{
					One = "kazašské tenge",
					Few = "kazašské tenge",
					Many = "kazašského tenge",
					Other = "kazašských tenge",
				},
				["LAK"] = new Currency()
				{
					One = "laoský kip",
					Few = "laoské kipy",
					Many = "laoského kipu",
					Other = "laoských kipov",
				},
				["LBP"] = new Currency()
				{
					One = "libanonská libra",
					Few = "libanonské libry",
					Many = "libanonskej libry",
					Other = "libanonských libier",
				},
				["LKR"] = new Currency()
				{
					One = "srílanská rupia",
					Few = "srílanské rupie",
					Many = "srílanskej rupie",
					Other = "srílanských rupií",
				},
				["LRD"] = new Currency()
				{
					One = "libérijský dolár",
					Few = "libérijské doláre",
					Many = "libérijského dolára",
					Other = "libérijských dolárov",
				},
				["LSL"] = new Currency()
				{
					One = "lesothský loti",
					Few = "lesothské loti",
					Many = "lesothského loti",
					Other = "lesothských loti",
				},
				["LYD"] = new Currency()
				{
					One = "líbyjský dinár",
					Few = "líbyjské dináre",
					Many = "líbyjského dinára",
					Other = "líbyjských dinárov",
				},
				["MAD"] = new Currency()
				{
					One = "marocký dirham",
					Few = "marocké dirhamy",
					Many = "marockého dirhamu",
					Other = "marockých dirhamov",
				},
				["MDL"] = new Currency()
				{
					One = "moldavský lei",
					Few = "moldavské lei",
					Many = "moldavského lei",
					Other = "moldavských lei",
				},
				["MGA"] = new Currency()
				{
					One = "malgašský ariary",
					Few = "malgašské ariary",
					Many = "malgašského ariary",
					Other = "malgašských ariary",
				},
				["MKD"] = new Currency()
				{
					One = "macedónsky denár",
					Few = "macedónske denáre",
					Many = "macedónskeho denára",
					Other = "macedónskych denárov",
				},
				["MMK"] = new Currency()
				{
					One = "mjanmarský kyat",
					Few = "mjanmarské kyaty",
					Many = "mjanmarského kyatu",
					Other = "mjanmarských kyatov",
				},
				["MNT"] = new Currency()
				{
					One = "mongolský tugrik",
					Few = "mongolské tugriky",
					Many = "mongolského tugrika",
					Other = "mongolských tugrikov",
				},
				["MOP"] = new Currency()
				{
					One = "macajská pataca",
					Few = "macajské patacy",
					Many = "macajskej patacy",
					Other = "macajských patác",
				},
				["MRU"] = new Currency()
				{
					One = "mauritánska ukija",
					Few = "mauritánske ukije",
					Many = "mauritánskej ukije",
					Other = "mauritánskych ukijí",
				},
				["MUR"] = new Currency()
				{
					One = "maurícijská rupia",
					Few = "maurícijské rupie",
					Many = "maurícijskej rupie",
					Other = "maurícijských rupií",
				},
				["MVR"] = new Currency()
				{
					One = "maldivská rupia",
					Few = "maldivské rupie",
					Many = "maldivskej rupie",
					Other = "maldivských rupií",
				},
				["MWK"] = new Currency()
				{
					One = "malawijská kwacha",
					Few = "malawijské kwachy",
					Many = "malawijskej kwachy",
					Other = "malawijských kwách",
				},
				["MXN"] = new Currency()
				{
					One = "mexické peso",
					Few = "mexické pesos",
					Many = "mexického pesa",
					Other = "mexických pesos",
				},
				["MXV"] = new Currency()
				{
					One = "mexická investičná jednotka",
					Few = "mexické investičné jednotky",
					Many = "mexickej investičnej jednotky",
					Other = "mexických investičných jednotiek",
				},
				["MYR"] = new Currency()
				{
					One = "malajzijský ringgit",
					Few = "malajzijské ringgity",
					Many = "malajzijského ringgitu",
					Other = "malajzijských ringgitov",
				},
				["MZN"] = new Currency()
				{
					One = "mozambický metical",
					Few = "mozambické meticaly",
					Many = "mozambického meticalu",
					Other = "mozambických meticalov",
				},
				["NAD"] = new Currency()
				{
					One = "namíbijský dolár",
					Few = "namíbijské doláre",
					Many = "namíbijského dolára",
					Other = "namíbijských dolárov",
				},
				["NGN"] = new Currency()
				{
					One = "nigérijská naira",
					Few = "nigérijské nairy",
					Many = "nigérijskej nairy",
					Other = "nigérijských nair",
				},
				["NIO"] = new Currency()
				{
					One = "nikaragujská córdoba",
					Few = "nikaragujské córdoby",
					Many = "nikaragujskej córdoby",
					Other = "nikaragujských córdob",
				},
				["NOK"] = new Currency()
				{
					One = "nórska koruna",
					Few = "nórske koruny",
					Many = "nórskej koruny",
					Other = "nórskych korún",
				},
				["NPR"] = new Currency()
				{
					One = "nepálska rupia",
					Few = "nepálske rupie",
					Many = "nepálskej rupie",
					Other = "nepálskych rupií",
				},
				["NZD"] = new Currency()
				{
					One = "novozélandský dolár",
					Few = "novozélandské doláre",
					Many = "novozélandského dolára",
					Other = "novozélandských dolárov",
				},
				["OMR"] = new Currency()
				{
					One = "ománsky rial",
					Few = "ománske rialy",
					Many = "ománskeho rialu",
					Other = "ománskych rialov",
				},
				["PAB"] = new Currency()
				{
					One = "panamská balboa",
					Few = "panamské balboy",
					Many = "panamskej balboy",
					Other = "panamských balboí",
				},
				["PEN"] = new Currency()
				{
					One = "peruánsky sol",
					Few = "peruánske soly",
					Many = "peruánskeho sola",
					Other = "peruánskych solov",
				},
				["PGK"] = new Currency()
				{
					One = "papuánska kina",
					Few = "papuánske kiny",
					Many = "papuánskej kiny",
					Other = "papuánskych kín",
				},
				["PHP"] = new Currency()
				{
					One = "filipínske peso",
					Few = "filipínske pesos",
					Many = "filipínskeho pesa",
					Other = "filipínskych pesos",
				},
				["PKR"] = new Currency()
				{
					One = "pakistanská rupia",
					Few = "pakistanské rupie",
					Many = "pakistanskej rupie",
					Other = "pakistanských rupií",
				},
				["PLN"] = new Currency()
				{
					One = "poľský zlotý",
					Few = "poľské zloté",
					Many = "poľského zlotého",
					Other = "poľských zlotých",
				},
				["PYG"] = new Currency()
				{
					One = "paraguajské guaraní",
					Few = "paraguajské guaraní",
					Many = "paraguajského guaraní",
					Other = "paraguajských guaraní",
				},
				["QAR"] = new Currency()
				{
					One = "katarský rial",
					Few = "katarské rialy",
					Many = "katarského rialu",
					Other = "katarských rialov",
				},
				["RON"] = new Currency()
				{
					One = "rumunský lei",
					Few = "rumunské lei",
					Many = "rumunského lei",
					Other = "rumunských lei",
				},
				["RSD"] = new Currency()
				{
					One = "srbský dinár",
					Few = "srbské dináre",
					Many = "srbského dinára",
					Other = "srbských dinárov",
				},
				["RUB"] = new Currency()
				{
					One = "ruský rubeľ",
					Few = "ruské ruble",
					Many = "ruského rubľa",
					Other = "ruských rubľov",
				},
				["RWF"] = new Currency()
				{
					One = "rwandský frank",
					Few = "rwandské franky",
					Many = "rwandského franku",
					Other = "rwandských frankov",
				},
				["SAR"] = new Currency()
				{
					One = "saudskoarabský rial",
					Few = "saudskoarabské rialy",
					Many = "saudskoarabského rialu",
					Other = "saudskoarabských rialov",
				},
				["SBD"] = new Currency()
				{
					One = "šalamúnsky dolár",
					Few = "šalamúnske doláre",
					Many = "šalamúnskeho dolára",
					Other = "šalamúnskych dolárov",
				},
				["SCR"] = new Currency()
				{
					One = "seychelská rupia",
					Few = "seychelské rupie",
					Many = "seychelskej rupie",
					Other = "seychelských rupií",
				},
				["SDG"] = new Currency()
				{
					One = "sudánska libra",
					Few = "sudánske libry",
					Many = "sudánskej libry",
					Other = "sudánskych libier",
				},
				["SEK"] = new Currency()
				{
					One = "švédska koruna",
					Few = "švédske koruny",
					Many = "švédskej koruny",
					Other = "švédskych korún",
				},
				["SGD"] = new Currency()
				{
					One = "singapurský dolár",
					Few = "singapurské doláre",
					Many = "singapurského dolára",
					Other = "singapurských dolárov",
				},
				["SHP"] = new Currency()
				{
					One = "svätohelenská libra",
					Few = "svätohelenské libry",
					Many = "svätohelenskej libry",
					Other = "svätohelenských libier",
				},
				["SLL"] = new Currency()
				{
					One = "sierraleonský leone",
					Few = "sierraleonské leone",
					Many = "sierraleonského leone",
					Other = "sierraleonských leone",
				},
				["SOS"] = new Currency()
				{
					One = "somálsky šiling",
					Few = "somálske šilingy",
					Many = "somálskeho šilingu",
					Other = "somálskych šilingov",
				},
				["SRD"] = new Currency()
				{
					One = "surinamský dolár",
					Few = "surinamské doláre",
					Many = "surinamského dolára",
					Other = "surinamských dolárov",
				},
				["SSP"] = new Currency()
				{
					One = "juhosudánska libra",
					Few = "juhosudánske libry",
					Many = "juhosudánskej libry",
					Other = "juhosudánskych libier",
				},
				["STN"] = new Currency()
				{
					One = "svätotomášska dobra",
					Few = "svätotomášske dobry",
					Many = "svätotomášskej dobry",
					Other = "svätotomášskych dobier",
				},
				["SVC"] = new Currency()
				{
					One = "salvádorský colón",
					Few = "salvádorské colóny",
					Many = "salvádorského colóna",
					Other = "salvádorských colónov",
				},
				["SYP"] = new Currency()
				{
					One = "sýrska libra",
					Few = "sýrske libry",
					Many = "sýrskej libry",
					Other = "sýrskych libier",
				},
				["SZL"] = new Currency()
				{
					One = "svazijské lilangeni",
					Few = "svazijské lilangeni",
					Many = "svazijského lilangeni",
					Other = "svazijských lilangeni",
				},
				["THB"] = new Currency()
				{
					One = "thajský baht",
					Few = "thajské bahty",
					Many = "thajského bahtu",
					Other = "thajských bahtov",
				},
				["TJS"] = new Currency()
				{
					One = "tadžické somoni",
					Few = "tadžické somoni",
					Many = "tadžického somoni",
					Other = "tadžických somoni",
				},
				["TMT"] = new Currency()
				{
					One = "turkménsky manat",
					Few = "turkménske manaty",
					Many = "turkménskeho manatu",
					Other = "turkménskych manatov",
				},
				["TND"] = new Currency()
				{
					One = "tuniský dinár",
					Few = "tuniské dináre",
					Many = "tuniského dinára",
					Other = "tuniských dinárov",
				},
				["TOP"] = new Currency()
				{
					One = "tongská pa’anga",
					Few = "tongské pa’anga",
					Many = "tongského pa’anga",
					Other = "tongských pa’anga",
				},
				["TRY"] = new Currency()
				{
					One = "turecká líra",
					Few = "turecké líry",
					Many = "tureckej líry",
					Other = "tureckých lír",
				},
				["TTD"] = new Currency()
				{
					One = "trinidadsko-tobažský dolár",
					Few = "trinidadsko-tobažské doláre",
					Many = "trinidadsko-tobažského dolára",
					Other = "trinidadsko-tobažských dolárov",
				},
				["TWD"] = new Currency()
				{
					One = "nový taiwanský dolár",
					Few = "nové taiwanské doláre",
					Many = "nového taiwanského dolára",
					Other = "nových taiwanských dolárov",
				},
				["TZS"] = new Currency()
				{
					One = "tanzánsky šiling",
					Few = "tanzánske šilingy",
					Many = "tanzánskeho šilingu",
					Other = "tanzánskych šilingov",
				},
				["UAH"] = new Currency()
				{
					One = "ukrajinská hrivna",
					Few = "ukrajinské hrivny",
					Many = "ukrajinskej hrivny",
					Other = "ukrajinských hrivien",
				},
				["UGX"] = new Currency()
				{
					One = "ugandský šiling",
					Few = "ugandské šilingy",
					Many = "ugandského šilingu",
					Other = "ugandských šilingov",
				},
				["USD"] = new Currency()
				{
					One = "americký dolár",
					Few = "americké doláre",
					Many = "amerického dolára",
					Other = "amerických dolárov",
				},
				["UYU"] = new Currency()
				{
					One = "uruguajské peso",
					Few = "uruguajské pesos",
					Many = "uruguajského pesa",
					Other = "uruguajských pesos",
				},
				["UZS"] = new Currency()
				{
					One = "uzbecký sum",
					Few = "uzbecké sumy",
					Many = "uzbeckého sumu",
					Other = "uzbeckých sumov",
				},
				["VES"] = new Currency()
				{
					One = "venezuelský bolívar",
					Few = "venezuelské bolívary",
					Many = "venezuelského bolívaru",
					Other = "venezuelských bolívarov",
				},
				["VND"] = new Currency()
				{
					One = "vietnamský dong",
					Few = "vietnamské dongy",
					Many = "vietnamského dongu",
					Other = "vietnamských dongov",
				},
				["VUV"] = new Currency()
				{
					One = "vanuatské vatu",
					Few = "vanuatské vatu",
					Many = "vanuatského vatu",
					Other = "vanuatských vatu",
				},
				["WST"] = new Currency()
				{
					One = "samojská tala",
					Few = "samojské taly",
					Many = "samojskej taly",
					Other = "samojských tál",
				},
				["XAF"] = new Currency()
				{
					One = "stredoafrický frank",
					Few = "stredoafrické franky",
					Many = "stredoafrického franku",
					Other = "stredoafrických frankov",
				},
				["XCD"] = new Currency()
				{
					One = "východokaribský dolár",
					Few = "východokaribské doláre",
					Many = "východokaribského dolára",
					Other = "východokaribských dolárov",
				},
				["XOF"] = new Currency()
				{
					One = "západoafrický frank",
					Few = "západoafrické franky",
					Many = "západoafrického franku",
					Other = "západoafrických frankov",
				},
				["XPF"] = new Currency()
				{
					One = "CFP frank",
					Few = "CFP franky",
					Many = "CFP franku",
					Other = "CFP frankov",
				},
				["YER"] = new Currency()
				{
					One = "jemenský rial",
					Few = "jemenské rialy",
					Many = "jemenského rialu",
					Other = "jemenských rialov",
				},
				["ZAR"] = new Currency()
				{
					One = "juhoafrický rand",
					Few = "juhoafrické randy",
					Many = "juhoafrického randu",
					Other = "juhoafrických randov",
				},
				["ZMW"] = new Currency()
				{
					One = "zambijská kwacha",
					Few = "zambijské kwachy",
					Many = "zambijskej kwachy",
					Other = "zambijských kwách",
				},
				["ZWL"] = new Currency()
				{
					One = "zimbabwiansky dolár (2009)",
					Few = "zimbabwianske doláre (2009)",
					Many = "zimbabwianskeho dolára (2009)",
					Other = "zimbabwianskych dolárov (2009)",
				},
			};
		}
	}
}
