using WrittenNumber.Models;

namespace WrittenNumber.Data.ta
{
	public static class Currencies
	{
		public static Dictionary<string, Currency> Get()
		{
			return new Dictionary<string, Currency>()
			{
				["AED"] = new Currency()
				{
					One = "ஐக்கிய அரபு எமிரேட்ஸ் திர்ஹாம்",
					Other = "ஐக்கிய அரபு எமிரேட்ஸ் திர்ஹாம்கள்",
				},
				["AFN"] = new Currency()
				{
					One = "ஆஃப்கான் ஆஃப்கானி",
					Other = "ஆஃப்கான் ஆஃப்கானிகள்",
				},
				["ALL"] = new Currency()
				{
					One = "அல்பேனியன் லெக்",
					Other = "அல்பேனியன் லெகே",
				},
				["AMD"] = new Currency()
				{
					One = "ஆர்மேனியன் ட்ராம்",
					Other = "ஆர்மேனியன் ட்ராம்கள்",
				},
				["ANG"] = new Currency()
				{
					One = "நெதர்லேண்ட்ஸ் அன்டிலியன் கில்டர்",
					Other = "நெதர்லேண்ட்ஸ் அன்டிலியன் கில்டர்கள்",
				},
				["AOA"] = new Currency()
				{
					One = "அங்கோலன் க்வான்ஸா",
					Other = "அங்கோலன் க்வான்ஸாக்கள்",
				},
				["ARS"] = new Currency()
				{
					One = "அர்ஜென்டைன் பெசோ",
					Other = "அர்ஜென்டைன் பெசோக்கள்",
				},
				["AUD"] = new Currency()
				{
					One = "ஆஸ்திரேலிய டாலர்",
					Other = "ஆஸ்திரேலிய டாலர்கள்",
				},
				["AWG"] = new Currency()
				{
					Other = "அருபன் ஃப்ளோரின்",
				},
				["BAM"] = new Currency()
				{
					One = "போஸ்னியா-ஹெர்ஸேகோவினா கன்வெர்டிபில் மார்க்",
					Other = "போஸ்னியா-ஹெர்ஸேகோவினா கன்வெர்டிபில் மார்க்குகள்",
				},
				["BBD"] = new Currency()
				{
					One = "பார்பேடியன் டாலர்",
					Other = "பார்பேடியன் டாலர்கள்",
				},
				["BDT"] = new Currency()
				{
					One = "பங்களாதேஷி டாகா",
					Other = "பங்களாதேஷி டாகாக்கள்",
				},
				["BGN"] = new Currency()
				{
					One = "பல்கேரியன் லேவ்",
					Other = "பல்கேரியன் லேவா",
				},
				["BHD"] = new Currency()
				{
					One = "பஹ்ரைனி தினார்",
					Other = "பஹ்ரைனி தினார்கள்",
				},
				["BIF"] = new Currency()
				{
					One = "புருண்டியன் ஃப்ராங்க்",
					Other = "புருண்டியன் ஃப்ராங்க்குகள்",
				},
				["BMD"] = new Currency()
				{
					One = "பெர்முடன் டாலர்",
					Other = "பெர்முடன் டாலர்கள்",
				},
				["BND"] = new Currency()
				{
					One = "புரூனே டாலர்",
					Other = "புரூனே டாலர்கள்",
				},
				["BOB"] = new Currency()
				{
					One = "பொலிவியன் பொலிவியானோ",
					Other = "பொலிவியன் பொலிவியானோக்கள்",
				},
				["BRL"] = new Currency()
				{
					One = "பிரேசிலியன் ரியால்",
					Other = "பிரேசிலியன் ரியால்கள்",
				},
				["BTN"] = new Currency()
				{
					One = "பூட்டானீஸ் குல்ட்ரம்",
					Other = "பூட்டானீஸ் குல்ட்ரம்கள்",
				},
				["BWP"] = new Currency()
				{
					One = "போட்ஸ்வானன் புலா",
					Other = "போட்ஸ்வானன் புலாக்கள்",
				},
				["BYN"] = new Currency()
				{
					One = "பெலருசியன் ரூபிள்",
					Other = "பெலருசியன் ரூபிள்கள்",
				},
				["BZD"] = new Currency()
				{
					One = "பெலீஸ் டாலர்",
					Other = "பெலீஸ் டாலர்கள்",
				},
				["CAD"] = new Currency()
				{
					One = "கனடியன் டாலர்",
					Other = "கனடியன் டாலர்கள்",
				},
				["CDF"] = new Currency()
				{
					One = "காங்கோலீஸ் ஃப்ராங்க்",
					Other = "காங்கோலீஸ் ஃப்ராங்க்குகள்",
				},
				["CHF"] = new Currency()
				{
					One = "சுவிஸ் ஃப்ராங்க்",
					Other = "சுவிஸ் ஃப்ராங்குகள்",
				},
				["CNY"] = new Currency()
				{
					Other = "சீன யுவான்",
				},
				["COP"] = new Currency()
				{
					One = "கொலம்பியன் பெசோ",
					Other = "கொலம்பியன் பெசோக்கள்",
				},
				["CRC"] = new Currency()
				{
					One = "கோஸ்டா ரிகன் கொலோன்",
					Other = "கோஸ்டா ரிகன் கொலோன்கள்",
				},
				["CUC"] = new Currency()
				{
					One = "கியூபன் கன்வெர்டிபில் பெசோ",
					Other = "கியூபன் கன்வெர்டிபில் பெசோக்கள்",
				},
				["CUP"] = new Currency()
				{
					One = "கியூபன் பெசோ",
					Other = "கியூபன் பெசோக்கள்",
				},
				["CVE"] = new Currency()
				{
					One = "கேப் வெர்டியன் எஸ்குடோ",
					Other = "கேப் வெர்டியன் எஸ்குடோக்கள்",
				},
				["CZK"] = new Currency()
				{
					One = "செக் குடியரசு கொருனா",
					Other = "செக் குடியரசு கொருனாக்கள்",
				},
				["DJF"] = new Currency()
				{
					One = "ஜிபவ்டியென் ஃப்ராங்க்",
					Other = "ஜிபவ்டியென் ஃப்ராங்க்குகள்",
				},
				["DKK"] = new Currency()
				{
					One = "டேனிஷ் க்ரோன்",
					Other = "டேனிஷ் க்ரோனர்",
				},
				["DOP"] = new Currency()
				{
					One = "டொமினிக்கன் பெசோ",
					Other = "டொமினிக்கன் பெசோக்கள்",
				},
				["DZD"] = new Currency()
				{
					One = "அல்ஜீரியன் தினார்",
					Other = "அல்ஜீரியன் தினார்கள்",
				},
				["EGP"] = new Currency()
				{
					One = "எகிப்திய பவுண்டு",
					Other = "எகிப்திய பவுண்டுகள்",
				},
				["ERN"] = new Currency()
				{
					One = "எரித்ரியன் நக்ஃபா",
					Other = "எரித்ரியன் நக்ஃபாக்கள்",
				},
				["ETB"] = new Currency()
				{
					One = "எத்தியோப்பியன் பிர்",
					Other = "எத்தியோப்பியன் பிர்கள்",
				},
				["EUR"] = new Currency()
				{
					One = "யூரோ",
					Other = "யூரோக்கள்",
				},
				["FJD"] = new Currency()
				{
					One = "ஃபிஜியன் டாலர்",
					Other = "ஃபிஜியன் டாலர்கள்",
				},
				["FKP"] = new Currency()
				{
					One = "ஃபாக்லாந்து தீவுகள் பவுண்டு",
					Other = "ஃபாக்லாந்து தீவுகள் பவுண்டுகள்",
				},
				["GBP"] = new Currency()
				{
					One = "பிரிட்டிஷ் பவுண்டு",
					Other = "பிரிட்டிஷ் பவுண்டுகள்",
				},
				["GEL"] = new Currency()
				{
					One = "ஜார்ஜியன் லாரி",
					Other = "ஜார்ஜியன் லாரிகள்",
				},
				["GHS"] = new Currency()
				{
					One = "கானயன் சேடி",
					Other = "கானயன் சேடிகள்",
				},
				["GIP"] = new Currency()
				{
					One = "ஜிப்ரால்டர் பவுண்டு",
					Other = "ஜிப்ரால்டர் பவுண்டுகள்",
				},
				["GMD"] = new Currency()
				{
					One = "கேம்பியன் தலாசி",
					Other = "கேம்பியன் தலாசிகள்",
				},
				["GNF"] = new Currency()
				{
					One = "கினியன் ஃப்ராங்க்",
					Other = "கினியன் ஃப்ராங்குகள்",
				},
				["GTQ"] = new Currency()
				{
					One = "குவாதெமாலன் க்யுட்ஸல்",
					Other = "குவாதெமாலன் க்யுட்ஸல்கள்",
				},
				["GYD"] = new Currency()
				{
					One = "கயானீஸ் டாலர்",
					Other = "கயானீஸ் டாலர்கள்",
				},
				["HKD"] = new Currency()
				{
					One = "ஹாங்காங் டாலர்",
					Other = "ஹாங்காங் டாலர்கள்",
				},
				["HNL"] = new Currency()
				{
					One = "ஹோன்டூரன் லெம்பீரா",
					Other = "ஹோன்டூரன் லெம்பீராக்கள்",
				},
				["HRK"] = new Currency()
				{
					One = "குரோஷியன் குனா",
					Other = "குரோஷியன் குனாக்கள்",
				},
				["HTG"] = new Currency()
				{
					One = "ஹைட்டியன் கோர்டே",
					Other = "ஹைட்டியன் கோர்டேக்கள்",
				},
				["HUF"] = new Currency()
				{
					One = "ஹங்கேரியன் ஃபோரின்ட்",
					Other = "ஹங்கேரியன் ஃபோரின்ட்கள்",
				},
				["IDR"] = new Currency()
				{
					One = "இந்தோனேஷியன் ருபியா",
					Other = "இந்தோனேஷியன் ருபியாக்கள்",
				},
				["ILS"] = new Currency()
				{
					One = "இஸ்ரேலி நியூ ஷிகேல்",
					Other = "இஸ்ரேலி நியூ ஷிகேல்கள்",
				},
				["INR"] = new Currency()
				{
					One = "இந்திய ரூபாய்",
					Other = "இந்திய ரூபாய்கள்",
				},
				["IQD"] = new Currency()
				{
					One = "ஈராக்கி தினார்",
					Other = "ஈராக்கி தினார்கள்",
				},
				["IRR"] = new Currency()
				{
					One = "ஈரானியன் ரியால்",
					Other = "ஈரானியன் ரியால்கள்",
				},
				["ISK"] = new Currency()
				{
					One = "ஐஸ்லாண்டிக் க்ரோனா",
					Other = "ஐஸ்லாண்டிக் க்ரோனர்",
				},
				["JMD"] = new Currency()
				{
					One = "ஜமைக்கன் டாலர்",
					Other = "ஜமைக்கன் டாலர்கள்",
				},
				["JOD"] = new Currency()
				{
					One = "ஜோர்டானிய தினார்",
					Other = "ஜோர்டானிய தினார்கள்",
				},
				["JPY"] = new Currency()
				{
					Other = "ஜப்பானிய யென்",
				},
				["KES"] = new Currency()
				{
					One = "கென்யன் ஷில்லிங்",
					Other = "கென்யன் ஷில்லிங்குகள்",
				},
				["KGS"] = new Currency()
				{
					One = "கிரிகிஸ்தானி சோம்",
					Other = "கிர்கிஸ்தானி சோம்கள்",
				},
				["KHR"] = new Currency()
				{
					One = "கம்போடியன் ரியெல்",
					Other = "கம்போடியன் ரியெல்கள்",
				},
				["KMF"] = new Currency()
				{
					One = "கமோரியன் ஃப்ராங்க்",
					Other = "கமோரியன் ஃப்ராங்க்குகள்",
				},
				["KPW"] = new Currency()
				{
					Other = "வட கொரிய வான்",
				},
				["KRW"] = new Currency()
				{
					Other = "தென் கொரிய வான்",
				},
				["KWD"] = new Currency()
				{
					One = "குவைத்தி தினார்",
					Other = "குவைத்தி தினார்கள்",
				},
				["KYD"] = new Currency()
				{
					One = "கேமன் தீவுகள் டாலர்",
					Other = "கேமன் தீவுகள் டாலர்கள்",
				},
				["KZT"] = new Currency()
				{
					One = "கஸகஸ்தானி டென்கே",
					Other = "கஸகஸ்தானி டென்கேக்கள்",
				},
				["LAK"] = new Currency()
				{
					One = "லவோஷியன் கிப்",
					Other = "லவோஷியன் கிப்கள்",
				},
				["LBP"] = new Currency()
				{
					One = "லெபனீஸ் பவுண்டு",
					Other = "லெபனீஸ் பவுண்டுகள்",
				},
				["LKR"] = new Currency()
				{
					One = "இலங்கை ரூபாய்",
					Other = "இலங்கை ரூபாய்கள்",
				},
				["LRD"] = new Currency()
				{
					One = "லைபீரியன் டாலர்",
					Other = "லைபீரியன் டாலர்கள்",
				},
				["LSL"] = new Currency()
				{
					One = "லெசோதோ லோட்டி",
					Other = "லெசோதோ லோட்டிகள்",
				},
				["LYD"] = new Currency()
				{
					One = "லிபியன் தினார்",
					Other = "லிபியன் தினார்கள்",
				},
				["MAD"] = new Currency()
				{
					One = "மொராக்கன் திர்ஹாம்",
					Other = "மொராக்கன் திர்ஹாம்கள்",
				},
				["MDL"] = new Currency()
				{
					One = "மால்டோவன் லியூ",
					Other = "மால்டோவன் லேய்",
				},
				["MGA"] = new Currency()
				{
					One = "மலகாசி ஏரியரி",
					Other = "மலகாசி ஏரியரிகள்",
				},
				["MKD"] = new Currency()
				{
					One = "மாசிடோனியன் டேனார்",
					Other = "மாசிடோனியன் டேனாரி",
				},
				["MMK"] = new Currency()
				{
					One = "மியான்மர் கியாத்",
					Other = "மியான்மர் கியாத்கள்",
				},
				["MNT"] = new Currency()
				{
					One = "மங்கோலியன் டுக்ரிக்",
					Other = "மங்கோலியன் டுக்ரிக்குகள்",
				},
				["MOP"] = new Currency()
				{
					One = "மெகனீஸ் படாகா",
					Other = "மெகனீஸ் படாகாக்கள்",
				},
				["MRU"] = new Currency()
				{
					One = "மொரிஷானியன் ஒகுயா",
					Other = "மொரிஷானியன் ஒகுயாக்கள்",
				},
				["MUR"] = new Currency()
				{
					One = "மொரீஷியன் ருபீ",
					Other = "மொரீஷியன் ருபீக்கள்",
				},
				["MVR"] = new Currency()
				{
					One = "மாலத்தீவு ருஃபியா",
					Other = "மாலத்தீவு ருஃபியாக்கள்",
				},
				["MWK"] = new Currency()
				{
					One = "மலாவியன் குவாச்சா",
					Other = "மலாவியன் குவாச்சாக்கள்",
				},
				["MXN"] = new Currency()
				{
					One = "மெக்ஸிகன் பெசோ",
					Other = "மெக்ஸிகன் பெசோக்கள்",
				},
				["MYR"] = new Currency()
				{
					One = "மலேஷியன் ரிங்கிட்",
					Other = "மலேஷியன் ரிங்கிட்கள்",
				},
				["MZN"] = new Currency()
				{
					One = "மொசாம்பிகன் மெடிகல்",
					Other = "மொசாம்பிகன் மெடிகல்கள்",
				},
				["NAD"] = new Currency()
				{
					One = "நமீபியன் டாலர்",
					Other = "நமீபியன் டாலர்கள்",
				},
				["NGN"] = new Currency()
				{
					One = "நைஜீரியன் நைரா",
					Other = "நைஜீரியன் நைராக்கள்",
				},
				["NIO"] = new Currency()
				{
					One = "நிகரகுவன் கோர்டோபா",
					Other = "நிகரகுவன் கோர்டோபாக்கள்",
				},
				["NOK"] = new Currency()
				{
					One = "நார்வேஜியன் க்ரோன்",
					Other = "நார்வேஜியன் க்ரோனர்",
				},
				["NPR"] = new Currency()
				{
					One = "நேபாளீஸ் ரூபாய்",
					Other = "நேபாளீஸ் ரூபாய்கள்",
				},
				["NZD"] = new Currency()
				{
					One = "நியூசிலாந்து டாலர்",
					Other = "நியூசிலாந்து டாலர்கள்",
				},
				["OMR"] = new Currency()
				{
					One = "ஓமானி ரியால்",
					Other = "ஓமானி ரியால்கள்",
				},
				["PAB"] = new Currency()
				{
					One = "பனாமானியன் பால்போவா",
					Other = "பனாமானியன் பால்போவாக்கள்",
				},
				["PEN"] = new Currency()
				{
					One = "பெரூவியன் சோல்",
					Other = "பெரூவியன் சோல்கள்",
				},
				["PGK"] = new Currency()
				{
					Other = "பபுவா நியூ கினியன் கினா",
				},
				["PHP"] = new Currency()
				{
					One = "பிலிப்பைன் பெசோ",
					Other = "பிலிப்பைன் பெசோக்கள்",
				},
				["PKR"] = new Currency()
				{
					One = "பாகிஸ்தானி ரூபாய்",
					Other = "பாகிஸ்தானி ரூபாய்கள்",
				},
				["PLN"] = new Currency()
				{
					One = "போலிஷ் ஸ்லாட்டி",
					Other = "போலிஷ் ஸ்லாட்டிகள்",
				},
				["PYG"] = new Currency()
				{
					One = "பராகுவன் குவாரானி",
					Other = "பராகுவன் குவாரானிகள்",
				},
				["QAR"] = new Currency()
				{
					One = "கத்தாரி ரியால்",
					Other = "கத்தாரி ரியால்கள்",
				},
				["RON"] = new Currency()
				{
					One = "ரோமானியன் லியூ",
					Other = "ரோமானியன் லேய்",
				},
				["RSD"] = new Currency()
				{
					One = "செர்பியன் தினார்",
					Other = "செர்பியன் தினார்கள்",
				},
				["RUB"] = new Currency()
				{
					One = "ரஷியன் ரூபிள்",
					Other = "ரஷியன் ரூபிள்கள்",
				},
				["RWF"] = new Currency()
				{
					One = "ருவாண்டன் ஃப்ராங்க்",
					Other = "ருவாண்டன் ஃப்ராங்க்குகள்",
				},
				["SAR"] = new Currency()
				{
					One = "சவுதி ரியால்",
					Other = "சவுதி ரியால்கள்",
				},
				["SBD"] = new Currency()
				{
					One = "சாலமன் தீவுகள் டாலர்",
					Other = "சாலமன் தீவுகள் டாலர்கள்",
				},
				["SCR"] = new Currency()
				{
					One = "சிசீலோயிஸ் ருபீ",
					Other = "சிசீலோயிஸ் ருபீக்கள்",
				},
				["SDG"] = new Currency()
				{
					One = "சூடானீஸ் பவுண்டு",
					Other = "சூடானீஸ் பவுண்டுகள்",
				},
				["SEK"] = new Currency()
				{
					One = "ஸ்வீடிஷ் க்ரோனா",
					Other = "ஸ்வீடிஷ் க்ரோனர்",
				},
				["SGD"] = new Currency()
				{
					One = "சிங்கப்பூர் டாலர்",
					Other = "சிங்கப்பூர் டாலர்கள்",
				},
				["SHP"] = new Currency()
				{
					One = "செயின்ட் ஹெலேனா பவுண்டு",
					Other = "செயின்ட் ஹெலேனா பவுண்டுகள்",
				},
				["SLL"] = new Currency()
				{
					One = "சியாரா லியோனியன் லியோன்",
					Other = "சியாரா லியோனியன் லியோன்கள்",
				},
				["SOS"] = new Currency()
				{
					One = "சோமாலி ஷில்லிங்",
					Other = "சோமாலி ஷில்லிங்குகள்",
				},
				["SRD"] = new Currency()
				{
					One = "சுரினாமீஸ் டாலர்",
					Other = "சுரினாமீஸ் டாலர்கள்",
				},
				["SSP"] = new Currency()
				{
					One = "தெற்கு சூடானீஸ் பவுண்டு",
					Other = "தெற்கு சூடானீஸ் பவுண்டுகள்",
				},
				["STN"] = new Currency()
				{
					One = "சாவ் டோமி மற்றும் பிரின்ஸ்பி டோப்ரா",
					Other = "சாவ் டோமி மற்றும் பிரின்ஸ்பி டோப்ராக்கள்",
				},
				["SYP"] = new Currency()
				{
					One = "சிரியன் பவுண்டு",
					Other = "சிரியன் பவுண்டுகள்",
				},
				["SZL"] = new Currency()
				{
					One = "சுவாஸி லிலாங்கனி",
					Other = "சுவாஸி எமாலாங்கனி",
				},
				["THB"] = new Currency()
				{
					Other = "தாய் பாட்",
				},
				["TJS"] = new Currency()
				{
					One = "தஜிகிஸ்தானி சோமோனி",
					Other = "தஜிகிஸ்தானி சோமோனிகள்",
				},
				["TMT"] = new Currency()
				{
					Other = "துர்க்மெனிஸ்தானி மனத்",
				},
				["TND"] = new Currency()
				{
					One = "துனிஷியன் தினார்",
					Other = "துனிஷியன் தினார்கள்",
				},
				["TOP"] = new Currency()
				{
					Other = "தொங்கான் பங்கா",
				},
				["TRY"] = new Currency()
				{
					Other = "துருக்கிஷ் லீரா",
				},
				["TTD"] = new Currency()
				{
					One = "டிரினிடாட் மற்றும் டோபாகோ டாலர்",
					Other = "டிரினிடாட் மற்றும் டோபாகோ டாலர்கள்",
				},
				["TWD"] = new Currency()
				{
					One = "புதிய தைவான் டாலர்",
					Other = "புதிய தைவான் டாலர்கள்",
				},
				["TZS"] = new Currency()
				{
					One = "தான்சானியன் ஷில்லிங்",
					Other = "தான்சானியன் ஷில்லிங்குகள்",
				},
				["UAH"] = new Currency()
				{
					One = "உக்ரைனியன் ஹிரைவ்னியா",
					Other = "உக்ரைனியன் ஹிரைவ்னியாக்கள்",
				},
				["UGX"] = new Currency()
				{
					One = "உகாண்டன் ஷில்லிங்",
					Other = "உகாண்டன் ஷில்லிங்குகள்",
				},
				["USD"] = new Currency()
				{
					One = "அமெரிக்க டாலர்",
					Other = "அமெரிக்க டாலர்கள்",
				},
				["UYU"] = new Currency()
				{
					One = "உருகுவேயன் பெசோ",
					Other = "உருகுவேயன் பெசோக்கள்",
				},
				["UZS"] = new Currency()
				{
					Other = "உஸ்பெக்கிஸ்தானி சோம்",
				},
				["VES"] = new Currency()
				{
					One = "வெனிசுலன் போலிவர்",
					Other = "வெனிசுலன் போலிவர்கள்",
				},
				["VND"] = new Currency()
				{
					Other = "வியட்நாமீஸ் டாங்",
				},
				["VUV"] = new Currency()
				{
					One = "வனுவாட்டு வாட்டு",
					Other = "வனுவாட்டு வாட்டுகள்",
				},
				["WST"] = new Currency()
				{
					Other = "சமோவான் தாலா",
				},
				["XAF"] = new Currency()
				{
					One = "மத்திய ஆப்பிரிக்க CFA ஃப்ராங்க்",
					Other = "மத்திய ஆப்பிரிக்க CFA ஃப்ராங்க்குகள்",
				},
				["XCD"] = new Currency()
				{
					One = "கிழக்கு கரீபியன் டாலர்",
					Other = "கிழக்கு கரீபியன் டாலர்கள்",
				},
				["XOF"] = new Currency()
				{
					One = "மேற்கு ஆப்பிரிக்க CFA ஃப்ராங்க்",
					Other = "மேற்கு ஆப்பிரிக்க CFA ஃப்ராங்க்குகள்",
				},
				["XPF"] = new Currency()
				{
					One = "ஃப்ராங்க் (CFP)",
					Other = "ஃப்ராங்குகள் (CFP)",
				},
				["YER"] = new Currency()
				{
					One = "ஏமனி ரியால்",
					Other = "ஏமனி ரியால்கள்",
				},
				["ZAR"] = new Currency()
				{
					Other = "தென் ஆப்ரிக்க ராண்ட்",
				},
				["ZMW"] = new Currency()
				{
					One = "ஸாம்பியன் குவாச்சா",
					Other = "ஸாம்பியன் குவாச்சாக்கள்",
				},
			};
		}
	}
}
