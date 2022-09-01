using WrittenNumber.Models;

namespace WrittenNumber.Test;

public class EnglishCurrencyTest
{
    private readonly Option _cad;
    private readonly Option _xxx;

    public EnglishCurrencyTest()
    {
        _cad = new Option
        {
            Language = "en",
            Currency = "CAD"
        };
        _xxx = new Option
        {
            Language = "en",
            Currency = "XXX"
        };
    }
   
    [Fact]
    public void Correctly_Appends_Currency_Name()
    {
        Assert.Equal("one Canadian dollar", 1.WrittenNumber(_cad));
        Assert.Equal("twenty Canadian dollars", 20.WrittenNumber(_cad));
        Assert.Equal("twenty-five Canadian dollars", 25.WrittenNumber(_cad));
        Assert.Equal("eighty-eight Canadian dollars", 88.WrittenNumber(_cad));
        Assert.Equal("seventy-three XXX", 73.WrittenNumber(_xxx));
    }
}