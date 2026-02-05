namespace TestUnite;
using System;
using TempUnitConverter;
using Xunit;

public class UnitTest1
{
    Converter converter = new Converter();
    [Fact]
    public void CToKTestShouldReturnFifty()
    {
        Assert.Equal(283.15, converter.CToK(10));
    }

    [Fact]
    public void CToFTestShouldReturnDouble()
    {
        Assert.Equal(283.14999999999998, converter.CToK(10));
    }

    [Fact]
    public void KToCTestShouldReturnZero()
    {
        Assert.Equal(-273.15, converter.KToC(0));
    }

    [Fact]
    public void KToFTestShouldReturnZero()
    {
        Assert.Equal(-459.67, converter.KToF(0));
    }

    [Fact]
    public void FToCTestShouldReturnDouble()
    {
        Assert.Equal(-17.777777777777779, converter.FToC(0));
    }

    [Fact]
    public void FToKTestShouldReturnDouble()
    {
        Assert.Equal(255.37222222222221, converter.FToK(0));
    }

}



