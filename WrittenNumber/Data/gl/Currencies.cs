using WrittenNumber.Models;

namespace WrittenNumber.Data.gl
{
	public static class Currencies
	{
		public static Dictionary<string, Currency> Get()
		{
			return new Dictionary<string, Currency>()
			{
				["AED"] = new Currency()
				{
					One = "dirham dos Emiratos Árabes Unidos",
					Other = "dirhams dos Emiratos Árabes Unidos",
				},
				["AFN"] = new Currency()
				{
					One = "afgani afgán",
					Other = "afganis afgáns",
				},
				["ALL"] = new Currency()
				{
					One = "lek albanés",
					Other = "lekë albaneses",
				},
				["AMD"] = new Currency()
				{
					One = "dram armenio",
					Other = "drams armenios",
				},
				["ANG"] = new Currency()
				{
					One = "florín das Antillas Neerlandesas",
					Other = "floríns das Antillas Neerlandesas",
				},
				["AOA"] = new Currency()
				{
					One = "kwanza angolano",
					Other = "kwanzas angolanos",
				},
				["ARS"] = new Currency()
				{
					One = "peso arxentino",
					Other = "pesos arxentinos",
				},
				["AUD"] = new Currency()
				{
					One = "dólar australiano",
					Other = "dólares australianos",
				},
				["AWG"] = new Currency()
				{
					One = "florín de Aruba",
					Other = "floríns de Aruba",
				},
				["BAM"] = new Currency()
				{
					One = "marco convertible de Bosnia e Hercegovina",
					Other = "marcos convertibles de Bosnia e Hercegovina",
				},
				["BBD"] = new Currency()
				{
					One = "dólar de Barbados",
					Other = "dólares de Barbados",
				},
				["BDT"] = new Currency()
				{
					One = "taka de Bangladesh",
					Other = "takas de Bangladesh",
				},
				["BGN"] = new Currency()
				{
					One = "lev búlgaro",
					Other = "leva búlgaros",
				},
				["BHD"] = new Currency()
				{
					One = "dinar de Bahrain",
					Other = "dinares de Bahrain",
				},
				["BIF"] = new Currency()
				{
					One = "franco burundiano",
					Other = "francos burundianos",
				},
				["BMD"] = new Currency()
				{
					One = "dólar bermudano",
					Other = "dólares bermudanos",
				},
				["BND"] = new Currency()
				{
					One = "dólar de Brunei",
					Other = "dólares de Brunei",
				},
				["BOB"] = new Currency()
				{
					One = "boliviano",
					Other = "bolivianos",
				},
				["BRL"] = new Currency()
				{
					One = "real brasileiro",
					Other = "reais brasileiros",
				},
				["BTN"] = new Currency()
				{
					One = "ngultrum butanés",
					Other = "ngultrums butaneses",
				},
				["BWP"] = new Currency()
				{
					One = "pula botswaniano",
					Other = "pulas botswanianos",
				},
				["BYN"] = new Currency()
				{
					One = "rublo belaruso",
					Other = "rublos belarusos",
				},
				["BZD"] = new Currency()
				{
					One = "dólar belizense",
					Other = "dólares belizenses",
				},
				["CAD"] = new Currency()
				{
					One = "dólar canadense",
					Other = "dólares canadenses",
				},
				["CDF"] = new Currency()
				{
					One = "franco congolés",
					Other = "francos congoleses",
				},
				["CHF"] = new Currency()
				{
					One = "franco suízo",
					Other = "francos suízos",
				},
				["CLF"] = new Currency()
				{
					One = "unidade de fomento chilena",
					Other = "unidades de fomento chilenas",
				},
				["CNY"] = new Currency()
				{
					One = "iuán chinés",
					Other = "iuáns chineses",
				},
				["COP"] = new Currency()
				{
					One = "peso colombiano",
					Other = "pesos colombianos",
				},
				["CRC"] = new Currency()
				{
					One = "colón costarriqueño",
					Other = "colóns costarriqueños",
				},
				["CUC"] = new Currency()
				{
					One = "peso cubano convertible",
					Other = "pesos cubanos convertibles",
				},
				["CUP"] = new Currency()
				{
					One = "peso cubano",
					Other = "pesos cubanos",
				},
				["CVE"] = new Currency()
				{
					One = "escudo caboverdiano",
					Other = "escudos caboverdianos",
				},
				["CZK"] = new Currency()
				{
					One = "coroa checa",
					Other = "coroas checas",
				},
				["DJF"] = new Currency()
				{
					One = "franco djibutiano",
					Other = "francos djibutianos",
				},
				["DKK"] = new Currency()
				{
					One = "coroa dinamarquesa",
					Other = "coroas dinamarquesas",
				},
				["DOP"] = new Currency()
				{
					One = "peso dominicano",
					Other = "pesos dominicanos",
				},
				["DZD"] = new Currency()
				{
					One = "dinar alxeriano",
					Other = "dinares alxerianos",
				},
				["EGP"] = new Currency()
				{
					One = "libra exipcia",
					Other = "libras exipcias",
				},
				["ERN"] = new Currency()
				{
					One = "nakfa eritreo",
					Other = "nakfas eritreos",
				},
				["ETB"] = new Currency()
				{
					One = "birr etíope",
					Other = "birres etíopes",
				},
				["EUR"] = new Currency()
				{
					One = "euro",
					Other = "euros",
				},
				["FJD"] = new Currency()
				{
					One = "dólar fixiano",
					Other = "dólares fixianos",
				},
				["FKP"] = new Currency()
				{
					One = "libra das Illas Malvinas",
					Other = "libras das Illas Malvinas",
				},
				["GBP"] = new Currency()
				{
					One = "libra esterlina",
					Other = "libras esterlinas",
				},
				["GEL"] = new Currency()
				{
					One = "lari xeorxiano",
					Other = "laris xeorxianos",
				},
				["GHS"] = new Currency()
				{
					One = "cedi ghanés",
					Other = "cedis ghaneses",
				},
				["GIP"] = new Currency()
				{
					One = "libra xibraltareña",
					Other = "libras xibraltareñas",
				},
				["GMD"] = new Currency()
				{
					One = "dalasi gambiano",
					Other = "dalasis gambianos",
				},
				["GNF"] = new Currency()
				{
					One = "franco guineano",
					Other = "francos guineanos",
				},
				["GTQ"] = new Currency()
				{
					One = "quetzal guatemalteco",
					Other = "quetzais guatemaltecos",
				},
				["GYD"] = new Currency()
				{
					One = "dólar güianés",
					Other = "dólares güianeses",
				},
				["HKD"] = new Currency()
				{
					One = "dólar de Hong Kong",
					Other = "dólares de Hong Kong",
				},
				["HNL"] = new Currency()
				{
					One = "lempira hondureño",
					Other = "lempiras hondureños",
				},
				["HRK"] = new Currency()
				{
					One = "kuna croata",
					Other = "kunas croatas",
				},
				["HTG"] = new Currency()
				{
					One = "gourde haitiana",
					Other = "gourdes haitianas",
				},
				["HUF"] = new Currency()
				{
					One = "florín húngaro",
					Other = "floríns húngaros",
				},
				["IDR"] = new Currency()
				{
					One = "rupia indonesia",
					Other = "rupias indonesias",
				},
				["ILS"] = new Currency()
				{
					One = "novo shequel israelí",
					Other = "novos shequeis israelís",
				},
				["INR"] = new Currency()
				{
					One = "rupia india",
					Other = "rupias indias",
				},
				["IQD"] = new Currency()
				{
					One = "dinar iraquí",
					Other = "dinares iraquíes",
				},
				["IRR"] = new Currency()
				{
					One = "rial iraniano",
					Other = "riales iranianos",
				},
				["ISK"] = new Currency()
				{
					One = "coroa islandesa",
					Other = "coroas islandesas",
				},
				["JMD"] = new Currency()
				{
					One = "dólar xamaicano",
					Other = "dólares xamaicanos",
				},
				["JOD"] = new Currency()
				{
					One = "dinar xordano",
					Other = "dinares xordanos",
				},
				["JPY"] = new Currency()
				{
					One = "ien xaponés",
					Other = "iens xaponeses",
				},
				["KES"] = new Currency()
				{
					One = "xilin kenyano",
					Other = "xilins kenyanos",
				},
				["KGS"] = new Currency()
				{
					One = "som kirguiz",
					Other = "soms kirguiz",
				},
				["KHR"] = new Currency()
				{
					One = "riel camboxano",
					Other = "rieis camboxanos",
				},
				["KMF"] = new Currency()
				{
					One = "franco comoriano",
					Other = "francos comorianos",
				},
				["KPW"] = new Currency()
				{
					One = "won norcoreano",
					Other = "wons norcoreanos",
				},
				["KRW"] = new Currency()
				{
					One = "won surcoreano",
					Other = "wons surcoreanos",
				},
				["KWD"] = new Currency()
				{
					One = "dinar kuwaití",
					Other = "dinares kuwaitís",
				},
				["KYD"] = new Currency()
				{
					One = "dólar das Illas Caimán",
					Other = "dólares das Illas Caimán",
				},
				["KZT"] = new Currency()
				{
					One = "tenge kazako",
					Other = "tenges kazakos",
				},
				["LAK"] = new Currency()
				{
					One = "kip laosiano",
					Other = "kips laosianos",
				},
				["LBP"] = new Currency()
				{
					One = "libra libanesa",
					Other = "libras libanesas",
				},
				["LKR"] = new Currency()
				{
					One = "rupia srilankesa",
					Other = "rupias srilankesas",
				},
				["LRD"] = new Currency()
				{
					One = "dólar liberiano",
					Other = "dólares liberianos",
				},
				["LSL"] = new Currency()
				{
					One = "loti de Lesoto",
					Other = "lotis de Lesoto",
				},
				["LYD"] = new Currency()
				{
					One = "dinar libio",
					Other = "dinares libios",
				},
				["MAD"] = new Currency()
				{
					One = "dirham marroquí",
					Other = "dirhams marroquís",
				},
				["MDL"] = new Currency()
				{
					One = "leu moldavo",
					Other = "lei moldavos",
				},
				["MGA"] = new Currency()
				{
					One = "ariary malgaxe",
					Other = "ariarys malgaxes",
				},
				["MKD"] = new Currency()
				{
					One = "dinar macedonio",
					Other = "dinares macedonios",
				},
				["MMK"] = new Currency()
				{
					One = "kyat birmano",
					Other = "kyats birmanos",
				},
				["MNT"] = new Currency()
				{
					One = "tugrik mongol",
					Other = "tugriks mongois",
				},
				["MOP"] = new Currency()
				{
					One = "pataca macaense",
					Other = "patacas macaenses",
				},
				["MRU"] = new Currency()
				{
					One = "ouguiya mauritano",
					Other = "ouguiyas mauritanos",
				},
				["MUR"] = new Currency()
				{
					One = "rupia mauriciana",
					Other = "rupias mauricianas",
				},
				["MVR"] = new Currency()
				{
					One = "rupia maldivana",
					Other = "rupias maldivanas",
				},
				["MWK"] = new Currency()
				{
					One = "kwacha de Malawi",
					Other = "kwachas de Malawi",
				},
				["MXN"] = new Currency()
				{
					One = "peso mexicano",
					Other = "pesos mexicanos",
				},
				["MYR"] = new Currency()
				{
					One = "ringgit malaio",
					Other = "ringgits malaios",
				},
				["MZN"] = new Currency()
				{
					One = "metical mozambicano",
					Other = "meticais mozambicanos",
				},
				["NAD"] = new Currency()
				{
					One = "dólar namibio",
					Other = "dólares namibios",
				},
				["NGN"] = new Currency()
				{
					One = "naira nixeriano",
					Other = "nairas nixerianos",
				},
				["NIO"] = new Currency()
				{
					One = "córdoba nicaraguano",
					Other = "córdobas nicaraguanos",
				},
				["NOK"] = new Currency()
				{
					One = "coroa norueguesa",
					Other = "coroas norueguesas",
				},
				["NPR"] = new Currency()
				{
					One = "rupia nepalesa",
					Other = "rupias nepalesas",
				},
				["NZD"] = new Currency()
				{
					One = "dólar neozelandés",
					Other = "dólares neozelandeses",
				},
				["OMR"] = new Currency()
				{
					One = "rial omaní",
					Other = "riais omanís",
				},
				["PAB"] = new Currency()
				{
					One = "balboa panameño",
					Other = "balboas panameños",
				},
				["PEN"] = new Currency()
				{
					One = "sol peruano",
					Other = "soles peruanos",
				},
				["PGK"] = new Currency()
				{
					One = "kina de Papúa-Nova Guinea",
					Other = "kinas de Papúa-Nova Guinea",
				},
				["PHP"] = new Currency()
				{
					One = "peso filipino",
					Other = "pesos filipinos",
				},
				["PKR"] = new Currency()
				{
					One = "rupia paquistaní",
					Other = "rupias paquistanís",
				},
				["PLN"] = new Currency()
				{
					One = "zloty polaco",
					Other = "zlotys polacos",
				},
				["PYG"] = new Currency()
				{
					One = "guaraní paraguaio",
					Other = "guaranís paraguaios",
				},
				["QAR"] = new Currency()
				{
					One = "rial qatarí",
					Other = "riais qatarís",
				},
				["RON"] = new Currency()
				{
					One = "leu romanés",
					Other = "lei romaneses",
				},
				["RSD"] = new Currency()
				{
					One = "dinar serbio",
					Other = "dinares serbios",
				},
				["RUB"] = new Currency()
				{
					One = "rublo ruso",
					Other = "rublos rusos",
				},
				["RWF"] = new Currency()
				{
					One = "franco ruandés",
					Other = "francos ruandeses",
				},
				["SAR"] = new Currency()
				{
					One = "rial saudita",
					Other = "riais sauditas",
				},
				["SBD"] = new Currency()
				{
					One = "dólar das Illas Salomón",
					Other = "dólares das Illas Salomón",
				},
				["SCR"] = new Currency()
				{
					One = "rupia de Seychelles",
					Other = "rupias de Seychelles",
				},
				["SDG"] = new Currency()
				{
					One = "libra sudanesa",
					Other = "libras sudanesas",
				},
				["SEK"] = new Currency()
				{
					One = "coroa sueca",
					Other = "coroas suecas",
				},
				["SGD"] = new Currency()
				{
					One = "dólar de Singapur",
					Other = "dólares de Singapur",
				},
				["SHP"] = new Currency()
				{
					One = "libra de Santa Helena",
					Other = "libras de Santa Helena",
				},
				["SLL"] = new Currency()
				{
					One = "leone de Serra Leoa",
					Other = "leones de Serra Leoa",
				},
				["SOS"] = new Currency()
				{
					One = "xilin somalí",
					Other = "xilins somalís",
				},
				["SRD"] = new Currency()
				{
					One = "dólar surinamés",
					Other = "dólares surinamés",
				},
				["SSP"] = new Currency()
				{
					One = "libra sursudanesa",
					Other = "libras sursudanesa",
				},
				["STN"] = new Currency()
				{
					One = "dobra de San Tomé e Príncipe",
					Other = "dobras de San Tomé e Príncipe",
				},
				["SVC"] = new Currency()
				{
					One = "colón salvadoreño",
					Other = "colóns salvadoreños",
				},
				["SYP"] = new Currency()
				{
					One = "libra siria",
					Other = "libras sirias",
				},
				["SZL"] = new Currency()
				{
					One = "lilangeni de Swazilandia",
					Other = "lilangenis de Swazilandia",
				},
				["THB"] = new Currency()
				{
					One = "baht tailandés",
					Other = "bahts tailandeses",
				},
				["TJS"] = new Currency()
				{
					One = "somoni taxiquistano",
					Other = "somonis taxiquistanos",
				},
				["TMT"] = new Currency()
				{
					One = "manat turkmeno",
					Other = "manats turkmenos",
				},
				["TND"] = new Currency()
				{
					One = "dinar tunisiano",
					Other = "dinares tunisianos",
				},
				["TOP"] = new Currency()
				{
					One = "paʻanga tongano",
					Other = "pa’angas tonganos",
				},
				["TRY"] = new Currency()
				{
					One = "lira turca",
					Other = "liras turcas",
				},
				["TTD"] = new Currency()
				{
					One = "dólar trinitense",
					Other = "dólares trinitenses",
				},
				["TWD"] = new Currency()
				{
					One = "novo dólar taiwanés",
					Other = "novos dólares taiwaneses",
				},
				["TZS"] = new Currency()
				{
					One = "xilin tanzano",
					Other = "xilins tanzanos",
				},
				["UAH"] = new Currency()
				{
					One = "hrivna ucraína",
					Other = "hrivnas ucraínas",
				},
				["UGX"] = new Currency()
				{
					One = "xilin ugandés",
					Other = "xilins ugandeses",
				},
				["USD"] = new Currency()
				{
					One = "dólar estadounidense",
					Other = "dólares estadounidenses",
				},
				["UYU"] = new Currency()
				{
					One = "peso uruguaio",
					Other = "pesos uruguaios",
				},
				["UZS"] = new Currency()
				{
					One = "som uzbeko",
					Other = "soms uzbekos",
				},
				["VES"] = new Currency()
				{
					One = "bolívar venezolano",
					Other = "bolívares venezolanos",
				},
				["VND"] = new Currency()
				{
					One = "dong vietnamita",
					Other = "dongs vietnamitas",
				},
				["VUV"] = new Currency()
				{
					One = "vatu vanuatiano",
					Other = "vatus vanuatianos",
				},
				["WST"] = new Currency()
				{
					One = "tala samoano",
					Other = "talas samoanos",
				},
				["XAF"] = new Currency()
				{
					One = "franco CFA (BEAC)",
					Other = "francos CFA (BEAC)",
				},
				["XCD"] = new Currency()
				{
					One = "dólar do Caribe Oriental",
					Other = "dólares do Caribe Oriental",
				},
				["XOF"] = new Currency()
				{
					One = "franco CFA (BCEAO)",
					Other = "francos CFA (BCEAO)",
				},
				["XPF"] = new Currency()
				{
					One = "franco CFP",
					Other = "francos CFP",
				},
				["YER"] = new Currency()
				{
					One = "rial iemení",
					Other = "riais iemenís",
				},
				["ZAR"] = new Currency()
				{
					One = "rand surafricano",
					Other = "rands surafricanos",
				},
				["ZMW"] = new Currency()
				{
					One = "kwacha zambiano",
					Other = "kwachas zambianos",
				},
			};
		}
	}
}
