using WrittenNumber.Models;

namespace WrittenNumber.Test;

public class EnglishUSDTest
{
    private readonly Option _option;

    public EnglishUSDTest()
    {
        _option = new Option
        {
            Language = "en",
            Currency = "CAD"
        };
    }
   
    [Fact]
    public void Correctly_Appends_Currency_Name()
    {
        Assert.Equal("one Canadian dollar", 1.WrittenNumber(_option));
        Assert.Equal("twenty Canadian dollars", 20.WrittenNumber(_option));
        Assert.Equal("twenty-five Canadian dollars", 25.WrittenNumber(_option));
        Assert.Equal("eighty-eight Canadian dollars", 88.WrittenNumber(_option));
        Assert.Equal("seventy-three Canadian dollars", 73.WrittenNumber(_option));
    }
}