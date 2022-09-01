namespace WrittenNumber
{
    internal static class Currencies
    {
        private static Dictionary<string, Type> types;

        static Currencies()
        {
            types = typeof(Currencies).Assembly.GetTypes().Where(x => x != typeof(Currencies) && x.Name == typeof(Currencies).Name).ToDictionary(x => x.Namespace!.Split('.').Last());
        }

        public static Dictionary<string, Models.Currency> Get(string language)
        {
            if (types.TryGetValue(language, out Type value))
            {
                return (Dictionary<string, Models.Currency>)value.GetMethod(nameof(Data.en.Currencies.Get))!.Invoke(null, null)!;
            }

            return (Dictionary<string, Models.Currency>)types[nameof(Data.en)].GetMethod(nameof(Data.en.Currencies.Get))!.Invoke(null, null)!;
        }
    }
}