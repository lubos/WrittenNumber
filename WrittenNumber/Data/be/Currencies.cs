using WrittenNumber.Models;

namespace WrittenNumber.Data.be
{
	public static class Currencies
	{
		public static Dictionary<string, Currency> Get()
		{
			return new Dictionary<string, Currency>()
			{
				["AED"] = new Currency()
				{
					One = "дырхам ААЭ",
					Few = "дырхамы ААЭ",
					Many = "дырхамаў ААЭ",
					Other = "дырхама ААЭ",
				},
				["AFN"] = new Currency()
				{
					One = "афганскі афгані",
					Few = "афганскія афгані",
					Many = "афганскіх афгані",
					Other = "афганскага афгані",
				},
				["ALL"] = new Currency()
				{
					One = "албанскі лек",
					Few = "албанскія лекі",
					Many = "албанскіх лекаў",
					Other = "албанскага лека",
				},
				["AMD"] = new Currency()
				{
					One = "армянскі драм",
					Few = "армянскія драмы",
					Many = "армянскіх драмаў",
					Other = "армянскага драма",
				},
				["ANG"] = new Currency()
				{
					One = "нідэрландскі антыльскі гульдэн",
					Few = "нідэрландскія антыльскія гульдэны",
					Many = "нідэрландскіх антыльскіх гульдэнаў",
					Other = "нідэрландскага антыльскага гульдэна",
				},
				["AOA"] = new Currency()
				{
					One = "ангольская кванза",
					Few = "ангольскія кванзы",
					Many = "ангольскіх кванз",
					Other = "ангольскай кванзы",
				},
				["ARS"] = new Currency()
				{
					One = "аргенцінскае песа",
					Few = "аргенцінскія песа",
					Many = "аргенцінскіх песа",
					Other = "аргенцінскага песа",
				},
				["AUD"] = new Currency()
				{
					One = "аўстралійскі долар",
					Few = "аўстралійскія долары",
					Many = "аўстралійскіх долараў",
					Other = "аўстралійскага долара",
				},
				["AWG"] = new Currency()
				{
					One = "арубанскі фларын",
					Few = "арубанскія фларыны",
					Many = "арубанскіх фларынаў",
					Other = "арубанскага фларына",
				},
				["BAM"] = new Currency()
				{
					One = "канверсоўная марка Босніі і Герцагавіны",
					Few = "канверсоўныя маркі Босніі і Герцагавіны",
					Many = "канверсоўных марак Босніі і Герцагавіны",
					Other = "канверсоўнай маркі Босніі і Герцагавіны",
				},
				["BBD"] = new Currency()
				{
					One = "барбадаскі долар",
					Few = "барбадаскія долары",
					Many = "барбадаскіх долараў",
					Other = "барбадаскага долара",
				},
				["BDT"] = new Currency()
				{
					One = "бангладэшская така",
					Few = "бангладэшскія такі",
					Many = "бангладэшскіх так",
					Other = "бангладэшскай такі",
				},
				["BGN"] = new Currency()
				{
					One = "балгарскі леў",
					Few = "балгарскія левы",
					Many = "балгарскіх леваў",
					Other = "балгарскага лева",
				},
				["BHD"] = new Currency()
				{
					One = "бахрэйнскі дынар",
					Few = "бахрэйнскія дынары",
					Many = "бахрэйнскі дынараў",
					Other = "бахрэйнскага дынара",
				},
				["BIF"] = new Currency()
				{
					One = "бурундзійскі франк",
					Few = "бурундзійскія франкі",
					Many = "бурундзійскіх франкаў",
					Other = "бурундзійскага франка",
				},
				["BMD"] = new Currency()
				{
					One = "бермудскі долар",
					Few = "бермудскія долары",
					Many = "бермудскіх долараў",
					Other = "бермудскага долара",
				},
				["BND"] = new Currency()
				{
					One = "брунейскі долар",
					Few = "брунейскія долары",
					Many = "брунейскіх долараў",
					Other = "брунейскага долара",
				},
				["BOB"] = new Currency()
				{
					Few = "балівіяна",
					Many = "балівіяна",
					Other = "балівіяна",
				},
				["BRL"] = new Currency()
				{
					One = "бразільскі рэал",
					Few = "бразільскія рэалы",
					Many = "бразільскіх рэалаў",
					Other = "бразільскага рэала",
				},
				["BTN"] = new Currency()
				{
					One = "бутанскі нгултрум",
					Few = "бутанскія нгултрумы",
					Many = "бутанскіх нгултрумаў",
					Other = "бутанскага нгултрума",
				},
				["BWP"] = new Currency()
				{
					One = "батсванская пула",
					Few = "батсванскія пулы",
					Many = "батсванскіх пул",
					Other = "батсванскай пулы",
				},
				["BYN"] = new Currency()
				{
					One = "беларускі рубель",
					Few = "беларускія рублі",
					Many = "беларускіх рублёў",
					Other = "беларускага рубля",
				},
				["BZD"] = new Currency()
				{
					One = "белізскі долар",
					Few = "белізскія долары",
					Many = "белізскіх долараў",
					Other = "белізскага долара",
				},
				["CAD"] = new Currency()
				{
					One = "канадскі долар",
					Few = "канадскія долары",
					Many = "канадскіх долараў",
					Other = "канадскага долара",
				},
				["CDF"] = new Currency()
				{
					One = "кангалезскі франк",
					Few = "кангалезскія франкі",
					Many = "кангалезскіх франкаў",
					Other = "кангалезскага франка",
				},
				["CHF"] = new Currency()
				{
					One = "швейцарскі франк",
					Few = "швейцарскія франкі",
					Many = "швейцарскіх франкаў",
					Other = "швейцарскага франка",
				},
				["CNY"] = new Currency()
				{
					One = "кітайскі юань",
					Few = "кітайскія юані",
					Many = "кітайскіх юаняў",
					Other = "кітайскага юаня",
				},
				["COP"] = new Currency()
				{
					One = "калумбійскае песа",
					Few = "калумбійскія песа",
					Many = "калумбійскіх песа",
					Other = "калумбійскага песа",
				},
				["CRC"] = new Currency()
				{
					One = "коста-рыканскі калон",
					Few = "коста-рыканскія калоны",
					Many = "коста-рыканскіх калонаў",
					Other = "коста-рыканскага калона",
				},
				["CUC"] = new Currency()
				{
					One = "кубінскае канверсоўнае песа",
					Few = "кубінскія канверсоўныя песа",
					Many = "кубінскіх канверсоўных песа",
					Other = "кубінскага канверсоўнага песа",
				},
				["CUP"] = new Currency()
				{
					One = "кубінскае песа",
					Few = "кубінскія песа",
					Many = "кубінскіх песа",
					Other = "кубінскага песа",
				},
				["CVE"] = new Currency()
				{
					Few = "эскуда Каба-Вердэ",
					Many = "эскуда Каба-Вердэ",
					Other = "эскуда Каба-Вердэ",
				},
				["CZK"] = new Currency()
				{
					One = "чэшская крона",
					Few = "чэшскія кроны",
					Many = "чэшскіх крон",
					Other = "чэшскай кроны",
				},
				["DJF"] = new Currency()
				{
					One = "джыбуційскі франк",
					Few = "джыбуційскія франкі",
					Many = "джыбуційскіх франкаў",
					Other = "джыбуційскага франка",
				},
				["DKK"] = new Currency()
				{
					One = "дацкая крона",
					Few = "дацкія кроны",
					Many = "дацкіх крон",
					Other = "дацкай кроны",
				},
				["DOP"] = new Currency()
				{
					One = "дамініканскае песа",
					Few = "дамініканскія песа",
					Many = "дамініканскіх песа",
					Other = "дамініканскага песа",
				},
				["DZD"] = new Currency()
				{
					One = "алжырскі дынар",
					Few = "алжырскія дынары",
					Many = "алжырскіх дынараў",
					Other = "алжырскага дынара",
				},
				["EGP"] = new Currency()
				{
					One = "егіпецкі фунт",
					Few = "егіпецкія фунты",
					Many = "егіпецкіх фунтаў",
					Other = "егіпецкага фунта",
				},
				["ERN"] = new Currency()
				{
					One = "эрытрэйская накфа",
					Few = "эрытрэйскія накфы",
					Many = "эрытрэйскіх накфаў",
					Other = "эрытрэйскай накфы",
				},
				["ETB"] = new Currency()
				{
					One = "эфіопскі быр",
					Few = "эфіопскія быры",
					Many = "эфіопскіх быраў",
					Other = "эфіопскага быра",
				},
				["EUR"] = new Currency()
				{
					Few = "еўра",
					Many = "еўра",
					Other = "еўра",
				},
				["FJD"] = new Currency()
				{
					One = "фіджыйскі долар",
					Few = "фіджыйскія долары",
					Many = "фіджыйскіх долараў",
					Other = "фіджыйскага долара",
				},
				["FKP"] = new Currency()
				{
					One = "фунт Фалклендскіх астравоў",
					Few = "фунты Фалклендскіх астравоў",
					Many = "фунтаў Фалклендскіх астравоў",
					Other = "фунта Фалклендскіх астравоў",
				},
				["GBP"] = new Currency()
				{
					One = "брытанскі фунт стэрлінгаў",
					Few = "брытанскія фунты стэрлінгаў",
					Many = "брытанскіх фунтаў стэрлінгаў",
					Other = "брытанскага фунта стэрлінгаў",
				},
				["GEL"] = new Currency()
				{
					One = "грузінскі лары",
					Few = "грузінскія лары",
					Many = "грузінскіх лары",
					Other = "грузінскага лары",
				},
				["GHS"] = new Currency()
				{
					One = "ганскі седзі",
					Few = "ганскія седзі",
					Many = "ганскіх седзі",
					Other = "ганскага седзі",
				},
				["GIP"] = new Currency()
				{
					One = "гібралтарскі фунт",
					Few = "гібралтарскія фунты",
					Many = "гібралтарскіх фунтаў",
					Other = "гібралтарскага фунта",
				},
				["GMD"] = new Currency()
				{
					One = "гамбійскі даласі",
					Few = "гамбійскія даласі",
					Many = "гамбійскіх даласі",
					Other = "гамбійскага даласі",
				},
				["GNF"] = new Currency()
				{
					One = "гвінейскі франк",
					Few = "гвінейскія франкі",
					Many = "гвінейскіх франкаў",
					Other = "гвінейскага франка",
				},
				["GTQ"] = new Currency()
				{
					One = "гватэмальскі кетсаль",
					Few = "гватэмальскія кетсалі",
					Many = "гватэмальскіх кетсаляў",
					Other = "гватэмальскага кетсаля",
				},
				["GYD"] = new Currency()
				{
					One = "гаянскі долар",
					Few = "гаянскія долары",
					Many = "гаянскіх долараў",
					Other = "гаянскага долара",
				},
				["HKD"] = new Currency()
				{
					One = "ганконгскі долар",
					Few = "ганконгскія долары",
					Many = "ганконгскіх долараў",
					Other = "ганконгскага долара",
				},
				["HNL"] = new Currency()
				{
					One = "гандураская лемпіра",
					Few = "гандураскія лемпіры",
					Many = "гандураскіх лемпір",
					Other = "гандураскай лемпіры",
				},
				["HRK"] = new Currency()
				{
					One = "харвацкая куна",
					Few = "харвацкія куны",
					Many = "харвацкіх кун",
					Other = "харвацкай куны",
				},
				["HTG"] = new Currency()
				{
					One = "гаіцянскі гурд",
					Few = "гаіцянскія гурды",
					Many = "гаіцянскіх гурдаў",
					Other = "гаіцянскага гурда",
				},
				["HUF"] = new Currency()
				{
					One = "венгерскі форынт",
					Few = "венгерскія форынты",
					Many = "венгерскіх форынтаў",
					Other = "венгерскага форынта",
				},
				["IDR"] = new Currency()
				{
					One = "інданезійская рупія",
					Few = "інданезійскія рупіі",
					Many = "інданезійскіх рупій",
					Other = "інданезійскай рупіі",
				},
				["ILS"] = new Currency()
				{
					One = "новы ізраільскі шэкель",
					Few = "новыя ізраільскія шэкелі",
					Many = "новых ізраільскіх шэкеляў",
					Other = "новага ізраільскага шэкеля",
				},
				["INR"] = new Currency()
				{
					One = "індыйская рупія",
					Few = "індыйскія рупіі",
					Many = "індыйскіх рупій",
					Other = "індыйскай рупіі",
				},
				["IQD"] = new Currency()
				{
					One = "іракскі дынар",
					Few = "іракскія дынары",
					Many = "іракскіх дынараў",
					Other = "іракскага дынара",
				},
				["IRR"] = new Currency()
				{
					One = "іранскі рыял",
					Few = "іранскія рыялы",
					Many = "іранскіх рыялаў",
					Other = "іранскага рыяла",
				},
				["ISK"] = new Currency()
				{
					One = "ісландская крона",
					Few = "ісландскія кроны",
					Many = "ісландскіх крон",
					Other = "ісландскай кроны",
				},
				["JMD"] = new Currency()
				{
					One = "ямайскі долар",
					Few = "ямайскія долары",
					Many = "ямайскіх долараў",
					Other = "ямайскага долара",
				},
				["JOD"] = new Currency()
				{
					One = "іарданскі дынар",
					Few = "іарданскія дынары",
					Many = "іарданскіх дынараў",
					Other = "іарданскага дынара",
				},
				["JPY"] = new Currency()
				{
					One = "японская іена",
					Few = "японскія іены",
					Many = "японскіх іен",
					Other = "японскай іены",
				},
				["KES"] = new Currency()
				{
					One = "кенійскі шылінг",
					Few = "кенійскія шылінгі",
					Many = "кенійскіх шылінгаў",
					Other = "кенійскага шылінга",
				},
				["KGS"] = new Currency()
				{
					One = "кіргізскі сом",
					Few = "кіргізскія сомы",
					Many = "кіргізскіх сомаў",
					Other = "кіргізскага сома",
				},
				["KHR"] = new Currency()
				{
					One = "камбаджыйскі рыель",
					Few = "камбаджыйскія рыелі",
					Many = "камбаджыйскіх рыеляў",
					Other = "камбаджыйскага рыеля",
				},
				["KMF"] = new Currency()
				{
					One = "каморскі франк",
					Few = "каморскія франкі",
					Many = "каморскіх франкаў",
					Other = "каморскага франка",
				},
				["KPW"] = new Currency()
				{
					One = "паўночнакарэйская вона",
					Few = "паўночнакарэйскія воны",
					Many = "паўночнакарэйскіх вон",
					Other = "паўночнакарэйскай воны",
				},
				["KRW"] = new Currency()
				{
					One = "паўднёвакарэйская вона",
					Few = "паўднёвакарэйскія воны",
					Many = "паўднёвакарэйскіх вон",
					Other = "паўднёвакарэйскай воны",
				},
				["KWD"] = new Currency()
				{
					One = "кувейцкі дынар",
					Few = "кувейцкія дынары",
					Many = "кувейцкіх дынараў",
					Other = "кувейцкага дынара",
				},
				["KYD"] = new Currency()
				{
					One = "долар Кайманавых астравоў",
					Few = "долары Кайманавых астравоў",
					Many = "долараў Кайманавых астравоў",
					Other = "долара Кайманавых астравоў",
				},
				["KZT"] = new Currency()
				{
					One = "казахстанскі тэнге",
					Few = "казахстанскія тэнге",
					Many = "казахстанскіх тэнге",
					Other = "казахстанскага тэнге",
				},
				["LAK"] = new Currency()
				{
					One = "лаоскі кіп",
					Few = "лаоскія кіпы",
					Many = "лаоскіх кіпаў",
					Other = "лаоскага кіпа",
				},
				["LBP"] = new Currency()
				{
					One = "ліванскі фунт",
					Few = "ліванскія фунты",
					Many = "ліванскіх фунтаў",
					Other = "ліванскага фунта",
				},
				["LKR"] = new Currency()
				{
					One = "шры-ланкійская рупія",
					Few = "шры-ланкійскія рупіі",
					Many = "шры-ланкійскіх рупій",
					Other = "шры-ланкійскай рупіі",
				},
				["LRD"] = new Currency()
				{
					One = "ліберыйскі долар",
					Few = "ліберыйскія долары",
					Many = "ліберыйскіх долараў",
					Other = "ліберыйскага долара",
				},
				["LSL"] = new Currency()
				{
					One = "лесоцкі лоці",
					Few = "лесоцкія лоці",
					Many = "лесоцкіх лоці",
					Other = "лесоцкага лоці",
				},
				["LYD"] = new Currency()
				{
					One = "лівійскі дынар",
					Few = "лівійскія дынары",
					Many = "лівійскіх дынараў",
					Other = "лівійскага дынара",
				},
				["MAD"] = new Currency()
				{
					One = "мараканскі дырхам",
					Few = "мараканскія дырхамы",
					Many = "мараканскіх дырхамаў",
					Other = "мараканскага дырхама",
				},
				["MDL"] = new Currency()
				{
					One = "малдаўскі лей",
					Few = "малдаўскія леі",
					Many = "малдаўскіх леяў",
					Other = "малдаўскага лея",
				},
				["MGA"] = new Currency()
				{
					One = "малагасійскі арыяры",
					Few = "малагасійскія арыяры",
					Many = "малагасійскіх арыяры",
					Other = "малагасійскага арыяры",
				},
				["MKD"] = new Currency()
				{
					One = "македонскі дэнар",
					Few = "македонскія дэнары",
					Many = "македонскіх дэнараў",
					Other = "македонскага дэнара",
				},
				["MMK"] = new Currency()
				{
					One = "м’янманскі к’ят",
					Few = "м’янманскія к’яты",
					Many = "м’янманскіх к’ятаў",
					Other = "м’янманскага к’ята",
				},
				["MNT"] = new Currency()
				{
					One = "мангольскі тугрык",
					Few = "мангольскія тугрыкі",
					Many = "мангольскіх тугрыкаў",
					Other = "мангольскага тугрыка",
				},
				["MOP"] = new Currency()
				{
					One = "патака Макаа",
					Few = "патакі Макаа",
					Many = "патак Макаа",
					Other = "патакі Макаа",
				},
				["MRU"] = new Currency()
				{
					One = "маўрытанская угія",
					Few = "маўрытанскія угіі",
					Many = "маўрытанскіх угій",
					Other = "маўрытанскай угіі",
				},
				["MUR"] = new Currency()
				{
					One = "маўрыкійская рупія",
					Few = "маўрыкійскія рупіі",
					Many = "маўрыкійскіх рупій",
					Other = "маўрыкійскай рупіі",
				},
				["MVR"] = new Currency()
				{
					One = "мальдыўская руфія",
					Few = "мальдыўскія руфіі",
					Many = "мальдыўскіх руфій",
					Other = "мальдыўскай руфіі",
				},
				["MWK"] = new Currency()
				{
					One = "малавійская квача",
					Few = "малавійскія квачы",
					Many = "малавійскіх квач",
					Other = "малавійскай квачы",
				},
				["MXN"] = new Currency()
				{
					One = "мексіканскае песа",
					Few = "мексіканскія песа",
					Many = "мексіканскіх песа",
					Other = "мексіканскага песа",
				},
				["MYR"] = new Currency()
				{
					One = "малайзійскі рынгіт",
					Few = "малайзійскія рынгіты",
					Many = "малайзійскіх рынгітаў",
					Other = "малайзійскага рынгіта",
				},
				["MZN"] = new Currency()
				{
					One = "мазамбікскі метыкал",
					Few = "мазамбікскія метыкалы",
					Many = "мазамбікскіх метыкалаў",
					Other = "мазамбікскага метыкала",
				},
				["NAD"] = new Currency()
				{
					One = "намібійскі долар",
					Few = "намібійскія долары",
					Many = "намібійскіх долараў",
					Other = "намібійскага долара",
				},
				["NGN"] = new Currency()
				{
					One = "нігерыйская наіра",
					Few = "нігерыйскія наіры",
					Many = "нігерыйскіх наір",
					Other = "нігерыйскай наіры",
				},
				["NIO"] = new Currency()
				{
					One = "нікарагуанская кордаба",
					Few = "нікарагуанскія кордабы",
					Many = "нікарагуанскіх кордаб",
					Other = "нікарагуанскай кордабы",
				},
				["NOK"] = new Currency()
				{
					One = "нарвежская крона",
					Few = "нарвежскія кроны",
					Many = "нарвежскіх крон",
					Other = "нарвежскай кроны",
				},
				["NPR"] = new Currency()
				{
					One = "непальская рупія",
					Few = "непальскія рупіі",
					Many = "непальскіх рупій",
					Other = "непальскай рупіі",
				},
				["NZD"] = new Currency()
				{
					One = "новазеландскі долар",
					Few = "новазеландскія долары",
					Many = "новазеландскіх долараў",
					Other = "новазеландскага долара",
				},
				["OMR"] = new Currency()
				{
					One = "аманскі рыял",
					Few = "аманскія рыялы",
					Many = "аманскіх рыялаў",
					Other = "аманскага рыяла",
				},
				["PAB"] = new Currency()
				{
					One = "панамскае бальбоа",
					Few = "панамскія бальбоа",
					Many = "панамскіх бальбоа",
					Other = "панамскага бальбоа",
				},
				["PEN"] = new Currency()
				{
					One = "перуанскі соль",
					Few = "перуанскія солі",
					Many = "перуанскіх соляў",
					Other = "перуанскага соля",
				},
				["PGK"] = new Currency()
				{
					One = "кіна Папуа-Новай Гвінеі",
					Few = "кіны Папуа-Новай Гвінеі",
					Many = "кін Папуа-Новай Гвінеі",
					Other = "кіны Папуа-Новай Гвінеі",
				},
				["PHP"] = new Currency()
				{
					One = "філіпінскае песа",
					Few = "філіпінскія песа",
					Many = "філіпінскіх песа",
					Other = "філіпінскага песа",
				},
				["PKR"] = new Currency()
				{
					One = "пакістанская рупія",
					Few = "пакістанскія рупіі",
					Many = "пакістанскіх рупій",
					Other = "пакістанскай рупіі",
				},
				["PLN"] = new Currency()
				{
					One = "польскі злоты",
					Few = "польскія злотыя",
					Many = "польскіх злотых",
					Other = "польскага злотага",
				},
				["PYG"] = new Currency()
				{
					One = "парагвайскі гуарані",
					Few = "парагвайскія гуарані",
					Many = "парагвайскіх гуарані",
					Other = "парагвайскага гуарані",
				},
				["QAR"] = new Currency()
				{
					One = "катарскі рыял",
					Few = "катарскія рыялы",
					Many = "катарскіх рыялаў",
					Other = "катарскага рыяла",
				},
				["RON"] = new Currency()
				{
					One = "румынскі лей",
					Few = "румынскія леі",
					Many = "румынскіх леяў",
					Other = "румынскага лея",
				},
				["RSD"] = new Currency()
				{
					One = "сербскі дынар",
					Few = "сербскія дынары",
					Many = "сербскіх дынараў",
					Other = "сербскага дынара",
				},
				["RUB"] = new Currency()
				{
					One = "расійскі рубель",
					Few = "расійскія рублі",
					Many = "расійскіх рублёў",
					Other = "расійскага рубля",
				},
				["RWF"] = new Currency()
				{
					One = "руандыйскі франк",
					Few = "руандыйскія франкі",
					Many = "руандыйскіх франкаў",
					Other = "руандыйскага франка",
				},
				["SAR"] = new Currency()
				{
					One = "саудаўскі рыял",
					Few = "саудаўскія рыялы",
					Many = "саудаўскіх рыялаў",
					Other = "саудаўскага рыяла",
				},
				["SBD"] = new Currency()
				{
					One = "долар Саламонавых астравоў",
					Few = "долар Саламонавых астравоў",
					Many = "долараў Саламонавых астравоў",
					Other = "долара Саламонавых астравоў",
				},
				["SCR"] = new Currency()
				{
					One = "сейшэльская рупія",
					Few = "сейшэльскія рупіі",
					Many = "сейшэльскіх рупій",
					Other = "сейшэльскай рупіі",
				},
				["SDG"] = new Currency()
				{
					One = "суданскі фунт",
					Few = "суданскія фунты",
					Many = "суданскіх фунтаў",
					Other = "суданскага фунта",
				},
				["SEK"] = new Currency()
				{
					One = "шведская крона",
					Few = "шведскія кроны",
					Many = "шведскіх крон",
					Other = "шведскай кроны",
				},
				["SGD"] = new Currency()
				{
					One = "сінгапурскі долар",
					Few = "сінгапурскія долары",
					Many = "сінгапурскіх долараў",
					Other = "сінгапурскага долара",
				},
				["SHP"] = new Currency()
				{
					One = "фунт в-ва Святой Алены",
					Few = "фунты в-ва Святой Алены",
					Many = "фунтаў в-ва Святой Алены",
					Other = "фунта в-ва Святой Алены",
				},
				["SLL"] = new Currency()
				{
					One = "сьера-леонскі леонэ",
					Few = "сьера-леонскія леонэ",
					Many = "сьера-леонскіх леонэ",
					Other = "сьера-леонскага леонэ",
				},
				["SOS"] = new Currency()
				{
					One = "самалійскі шылінг",
					Few = "самалійскія шылінгі",
					Many = "самалійскіх шылінгаў",
					Other = "самалійскага шылінга",
				},
				["SRD"] = new Currency()
				{
					One = "сурынамскі долар",
					Few = "сурынамскія долары",
					Many = "сурынамскіх долараў",
					Other = "сурынамскага долара",
				},
				["SSP"] = new Currency()
				{
					One = "паўднёвасуданскі фунт",
					Few = "паўднёвасуданскія фунты",
					Many = "паўднёвасуданскіх фунтаў",
					Other = "паўднёвасуданскага фунта",
				},
				["STN"] = new Currency()
				{
					One = "добра Сан-Тамэ і Прынсіпі",
					Few = "добры Сан-Тамэ і Прынсіпі",
					Many = "добраў Сан-Тамэ і Прынсіпі",
					Other = "добры Сан-Тамэ і Прынсіпі",
				},
				["SYP"] = new Currency()
				{
					One = "сірыйскі фунт",
					Few = "сірыйскія фунты",
					Many = "сірыйскіх фунтаў",
					Other = "сірыйскага фунта",
				},
				["SZL"] = new Currency()
				{
					One = "свазілендскі лілангені",
					Few = "свазілендскія лілангені",
					Many = "свазілендскіх лілангені",
					Other = "свазілендскага лілангені",
				},
				["THB"] = new Currency()
				{
					One = "тайскі бат",
					Few = "тайскія баты",
					Many = "тайскіх батаў",
					Other = "тайскага бата",
				},
				["TJS"] = new Currency()
				{
					One = "таджыкскі самані",
					Few = "таджыкскія самані",
					Many = "таджыкскіх самані",
					Other = "таджыкскага самані",
				},
				["TMT"] = new Currency()
				{
					One = "туркменскі манат",
					Few = "туркменскія манаты",
					Many = "туркменскіх манатаў",
					Other = "туркменскага маната",
				},
				["TND"] = new Currency()
				{
					One = "туніскі дынар",
					Few = "туніскія дынары",
					Many = "туніскіх дынараў",
					Other = "туніскага дынара",
				},
				["TOP"] = new Currency()
				{
					One = "танганская паанга",
					Few = "танганскія паангі",
					Many = "танганскіх паанг",
					Other = "танганскай паангі",
				},
				["TRY"] = new Currency()
				{
					One = "турэцкая ліра",
					Few = "турэцкія ліры",
					Many = "турэцкіх лір",
					Other = "турэцкай ліры",
				},
				["TTD"] = new Currency()
				{
					One = "долар Трынідада і Табага",
					Few = "долары Трынідада і Табага",
					Many = "долараў Трынідада і Табага",
					Other = "долара Трынідада і Табага",
				},
				["TWD"] = new Currency()
				{
					One = "новы тайваньскі долар",
					Few = "новыя тайваньскія долары",
					Many = "новых тайваньскіх долараў",
					Other = "новага тайваньскага долара",
				},
				["TZS"] = new Currency()
				{
					One = "танзанійскі шылінг",
					Few = "танзанійскія шылінгі",
					Many = "танзанійскіх шылінгаў",
					Other = "танзанійскага шылінга",
				},
				["UAH"] = new Currency()
				{
					One = "украінская грыўня",
					Few = "украінскія грыўні",
					Many = "украінскіх грыўняў",
					Other = "украінскай грыўні",
				},
				["UGX"] = new Currency()
				{
					One = "угандыйскі шылінг",
					Few = "угандыйскія шылінгі",
					Many = "угандыйскіх шылінгаў",
					Other = "угандыйскага шылінга",
				},
				["USD"] = new Currency()
				{
					One = "долар ЗША",
					Few = "долары ЗША",
					Many = "долараў ЗША",
					Other = "долара ЗША",
				},
				["UYU"] = new Currency()
				{
					One = "уругвайскае песа",
					Few = "уругвайскія песа",
					Many = "уругвайскіх песа",
					Other = "уругвайскага песа",
				},
				["UZS"] = new Currency()
				{
					One = "узбекскі сум",
					Few = "узбекскія сумы",
					Many = "узбекскіх сумаў",
					Other = "узбекскага сума",
				},
				["VES"] = new Currency()
				{
					One = "венесуэльскі балівар",
					Few = "венесуэльскія балівары",
					Many = "венесуэльскіх балівараў",
					Other = "венесуэльскага балівара",
				},
				["VND"] = new Currency()
				{
					One = "в’етнамскі донг",
					Few = "в’етнамскія донгі",
					Many = "в’етнамскіх донгаў",
					Other = "в’етнамскага донга",
				},
				["VUV"] = new Currency()
				{
					One = "вануацкі вату",
					Few = "вануацкія вату",
					Many = "вануацкіх вату",
					Other = "вануацкага вату",
				},
				["WST"] = new Currency()
				{
					One = "самаанская тала",
					Few = "самаанскія талы",
					Many = "самаанскіх тал",
					Other = "самаанскай талы",
				},
				["XAF"] = new Currency()
				{
					One = "цэнтральнаафрыканскі франк КФА",
					Few = "цэнтральнаафрыканскія франкі КФА",
					Many = "цэнтральнаафрыканскіх франкаў КФА",
					Other = "цэнтральнаафрыканскага франка КФА",
				},
				["XCD"] = new Currency()
				{
					One = "усходнекарыбскі долар",
					Few = "усходнекарыбскія долары",
					Many = "усходнекарыбскіх долараў",
					Other = "усходнекарыбскага долара",
				},
				["XOF"] = new Currency()
				{
					One = "заходнеафрыканскі франк КФА",
					Few = "заходнеафрыканскія франкі КФА",
					Many = "заходнеафрыканскіх франкаў КФА",
					Other = "заходнеафрыканскага франка КФА",
				},
				["XPF"] = new Currency()
				{
					One = "французскі ціхаакіянскі франк",
					Few = "французскія ціхаакіянскія франкі",
					Many = "французскіх ціхаакіянскіх франкаў",
					Other = "французскага ціхаакіянскага франка",
				},
				["YER"] = new Currency()
				{
					One = "еменскі рыял",
					Few = "еменскія рыялы",
					Many = "еменскіх рыялаў",
					Other = "еменскага рыяла",
				},
				["ZAR"] = new Currency()
				{
					One = "паўднёваафрыканскі рэнд",
					Few = "паўднёваафрыканскія рэнды",
					Many = "паўднёваафрыканскіх рэндаў",
					Other = "паўднёваафрыканскага рэнда",
				},
				["ZMW"] = new Currency()
				{
					One = "замбійская квача",
					Few = "замбійскія квачы",
					Many = "замбійскіх квач",
					Other = "замбійскай квачы",
				},
			};
		}
	}
}
